﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Bindings.Collections.Generic;
using System.Linq;
using Gamma.Utilities;
using QS.DomainModel.Entity;
using QS.DomainModel.Entity.EntityPermissions;
using QS.HistoryLog;
using Vodovoz.Domain.Goods;
using Vodovoz.Domain.Store;
using Vodovoz.Domain.Employees;

namespace Vodovoz.Domain.Documents
{
	[Appellative(Gender = GrammaticalGender.Masculine,
		NominativePlural = "документы перемещения ТМЦ",
		Nominative = "документ перемещения ТМЦ")]
	[EntityPermission]
	[HistoryTrace]
	public class MovementDocument : Document, IValidatableObject
	{
		MovementDocumentCategory category;
		[Display(Name = "Тип документа перемещения")]
		public virtual MovementDocumentCategory Category {
			get => category;
			set => SetField(ref category, value);
		}

		private DateTime timeStamp;
		public override DateTime TimeStamp {
			get => timeStamp;
			set => SetField(ref timeStamp, value);
		}

		private MovementDocumentStatus status;
		[Display(Name = "Статус")]
		public virtual MovementDocumentStatus Status {
			get => status;
			set => SetField(ref status, value, () => Status);
		}

		private MovementWagon movementWagon;
		[Display(Name = "Фура")]
		public virtual MovementWagon MovementWagon {
			get => movementWagon;
			set => SetField(ref movementWagon, value);
		}

		private string comment;
		[Display(Name = "Комментарий")]
		public virtual string Comment {
			get => comment;
			set => SetField(ref comment, value);
		}

		#region Send

		private Warehouse fromWarehouse;
		[Display(Name = "Склад отправки")]
		public virtual Warehouse FromWarehouse {
			get => fromWarehouse;
			set => SetField(ref fromWarehouse, value);
		}

		private Employee sender;
		[Display(Name = "Отправитель")]
		public virtual Employee Sender {
			get => sender;
			set => SetField(ref sender, value, () => Sender);
		}

		private DateTime? sendTime;
		[Display(Name = "Время отправления")]
		public virtual DateTime? SendTime {
			get => sendTime;
			set => SetField(ref sendTime, value, () => SendTime);
		}

		#endregion Send

		#region Receive

		private Warehouse toWarehouse;
		[Display(Name = "Склад получения")]
		public virtual Warehouse ToWarehouse {
			get => toWarehouse;
			set => SetField(ref toWarehouse, value);
		}

		private Employee receiver;
		[Display(Name = "Получатель")]
		public virtual Employee Receiver {
			get => receiver;
			set => SetField(ref receiver, value, () => Receiver);
		}

		private DateTime? deliveredTime;
		[Display(Name = "Время получения")]
		public virtual DateTime? DeliveredTime {
			get => deliveredTime;
			set => SetField(ref deliveredTime, value);
		}

		#endregion Receive

		#region Discrepancy

		private Employee discrepancyAccepter;
		[Display(Name = "Кто подтвердил расхождения")]
		public virtual Employee DiscrepancyAccepter {
			get => discrepancyAccepter;
			set => SetField(ref discrepancyAccepter, value, () => DiscrepancyAccepter);
		}

		private DateTime? discrepancyAcceptTime;
		[Display(Name = "Время подтверждения расхождений")]
		public virtual DateTime? DiscrepancyAcceptTime {
			get => discrepancyAcceptTime;
			set => SetField(ref discrepancyAcceptTime, value, () => DiscrepancyAcceptTime);
		}

		#endregion Discrepancy

		private IList<MovementDocumentItem> items = new List<MovementDocumentItem>();
		[Display(Name = "Строки")]
		public virtual IList<MovementDocumentItem> Items {
			get => items;
			set {
				SetField(ref items, value);
				observableItems = null;
			}
		}

		private GenericObservableList<MovementDocumentItem> observableItems;
		//FIXME Кослыль пока не разберемся как научить hibernate работать с обновляемыми списками.
		public virtual GenericObservableList<MovementDocumentItem> ObservableItems {
			get {
				if(observableItems == null)
					observableItems = new GenericObservableList<MovementDocumentItem>(Items);
				return observableItems;
			}
		}

		#region Вычисляемые

		public virtual bool IsDelivered => DeliveredStatuses.Contains(Status);

		public virtual string Title => String.Format("Перемещение ТМЦ №{0} от {1:d}", Id, TimeStamp);

		#endregion Вычисляемые

		#region IValidatableObject implementation

