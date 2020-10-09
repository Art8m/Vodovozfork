using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using NSubstitute;
using NUnit.Framework;
using QS.DomainModel.UoW;
using QS.Permissions;
using Vodovoz.Domain.Client;
using Vodovoz.Domain.Goods;
using Vodovoz.Domain.Orders;
using Vodovoz.Parameters;
using Vodovoz.Validators.Orders;

namespace VodovozBusinessTests.Validators.Orders {
    [TestFixture]
    public class SelfDeliveryOrderValidatorTests {

        #region OrderValidator без параметров
        
        [Test(Description = "Проверка валидирования заказа-самовывоза без контрагента")]
        public void ValidateSelfDeliveryOrderWithoutCounterparty()
        {
            // arrange
            SelfDeliveryOrder testOrder = new SelfDeliveryOrder();
            
            SelfDeliveryOrderValidator validator = new SelfDeliveryOrderValidator(new DefaultAllowedPermissionService(), 
                new NomenclatureParametersProvider() ,UnitOfWorkFactory.CreateWithoutRoot(), testOrder);
            
            var results = new List<ValidationResult>();
            var validationRes =  new ValidationResult("В заказе необходимо заполнить поле \"клиент\".",
                new[] {nameof(testOrder.Counterparty)});
            var vc = new ValidationContext(validator, null, null);

            // act
            var isValid = Validator.TryValidateObject(validator, vc, results, true);
            
            // assert
            Assert.False(isValid);
            Assert.True(results.Any(x => x.ErrorMessage == validationRes.ErrorMessage));
        }
        
        [Test(Description = "Проверка валидирования заказа-самовывоза без даты доставки")]
        public void ValidateSelfDeliveryOrderWithoutDeliveryDate()
        {
            // arrange
            SelfDeliveryOrder testOrder = new SelfDeliveryOrder();
            
            SelfDeliveryOrderValidator validator = new SelfDeliveryOrderValidator(new DefaultAllowedPermissionService(), 
                new NomenclatureParametersProvider() ,UnitOfWorkFactory.CreateWithoutRoot(), testOrder);
            
            var results = new List<ValidationResult>();
            var validationRes = new ValidationResult("В заказе не указана дата доставки.",
                new[] { nameof(testOrder.DeliveryDate) });
            var vc = new ValidationContext(validator, null, null);

            // act
            var isValid = Validator.TryValidateObject(validator, vc, results, true);
            
            // assert
            Assert.False(isValid);
            Assert.True(results.Any(x => x.ErrorMessage == validationRes.ErrorMessage));
        }
        
        [Test(Description = "Проверка валидирования заказа-самовывоза с отрицательным залогом")]
        public void ValidateSelfDeliveryOrderWithNegativeDeposit()
        {
            // arrange
            SelfDeliveryOrder testOrder = new SelfDeliveryOrder();
            OrderDepositItem orderDepositItem = new OrderDepositItem {
                Deposit = -250m,
                Count = 1
            };

            testOrder.ObservableOrderDepositItems.Add(orderDepositItem);
            
            SelfDeliveryOrderValidator validator = new SelfDeliveryOrderValidator(new DefaultAllowedPermissionService(), 
                new NomenclatureParametersProvider() ,UnitOfWorkFactory.CreateWithoutRoot(), testOrder);
            
            var results = new List<ValidationResult>();
            var validationRes = new ValidationResult("В возврате залогов в заказе необходимо вводить положительную сумму.");
            var vc = new ValidationContext(validator, null, null);

            // act
            var isValid = Validator.TryValidateObject(validator, vc, results, true);
            
            // assert
            Assert.False(isValid);
            Assert.True(results.Any(x => x.ErrorMessage == validationRes.ErrorMessage));
        }
        
