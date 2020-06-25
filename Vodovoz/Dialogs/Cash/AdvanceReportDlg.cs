﻿using System;
using System.Collections.Generic;
using System.Linq;
using Gamma.GtkWidgets;
using QS.Dialog.GtkUI;
using QS.DomainModel.UoW;
using QSProjectsLib;
using QS.Validation;
using Vodovoz.Domain.Cash;
using Vodovoz.Domain.Employees;
using Vodovoz.Filters.ViewModels;
using QS.Services;
using Vodovoz.EntityRepositories.Employees;
using Vodovoz.EntityRepositories;
using QS.DomainModel.NotifyChange;

namespace Vodovoz
{
	public partial class AdvanceReportDlg : QS.Dialog.Gtk.EntityDialogBase<AdvanceReport>
	{
		private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

		decimal debt = 0;
		decimal Balance = 0;
		decimal closingSum = 0;

		List<RecivedAdvance> advanceList;
		private bool canEdit = true;

		protected decimal Debt {
			get {
				return debt;
			}
			set {
				debt = value;
				labelCurrentDebt.LabelProp = String.Format("{0:C}", debt);
			}
		}

		protected decimal ClosingSum {
			get {
				return closingSum;
			}
			set {
				closingSum = value;
				labelClosingSum.LabelProp = String.Format("{0:C}", closingSum);
				CalculateBalance();
			}
		}

		public AdvanceReportDlg(Expense advance, IPermissionService permissionService) : this(advance.Employee, advance.ExpenseCategory, advance.UnclosedMoney, permissionService)
		{
			if(advance.Employee == null) {
				logger.Error("Аванс без сотрудника. Для него нельзя открыть диалог возврата.");
				base.FailInitialize = true;
				return;
			}
			advanceList.Find(x => x.Advance.Id == advance.Id).Selected = true;
		}

		public AdvanceReportDlg(Employee accountable, ExpenseCategory expenseCategory, decimal money, IPermissionService permissionService) : this(permissionService)
		{
			Entity.Accountable = accountable;
			Entity.ExpenseCategory = expenseCategory;
			Entity.Money = money;
		}

		public AdvanceReportDlg(IPermissionService permissionService)
		{
			this.Build();
			UoWGeneric = UnitOfWorkFactory.CreateWithNewRoot<AdvanceReport>();
			Entity.Casher = EmployeeSingletonRepository.GetInstance().GetEmployeeForCurrentUser(UoW);
			if(Entity.Casher == null) {
				MessageDialogHelper.RunErrorDialog("Ваш пользователь не привязан к действующему сотруднику, вы не можете создавать кассовые документы, так как некого указывать в качестве кассира.");
				FailInitialize = true;
				return;
			}

			var userPermission = permissionService.ValidateUserPermission(typeof(AdvanceReport), UserSingletonRepository.GetInstance().GetCurrentUser(UoW).Id);
			if(!userPermission.CanCreate) {
				MessageDialogHelper.RunErrorDialog("Отсутствуют права на создание приходного ордера");
				FailInitialize = true;
				return;
			}

			if(!accessfilteredsubdivisionselectorwidget.Configure(UoW, false, typeof(AdvanceReport))) {

				MessageDialogHelper.RunErrorDialog(accessfilteredsubdivisionselectorwidget.ValidationErrorMessage);
				FailInitialize = true;
				return;
			}

			Entity.Date = DateTime.Now;
			ConfigureDlg();
			FillDebt();
		}

		public AdvanceReportDlg(int id, IPermissionService permissionService)
		{
			this.Build();
			UoWGeneric = UnitOfWorkFactory.CreateForRoot<AdvanceReport>(id);

			if(!accessfilteredsubdivisionselectorwidget.Configure(UoW, false, typeof(Income))) {

				MessageDialogHelper.RunErrorDialog(accessfilteredsubdivisionselectorwidget.ValidationErrorMessage);
				FailInitialize = true;
				return;
			}
			var userPermission = permissionService.ValidateUserPermission(typeof(AdvanceReport), UserSingletonRepository.GetInstance().GetCurrentUser(UoW).Id);
			if(!userPermission.CanRead) {
				MessageDialogHelper.RunErrorDialog("Отсутствуют права на просмотр приходного ордера");
				FailInitialize = true;
				return;
			}
			canEdit = userPermission.CanUpdate;

			//Отключаем отображение ненужных элементов.
			labelDebtTitle.Visible = labelTableTitle.Visible = hboxDebt.Visible = GtkScrolledWindow1.Visible = labelCreating.Visible = false;

			comboExpense.Sensitive = yspinMoney.Sensitive = yentryEmployee.Sensitive = false;

			ConfigureDlg();
		}

