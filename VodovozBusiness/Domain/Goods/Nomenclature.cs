﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Bindings.Collections.Generic;
using System.Linq;
using Gamma.Utilities;
using QS.DomainModel.Entity;
using QS.DomainModel.Entity.EntityPermissions;
using QS.DomainModel.UoW;
using QS.HistoryLog;
using QS.Project.Repositories;
using QS.BusinessCommon.Domain;
using Vodovoz.Domain.Employees;
using Vodovoz.Domain.Store;
using Vodovoz.Repository;
using Vodovoz.Domain.Logistic;
using Vodovoz.Domain.Client;
using Vodovoz.EntityRepositories;

namespace Vodovoz.Domain.Goods
{
	[Appellative(Gender = GrammaticalGender.Feminine,
		NominativePlural = "номенклатуры",
		Nominative = "номенклатура")]
	[EntityPermission]
	[HistoryTrace]
	public class Nomenclature : BusinessObjectBase<Nomenclature>, IDomainObject, IValidatableObject
	{
		#region Свойства

		public virtual int Id { get; set; }

		DateTime? createDate;
		[Display(Name = "Дата создания")]
		public virtual DateTime? CreateDate {
			get { return createDate; }
			set { SetField(ref createDate, value, () => CreateDate); }
		}

		User createdBy;
		[Display(Name = "Кем создана")]
		public virtual User CreatedBy {
			get { return createdBy; }
			set { SetField(ref createdBy, value, () => CreatedBy); }
		}

		string name;

		[Display(Name = "Название")]
		public virtual string Name {
			get { return name; }
			set { SetField(ref name, value, () => Name); }
		}

		string officialName;

		[Display(Name = "Официальное название")]
		public virtual string OfficialName {
			get { return officialName; }
			set { SetField(ref officialName, value, () => OfficialName); }
		}

		bool isArchive;

		[Display(Name = "Архивная")]
		public virtual bool IsArchive {
			get { return isArchive; }
			set { SetField(ref isArchive, value, () => IsArchive); }
		}

		bool isDiler;

		[Display(Name = "Дилер")]
		public virtual bool IsDiler {
			get { return isDiler; }
			set { SetField(ref isDiler, value, () => IsDiler); }
		}

		bool canPrintPrice;

		[Display(Name = "Печатается прайс в документах")]
		public virtual bool CanPrintPrice {
			get { return canPrintPrice; }
			set { SetField(ref canPrintPrice, value, () => CanPrintPrice); }
		}

		string code1c;
		[Display(Name = "Код 1с")]
		[StringLength(11)]
		public virtual string Code1c {
			get { return code1c; }
			set { SetField(ref code1c, value, () => Code1c); }
		}

		private Folder1c folder1;

		[Display(Name = "Папка в 1с")]
		public virtual Folder1c Folder1C {
			get { return folder1; }
			set { SetField(ref folder1, value, () => Folder1C); }
		}

		string model;

		[Display(Name = "Модель оборудования")]
		public virtual string Model {
			get { return model; }
			set { SetField(ref model, value, () => Model); }
		}

		double weight;

		[Display(Name = "Вес")]
		public virtual double Weight {
			get { return weight; }
			set { SetField(ref weight, value, () => Weight); }
		}

		double volume;

		/// <summary>
		/// Объем измеряемый в квадратных метрах
		/// </summary>
		[Display(Name = "Объём")]
		public virtual double Volume {
			get { return volume; }
			set { SetField(ref volume, value, () => Volume); }
		}

		VAT vAT = VAT.Vat18;

		[Display(Name = "НДС")]
		public virtual VAT VAT {
			get { return vAT; }
			set { SetField(ref vAT, value, () => VAT); }
		}

		bool doNotReserve;

		[Display(Name = "Не резервировать")]
		public virtual bool DoNotReserve {
			get { return doNotReserve; }
			set { SetField(ref doNotReserve, value, () => DoNotReserve); }
		}

		bool rentPriority;

		[Display(Name = "Приоритет аренды")]
		public virtual bool RentPriority {
			get { return rentPriority; }
			set { SetField(ref rentPriority, value, () => RentPriority); }
		}

		bool isDuty;
		/// <summary>
		/// Дежурное оборудование
		/// </summary>
		[Display(Name = "Дежурное оборудование")]
		public virtual bool IsDuty {
			get { return isDuty; }
			set { SetField(ref isDuty, value, () => IsDuty); }
		}