        [Test(Description = "Проверка валидирования заказа-самовывоза с оборудованием, без причины забора-доставки")]
        public void ValidateSelfDeliveryOrderWithOrderEquipmentsWithoutDirectionReason()
        {
            // arrange
            SelfDeliveryOrder testOrder = new SelfDeliveryOrder();

            OrderEquipment orderEquipmentMock1 = Substitute.For<OrderEquipment>();
            OrderEquipment orderEquipmentMock2 = Substitute.For<OrderEquipment>();
            Nomenclature nomenclatureMock1 = Substitute.For<Nomenclature>();
            Nomenclature nomenclatureMock2 = Substitute.For<Nomenclature>();

            nomenclatureMock1.Category = NomenclatureCategory.equipment;
            nomenclatureMock2.Category = NomenclatureCategory.water;

            orderEquipmentMock1.Nomenclature = nomenclatureMock1;
            orderEquipmentMock2.Nomenclature = nomenclatureMock2;
            
            testOrder.ObservableOrderEquipments.Add(orderEquipmentMock1);
            testOrder.ObservableOrderEquipments.Add(orderEquipmentMock2);
            
            SelfDeliveryOrderValidator validator = new SelfDeliveryOrderValidator(new DefaultAllowedPermissionService(), 
                new NomenclatureParametersProvider() ,UnitOfWorkFactory.CreateWithoutRoot(), testOrder);
            
            var results = new List<ValidationResult>();
            var validationRes =
                new ValidationResult("У оборудования в заказе должна быть указана причина забор-доставки.");
            var vc = new ValidationContext(validator, null, null);

            // act
            var isValid = Validator.TryValidateObject(validator, vc, results, true);
            
            // assert
            Assert.False(isValid);
            Assert.True(results.Any(x => x.ErrorMessage == validationRes.ErrorMessage));
        }
        
        [Test(Description = "Проверка валидирования заказа-самовывоза с оборудованием, без принадлежности")]
        public void ValidateSelfDeliveryOrderWithOrderEquipmentsWithoutOwnType()
        {
            // arrange
            SelfDeliveryOrder testOrder = new SelfDeliveryOrder();

            OrderEquipment orderEquipmentMock1 = Substitute.For<OrderEquipment>();
            OrderEquipment orderEquipmentMock2 = Substitute.For<OrderEquipment>();
            Nomenclature nomenclatureMock1 = Substitute.For<Nomenclature>();
            Nomenclature nomenclatureMock2 = Substitute.For<Nomenclature>();

            nomenclatureMock1.Category = NomenclatureCategory.equipment;
            nomenclatureMock2.Category = NomenclatureCategory.water;

            orderEquipmentMock1.Nomenclature = nomenclatureMock1;
            orderEquipmentMock2.Nomenclature = nomenclatureMock2;
            
            testOrder.ObservableOrderEquipments.Add(orderEquipmentMock1);
            testOrder.ObservableOrderEquipments.Add(orderEquipmentMock2);
            
            SelfDeliveryOrderValidator validator = new SelfDeliveryOrderValidator(new DefaultAllowedPermissionService(), 
                new NomenclatureParametersProvider() ,UnitOfWorkFactory.CreateWithoutRoot(), testOrder);
            
            var results = new List<ValidationResult>();
            var validationRes =
                new ValidationResult("У оборудования в заказе должна быть выбрана принадлежность.");
            var vc = new ValidationContext(validator, null, null);

            // act
            var isValid = Validator.TryValidateObject(validator, vc, results, true);
            
            // assert
            Assert.False(isValid);
            Assert.True(results.Any(x => x.ErrorMessage == validationRes.ErrorMessage));
        }

