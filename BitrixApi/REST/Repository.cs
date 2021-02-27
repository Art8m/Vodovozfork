using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BitrixApi.DTO;
using Newtonsoft.Json;
using QS.DomainModel.UoW;
using Vodovoz.Domain;
using Vodovoz.Domain.Orders;

namespace BitrixApi.REST
{
    public class BitrixRestApi : IBitrixRestApi
    {
        static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        private static readonly HttpClient client = new HttpClient();
        private string token;
        private const string baseURL = "https://vodovoz.bitrix24.ru";
        static SemaphoreSlim semaphoreSlim = new SemaphoreSlim(1,1);
        private const string userId = "2364";
        private const string createInDVStageId = "13";
        
        
        /// <param name="token">BitrixAPI токен из конфига</param>
        public BitrixRestApi(string token)
        {
            this.token = token ?? throw new ArgumentNullException(nameof(token));
        }
        
        //crm.deal.get
        public async Task<Deal> GetDealAsync( uint id )
        {
            AddJsonHeader();
            
            string requestUri = $"{baseURL}/rest/{userId}/{token}/crm.deal.get.json?id={id}";
            var msg = client.GetStringAsync(requestUri);
            await semaphoreSlim.WaitAsync();
            DealRequest request = null;
            try{
                logger.Info("Ждем Deal");
                Thread.Sleep(20);
                request = JsonConvert.DeserializeObject<DealRequest>(await msg);
                logger.Info("Подождали Deal");
            }
            finally{
                semaphoreSlim.Release();
            }
           
            return request.Result;
        }
        
        //crm.contact.get
        public async Task<Contact> GetContact( uint id )
        {
            AddJsonHeader();
            string requestUri = $"{baseURL}/rest/{userId}/{token}/crm.contact.get.json?id={id}";
            var msg = client.GetStringAsync(requestUri);
            await semaphoreSlim.WaitAsync();

            ContactRequest request = null;
            try{
                logger.Info("Ждем Contact");
                Thread.Sleep(1000);
                request = JsonConvert.DeserializeObject<ContactRequest>(await msg);
                logger.Info("Подождали Contact");
            }
            finally{
                semaphoreSlim.Release();
            }
            
            return request.Result; 
        }
        
        //crm.company.get
        public async Task<Company> GetCompany( uint id )
        {
            AddJsonHeader();
            string requestUri = $"{baseURL}/rest/{userId}/{token}/crm.company.get.json?id={id}";
            var msg = client.GetStringAsync(requestUri);
            await semaphoreSlim.WaitAsync();

            CompanyRequest request = null;
            try{
                logger.Info("Ждем Company");
                Thread.Sleep(1000);
                request = JsonConvert.DeserializeObject<CompanyRequest>(await msg);
                logger.Info("Подождали Company");
            }
            finally{
                semaphoreSlim.Release();
            }
            
            return request.Result; 
        }

        //crm.product.get
        public async Task<Product> GetProduct( uint id )
        {
            AddJsonHeader();
            string requestUri = $"{baseURL}/rest/{userId}/{token}/crm.product.get.json?id={id}";
            var msg = client.GetStringAsync(requestUri);
            await semaphoreSlim.WaitAsync();

            ProductRequest request = null;
            try{
                logger.Info("Ждем Product");

                Thread.Sleep(1000);
                request = JsonConvert.DeserializeObject<ProductRequest>(await msg);
                logger.Info("Подождали Product");

            }
            finally{
                semaphoreSlim.Release();
            }
            
            return request.Result; 
        }

        public async Task<IList<ProductFromDeal>> GetProductsForDeal(uint dealId)
        {
            AddJsonHeader();
            string requestUri = $"{baseURL}/rest/{userId}/{token}/crm.deal.productrows.get.json?id={dealId}";
            var msg = client.GetStringAsync(requestUri);
            await semaphoreSlim.WaitAsync();

            ProductFromDealRequest request = null;
            try{
                logger.Info("Ждем ProductFromDeal");

                Thread.Sleep(1000);
                request = JsonConvert.DeserializeObject<ProductFromDealRequest>(await msg);
                logger.Info("Подождали ProductFromDeal");

            }
            finally{
                semaphoreSlim.Release();
            }
            
            return request.Result; 
        }