		bool isSerial;

		[Display(Name = "Серийный номер")]
		public virtual bool IsSerial {
			get { return isSerial; }
			set { SetField(ref isSerial, value, () => IsSerial); }
		}

		MeasurementUnits unit;

		[Display(Name = "Единица измерения")]
		public virtual MeasurementUnits Unit {
			get { return unit; }
			set { SetField(ref unit, value, () => Unit); }
		}

		decimal minStockCount;

		[Display(Name = "Минимальное количество на складе")]
		public virtual decimal MinStockCount {
			get { return minStockCount; }
			set { SetField(ref minStockCount, value, () => MinStockCount); }
		}

		bool isDisposableTare;

		[Display(Name = "Одноразовая тара для воды")]
		public virtual bool IsDisposableTare {
			get { return isDisposableTare; }
			set { SetField(ref isDisposableTare, value, () => IsDisposableTare); }
		}

		TareVolume? tareVolume;

		[Display(Name = "Объем тары для воды")]
		public virtual TareVolume? TareVolume {
			get { return tareVolume; }
			set { SetField(ref tareVolume, value, () => TareVolume); }
		}

		NomenclatureCategory category;

		[Display(Name = "Категория")]
		public virtual NomenclatureCategory Category {
			get { return category; }
			set {
				if(SetField(ref category, value, () => Category)) {
					if(Category != NomenclatureCategory.equipment)
						IsSerial = false;

					if(Category != NomenclatureCategory.water)
						TareVolume = null;

					if(!GetCategoriesWithSaleCategory().Contains(value))
						SaleCategory = null;
				}
			}
		}

		SaleCategory? saleCategory;

		[Display(Name = "Доступность для продаж")]
		public virtual SaleCategory? SaleCategory {
			get { return saleCategory; }
			set { SetField(ref saleCategory, value, () => SaleCategory); }
		}

		TypeOfDepositCategory? typeOfDepositCategory;

		[Display(Name = "Подкатегория залогов")]
		public virtual TypeOfDepositCategory? TypeOfDepositCategory {
			get { return typeOfDepositCategory; }
			set { SetField(ref typeOfDepositCategory, value, () => TypeOfDepositCategory); }
		}

		EquipmentColors equipmentColor;

		[Display(Name = "Цвет оборудования")]
		public virtual EquipmentColors EquipmentColor {
			get { return equipmentColor; }
			set { SetField(ref equipmentColor, value, () => EquipmentColor); }
		}

		EquipmentType type;

		[Display(Name = "Тип оборудования")]
		public virtual EquipmentType Type {
			get { return type; }
			set { SetField(ref type, value, () => Type); }
		}

		Manufacturer manufacturer;

		[Display(Name = "Производитель")]
		public virtual Manufacturer Manufacturer {
			get { return manufacturer; }
			set { SetField(ref manufacturer, value, () => Manufacturer); }
		}

		Logistic.RouteColumn routeListColumn;

		[Display(Name = "Производитель")]
		public virtual Logistic.RouteColumn RouteListColumn {
			get { return routeListColumn; }
			set { SetField(ref routeListColumn, value, () => RouteListColumn); }
		}

		decimal sumOfDamage;

		[Display(Name = "Сумма ущерба")]
		public virtual decimal SumOfDamage {
			get { return sumOfDamage; }
			set {
				SetField(ref sumOfDamage, value, () => SumOfDamage);
			}
		}

		IList<NomenclaturePrice> nomenclaturePrice = new List<NomenclaturePrice>();

		[Display(Name = "Цены")]
		public virtual IList<NomenclaturePrice> NomenclaturePrice {
			get { return nomenclaturePrice; }
			set { SetField(ref nomenclaturePrice, value, () => NomenclaturePrice); }
		}

		private string shortName;

		[Display(Name = "Сокращенное название")]
		public virtual string ShortName {
			get { return shortName; }
			set { SetField(ref shortName, value, () => ShortName); }
		}

		bool hide;

		[Display(Name = "Скрыть из МЛ")]
		public virtual bool Hide {
			get { return hide; }
			set { SetField(ref hide, value, () => Hide); }
		}

		bool noDelivey;