        /*[Test(Description = "Проверка валидирования заказа-самовывоза с товарами со скидкой, без указания причины скидки")]
        public void ValidateSelfDeliveryOrderWithOrderItemsWithDiscountWithoutDisountReason()
        {
            // arrange
            SelfDeliveryOrder testOrder = new SelfDeliveryOrder();

            OrderItem orderItemMock1 = Substitute.For<OrderItem>();
            Nomenclature nomenclatureMock1 = Substitute.For<Nomenclature>();
            
            orderItemMock1.Discount = 25m;
            orderItemMock1.IsDiscountInMoney = true;
            orderItemMock1.Nomenclature = nomenclatureMock1;

            testOrder.ObservableOrderItems.Add(orderItemMock1);
            
            SelfDeliveryOrderValidator validator = new SelfDeliveryOrderValidator(new DefaultAllowedPermissionService(), 
                new NomenclatureParametersProvider() ,UnitOfWorkFactory.CreateWithoutRoot(), testOrder);
            
            var results = new List<ValidationResult>();
            var validationRes =
                new ValidationResult(
                    "Если в заказе указана скидка на товар, то обязательно должно быть заполнено поле 'Основание'.");
            var vc = new ValidationContext(validator, null, null);

            // act
            var isValid = Validator.TryValidateObject(validator, vc, results, true);
            
            // assert
            Assert.False(isValid);
            Assert.True(results.Any(x => x.ErrorMessage == validationRes.ErrorMessage));
        }*/
        
        #endregion

        #region OrderValidator с параметрами

        [Test(Description = "Проверка валидирования заказа-самовывоза с забором оборудования, без указания причины не забора в комментарии")]
        public void ValidateSelfDeliveryOrderWithOrderEquipmentsWithDirectionPickUpWithoutComment()
        {
            // arrange
            SelfDeliveryOrder testOrder = new SelfDeliveryOrder();

            OrderEquipment orderEquipmentMock1 = Substitute.For<OrderEquipment>();
            Nomenclature nomenclatureMock1 = Substitute.For<Nomenclature>();
            
            nomenclatureMock1.Category = NomenclatureCategory.equipment;
            
            orderEquipmentMock1.Nomenclature = nomenclatureMock1;
            orderEquipmentMock1.Direction = Direction.PickUp;
            
            testOrder.ObservableOrderEquipments.Add(orderEquipmentMock1);
            
            SelfDeliveryOrderValidator validator = new SelfDeliveryOrderValidator(new DefaultAllowedPermissionService(), 
                new NomenclatureParametersProvider() ,UnitOfWorkFactory.CreateWithoutRoot(), testOrder);
            
            var contextItems = new Dictionary<object, object> {
                { nameof(OrderValidateParameters), new OrderValidateParameters { OrderAction = OrderValidateAction.Close } }
            };
            
            var results = new List<ValidationResult>();
            var validationRes =
                new ValidationResult(
                    $"Забор оборудования {orderEquipmentMock1.NameString} по заказу {testOrder.Id} не произведен, а в комментарии не указана причина.",
                    new[] { nameof(testOrder.OrderEquipments) });
            var vc = new ValidationContext(validator, null, contextItems);

            // act
            var isValid = Validator.TryValidateObject(validator, vc, results, true);
            
            // assert
            Assert.False(isValid);
            Assert.True(results.Any(x => x.ErrorMessage == validationRes.ErrorMessage));
        }
        
        [Test(Description = "Проверка валидирования заказа-самовывоза с залогами, для типа оплаты cashless")]
        public void ValidateSelfDeliveryOrderWithOrderDepositItemsAndPaymentTypeCashless()
        {
            // arrange
            SelfDeliveryOrder testOrder = new SelfDeliveryOrder { PaymentType = PaymentType.cashless };

            Counterparty counterpartyMock1 = Substitute.For<Counterparty>();
            OrderDepositItem orderDepositItemMock1 = Substitute.For<OrderDepositItem>();

            testOrder.ObservableOrderDepositItems.Add(orderDepositItemMock1);
            testOrder.Counterparty = counterpartyMock1;
            
            SelfDeliveryOrderValidator validator = new SelfDeliveryOrderValidator(new DefaultAllowedPermissionService(), 
                new NomenclatureParametersProvider() ,UnitOfWorkFactory.CreateWithoutRoot(), testOrder);
            
            var contextItems = new Dictionary<object, object> {
                { nameof(OrderValidateParameters), new OrderValidateParameters { OrderAction = OrderValidateAction.Accept } }
            };
            
            var results = new List<ValidationResult>();
            var validationRes =
                new ValidationResult("Возврат залога не применим для заказа в текущем состоянии");
            var vc = new ValidationContext(validator, null, contextItems);

            // act
            var isValid = Validator.TryValidateObject(validator, vc, results, true);
            
            // assert
            Assert.False(isValid);
            Assert.True(results.Any(x => x.ErrorMessage == validationRes.ErrorMessage));
        }

