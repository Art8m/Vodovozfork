﻿using System.Collections.Generic;
using QS.DomainModel.UoW;
using QS.Project.Journal;
using QS.Project.Journal.EntitySelector;
using QS.Project.Services;
using Vodovoz.Domain.Client;
using Vodovoz.Domain.Goods;
using Vodovoz.Domain.Store;
using Vodovoz.EntityRepositories;
using Vodovoz.EntityRepositories.Goods;
using Vodovoz.EntityRepositories.Store;
using Vodovoz.Filters.ViewModels;
using Vodovoz.FilterViewModels.Goods;
using Vodovoz.Infrastructure.Services;
using Vodovoz.JournalViewModels;
using Vodovoz.Parameters;
using Vodovoz.ViewModels.Journals.JournalSelectors;
using Vodovoz.ViewModels.Journals.JournalViewModels.Goods;

namespace Vodovoz.TempAdapters
{
	public class NomenclatureSelectorFactory : INomenclatureSelectorFactory
	{
		public IEntitySelector CreateNomenclatureSelectorForWarehouse(Warehouse warehouse, IEnumerable<int> excludedNomenclatures)
		{
			NomenclatureStockFilterViewModel nomenclatureStockFilter = new NomenclatureStockFilterViewModel(new WarehouseRepository());
			nomenclatureStockFilter.ExcludedNomenclatureIds = excludedNomenclatures;
			nomenclatureStockFilter.RestrictWarehouse = warehouse;

			NomenclatureStockBalanceJournalViewModel vm = new NomenclatureStockBalanceJournalViewModel(
				nomenclatureStockFilter,
				UnitOfWorkFactory.GetDefaultFactory,
				ServicesConfig.CommonServices
			);

			vm.SelectionMode = JournalSelectionMode.Multiple;

			return vm;
		}
		
		public IEntitySelector CreateNomenclatureSelector(IEnumerable<int> excludedNomenclatures)
		{
			NomenclatureFilterViewModel nomenclatureFilter = new NomenclatureFilterViewModel();
			nomenclatureFilter.RestrictArchive = true;
			nomenclatureFilter.AvailableCategories = Nomenclature.GetCategoriesForGoods();
			
			var nomenclatureRepository = new NomenclatureRepository(new NomenclatureParametersProvider());
			
			var counterpartySelectorFactory =
				new DefaultEntityAutocompleteSelectorFactory<Counterparty, CounterpartyJournalViewModel, CounterpartyJournalFilterViewModel>(
					ServicesConfig.CommonServices);
			
			var nomenclatureSelectorFactory =
				new NomenclatureAutoCompleteSelectorFactory<Nomenclature, NomenclaturesJournalViewModel>(
					ServicesConfig.CommonServices, VodovozGtkServicesConfig.EmployeeService,
					nomenclatureFilter, counterpartySelectorFactory, nomenclatureRepository,
					UserSingletonRepository.GetInstance());

			NomenclaturesJournalViewModel vm = new NomenclaturesJournalViewModel(
				nomenclatureFilter,
				UnitOfWorkFactory.GetDefaultFactory,
				ServicesConfig.CommonServices,
				new EmployeeService(),
				nomenclatureSelectorFactory,
				counterpartySelectorFactory,
				nomenclatureRepository,
				UserSingletonRepository.GetInstance()
			);

			vm.SelectionMode = JournalSelectionMode.Multiple;

			return vm;
		}
		

		public IEntitySelector CreateNomenclatureSelectorForFuelSelect()
		{
			NomenclatureFilterViewModel nomenclatureFilter = new NomenclatureFilterViewModel();
			nomenclatureFilter.RestrictCategory = NomenclatureCategory.fuel;
			nomenclatureFilter.RestrictArchive = false;
			
			var nomenclatureRepository = new NomenclatureRepository(new NomenclatureParametersProvider());
			
			var counterpartySelectorFactory =
				new DefaultEntityAutocompleteSelectorFactory<Counterparty, CounterpartyJournalViewModel, CounterpartyJournalFilterViewModel>(
					ServicesConfig.CommonServices);
			
			var nomenclatureSelectorFactory =
				new NomenclatureAutoCompleteSelectorFactory<Nomenclature, NomenclaturesJournalViewModel>(
					ServicesConfig.CommonServices, VodovozGtkServicesConfig.EmployeeService,
					nomenclatureFilter, counterpartySelectorFactory, nomenclatureRepository,
					UserSingletonRepository.GetInstance());

			NomenclaturesJournalViewModel vm = new NomenclaturesJournalViewModel(
				nomenclatureFilter,
				UnitOfWorkFactory.GetDefaultFactory,
				ServicesConfig.CommonServices,
				new EmployeeService(),
				nomenclatureSelectorFactory,
				counterpartySelectorFactory,
				nomenclatureRepository,
				UserSingletonRepository.GetInstance()
			);

			vm.SelectionMode = JournalSelectionMode.Multiple;

			return vm;
		}

		public IEntityAutocompleteSelectorFactory GetWaterJournalFactory()
		{
			return new WaterJournalFactory();
		}

		public IEntityAutocompleteSelectorFactory CreateNomenclatureAutocompleteSelectorFactory(
			NomenclatureFilterViewModel filterViewModel)
		{
			var nomenclatureRepository = new NomenclatureRepository(new NomenclatureParametersProvider());
			
			var counterpartySelectorFactory =
				new DefaultEntityAutocompleteSelectorFactory<Counterparty, CounterpartyJournalViewModel, CounterpartyJournalFilterViewModel>(
					ServicesConfig.CommonServices);
			
			var nomenclatureSelectorFactory =
				new NomenclatureAutoCompleteSelectorFactory<Nomenclature, NomenclaturesJournalViewModel>(
					ServicesConfig.CommonServices, VodovozGtkServicesConfig.EmployeeService,
					filterViewModel, counterpartySelectorFactory, nomenclatureRepository,
					UserSingletonRepository.GetInstance());

			return nomenclatureSelectorFactory;
		}
	}
}