		[Display(Name = "Доставка не требуется")]
		public virtual bool NoDelivey {
			get { return noDelivey; }
			set { SetField(ref noDelivey, value, () => NoDelivey); }
		}

		private bool isNewBottle;

		[Display(Name = "Это новая бутыль")]
		public virtual bool IsNewBottle {
			get => isNewBottle;
			set {
				if(SetField(ref isNewBottle, value, () => IsNewBottle) && isNewBottle)
					IsDefectiveBottle = false;
			}
		}

		private bool isDefectiveBottle;

		[Display(Name = "Это бракованая бутыль")]
		public virtual bool IsDefectiveBottle {
			get { return isDefectiveBottle; }
			set {
				if(SetField(ref isDefectiveBottle, value, () => IsDefectiveBottle) && isDefectiveBottle)
					IsNewBottle = false;
			}
		}

		private FuelType fuelType;
		[Display(Name = "Тип топлива")]
		public virtual FuelType FuelType {
			get => fuelType;
			set => SetField(ref fuelType, value, () => FuelType);
		}

		private Nomenclature dependsOnNomenclature;

		[Display(Name = "Влияющая номенклатура")]
		public virtual Nomenclature DependsOnNomenclature {
			get { return dependsOnNomenclature; }
			set { SetField(ref dependsOnNomenclature, value, () => DependsOnNomenclature); }
		}

		private double percentForMaster;

		[Display(Name = "Процент зарплаты мастера")]
		public virtual double PercentForMaster {
			get { return percentForMaster; }
			set { SetField(ref percentForMaster, value, () => PercentForMaster); }
		}

		private Guid? onlineStoreGuid;

		[Display(Name = "Guid интернет магазина")]
		public virtual Guid? OnlineStoreGuid {
			get { return onlineStoreGuid; }
			set { SetField(ref onlineStoreGuid, value, () => OnlineStoreGuid); }
		}

		private ProductGroup productGroup;

		[Display(Name = "Группа товаров")]
		public virtual ProductGroup ProductGroup {
			get { return productGroup; }
			set { SetField(ref productGroup, value, () => ProductGroup); }
		}

		private IList<NomenclatureImage> images;

		[Display(Name = "Изображения")]
		public virtual IList<NomenclatureImage> Images {
			get { return images; }
			set { SetField(ref images, value, () => Images); }
		}

		private MobileCatalog mobileCatalog;

		[Display(Name = "Каталог в мобильном приложении")]
		public virtual MobileCatalog MobileCatalog {
			get { return mobileCatalog; }
			set { SetField(ref mobileCatalog, value, () => MobileCatalog); }
		}

		private string description;

		[Display(Name = "Описание товара")]
		public virtual string Description {
			get { return description; }
			set { SetField(ref description, value); }
		}

		IList<Warehouse> warehouses = new List<Warehouse>();

		[Display(Name = "Склады для отгрузки")]
		public virtual IList<Warehouse> Warehouses {
			get => warehouses;
			set => SetField(ref warehouses, value, () => Warehouses);
		}

		GenericObservableList<Warehouse> observableWarehouses;
		//FIXME Кослыль пока не разберемся как научить hibernate работать с обновляемыми списками.
		public virtual GenericObservableList<Warehouse> ObservableWarehouses {
			get {
				if(observableWarehouses == null)
					observableWarehouses = new GenericObservableList<Warehouse>(Warehouses);
				return observableWarehouses;
			}
		}

		#endregion

		#region Свойства товаров для магазина

		private decimal purchasePrice;
		[Display(Name = "Цена закупки")]
		public virtual decimal PurchasePrice {
			get => purchasePrice;
			set => SetField(ref purchasePrice, value);
		}

		private Counterparty shipperCounterparty;
		[Display(Name = "Поставщик")]
		public virtual Counterparty ShipperCounterparty {
			get => shipperCounterparty;
			set => SetField(ref shipperCounterparty, value);
		}

		private string storageCell;
		[Display(Name = "Ячейка хранения")]
		public virtual string StorageCell {
			get => storageCell;
			set => SetField(ref storageCell, value);
		}

		private string color;

		[Display(Name = "Цвет")]
		public virtual string Color {
			get { return color; }
			set { SetField(ref color, value); }
		}

		private string material;

		[Display(Name = "Материал")]
		public virtual string Material {
			get { return material; }
			set { SetField(ref material, value); }
		}

		private string liters;