        [Test(Description = "Проверка валидирования заказа-самовывоза с товарами или оборудованием с количеством <= 0")]
        public void ValidateSelfDeliveryOrderWithOrderItemsCountOrOrderEquipmentsCountEqualsZero()
        {
            // arrange
            Counterparty counterpartyMock1 = Substitute.For<Counterparty>();
            OrderEquipment orderEquipmentMock1 = Substitute.For<OrderEquipment>();
            Nomenclature nomenclatureMock1 = Substitute.For<Nomenclature>();

            SelfDeliveryOrder testOrder = new SelfDeliveryOrder {
                Counterparty = counterpartyMock1
            };

            orderEquipmentMock1.Nomenclature = nomenclatureMock1;
            testOrder.ObservableOrderEquipments.Add(orderEquipmentMock1);
            
            SelfDeliveryOrderValidator validator = new SelfDeliveryOrderValidator(new DefaultAllowedPermissionService(), 
                new NomenclatureParametersProvider() ,UnitOfWorkFactory.CreateWithoutRoot(), testOrder);
            
            var contextItems = new Dictionary<object, object> {
                { nameof(OrderValidateParameters), new OrderValidateParameters { OrderAction = OrderValidateAction.Accept } }
            };
            
            var results = new List<ValidationResult>();
            var validationRes =
                new ValidationResult("В заказе должно быть указано количество во всех позициях товара и оборудования");
            var vc = new ValidationContext(validator, null, contextItems);

            // act
            var isValid = Validator.TryValidateObject(validator, vc, results, true);
            
            // assert
            Assert.False(isValid);
            Assert.True(results.Any(x => x.ErrorMessage == validationRes.ErrorMessage));
        }
        
        //Не выставить IsDeliveriesClosed из-за protected свойства
        [Test(Description = "Проверка валидирования заказа-самовывоза для клиента с закрытыми поставками и определенными типами оплат")]
        public void ValidateSelfDeliveryOrderForCounterpartyWithCloseddeliveries()
        {
            // arrange
            Counterparty counterpartyMock1 = Substitute.For<Counterparty>();
            //counterpartyMock1.IsDeliveriesClosed = true;
            
            SelfDeliveryOrder testOrder = new SelfDeliveryOrder {
                Counterparty = counterpartyMock1,
                PaymentType = PaymentType.cashless
            };

            SelfDeliveryOrderValidator validator = new SelfDeliveryOrderValidator(new DefaultAllowedPermissionService(), 
                new NomenclatureParametersProvider() ,UnitOfWorkFactory.CreateWithoutRoot(), testOrder);
            
            var contextItems = new Dictionary<object, object> {
                { nameof(OrderValidateParameters), new OrderValidateParameters { OrderAction = OrderValidateAction.Accept } }
            };
            
            var results = new List<ValidationResult>();
            var validationRes =
                new ValidationResult(
                    "В заказе неверно указан тип оплаты (для данного клиента закрыты поставки)",
                    new[] { nameof(testOrder.PaymentType) });
            var vc = new ValidationContext(validator, null, contextItems);

            // act
            var isValid = Validator.TryValidateObject(validator, vc, results, true);
            
            // assert
            Assert.False(isValid);
            Assert.True(results.Any(x => x.ErrorMessage == validationRes.ErrorMessage));
        }
        