		public AdvanceReportDlg(AdvanceReport sub, IPermissionService permissionService) : this(sub.Id, permissionService) { }

		void ConfigureDlg()
		{
			accessfilteredsubdivisionselectorwidget.OnSelected += Accessfilteredsubdivisionselectorwidget_OnSelected;
			if(Entity.RelatedToSubdivision != null) {
				accessfilteredsubdivisionselectorwidget.SelectIfPossible(Entity.RelatedToSubdivision);
			}

			var filterEmployee = new EmployeeFilterViewModel();
			filterEmployee.Status = EmployeeStatus.IsWorking;
			yentryEmployee.RepresentationModel = new ViewModel.EmployeesVM(filterEmployee);
			yentryEmployee.Binding.AddBinding(Entity, e => e.Accountable, w => w.Subject).InitializeFromSource();

			var filterCasher = new EmployeeFilterViewModel();
			filterCasher.Status = EmployeeStatus.IsWorking;
			yentryCasher.RepresentationModel = new ViewModel.EmployeesVM(filterCasher);
			yentryCasher.Binding.AddBinding(Entity, e => e.Casher, w => w.Subject).InitializeFromSource();

			ydateDocument.Binding.AddBinding(Entity, s => s.Date, w => w.Date).InitializeFromSource();

			NotifyConfiguration.Instance.BatchSubscribeOnEntity<ExpenseCategory>(HandleBatchEntityChangeHandler);
			UpdateExpenseCategories();

			comboExpense.Binding.AddBinding(Entity, s => s.ExpenseCategory, w => w.SelectedItem).InitializeFromSource();

			yspinMoney.Binding.AddBinding(Entity, s => s.Money, w => w.ValueAsDecimal).InitializeFromSource();

			ytextviewDescription.Binding.AddBinding(Entity, s => s.Description, w => w.Buffer.Text).InitializeFromSource();

			ytreeviewDebts.ColumnsConfig = ColumnsConfigFactory.Create<RecivedAdvance>()
				.AddColumn("Закрыть").AddToggleRenderer(a => a.Selected).Editing()
				.AddColumn("Дата").AddTextRenderer(a => a.Advance.Date.ToString())
				.AddColumn("Получено").AddTextRenderer(a => a.Advance.Money.ToString("C"))
				.AddColumn("Непогашено").AddTextRenderer(a => a.Advance.UnclosedMoney.ToString("C"))
				.AddColumn("Статья").AddTextRenderer(a => a.Advance.ExpenseCategory.Name)
				.AddColumn("Основание").AddTextRenderer(a => a.Advance.Description)
				.Finish();
			UpdateSubdivision();

			if(!canEdit) {
				table1.Sensitive = false;
				accessfilteredsubdivisionselectorwidget.Sensitive = false;
				buttonSave.Sensitive = false;
				ytreeviewDebts.Sensitive = false;
				ytextviewDescription.Editable = false;
			}
		}

		void HandleBatchEntityChangeHandler(EntityChangeEvent[] changeEvents)
		{
			UpdateExpenseCategories();
		}

		private void UpdateExpenseCategories()
		{
			comboExpense.ItemsList = Repository.Cash.CategoryRepository.ExpenseCategories(UoW);
		}

		void Accessfilteredsubdivisionselectorwidget_OnSelected(object sender, EventArgs e)
		{
			UpdateSubdivision();
		}

		private void UpdateSubdivision()
		{
			if(accessfilteredsubdivisionselectorwidget.SelectedSubdivision != null && accessfilteredsubdivisionselectorwidget.NeedChooseSubdivision) {
				Entity.RelatedToSubdivision = accessfilteredsubdivisionselectorwidget.SelectedSubdivision;
			}
		}