		[Display(Name = "Объем")]
		public virtual string Liters {
			get { return liters; }
			set { SetField(ref liters, value); }
		}

		private string size;

		[Display(Name = "Размеры")]
		public virtual string Size {
			get { return size; }
			set { SetField(ref size, value); }
		}

		private string package;

		[Display(Name = "Тип упаковки")]
		public virtual string Package {
			get { return package; }
			set { SetField(ref package, value); }
		}

		private string degreeOfRoast;

		[Display(Name = "Степень обжарки")]
		public virtual string DegreeOfRoast {
			get { return degreeOfRoast; }
			set { SetField(ref degreeOfRoast, value); }
		}

		private string smell;

		[Display(Name = "Запах")]
		public virtual string Smell {
			get { return smell; }
			set { SetField(ref smell, value); }
		}

		private string taste;

		[Display(Name = "Вкус")]
		public virtual string Taste {
			get { return taste; }
			set { SetField(ref taste, value); }
		}

		private string refrigeratorCapacity;

		[Display(Name = "Объем шкафчика/холодильника")]
		public virtual string RefrigeratorCapacity {
			get { return refrigeratorCapacity; }
			set { SetField(ref refrigeratorCapacity, value); }
		}

		private string coolingType;

		[Display(Name = "Тип охлаждения")]
		public virtual string CoolingType {
			get { return coolingType; }
			set { SetField(ref coolingType, value); }
		}

		private string heatingPower;

		[Display(Name = "Мощность нагрева")]
		public virtual string HeatingPower {
			get { return heatingPower; }
			set { SetField(ref heatingPower, value); }
		}

		private string coolingPower;

		[Display(Name = "Мощность охлаждения")]
		public virtual string CoolingPower {
			get { return coolingPower; }
			set { SetField(ref coolingPower, value); }
		}

		private string heatingPerformance;

		[Display(Name = "Производительность нагрева")]
		public virtual string HeatingPerformance {
			get { return heatingPerformance; }
			set { SetField(ref heatingPerformance, value); }
		}

		private string coolingPerformance;

		[Display(Name = "Производительность охлаждения")]
		public virtual string CoolingPerformance {
			get { return coolingPerformance; }
			set { SetField(ref coolingPerformance, value); }
		}

		private string numberOfCartridges;

		[Display(Name = "Количество картриджей")]
		public virtual string NumberOfCartridges {
			get { return numberOfCartridges; }
			set { SetField(ref numberOfCartridges, value); }
		}

		private string characteristicsOfCartridges;

		[Display(Name = "Характеристика картриджей")]
		public virtual string CharacteristicsOfCartridges {
			get { return characteristicsOfCartridges; }
			set { SetField(ref characteristicsOfCartridges, value); }
		}

		private string countryOfOrigin;

		[Display(Name = "Страна происхождения")]
		public virtual string CountryOfOrigin {
			get { return countryOfOrigin; }
			set { SetField(ref countryOfOrigin, value); }
		}

		private string amountInAPackage;

		[Display(Name = "Количество  в упаковке")]
		public virtual string AmountInAPackage {
			get { return amountInAPackage; }
			set { SetField(ref amountInAPackage, value); }
		}

		#endregion

		#region Рассчетные

		public virtual string CategoryString => Category.GetEnumTitle();

		public virtual string ShortOrFullName => string.IsNullOrWhiteSpace(ShortName) ? Name : ShortName;

		public virtual bool IsWater19L {
			get {
				return Category == NomenclatureCategory.water
				&& TareVolume.HasValue
				&& TareVolume.Value == Goods.TareVolume.Vol19L;
			}
		}

		#endregion

		public override string ToString()
		{
			return string.Format("id ={0} Name = {1}", Id, Name);

		}

		public virtual void SetNomenclatureCreationInfo(IUserRepository userRepository)
		{
			if(Id == 0 && !CreateDate.HasValue) {
				CreateDate = DateTime.Now;
				CreatedBy = userRepository.GetCurrentUser(UoW);
			}
		}

		public Nomenclature()
		{
			Category = NomenclatureCategory.water;
		}

		#region Методы