        [Test(Description = "Проверка валидирования заказа-самовывоза с точкой доставки без района")]
        public void ValidateSelfDeliveryOrderWithDeliveryPointWithoutDistrict()
        {
            // arrange
            Counterparty counterpartyMock1 = Substitute.For<Counterparty>();
            DeliveryPoint deliveryPointMock1 = Substitute.For<DeliveryPoint>();
            
            SelfDeliveryOrder testOrder = new SelfDeliveryOrder {
                DeliveryPoint = deliveryPointMock1,
                Counterparty = counterpartyMock1
            };

            SelfDeliveryOrderValidator validator = new SelfDeliveryOrderValidator(new DefaultAllowedPermissionService(), 
                new NomenclatureParametersProvider() ,UnitOfWorkFactory.CreateWithoutRoot(), testOrder);
            
            var contextItems = new Dictionary<object, object> {
                { nameof(OrderValidateParameters), new OrderValidateParameters { OrderAction = OrderValidateAction.Accept } }
            };
            
            var results = new List<ValidationResult>();
            var validationRes =
                new ValidationResult(
                    "Район доставки не найден. Укажите правильные координаты или разметьте район доставки.",
                    new[] { nameof(DeliveryPoint) });
            var vc = new ValidationContext(validator, null, contextItems);

            // act
            var isValid = Validator.TryValidateObject(validator, vc, results, true);
            
            // assert
            Assert.False(isValid);
            Assert.True(results.Any(x => x.ErrorMessage == validationRes.ErrorMessage));
        }
        
        #endregion
        
        #region SelfDeliveryOrderValidator

        [Test(Description = "Проверка валидирования заказа-самовывоза с оплатой по карте, без заполненного номера онлайн-заказа")]
        public void ValidateSelfDeliveryOrderWithPaymentTypeByCardWithoutOrderNumberFromOnlineStore()
        {
            // arrange
            SelfDeliveryOrder testOrder = new SelfDeliveryOrder {
                PaymentType = PaymentType.ByCard
            };
            
            SelfDeliveryOrderValidator validator = new SelfDeliveryOrderValidator(new DefaultAllowedPermissionService(), 
                new NomenclatureParametersProvider() ,UnitOfWorkFactory.CreateWithoutRoot(), testOrder);
            
            var results = new List<ValidationResult>();
            var validationRes =
                new ValidationResult("Если в заказе выбран тип оплаты по карте, необходимо заполнить номер онлайн заказа.",
                    new[] { nameof(testOrder.OrderNumberFromOnlineStore) });
            var vc = new ValidationContext(validator, null, null);

            // act
            var isValid = Validator.TryValidateObject(validator, vc, results, true);
            
            // assert
            Assert.False(isValid);
            Assert.True(results.Any(x => x.ErrorMessage == validationRes.ErrorMessage));
        }
        
        [Test(Description = "Проверка валидирования заказа-самовывоза с оплатой по карте, без указания откуда оплата")]
        public void ValidateSelfDeliveryOrderWithPaymentTypeByCardWithoutPaymentFrom()
        {
            // arrange
            SelfDeliveryOrder testOrder = new SelfDeliveryOrder {
                PaymentType = PaymentType.ByCard
            };
            
            SelfDeliveryOrderValidator validator = new SelfDeliveryOrderValidator(new DefaultAllowedPermissionService(), 
                new NomenclatureParametersProvider() ,UnitOfWorkFactory.CreateWithoutRoot(), testOrder);
            
            var results = new List<ValidationResult>();
            var validationRes =
                new ValidationResult(
                    "Выбран тип оплаты по карте. Необходимо указать откуда произведена оплата.",
                    new[] { nameof(testOrder.PaymentByCardFrom) });
            var vc = new ValidationContext(validator, null, null);

            // act
            var isValid = Validator.TryValidateObject(validator, vc, results, true);
            
            // assert
            Assert.False(isValid);
            Assert.True(results.Any(x => x.ErrorMessage == validationRes.ErrorMessage));
        }
        