        public async Task<IList<uint>> GetDealsIdsBetweenDates( DateTime date1, DateTime date2)
        {
            string date1Formatted = date1.ToString("dd.MM.yyyy HH:mm:ss");
            string date2Formatted = date2.ToString("dd.MM.yyyy HH:mm:ss");
            IList<uint> listOfIds = new List<uint>();
            IList<Deal> listOfdeals = new List<Deal>();
            AddJsonHeader();
            ListofDealsRequest request;//хак для цикла
            uint i = 1;
            bool needOneMoretime = false;
            do{
                string requestUri = $"{baseURL}/rest/{userId}/{token}/crm.deal.list.json?" +
                                    $"FILTER[>DATE_CREATE]={date1Formatted}&" +
                                    $"FILTER[<DATE_CREATE]={date2Formatted}&" +
                                    $"FILTER[STAGE_ID]={createInDVStageId}&" +
                                    $"start={50 * i}";
                request = JsonConvert.DeserializeObject<ListofDealsRequest>(await client.GetStringAsync(requestUri));
                if (request.Total > 50)
                    needOneMoretime = true;
                
                foreach (var dealFromList in request.Result)
                    listOfIds.Add(dealFromList.Id);
                
                ++i;
            } while (request.Next != null);

            if(needOneMoretime){
                string requestUri2 = $"{baseURL}/rest/{userId}/{token}/crm.deal.list.json?" +
                                     $"FILTER[>DATE_MODIFY]={date1Formatted}&" +
                                     $"FILTER[<DATE_MODIFY]={date2Formatted}&" +
                                     $"FILTER[STAGE_ID]={createInDVStageId}&" +
                                     $"start={50 * i}";
                request = JsonConvert.DeserializeObject<ListofDealsRequest>(await client.GetStringAsync(requestUri2));
                foreach (var dealFromList in request.Result)
                    listOfIds.Add(dealFromList.Id);
            }
            
         
            logger.Info($"В период между {date1} и {date2} получено {listOfIds.Count} сделок в статусе завести в ДВ" +
                        "Десериализация в DTO...");

            return listOfIds;
        }

        public async Task<bool> SendWONBitrixStatus(uint bitrixId)
        {
            bitrixId = 163726; //TODO gavr убрать
            AddJsonHeader();
            string requestUri = $"{baseURL}/rest/{userId}/{token}/crm.deal.update.json?id={bitrixId}&FIELDS[STAGE_ID]=WON";
            var msg = client.GetStringAsync(requestUri);
            
            await semaphoreSlim.WaitAsync();

            ChangeStatusResult request = null;
            try{
                logger.Info("Ждем ProductFromDeal");

                Thread.Sleep(1000);
                request = JsonConvert.DeserializeObject<ChangeStatusResult>(await msg);
                logger.Info("Подождали ProductFromDeal");
            }
            finally{
                semaphoreSlim.Release();
            }
            
            return request.Result; 
        }
        