		public virtual decimal GetPrice(int? itemsCount)
		{
			if(itemsCount < 1)
				itemsCount = 1;
			decimal price = 0m;
			if(DependsOnNomenclature != null) {
				price = DependsOnNomenclature.GetPrice(itemsCount);
			} else {
				var nomPrice = NomenclaturePrice
					.OrderByDescending(p => p.MinCount)
					.FirstOrDefault(p => (p.MinCount <= itemsCount));
				price = nomPrice == null ? 0 : nomPrice.Price;
			}
			return price;
		}

		/// <summary>
		/// Cоздает новый Guid. Uow необходим для сохранения созданного Guid в базу.
		/// </summary>
		public virtual void CreateGuidIfNotExist(IUnitOfWork uow)
		{
			if(OnlineStoreGuid == null) {
				OnlineStoreGuid = Guid.NewGuid();
				uow.Save(this);
			}
		}

		public bool IsFromOnlineShopGroup(int idOfOnlineShopGroup)
		{
			ProductGroup parent = ProductGroup;
			while(parent != null) {
				if(parent.Id == idOfOnlineShopGroup)
					return true;
				parent = parent.Parent;
			};
			return false;
		}

		#endregion

		#region IValidatableObject implementation

		public virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{
			if(String.IsNullOrWhiteSpace(Name))
				yield return new ValidationResult(
					string.Format("Название номенклатуры должно быть заполнено."), new[] { this.GetPropertyName(o => o.Name) });
			else if(Name.Length > 220)
				yield return new ValidationResult(
					string.Format("Превышено максимальное количество символов в названии (220)."), new[] { this.GetPropertyName(o => o.Name) });

			if(String.IsNullOrWhiteSpace(OfficialName))
				yield return new ValidationResult(
					string.Format("Официальное название номенклатуры должно быть заполнено."), new[] { this.GetPropertyName(o => o.OfficialName) });
			else if(Name.Length > 220)
				yield return new ValidationResult(
					string.Format("Превышено максимальное количество символов в официальном названии (220)."), new[] { this.GetPropertyName(o => o.OfficialName) });

			if(Folder1C == null)
				yield return new ValidationResult(
					string.Format("Папка 1С обязательна для заполнения"), new[] { this.GetPropertyName(o => o.Folder1C) });

			if(String.IsNullOrWhiteSpace(Code1c))
				yield return new ValidationResult(
					string.Format("Код 1С обязателен для заполнения"), new[] { this.GetPropertyName(o => o.Code1c) });

			if(Category == NomenclatureCategory.equipment && Type == null)
				yield return new ValidationResult(
					string.Format("Не указан тип оборудования."),
					new[] { this.GetPropertyName(o => o.Type) });

			if(GetCategoriesWithSaleCategory().Contains(category) && SaleCategory == null)
				yield return new ValidationResult(
					"Не указана \"Доступность для продажи\"",
					new[] { this.GetPropertyName(o => o.SaleCategory) }
				);

			if(Category == NomenclatureCategory.deposit && TypeOfDepositCategory == null)
				yield return new ValidationResult(
					string.Format("Не указан тип залога."),
					new[] { this.GetPropertyName(o => o.TypeOfDepositCategory) });

			if(Category == NomenclatureCategory.water && !TareVolume.HasValue)
				yield return new ValidationResult(
					"Не выбран объем тары",
					new[] { this.GetPropertyName(o => o.TareVolume) }
				);

			if(Category == NomenclatureCategory.fuel && FuelType == null) {
				yield return new ValidationResult("Не выбран тип топлива");
			}

			if(Unit == null)
				yield return new ValidationResult(
					string.Format("Не указаны единицы измерения"),
					new[] { this.GetPropertyName(o => o.Unit) });

			//Проверка зависимостей номенклатур #1: если есть зависимые
			if(DependsOnNomenclature != null) {
				IList<Nomenclature> dependedNomenclatures = Repository.NomenclatureRepository.GetDependedNomenclatures(UoW, this);
				if(dependedNomenclatures.Any()) {
					string dependedNomenclaturesText = "Цена данной номенклатуры не может зависеть от другой номенклатуры, т.к. от данной номенклатуры зависят цены следующих номенклатур:\n";
					foreach(Nomenclature n in dependedNomenclatures)
						dependedNomenclaturesText += string.Format("{0}: {1} ({2})\n", n.Id, n.OfficialName, n.CategoryString);
					yield return new ValidationResult(dependedNomenclaturesText, new[] { this.GetPropertyName(o => o.DependsOnNomenclature) });
				}
				if(DependsOnNomenclature.DependsOnNomenclature != null)
					yield return new ValidationResult(
						string.Format("Номенклатура '{0}' указанная в качеcтве основной для цен этой номеклатуры, сама зависит от '{1}'",
									  DependsOnNomenclature.ShortOrFullName, DependsOnNomenclature.DependsOnNomenclature.ShortOrFullName),
						new[] { this.GetPropertyName(o => o.DependsOnNomenclature) });
			}

			if(Code1c != null && Code1c.StartsWith(PrefixOfCode1c)) {
				if(Code1c.Length != LengthOfCode1c)
					yield return new ValidationResult(
						string.Format("Код 1с с префиксом автоформирования '{0}', должен содержать {1}-символов.",
									  PrefixOfCode1c, LengthOfCode1c),
						new[] { this.GetPropertyName(o => o.Code1c) });

				var next = NomenclatureRepository.GetNextCode1c(UoW);
				if(string.Compare(Code1c, next) > 0)
					yield return new ValidationResult(
						string.Format("Код 1с использует префикс автоматического формирования кодов '{0}'. При этом пропускает некоторое количество значений. Используйте в качестве следующего кода {1} или оставьте это поле пустым для автозаполенения.",
									  PrefixOfCode1c, next),
						new[] { this.GetPropertyName(o => o.Code1c) });
			}

			if(DateTime.Now >= new DateTime(2019, 01, 01) && VAT == VAT.Vat18)
				yield return new ValidationResult(
					"С 01.01.2019 ставка НДС 20%",
					new[] { this.GetPropertyName(o => o.VAT) }
				);
		}