        /*[Test(Description = "Проверка валидирования заказа-самовывоза с номенклатурой из интернет-магазина, без указания номера заказа ИМ")]
        public void ValidateSelfDeliveryOrderWithOrderItemsFromWebStoreWithoutEShopOrder()
        {
            // arrange
            SelfDeliveryOrder testOrder = new SelfDeliveryOrder();

            OrderItem orderItemMock1 = Substitute.For<OrderItem>();
            Nomenclature nomenclatureMock1 = Substitute.For<Nomenclature>();
            ProductGroup productGroupMock1 = Substitute.For<ProductGroup>();

            productGroupMock1.IsOnlineStore = true;
            nomenclatureMock1.ProductGroup = productGroupMock1;
            orderItemMock1.Nomenclature = nomenclatureMock1;

            testOrder.ObservableOrderItems.Add(orderItemMock1);
            
            SelfDeliveryOrderValidator validator = new SelfDeliveryOrderValidator(new DefaultAllowedPermissionService(), 
                new NomenclatureParametersProvider() ,UnitOfWorkFactory.CreateWithoutRoot(), testOrder);
            
            var results = new List<ValidationResult>();
            var validationRes =
                new ValidationResult(
                    "При добавлении в заказ номенклатур с группой товаров интернет-магазина необходимо указать номер заказа интернет-магазина.",
                    new[] { nameof(testOrder.EShopOrder) });
            var vc = new ValidationContext(validator, null, null);

            // act
            var isValid = Validator.TryValidateObject(validator, vc, results, true);
            
            // assert
            Assert.False(isValid);
            Assert.True(results.Any(x => x.ErrorMessage == validationRes.ErrorMessage));
        }*/
        
        [Test(Description = "Проверка валидирования заказа-самовывоза с контрактной документацией")]
        public void ValidateSelfDeliveryOrderWithPaymentTypeContractDoc()
        {
            // arrange
            SelfDeliveryOrder testOrder = new SelfDeliveryOrder {
                PaymentType = PaymentType.ContractDoc
            };
            
            SelfDeliveryOrderValidator validator = new SelfDeliveryOrderValidator(new DefaultAllowedPermissionService(), 
                new NomenclatureParametersProvider() ,UnitOfWorkFactory.CreateWithoutRoot(), testOrder);
            
            var results = new List<ValidationResult>();
            var validationRes =
                new ValidationResult(
                    "Тип оплаты - контрактная документация невозможен для самовывоза",
                    new[] { nameof(testOrder.PaymentType) });
            var vc = new ValidationContext(validator, null, null);

            // act
            var isValid = Validator.TryValidateObject(validator, vc, results, true);
            
            // assert
            Assert.False(isValid);
            Assert.True(results.Any(x => x.ErrorMessage == validationRes.ErrorMessage));
        }
        
        #endregion

        #region SelfDeliveryOrderValidator с параметрами

        [Test(Description = "Проверка валидирования заказа-самовывоза в определенных условиях")]
        public void ValidateSelfDeliveryOrderOrderStateKey2()
        {
            // arrange
            Counterparty counterpartyMock1 = Substitute.For<Counterparty>();
            
            SelfDeliveryOrder testOrder = new SelfDeliveryOrder {
                PaymentType = PaymentType.ByCard,
                Counterparty = counterpartyMock1,
                BottlesReturn = 5
            };
            
            SelfDeliveryOrderValidator validator = new SelfDeliveryOrderValidator(new DefaultAllowedPermissionService(), 
                new NomenclatureParametersProvider() ,UnitOfWorkFactory.CreateWithoutRoot(), testOrder);
            
            var contextItems = new Dictionary<object, object> {
                { nameof(OrderValidateParameters), new OrderValidateParameters { OrderAction = OrderValidateAction.Accept } }
            };
            
            var results = new List<ValidationResult>();
            var validationRes =
                new ValidationResult("Невозможно подтвердить или перевести в статус ожидания оплаты заказ в текущем состоянии без суммы");
            var vc = new ValidationContext(validator, null, contextItems);

            // act
            var isValid = Validator.TryValidateObject(validator, vc, results, true);
            
            // assert
            Assert.False(isValid);
            Assert.True(results.Any(x => x.ErrorMessage == validationRes.ErrorMessage));
        }
        
