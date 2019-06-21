﻿using System;
using QS.DomainModel.Entity;
using QS.RepresentationModel.GtkUI;
using Vodovoz.Core.Journal;
using Vodovoz.Domain.Fuel;
using Gamma.Utilities;
using QS.Utilities.Text;
using System.Collections.Generic;
using Vodovoz.Domain.Employees;
using QS.DomainModel.UoW;
using Gamma.ColumnConfig;
using NHibernate.Transform;
using Vodovoz.Dialogs.Fuel;
using Vodovoz.Infrastructure.Services;
using Vodovoz.EntityRepositories.Subdivisions;
using NHibernate.Criterion;
using Vodovoz.EntityRepositories.Fuel;
using QS.Services;
using QS.Project.Domain;

namespace Vodovoz.Representations
{
	public class FuelDocumentsJournalViewModel : MultipleEntityModelBase<FuelDocumentVMNode>
	{
		private readonly IEmployeeService employeeService;
		private readonly ICommonServices services;
		private readonly ISubdivisionRepository subdivisionRepository;
		private readonly IFuelRepository fuelRepository;
		private readonly IRepresentationEntityPicker representationEntityPicker;

		public FuelDocumentsJournalViewModel(
			IEmployeeService employeeService, 
			ICommonServices services, 
			ISubdivisionRepository subdivisionRepository,
			IFuelRepository fuelRepository, 
			IRepresentationEntityPicker representationEntityPicker)
		{
			this.employeeService = employeeService ?? throw new ArgumentNullException(nameof(employeeService));
			this.services = services ?? throw new ArgumentNullException(nameof(services));
			this.subdivisionRepository = subdivisionRepository ?? throw new ArgumentNullException(nameof(subdivisionRepository));
			this.fuelRepository = fuelRepository ?? throw new ArgumentNullException(nameof(fuelRepository));
			this.representationEntityPicker = representationEntityPicker ?? throw new ArgumentNullException(nameof(representationEntityPicker));

			UoW = UnitOfWorkFactory.CreateWithoutRoot();

			RepresentationFilter = null;
			JournalFilter = null;

			RegisterIncomeInvoice();
			RegisterTransferDocument();



			UpdateOnChanges(
				typeof(FuelIncomeInvoice),
				typeof(FuelIncomeInvoiceItem),
				typeof(FuelTransferDocument)
			);

			TreeViewConfig = FluentColumnsConfig<FuelDocumentVMNode>.Create()
				.AddColumn("№").AddTextRenderer(node => node.DocumentId.ToString())
				.AddColumn("Тип").AddTextRenderer(node => node.DisplayName)
				.AddColumn("Дата").AddTextRenderer(node => node.CreationDate.ToShortDateString())
				.AddColumn("Автор").AddTextRenderer(node => node.Author)
				.AddColumn("Статус").AddTextRenderer(node => node.Status)
				.AddColumn("Литры").AddTextRenderer(node => node.Liters.ToString("0"))

				.AddColumn("Отправлено из").AddTextRenderer(node => node.SubdivisionFrom)
				.AddColumn("Время отпр.").AddTextRenderer(node => node.SendTime.HasValue ? node.SendTime.Value.ToShortDateString() : "")

				.AddColumn("Отправлено в").AddTextRenderer(node => node.SubdivisionTo)
				.AddColumn("Время принятия").AddTextRenderer(node => node.ReceiveTime.HasValue ? node.ReceiveTime.Value.ToShortDateString() : "")

				.AddColumn("Комментарий").AddTextRenderer(node => node.Comment)
				.Finish();
		}

		public override string GetSummaryInfo()
		{
			var balance = fuelRepository.GetAllFuelsBalance(UoW);

			string result = "";

			foreach(var item in balance) {
				result += $"{item.Key.Name}: {item.Value.ToString("0")} л., ";
			}
			result.Trim(' ', ',');
			return result;
		}