		public virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{
			if(Id == 0 && Category == MovementDocumentCategory.InnerTransfer) {
				yield return new ValidationResult(
					"Внутреннее перемещение на данный момент запрещено.",
					new[] { this.GetPropertyName(o => o.Category) }
				);
			}

			if(!Items.Any())
				yield return new ValidationResult(String.Format("Табличная часть документа пустая."),
					new[] { this.GetPropertyName(o => o.Items) });

			if(Category == MovementDocumentCategory.InnerTransfer || Category == MovementDocumentCategory.Transportation) {
				if(FromWarehouse == ToWarehouse)
					yield return new ValidationResult("Склады отправления и получения должны различатся.",
						new[] { this.GetPropertyName(o => o.FromWarehouse), this.GetPropertyName(o => o.ToWarehouse) });
				if(FromWarehouse == null)
					yield return new ValidationResult("Склады отправления должен быть указан.",
						new[] { this.GetPropertyName(o => o.FromWarehouse) });
				if(ToWarehouse == null)
					yield return new ValidationResult("Склады получения должен быть указан.",
						new[] { this.GetPropertyName(o => o.ToWarehouse) });
			}

			if(Category == MovementDocumentCategory.Transportation) {
				if(MovementWagon == null)
					yield return new ValidationResult("Фура не указана.",
						new[] { this.GetPropertyName(o => o.MovementWagon) });
			}

			foreach(var item in Items) {
				if(item.SendedAmount <= 0)
					yield return new ValidationResult(String.Format("Для номенклатуры <{0}> не указано количество.", item.Nomenclature.Name),
						new[] { this.GetPropertyName(o => o.Items) });
			}

		}

		#endregion

		#region Функции

		public virtual void AddItem(Nomenclature nomenclature, decimal amount, decimal inStock)
		{
			var item = new MovementDocumentItem {
				Nomenclature = nomenclature,
				SendedAmount = amount,
				AmountOnSource = inStock,
				Document = this
			};

			ObservableItems.Add(item);
		}

		public virtual void Send(Employee sender)
		{
			if(sender == null) {
				throw new ArgumentNullException(nameof(sender));
			}

			if(Status != MovementDocumentStatus.New) {
				return;
			}

			Status = MovementDocumentStatus.Sended;
			Sender = sender;
			SendTime = DateTime.Now;

			foreach(var item in Items) {
				item.UpdateWriteoffOperation();
			}
		}

		public virtual void Receive(bool canChangeAlreadyDelivered, Employee employeeReceiver)
		{
			if(employeeReceiver == null) {
				throw new ArgumentNullException(nameof(employeeReceiver));
			}

			if(Status != MovementDocumentStatus.Sended && !(canChangeAlreadyDelivered && IsDelivered)) {
				return;
			}

			if(HasDeliveryDiscrepancies()) {
				Status = MovementDocumentStatus.Discrepancy;
			} else {
				Status = MovementDocumentStatus.Accepted;
			}

			foreach(var item in Items) {
				item.UpdateIncomeOperation();
			}
		}

		private bool HasDeliveryDiscrepancies()
		{
			if(Status == MovementDocumentStatus.New || Status == MovementDocumentStatus.Accepted) {
				return false;
			}
			foreach(var item in Items) {
				if(item.HasDiscrepancy) {
					return true;
				}
			}
			return false;
		}

		public virtual void AcceptDiscrepancy(Employee employeeDiscrepancyAccepter)
		{
			if(employeeDiscrepancyAccepter == null) {
				throw new ArgumentNullException(nameof(employeeDiscrepancyAccepter));
			}

			if(!HasDeliveryDiscrepancies()) {
				return;
			}

			DiscrepancyAccepter = employeeDiscrepancyAccepter;
			DiscrepancyAcceptTime = DateTime.Now;
		}

		public virtual void ClearDiscrepancyAccepterInformation()
		{
			DiscrepancyAccepter = null;
			DiscrepancyAcceptTime = null;
		}

		#endregion

		public static IEnumerable<MovementDocumentStatus> DeliveredStatuses => new[] { MovementDocumentStatus.Discrepancy, MovementDocumentStatus.Accepted }; 
	}

	public enum MovementDocumentStatus
	{
		[Display(Name = "Новый")]
		New,
		[Display(Name = "Отправлен")]
		Sended,
		[Display(Name = "Расхождение")]
		Discrepancy,
		[Display(Name = "Принят")]
		Accepted
	}

	public class MovementDocumentStatusStringType : NHibernate.Type.EnumStringType
	{
		public MovementDocumentStatusStringType() : base(typeof(MovementDocumentStatus))
		{
		}
	}

	public enum MovementDocumentCategory
	{
		[Display(Name = "Внутреннее перемещение")]
		InnerTransfer,
		[Display(Name = "Транспортировка")]
		Transportation
	}

	public class MovementDocumentCategoryStringType : NHibernate.Type.EnumStringType
	{
		public MovementDocumentCategoryStringType() : base(typeof(MovementDocumentCategory))
		{
		}
	}
}