        [Test(Description = "Проверка валидирования заказа-самовывоза в определенных условиях")]
        public void ValidateSelfDeliveryOrderOrderStateKey3()
        {
            // arrange
            Counterparty counterpartyMock1 = Substitute.For<Counterparty>();
            
            SelfDeliveryOrder testOrder = new SelfDeliveryOrder {
                Counterparty = counterpartyMock1,
                BottlesReturn = 5
            };
            
            SelfDeliveryOrderValidator validator = new SelfDeliveryOrderValidator(new DefaultAllowedPermissionService(), 
                new NomenclatureParametersProvider() ,UnitOfWorkFactory.CreateWithoutRoot(), testOrder);
            
            var contextItems = new Dictionary<object, object> {
                { nameof(OrderValidateParameters), new OrderValidateParameters { OrderAction = OrderValidateAction.Accept } }
            };
            
            var results = new List<ValidationResult>();
            var validationRes =
                new ValidationResult("Невозможно подтвердить или перевести в статус ожидания оплаты пустой заказ");
            var vc = new ValidationContext(validator, null, contextItems);

            // act
            var isValid = Validator.TryValidateObject(validator, vc, results, true);
            
            // assert
            Assert.False(isValid);
            Assert.True(results.Any(x => x.ErrorMessage == validationRes.ErrorMessage));
        }
        
        [Test(Description = "Проверка валидирования заказа-самовывоза без продажи воды, но с забором тары и без указания причины этого забора")]
        public void ValidateSelfDeliveryOrderWithBottlesReturnWithoutReturnTareReason()
        {
            // arrange
            Counterparty counterpartyMock1 = Substitute.For<Counterparty>();
            
            SelfDeliveryOrder testOrder = new SelfDeliveryOrder {
                Counterparty = counterpartyMock1,
                BottlesReturn = 5
            };
            
            SelfDeliveryOrderValidator validator = new SelfDeliveryOrderValidator(new DefaultAllowedPermissionService(), 
                new NomenclatureParametersProvider() ,UnitOfWorkFactory.CreateWithoutRoot(), testOrder);
            
            var contextItems = new Dictionary<object, object> {
                { nameof(OrderValidateParameters), new OrderValidateParameters { OrderAction = OrderValidateAction.Accept } }
            };
            
            var results = new List<ValidationResult>();
            var validationRes =
                new ValidationResult("Необходимо указать причину забора тары.",
                    new[] {nameof(testOrder.ReturnTareReason)});
            var vc = new ValidationContext(validator, null, contextItems);

            // act
            var isValid = Validator.TryValidateObject(validator, vc, results, true);
            
            // assert
            Assert.False(isValid);
            Assert.True(results.Any(x => x.ErrorMessage == validationRes.ErrorMessage));
        }
        
