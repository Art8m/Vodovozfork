using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Nini.Config;
using NLog.Web;

namespace VodovozMangoService
{
    public class Program
    {
	    private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
	    private static readonly string configFile = "/etc/vodovoz-mango-service.conf";
	    
	    //MangoService
	    private static int notficationServicePort;
	    private static int mangoServiceHTTPPort; 
	    private static int mangoServiceHTTPSPort; 
	    
	    //Mysql
	    private static string mysqlServerHostName;
	    private static string mysqlServerPort;
	    private static string mysqlUser;
	    private static string mysqlPassword;
	    private static string mysqlDatabase;
	    public static void Main(string[] args)
        {
	        #region Читаем конфигурацию
	        try {
		        IniConfigSource confFile = new IniConfigSource(configFile);
		        confFile.Reload();

		        IConfig smsConfig = confFile.Configs["MangoService"];
		        notficationServicePort = smsConfig.GetInt("grps_client_port");
		        mangoServiceHTTPPort = smsConfig.GetInt("http_port");
		        mangoServiceHTTPSPort = smsConfig.GetInt("https_port");
		        
		        IConfig mysqlConfig = confFile.Configs["Mysql"];
				mysqlServerHostName = mysqlConfig.GetString("mysql_server_host_name");
				mysqlServerPort = mysqlConfig.GetString("mysql_server_port", "3306");
				mysqlUser = mysqlConfig.GetString("mysql_user");
				mysqlPassword = mysqlConfig.GetString("mysql_password");
				mysqlDatabase = mysqlConfig.GetString("mysql_database");
	        }
	        catch(Exception ex) {
		        logger.Fatal(ex, "Ошибка чтения конфигурационного файла.");
		        return;
	        }
	        #endregion
	        
	        InitNotifacationService();
	        CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
	            .ConfigureLogging(logging =>
	            {
		            logging.ClearProviders();
		            logging.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);
	            })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder
                        .UseKestrel(k =>
                        {
                            var appServices = k.ApplicationServices;
                            k.Listen(
                                IPAddress.Any, mangoServiceHTTPSPort,
                                o => o.UseHttps(h =>
                                {
                                    h.UseLettuceEncrypt(appServices);
                                }));
                            k.Listen(IPAddress.Any, mangoServiceHTTPPort);
                        })
                        .UseStartup<Startup>();
                })
	            .UseNLog();

        private static void InitNotifacationService()
        {
	        var service = new NotificationServiceImpl();
            Server server = new Server
            {
                Services = { NotificationService.BindService(service) },
                Ports = { new ServerPort("0.0.0.0", notficationServicePort, ServerCredentials.Insecure) }
            };
            server.Start();
			
			#if DEBUG
	        Task.Run(() => RandomNotifyTest(service));
			#endif
        }
        
        private static void RandomNotifyTest(NotificationServiceImpl service)
		{
			var random = new Random();
			while (true)
			{
				//Ждем
				var wait = random.Next(1000, 7000);
				Console.WriteLine($"Ждем {wait} милисекуд");
				Thread.Sleep(wait);
				//Выбираем подписчика
				BlockingCollection<NotificationMessage> queue;
				lock (service.Subscribers)
				{
					var count = service.Subscribers.Count;
					if(count == 0)
						continue;
					
					queue = service.Subscribers.Values.Skip(random.Next(count)).First();
				}
				//Создаем звонящего....
				var type = (CallerType) random.Next(2);
				var caller = new Caller
				{
					Type = type,
					Number = type == CallerType.External
						? "+79" + random.Next(1000000000).ToString("D9")
						: random.Next(100, 1000).ToString(),
					Name = type == CallerType.Internal ? new [] {"Ганьков Андрей", "Солдаткина Алина", "Потапов Данила"}[random.Next(3)] : String.Empty
				};
				//Отправляем уведомление о поступлении входящего
				var message = new NotificationMessage
				{
					CallFrom = caller,
					Timestamp = Timestamp.FromDateTime(DateTime.Now.ToUniversalTime()),
					State = CallState.Appeared
				};
				Console.WriteLine("Send:" + message.ToString() );
				queue.Add(message);
				//Ждет поднятия трубки
				wait = random.Next(1000, 10000);
				Console.WriteLine($"Ждем {wait} милисекуд, пока оператор поднимет трубку.");
				Thread.Sleep(wait);
				//Отправляем уведомление о начале разговора
				message = new NotificationMessage
				{
					CallFrom = caller,
					Timestamp = Timestamp.FromDateTime(DateTime.Now.ToUniversalTime()),
					State = CallState.Connected
				};
				Console.WriteLine("Send:" + message.ToString() );
				queue.Add(message);
				//Ожидаем разговор.
				wait = random.Next(5000, 25000);
				Console.WriteLine($"Идет разговор с оператором {wait} милисекуд.");
				Thread.Sleep(wait);
				
				//Отправляем уведомление о завершении разговора.
				message = new NotificationMessage
				{
					CallFrom = caller,
					Timestamp = Timestamp.FromDateTime(DateTime.Now.ToUniversalTime()),
					State = CallState.Disconnected
				};
				Console.WriteLine("Send:" + message.ToString() );
				queue.Add(message);
			}
		}
    }
}