		private void RegisterIncomeInvoice()
		{
			FuelDocumentVMNode resultAlias = null;
			var fuelIncomeInvoiceConfig = RegisterEntity<FuelIncomeInvoice>();
			//функция получения данных
			fuelIncomeInvoiceConfig.AddDataFunction(() => {
				IList<FuelDocumentVMNode> fuelIncomeInvoiceResultList = new List<FuelDocumentVMNode>();

				FuelIncomeInvoice fuelIncomeInvoiceAlias = null;
				FuelIncomeInvoiceItem fuelIncomeInvoiceItemAlias = null;
				Employee authorAlias = null;
				Subdivision subdivisionToAlias = null;
				var fuelIncomeInvoiceQuery = UoW.Session.QueryOver<FuelIncomeInvoice>(() => fuelIncomeInvoiceAlias);

				fuelIncomeInvoiceResultList = fuelIncomeInvoiceQuery
					.Left.JoinQueryOver(() => fuelIncomeInvoiceAlias.Author, () => authorAlias)
					.Left.JoinQueryOver(() => fuelIncomeInvoiceAlias.Subdivision, () => subdivisionToAlias)
					.Left.JoinQueryOver(() => fuelIncomeInvoiceAlias.FuelIncomeInvoiceItems, () => fuelIncomeInvoiceItemAlias)
					.SelectList(list => list
						.SelectGroup(() => fuelIncomeInvoiceAlias.Id).WithAlias(() => resultAlias.DocumentId)
						.Select(() => fuelIncomeInvoiceAlias.СreationTime).WithAlias(() => resultAlias.CreationDate)
						.Select(() => fuelIncomeInvoiceAlias.Comment).WithAlias(() => resultAlias.Comment)
						.Select(Projections.Sum(Projections.Property(() => fuelIncomeInvoiceItemAlias.Liters))).WithAlias(() => resultAlias.Liters)
						.Select(() => authorAlias.Name).WithAlias(() => resultAlias.AuthorName)
						.Select(() => authorAlias.LastName).WithAlias(() => resultAlias.AuthorSurname)
						.Select(() => authorAlias.Patronymic).WithAlias(() => resultAlias.AuthorPatronymic)

						.Select(() => subdivisionToAlias.Name).WithAlias(() => resultAlias.SubdivisionTo)
					)

					.TransformUsing(Transformers.AliasToBean<FuelDocumentVMNode<FuelIncomeInvoice>>())
					.List<FuelDocumentVMNode>();

				return fuelIncomeInvoiceResultList;
			});

			fuelIncomeInvoiceConfig.AddViewModelDocumentConfiguration<FuelIncomeInvoiceViewModel>(
				//функция идентификации документа 
				(FuelDocumentVMNode node) => node.EntityType == typeof(FuelIncomeInvoice),
				//заголовок действия для создания нового документа
				"Входящая накладная",
				//функция диалога создания документа
				() => new FuelIncomeInvoiceViewModel(EntityConstructorParam.ForCreate(), employeeService, representationEntityPicker, subdivisionRepository, fuelRepository, services),
				//функция диалога открытия документа
				(node) => new FuelIncomeInvoiceViewModel(EntityConstructorParam.ForOpen(node.DocumentId), employeeService, representationEntityPicker, subdivisionRepository, fuelRepository, services)
			);

			//завершение конфигурации
			fuelIncomeInvoiceConfig.FinishConfiguration();
		}