        [Test(Description = "Проверка валидирования заказа-самовывоза без продажи воды, но с забором тары и без указания категории причины этого забора")]
        public void ValidateSelfDeliveryOrderWithBottlesReturnWithoutReturnTareReasonCategory()
        {
            // arrange
            Counterparty counterpartyMock1 = Substitute.For<Counterparty>();
            
            SelfDeliveryOrder testOrder = new SelfDeliveryOrder {
                Counterparty = counterpartyMock1,
                BottlesReturn = 5
            };
            
            SelfDeliveryOrderValidator validator = new SelfDeliveryOrderValidator(new DefaultAllowedPermissionService(), 
                new NomenclatureParametersProvider() ,UnitOfWorkFactory.CreateWithoutRoot(), testOrder);
            
            var contextItems = new Dictionary<object, object> {
                { nameof(OrderValidateParameters), new OrderValidateParameters { OrderAction = OrderValidateAction.Accept } }
            };
            
            var results = new List<ValidationResult>();
            var validationRes =
                new ValidationResult("Необходимо указать категорию причины забора тары.",
                    new[] {nameof(testOrder.ReturnTareReasonCategory)});
            var vc = new ValidationContext(validator, null, contextItems);

            // act
            var isValid = Validator.TryValidateObject(validator, vc, results, true);
            
            // assert
            Assert.False(isValid);
            Assert.True(results.Any(x => x.ErrorMessage == validationRes.ErrorMessage));
        }
        
        [Test(Description = "Проверка валидирования заказа-самовывоза с продажей воды, без возвратной тары")]
        public void ValidateSelfDeliveryOrderWithWaterAndWithoutBottlesReturn()
        {
            // arrange
            OrderItem orderItemMock1 = Substitute.For<OrderItem>();
            Nomenclature nomenclatureMock1 = Substitute.For<Nomenclature>();
            Counterparty counterpartyMock1 = Substitute.For<Counterparty>();
            
            SelfDeliveryOrder testOrder = new SelfDeliveryOrder {
                Counterparty = counterpartyMock1,
            };

            nomenclatureMock1.Category = NomenclatureCategory.water;
            nomenclatureMock1.ProductGroup = null;
            orderItemMock1.Nomenclature = nomenclatureMock1;
            testOrder.ObservableOrderItems.Add(orderItemMock1);
            
            SelfDeliveryOrderValidator validator = new SelfDeliveryOrderValidator(new DefaultAllowedPermissionService(), 
                new NomenclatureParametersProvider() ,UnitOfWorkFactory.CreateWithoutRoot(), testOrder);
            
            var contextItems = new Dictionary<object, object> {
                { nameof(OrderValidateParameters), new OrderValidateParameters { OrderAction = OrderValidateAction.Accept } }
            };
            
            var results = new List<ValidationResult>();
            var validationRes =
                new ValidationResult("В заказе не указана планируемая тара.",
                    new[] { nameof(testOrder.Contract) });
            var vc = new ValidationContext(validator, null, contextItems);

            // act
            var isValid = Validator.TryValidateObject(validator, vc, results, true);
            
            // assert
            Assert.False(isValid);
            Assert.True(results.Any(x => x.ErrorMessage == validationRes.ErrorMessage));
        }
        
        [Test(Description = "Проверка валидирования заказа-самовывоза выставленного на контрагента без телефонов")]
        public void ValidateSelfDeliveryOrderWithCounterpartyWithoutPhones()
        {
            // arrange
            Counterparty counterpartyMock1 = Substitute.For<Counterparty>();
            
            SelfDeliveryOrder testOrder = new SelfDeliveryOrder {
                Counterparty = counterpartyMock1
            };
            
            SelfDeliveryOrderValidator validator = new SelfDeliveryOrderValidator(new DefaultAllowedPermissionService(), 
                new NomenclatureParametersProvider() ,UnitOfWorkFactory.CreateWithoutRoot(), testOrder);
            
            var contextItems = new Dictionary<object, object> {
                { nameof(OrderValidateParameters), new OrderValidateParameters { OrderAction = OrderValidateAction.Accept } }
            };
            
            var results = new List<ValidationResult>();
            var validationRes =
                new ValidationResult("Ни для контрагента, ни для точки доставки заказа не указано ни одного номера телефона.");
            var vc = new ValidationContext(validator, null, contextItems);

            // act
            var isValid = Validator.TryValidateObject(validator, vc, results, true);
            
            // assert
            Assert.False(isValid);
            Assert.True(results.Any(x => x.ErrorMessage == validationRes.ErrorMessage));
        }

        #endregion
    }
}