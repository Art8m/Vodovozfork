﻿using QS.Views.GtkUI;
using Vodovoz.Domain.Employees;
using Vodovoz.ViewModels.Journals.FilterViewModels.Cash;

namespace Vodovoz.Filters.GtkViews
{
	public partial class SalaryByEmployeeFilterView : FilterViewBase<SalaryByEmployeeJournalFilterViewModel>
	{
		public SalaryByEmployeeFilterView(SalaryByEmployeeJournalFilterViewModel filterViewModel) : base(filterViewModel)
		{
			this.Build();

			Configure();
		}

		private void Configure()
		{
			enumcomboCategory.ItemsEnum = typeof(EmployeeCategory);
			enumcomboCategory.Binding.AddBinding(ViewModel, vm => vm.Category, w => w.SelectedItemOrNull).InitializeFromSource();

			yenumcomboStatus.ItemsEnum = typeof(EmployeeStatus);
			yenumcomboStatus.Binding.AddBinding(ViewModel, vm => vm.Status, w => w.SelectedItemOrNull).InitializeFromSource();

			comboSubdivision.ItemsList = ViewModel.Subdivisions;
			comboSubdivision.Binding.AddBinding(ViewModel, vm => vm.Subdivision, w => w.SelectedItem).InitializeFromSource();
		}
	}
}
