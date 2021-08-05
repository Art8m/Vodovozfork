﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using Gamma.ColumnConfig;
using Google.OrTools.ConstraintSolver;
using Gtk;
using QS.Views.GtkUI;
using Vodovoz.ReportsParameters;
using Vodovoz.ViewModels.ViewModels.Suppliers;

namespace Vodovoz.Views.Suppliers
{
	[ToolboxItem(false)]
	public partial class WarehousesBalanceSummaryView : TabViewBase<WarehousesBalanceSummaryViewModel>
	{
		private Task _generationTask;
		private double _totalTime;

		public WarehousesBalanceSummaryView(WarehousesBalanceSummaryViewModel viewModel) : base(viewModel)
		{
			this.Build();

			Configure();
		}

		private void Configure()
		{
			ViewModel.PropertyChanged += ViewModelOnPropertyChanged;
			buttonLoad.Binding.AddSource(ViewModel)
				.AddFuncBinding(vm => !vm.IsGenerating, w => w.Visible)
				.AddFuncBinding(vm => !vm.IsGenerating, w => w.Sensitive)
				.InitializeFromSource();
			buttonLoad.Clicked += ButtonLoadOnClicked;
			buttonAbort.Binding.AddSource(ViewModel)
				.AddBinding(vm => vm.IsGenerating, w => w.Visible)
				.AddBinding(vm => vm.IsGenerating, w => w.Sensitive)
				.InitializeFromSource();
			buttonAbort.Clicked += (sender, args) => { ViewModel.ReportGenerationCancelationTokenSource.Cancel(); };

			/*buttonExport.Binding.AddSource(ViewModel)
				.AddBinding(vm => vm.CanSave, w => w.Sensitive)
				.InitializeFromSource();*/

			datePicker.Binding.AddBinding(ViewModel, vm => vm.EndDate, w => w.DateOrNull).InitializeFromSource();

			radioAllNoms.Binding.AddBinding(ViewModel, vm => vm.AllNoms, w => w.Active).InitializeFromSource();
			radioGtZNoms.Binding.AddBinding(ViewModel, vm => vm.GtZNoms, w => w.Active).InitializeFromSource();
			radioLeZNoms.Binding.AddBinding(ViewModel, vm => vm.LeZNoms, w => w.Active).InitializeFromSource();
			radioLtMinNoms.Binding.AddBinding(ViewModel, vm => vm.LtMinNoms, w => w.Active).InitializeFromSource();
			radioGeMinNoms.Binding.AddBinding(ViewModel, vm => vm.GeMinNoms, w => w.Active).InitializeFromSource();

			radioAllWars.Binding.AddBinding(ViewModel, vm => vm.AllWars, w => w.Active).InitializeFromSource();
			radioGtZWars.Binding.AddBinding(ViewModel, vm => vm.GtZWars, w => w.Active).InitializeFromSource();
			radioLeZWars.Binding.AddBinding(ViewModel, vm => vm.LeZWars, w => w.Active).InitializeFromSource();
			radioLtMinWars.Binding.AddBinding(ViewModel, vm => vm.LtMinWars, w => w.Active).InitializeFromSource();
			radioGeMinWars.Binding.AddBinding(ViewModel, vm => vm.GeMinWars, w => w.Active).InitializeFromSource();

			var nomsWidget = new SelectableParameterReportFilterView(ViewModel.NomsViewModel);
			vboxNomsFilter.Add(nomsWidget);
			nomsWidget.Show();

			var warsWidget = new SelectableParameterReportFilterView(ViewModel.WarsViewModel);
			vboxWarsFilter.Add(warsWidget);
			warsWidget.Show();

			eventboxArrow.ButtonPressEvent += (o, args) =>
			{
				vboxSections.Visible = !vboxSections.Visible;
				arrowSlider.ArrowType = vboxSections.Visible ? ArrowType.Left : ArrowType.Right;
			};

			treeData.EnableGridLines = TreeViewGridLines.Both;
		}

		private void ConfigureTreeView()
		{
			var columnsConfig = FluentColumnsConfig<BalanceSummaryRow>.Create()
				.AddColumn("Код").AddNumericRenderer(row => row.NomId).XAlign(0.5f)
				.AddColumn("Наименование").AddTextRenderer(row => row.NomTitle).XAlign(0.5f)
				.AddColumn("Мин. остаток").AddNumericRenderer(row => row.Min).XAlign(0.5f)
				.AddColumn("Общий остаток").AddNumericRenderer(row => row.Common).XAlign(0.5f)
				.AddColumn("Разница").AddNumericRenderer(row => row.Diff).XAlign(0.5f);

			for(var i = 0; i < ViewModel.Report.WarehousesTitles.Count; i++)
			{
				var index = i;
				columnsConfig.AddColumn($"{ViewModel.Report.WarehousesTitles[i]}").AddNumericRenderer(row => row.Separate[index])
					.XAlign(0.5f);
			}

			treeData.ColumnsConfig = columnsConfig.AddColumn("").Finish();
			ViewModel.ShowWarning($"Отчет остатков по складам сформирован за {_totalTime}с." +
			                      $"\r\nАлгоритм {ViewModel.AlgoTime}с. Запрос ~{_totalTime - ViewModel.AlgoTime}с.");
		}

		private void ViewModelOnPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			if(e.PropertyName == nameof(ViewModel.Report) && ViewModel.Report?.SummaryRows != null)
			{
				ConfigureTreeView();
				treeData.ItemsDataSource = ViewModel.Report.SummaryRows;
				treeData.YTreeModel.EmitModelChanged();
			}
		}

		private async void ButtonLoadOnClicked(object sender, EventArgs e)
		{
			ViewModel.ReportGenerationCancelationTokenSource = new CancellationTokenSource();
			ViewModel.IsGenerating = true;
			var start = DateTime.Now;

			_generationTask = Task.Run(async () =>
			{
				try
				{
					var report = await ViewModel.ActionGenerateReport(ViewModel.ReportGenerationCancelationTokenSource.Token);

					Application.Invoke((s, eventArgs) =>
					{
						ViewModel.Report = report;
					});
				}
				catch(OperationCanceledException)
				{
					Application.Invoke((s, eventArgs) =>
					{
						ViewModel.ShowWarning("Формирование отчета было прервано");
					});
				}
				catch(Exception ex)
				{
					Application.Invoke((s, eventArgs) => throw ex);
				}
				finally
				{
					_totalTime = (DateTime.Now - start).TotalSeconds;
					Application.Invoke((s, eventArgs) =>
					{
						ViewModel.IsGenerating = false;
					});
				}
			}, ViewModel.ReportGenerationCancelationTokenSource.Token);

			await _generationTask;
		}
	}
}