		public override bool Save()
		{
			var valid = new QSValidator<AdvanceReport>(UoWGeneric.Root);
			if(valid.RunDlgIfNotValid((Gtk.Window)this.Toplevel))
				return false;

			logger.Info("Сохраняем авансовый отчет...");
			Income newIncome;
			Expense newExpense;
			bool needClosing = UoWGeneric.IsNew;
			UoWGeneric.Save(); // Сохраняем сначала отчет, так как нужно получить Id.
			if(needClosing) {
				var closing = Entity.CloseAdvances(out newExpense, out newIncome,
					advanceList.Where(a => a.Selected).Select(a => a.Advance).ToList());

				if(newExpense != null)
					UoWGeneric.Save(newExpense);
				if(newIncome != null)
					UoWGeneric.Save(newIncome);

				advanceList.Where(a => a.Selected).Select(a => a.Advance).ToList().ForEach(a => UoWGeneric.Save(a));
				closing.ForEach(c => UoWGeneric.Save(c));

				UoWGeneric.Save();

				if(newIncome != null) {
					MessageDialogWorks.RunInfoDialog(String.Format("Дополнительно создан приходный ордер №{0}, на сумму {1:C}.\nНе забудьте получить сдачу от подотчетного лица!",
						newIncome.Id, newIncome.Money));
				}
				if(newExpense != null) {
					MessageDialogWorks.RunInfoDialog(String.Format("Дополнительно создан расходный ордер №{0}, на сумму {1:C}.\nНе забудьте доплатить подотчетному лицу!",
						newExpense.Id, newExpense.Money));
				}
			}
			logger.Info("Ok");
			return true;
		}

		protected void CalculateBalance()
		{
			if(!UoW.IsNew)
				return;

			Balance = ClosingSum - Entity.Money;

			labelChangeSum.Visible = labelChangeType.Visible = true;

			if(ClosingSum == 0) {
				labelChangeSum.Visible = labelChangeType.Visible = false;
				labelCreating.Markup = String.Format("<span foreground=\"Cadet Blue\">Не выбранных авансов.</span>");
			} else if(Balance == 0) {
				labelChangeSum.Visible = labelChangeType.Visible = false;
				labelCreating.Markup = String.Format("<span foreground=\"green\">Аванс будет закрыть полностью.</span>");
			} else if(Balance < 0) {
				labelChangeType.LabelProp = "Доплата:";
				labelChangeSum.LabelProp = string.Format("<span foreground=\"red\">{0:C}</span>", Math.Abs(Balance));
				labelCreating.Markup = String.Format("<span foreground=\"blue\">Будет создан расходный ордер на сумму {0:C}, в качестве доплаты.</span>", Math.Abs(Balance));
			} else {
				labelChangeType.LabelProp = "Остаток:";
				labelChangeSum.LabelProp = string.Format("{0:C}", Balance);
				labelCreating.Markup = String.Format("<span foreground=\"blue\">Будет создан приходный ордер на сумму {0:C}, в качестве сдачи от подотчетного лица.</span>", Math.Abs(Balance));
			}
		}

		protected void OnYspinMoneyValueChanged(object sender, EventArgs e)
		{
			CalculateBalance();
		}

		void FillDebt()
		{
			if(!UoW.IsNew)
				return;

			if(Entity.Accountable == null) {
				Debt = 0;
				ytreeviewDebts.Model = null;
				return;
			}

			logger.Info("Получаем долг {0}...", Entity.Accountable.ShortName);
			//Debt = Repository.Cash.AccountableDebtsRepository.EmloyeeDebt (UoW, Entity.Accountable);

			var advaces = Repository.Cash.AccountableDebtsRepository.UnclosedAdvance(UoW, Entity.Accountable, Entity.ExpenseCategory);

			Debt = advaces.Sum(a => a.UnclosedMoney);

			advanceList = new List<RecivedAdvance>();

			advaces.ToList().ForEach(adv => advanceList.Add(new RecivedAdvance(adv)));
			advanceList.ForEach(i => i.SelectChanged += I_SelectChanged);
			ytreeviewDebts.ItemsDataSource = advanceList;

			CalculateBalance();
			logger.Info("Ok");
		}

		void I_SelectChanged(object sender, EventArgs e)
		{
			ClosingSum = advanceList.Where(a => a.Selected).Sum(a => a.Advance.UnclosedMoney);
		}

		protected void OnYentryEmployeeChanged(object sender, EventArgs e)
		{
			FillDebt();
		}

		protected void OnComboExpenseChanged(object sender, EventArgs e)
		{
			FillDebt();
		}

		class RecivedAdvance
		{
			private bool selected;

			public bool Selected {
				get { return selected; }
				set {
					selected = value;
					if(SelectChanged != null)
						SelectChanged(this, EventArgs.Empty);
				}
			}

			public event EventHandler SelectChanged;

			public Expense Advance { get; set; }

			public RecivedAdvance(Expense exp)
			{
				Advance = exp;
				Selected = false;
			}
		}
	}
}