        public void CreateLead( uint dealId )
    {
        try
        {                
            throw new NotImplementedException();
            //
            // string accessToken = GetNewAccessToken();
            //
            // string url = string.Format( "https://{0}/rest/crm.lead.add.json", portal_name );
            //
            // var data = new
            // {
            //     fields = new
            //     {
            //         TITLE = title,
            //         CURRENCY_ID = "RUB",
            //         STATUS_ID = "NEW",
            //         OPENED = "Y",
            //         OPPORTUNITY = opportunity,
            //         ASSIGNED_BY_ID = 46,
            //         COMPANY_TITLE = contactName,
            //         PHONE =  new List<PHONE>() { new PHONE() { VALUE_TYPE = "WORK", TYPE_ID = "PHONE", VALUE = phoneNumber } }.ToArray(),
            //         EMAIL = new List<EMAIL>() { new EMAIL() { VALUE_TYPE = "WORK", TYPE_ID = "EMAIL", VALUE = email } }.ToArray()
            //     },
            //     @params = new
            //     {
            //         REGISTER_SONET_EVENT = "Y"
            //     }
            // };
            //
            // BitrixLead lead = new BitrixLead();
            //
            // lead.TITLE = title;
            // lead.CURRENCY_ID = "RUB";
            // lead.STATUS_ID = "NEW";
            // lead.OPENED = "Y";
            // lead.OPPORTUNITY = opportunity.ToString();                
            //
            // if (!string.IsNullOrEmpty( contactName ))
            //     lead.COMPANY_TITLE = contactName;
            //
            // if (!string.IsNullOrEmpty( phoneNumber ))
            //     lead.PHONE = new List<PHONE>() { new PHONE() { VALUE_TYPE="WORK", TYPE_ID="PHONE", VALUE = phoneNumber }}.ToArray();
            //
            // if (!string.IsNullOrEmpty( email ))
            //     lead.EMAIL = new List<EMAIL>() { new EMAIL() { VALUE_TYPE = "WORK", TYPE_ID = "EMAIL", VALUE = email } }.ToArray();
            //
            //
            // PostToAPI( url, accessToken, data );
        }
        catch (Exception exc)
        {
        }
    }
        


        #region CustomFields

        //crm.deal.userfield.list
        public async Task<IList<CustomFieldFromList>> GetAllCustomFieldsFromDeal()
        {
            AddJsonHeader();
            string requestUri = $"{baseURL}/rest/{userId}/{token}/crm.deal.userfield.list.json";
            var msg = client.GetStringAsync(requestUri);
            
            CustomFieldsDealList request = null;
            try{
                logger.Info("Ждем AllCustomFieldsFromDeal");
                Thread.Sleep(1000);
                request = JsonConvert.DeserializeObject<CustomFieldsDealList>(await msg);
                logger.Info("Подождали ProductFromDeal");
            }
            finally{
                semaphoreSlim.Release();
            }
            
            return request.Result; 
        }
        
        //crm.deal.userfield.get
        public async Task<CustomField> GetCustomFieldDeal(int id)
        {
            AddJsonHeader();
            string requestUri = $"{baseURL}/rest/{userId}/{token}/crm.deal.userfield.get.json?id={id}";
            var msg = client.GetStringAsync(requestUri);
            
            CustomFileldDealItem request = null;
            try{
                Thread.Sleep(1000);
                request = JsonConvert.DeserializeObject<CustomFileldDealItem>(await msg);
            }
            finally{
                semaphoreSlim.Release();
            }
            
            return request.Result; 
        }

        public async Task<Dictionary<string, CustomField>> GetMapCustomFieldsShitNamesToRus()
        {
            var map = new Dictionary<string, CustomField>();
            var customFieldsList = await GetAllCustomFieldsFromDeal();
            foreach (var customField in customFieldsList.Take(5)) //TODO gavr убрать take 5
            {
                map[customField.ShitName] = await GetCustomFieldDeal(customField.ID);
                Thread.Sleep(1000);
            }
            return map;
        }
        
        public string SerializeCustomFieldsShitToRusNamesToFile(Dictionary<string, CustomField> ShitToRusNames)
        {
            var builder = new StringBuilder();
            foreach (var shitToRusName in ShitToRusNames)
            {
                builder.Append(shitToRusName.Key);
                builder.Append(":");
                builder.Append(shitToRusName.Value.Russian.Name);
                builder.Append('\n');
            }
            builder.Append('\n');
            return builder.ToString();
        }

        public async Task CreateShitToRusCustomFieldsFile(string filename)
        {
            if (!File.Exists(filename))
            {
                var shitNamesToRus = await GetMapCustomFieldsShitNamesToRus();
                var text = SerializeCustomFieldsShitToRusNamesToFile(shitNamesToRus);
                //Добавляем дату в имя файла на случай если файл будет пересоздаваться раз в N дней
                var filenameWithDate = filename + DateTime.Now.ToString("d") + ".txt";
                File.WriteAllText(filenameWithDate, text);
            }
        }

        #endregion CustomFields
        
        private static void AddJsonHeader()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
        
    }
}