		#endregion

		#region statics

		public static string PrefixOfCode1c = "ДВ";
		public static int LengthOfCode1c = 10;

		/// <summary>
		/// Категории товаров к которым применима категория продажи
		/// (доступность для продаж) "<see cref="SaleCategory"/>"
		/// </summary>
		/// <returns>Массив <see cref="NomenclatureCategory"/> к которым может применяться <see cref="SaleCategory"/></returns>
		public static NomenclatureCategory[] GetCategoriesWithSaleCategory()
		{
			return new[] {
				NomenclatureCategory.equipment,
				NomenclatureCategory.material,
				NomenclatureCategory.bottle,
				NomenclatureCategory.spare_parts
			};
		}

		public static NomenclatureCategory[] GetCategoriesForShipment()
		{
			return new[] {
				NomenclatureCategory.additional,
				NomenclatureCategory.equipment,
				NomenclatureCategory.water,
				NomenclatureCategory.bottle,
				NomenclatureCategory.spare_parts,
				NomenclatureCategory.material
			};
		}

		public static NomenclatureCategory[] GetCategoriesForProductMaterial()
		{
			return new[] { NomenclatureCategory.material, NomenclatureCategory.bottle };
		}

		public static NomenclatureCategory[] GetCategoriesForSale()
		{
			return new[] {
				NomenclatureCategory.additional,
				NomenclatureCategory.equipment,
				NomenclatureCategory.water,
				NomenclatureCategory.bottle,
				NomenclatureCategory.deposit,
				NomenclatureCategory.spare_parts,
				NomenclatureCategory.service
			};
		}

		public static NomenclatureCategory[] GetCategoriesForSaleToOrder()
		{
			return new[] {
				NomenclatureCategory.additional,
				NomenclatureCategory.equipment,
				NomenclatureCategory.water,
				NomenclatureCategory.deposit,
				NomenclatureCategory.service,
				NomenclatureCategory.spare_parts,
				NomenclatureCategory.bottle,
				NomenclatureCategory.material
			};
		}

		/// <summary>
		/// Список номенклатур доступных для добавления в товары 
		/// из диалога изменения заказа в закрытии МЛ
		/// </summary>
		public static NomenclatureCategory[] GetCategoriesForEditOrderFromRL()
		{
			return new[] {
				NomenclatureCategory.additional,
				NomenclatureCategory.water,
				NomenclatureCategory.bottle,
				NomenclatureCategory.deposit,
				NomenclatureCategory.spare_parts,
				NomenclatureCategory.service,
				NomenclatureCategory.master
			};
		}

