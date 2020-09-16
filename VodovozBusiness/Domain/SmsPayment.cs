using System;
using System.ComponentModel.DataAnnotations;
using QS.DomainModel.Entity;
using Vodovoz.Domain.Client;
using Vodovoz.Domain.Orders;

namespace Vodovoz.Domain
{
    public class SmsPayment : PropertyChangedBase, IDomainObject
    {
        #region Свойства

        public virtual int Id { get; set; }
        
        private SmsPaymentStatus smsPaymentStatus;
        [Display(Name = "Статус оплаты")]
        public virtual SmsPaymentStatus SmsPaymentStatus {
            get => smsPaymentStatus;
            protected set => SetField(ref smsPaymentStatus, value, () => SmsPaymentStatus);
        }
        
        private int externalId;
        [Display(Name = "Внешний ID")]
        public virtual int ExternalId {
            get => externalId;
            set => SetField(ref externalId, value, () => ExternalId);
        }
        
        private decimal amount;
        [Display(Name = "Сумма платежа")]
        public virtual decimal Amount {
            get => amount;
            set => SetField(ref amount, value, () => Amount);
        }

        private Order order;
        [Display(Name = "Заказ")]
        public virtual Order Order {
            get => order;
            set => SetField(ref order, value, () => Order);
        }
        
        private Counterparty recepient;
        [Display(Name = "Получатель")]
        public virtual Counterparty Recepient {
            get => recepient;
            set => SetField(ref recepient, value, () => Recepient);
        }
        
        private string phoneNumber;
        [Display(Name = "Номер телефона")]
        public virtual string PhoneNumber {
            get => phoneNumber;
            set => SetField(ref phoneNumber, value, () => PhoneNumber);
        }
        
        private DateTime creationDate;
        [Display(Name = "Дата создания")]
        public virtual DateTime CreationDate {
            get => creationDate;
            set => SetField(ref creationDate, value, () => CreationDate);
        }
        
        private DateTime paidDate;
        [Display(Name = "Дата оплаты")]
        public virtual DateTime PaidDate {
            get => paidDate;
            set => SetField(ref paidDate, value, () => PaidDate);
        }

        #endregion

        #region Функции

        public virtual SmsPayment SetPaid(DateTime datePaid, PaymentFrom paymentFrom)
        {
            SmsPaymentStatus = SmsPaymentStatus.Paid;
            PaidDate = datePaid;
            Order.OnlineOrder = ExternalId;
            Order.PaymentType = PaymentType.ByCard;    
            Order.PaymentByCardFrom = paymentFrom;
            return this;
        }
        
        public virtual SmsPayment SetCancelled()
        {
            SmsPaymentStatus = SmsPaymentStatus.Cancelled;
            return this;
        }
        
        public virtual SmsPayment SetWaitingForPayment()
        {
            SmsPaymentStatus = SmsPaymentStatus.WaitingForPayment;
            return this;
        }

        #endregion
        
    }
    
    public enum SmsPaymentStatus
    {
        [Display(Name = "Ожидание оплаты")]
        WaitingForPayment,
        [Display(Name = "Оплачен")]
        Paid,
        [Display(Name = "Оплата отменена")]
        Cancelled
    }
	
    public class SmsPaymentStatusStringType : NHibernate.Type.EnumStringType
    {
        public SmsPaymentStatusStringType() : base(typeof(SmsPaymentStatus))
        {
        }
    }
}