		private void RegisterTransferDocument()
		{
			FuelDocumentVMNode resultAlias = null;
			var fuelTransferConfig = RegisterEntity<FuelTransferDocument>();
			//функция получения данных
			fuelTransferConfig.AddDataFunction(() => {
				IList<FuelDocumentVMNode> fuelTransferResultList = new List<FuelDocumentVMNode>();

				FuelTransferDocument fuelTransferAlias = null;
				Employee authorAlias = null;
				Subdivision subdivisionFromAlias = null;
				Subdivision subdivisionToAlias = null;
				var fuelTransferQuery = UoW.Session.QueryOver<FuelTransferDocument>(() => fuelTransferAlias);

				fuelTransferResultList = fuelTransferQuery
					.Left.JoinQueryOver(() => fuelTransferAlias.Author, () => authorAlias)
					.Left.JoinQueryOver(() => fuelTransferAlias.CashSubdivisionFrom, () => subdivisionFromAlias)
					.Left.JoinQueryOver(() => fuelTransferAlias.CashSubdivisionTo, () => subdivisionToAlias)
					.SelectList(list => list
						.Select(() => fuelTransferAlias.Id).WithAlias(() => resultAlias.DocumentId)
						.Select(() => fuelTransferAlias.CreationTime).WithAlias(() => resultAlias.CreationDate)
						.Select(() => fuelTransferAlias.Status).WithAlias(() => resultAlias.TransferDocumentStatus)
						.Select(() => fuelTransferAlias.TransferedLiters).WithAlias(() => resultAlias.Liters)
						.Select(() => fuelTransferAlias.Comment).WithAlias(() => resultAlias.Comment)
						.Select(() => fuelTransferAlias.SendTime).WithAlias(() => resultAlias.SendTime)
						.Select(() => fuelTransferAlias.ReceiveTime).WithAlias(() => resultAlias.ReceiveTime)

						.Select(() => authorAlias.Name).WithAlias(() => resultAlias.AuthorName)
						.Select(() => authorAlias.LastName).WithAlias(() => resultAlias.AuthorSurname)
						.Select(() => authorAlias.Patronymic).WithAlias(() => resultAlias.AuthorPatronymic)

						.Select(() => subdivisionFromAlias.Name).WithAlias(() => resultAlias.SubdivisionFrom)
						.Select(() => subdivisionToAlias.Name).WithAlias(() => resultAlias.SubdivisionTo)
					)

					.TransformUsing(Transformers.AliasToBean<FuelDocumentVMNode<FuelTransferDocument>>())
					.List<FuelDocumentVMNode>();

				return fuelTransferResultList;
			});

			fuelTransferConfig.AddViewModelDocumentConfiguration<FuelTransferDocumentViewModel>(
				//функция идентификации документа 
				(FuelDocumentVMNode node) => node.EntityType == typeof(FuelTransferDocument),
				//заголовок действия для создания нового документа
				"Перемещение",
				//функция диалога создания документа
				() =>  new FuelTransferDocumentViewModel(EntityConstructorParam.ForCreate(), employeeService, subdivisionRepository, fuelRepository, services),
				//функция диалога открытия документа
				(node) => new FuelTransferDocumentViewModel(EntityConstructorParam.ForOpen(node.DocumentId), employeeService, subdivisionRepository, fuelRepository, services)
			);

			//завершение конфигурации
			fuelTransferConfig.FinishConfiguration();
		}
	}

	public class FuelDocumentVMNode<TEntity> : FuelDocumentVMNode
		where TEntity : class, IDomainObject
	{
		public FuelDocumentVMNode()
		{
			EntityType = typeof(TEntity);
		}
	}

	public class FuelDocumentVMNode : MultipleEntityVMNodeBase
	{
		#region MultipleDocumentJournalVMNodeBase implementation

		public override Type EntityType { get; set; }

		public override int DocumentId { get; set; }

		[UseForSearch]
		public override string DisplayName {
			get {
				if(EntityType == typeof(FuelIncomeInvoice)) {
					return "Входящая накладная";
				} else if(EntityType == typeof(FuelTransferDocument)) {
					return "Перемещение";
				} else {
					return typeof(FuelTransferDocument).GetAttribute<AppellativeAttribute>(true)?.Nominative;
				}
			}
		}

		#endregion

		public DateTime CreationDate { get; set; }

		public FuelTransferDocumentStatuses TransferDocumentStatus { get; set; }
		public string Status {
			get {
				if(EntityType == typeof(FuelTransferDocument)) {
					return TransferDocumentStatus.GetEnumTitle();
				}
				return "";
			}
		}

		public decimal Liters { get; set; }
		public string SubdivisionFrom { get; set; }
		public string SubdivisionTo { get; set; }
		public DateTime? SendTime { get; set; }
		public DateTime? ReceiveTime { get; set; }

		public string AuthorSurname { get; set; }
		public string AuthorName { get; set; }
		public string AuthorPatronymic { get; set; }
		[UseForSearch]
		public string Author => PersonHelper.PersonNameWithInitials(AuthorSurname, AuthorName, AuthorPatronymic);

		[UseForSearch]
		public string Comment { get; set; }
	}
}