		public static NomenclatureCategory[] GetCategoriesForMaster()
		{
			List<NomenclatureCategory> list = new List<NomenclatureCategory>(GetCategoriesForSale()) {
				NomenclatureCategory.master,
				NomenclatureCategory.spare_parts
			};
			return list.ToArray();
		}

		/// <summary>
		/// Категории товаров. Товары могут хранится на складе.
		/// </summary>
		public static NomenclatureCategory[] GetCategoriesForGoods()
		{
			return new[] {
				NomenclatureCategory.bottle,
				NomenclatureCategory.additional,
				NomenclatureCategory.equipment,
				NomenclatureCategory.material,
				NomenclatureCategory.spare_parts,
				NomenclatureCategory.water,
			};
		}

		/// <summary>
		/// Категории товаров. Товары могут хранится на складе без учёта 19л воды.
		/// </summary>
		public static NomenclatureCategory[] GetCategoriesForGoodsWithoutEmptyBottles()
		{
			return new[] {
				NomenclatureCategory.water,
				NomenclatureCategory.additional,
				NomenclatureCategory.equipment,
				NomenclatureCategory.material,
				NomenclatureCategory.spare_parts,
			};
		}

		public static NomenclatureCategory[] GetCategoriesWithEditablePrice()
		{
			return new[] {
				NomenclatureCategory.bottle,
				NomenclatureCategory.additional,
				NomenclatureCategory.equipment,
				NomenclatureCategory.material,
				NomenclatureCategory.spare_parts,
				NomenclatureCategory.water,
				NomenclatureCategory.service,
				NomenclatureCategory.deposit,
				NomenclatureCategory.master
			};
		}

		public static NomenclatureCategory[] GetAllCategories()
		{
			var values = new List<NomenclatureCategory>();
			foreach(var item in Enum.GetValues(typeof(NomenclatureCategory))) {
				values.Add((NomenclatureCategory)item);
			}
			return values.ToArray();
		}


		/// <summary>
		/// Определяет категории для которых необходимо создавать доп соглашение по продаже воды
		/// </summary>
		public static NomenclatureCategory[] GetCategoriesRequirementForWaterAgreement()
		{
			return new[] {
				NomenclatureCategory.water
			};
		}
		#endregion
	}

	public enum NomenclatureCategory
	{
		[Display(Name = "Вода")]
		water,
		[Display(Name = "Залог")]
		deposit,
		[Display(Name = "Запчасти")]
		spare_parts,
		[Display(Name = "Оборудование")]
		equipment,
		[Display(Name = "Товары")]
		additional,
		[Display(Name = "Услуга")]
		service,
		[Display(Name = "Тара")]
		bottle,
		[Display(Name = "Сырьё")]
		material,
		[Display(Name = "Выезд мастера")]
		master,
		[Display(Name = "Топливо")]
		fuel

	}

	public enum TareVolume
	{
		[Display(Name = "19 л.")]
		Vol19L = 19000,
		[Display(Name = "6 л.")]
		Vol6L = 6000,
		[Display(Name = "1,5 л.")]
		Vol1500ml = 1500,
		[Display(Name = "0,6 л.")]
		Vol600ml = 600
	}

	/// <summary>
	/// Подтип категории "Товары"
	/// </summary>
	public enum SaleCategory
	{
		[Display(Name = "На продажу")]
		forSale,
		[Display(Name = "Не для продажи")]
		notForSale
	}

	/// <summary>
	/// Подтип категории "Залог"
	/// </summary>
	public enum TypeOfDepositCategory
	{
		[Display(Name = "Залог за бутыли")]
		BottleDeposit,
		[Display(Name = "Залог за оборудование")]
		EquipmentDeposit
	}

	public class NomenclatureCategoryStringType : NHibernate.Type.EnumStringType
	{
		public NomenclatureCategoryStringType() : base(typeof(NomenclatureCategory))
		{
		}
	}

	public class SaleCategoryStringType : NHibernate.Type.EnumStringType
	{
		public SaleCategoryStringType() : base(typeof(SaleCategory))
		{
		}
	}

	public class TypeOfDepositCategoryStringType : NHibernate.Type.EnumStringType
	{
		public TypeOfDepositCategoryStringType() : base(typeof(TypeOfDepositCategory))
		{
		}
	}

	public class TareVolumeStringType : NHibernate.Type.EnumStringType
	{
		public TareVolumeStringType() : base(typeof(TareVolume))
		{
		}
	}
}

