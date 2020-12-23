using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using QS.Commands;
using QS.Dialog;
using QS.DomainModel.UoW;
using Gamma.Utilities;
using QS.Project.Domain;
using QS.Project.Services;
using QS.Project.Services.Interactive;
using QS.Services;
using QS.ViewModels;
using Vodovoz.Domain.Cash;
using Vodovoz.Domain.Employees;
using Vodovoz.EntityRepositories.Cash;
using Vodovoz.EntityRepositories.Employees;
using Vodovoz.ViewModels.Journals.FilterViewModels;
using Vodovoz.ViewModels.Journals.JournalSelectors;
using VodovozInfrastructure.Interfaces;

namespace Vodovoz.ViewModels.ViewModels.Cash
{
    public class CashRequestViewModel: EntityTabViewModelBase<CashRequest>
    {
        public Action UpdateNodes;
        public Employee CurrentEmployee { get; }
        public ExpenseCategoryAutoCompleteSelectorFactory ExpenseCategoryAutocompleteSelectorFactory { get; }
        public UserRole UserRole { get; set; }
        public static UserRole savedUserRole { get; set; }
        
        private readonly IEntityUoWBuilder uowBuilder;
        private readonly CashRepository cashRepository;
        private readonly IUnitOfWorkFactory unitOfWorkFactory;
        private readonly ConsoleInteractiveService consoleInteractiveService;
        public HashSet<CashRequestSumItem> SumsGiven = new HashSet<CashRequestSumItem>();


        public string StateName => Entity.State.GetEnumTitle();
        public string UserRoleName => UserRole.GetEnumTitle();
        private static bool dialogLoadedOnce = false;
        public CashRequestViewModel(
            IEntityUoWBuilder uowBuilder,
            IUnitOfWorkFactory unitOfWorkFactory,
            ICommonServices commonServices,
            IFileChooserProvider fileChooserProvider,
            CashRequestJournalFilterViewModel journalFilterViewModel,
            IEmployeeRepository employeeRepository,
            CashRepository cashRepository,
            ConsoleInteractiveService consoleInteractiveService
        ) : base(uowBuilder, unitOfWorkFactory, commonServices)
        {
            this.uowBuilder = uowBuilder ?? throw new ArgumentNullException(nameof(uowBuilder));
            this.cashRepository = cashRepository ?? throw new ArgumentNullException(nameof(cashRepository));
            this.unitOfWorkFactory = unitOfWorkFactory ?? throw new ArgumentNullException(nameof(unitOfWorkFactory));
            this.consoleInteractiveService = consoleInteractiveService ?? throw new ArgumentNullException(nameof(consoleInteractiveService));
            
            ExpenseCategoryAutocompleteSelectorFactory = new ExpenseCategoryAutoCompleteSelectorFactory(
                commonServices,
                new ExpenseCategoryJournalFilterViewModel(), 
                fileChooserProvider
            );
            CurrentEmployee = employeeRepository.GetEmployeeForCurrentUser(UoW);

            if(uowBuilder.IsNewEntity)
                TabName = "Создание новой заявки на выдачу ДС";
            else
                TabName = $"{Entity.Title}";

            int userId = ServicesConfig.CommonServices.UserService.CurrentUserId;
            var isAdmin = ServicesConfig.CommonServices.UserService.GetCurrentUser(UoW).IsAdmin;
            IsAdminPanelVisible = isAdmin;

            var currentRole = getUserRole(userId);
            if (!dialogLoadedOnce)
            {
                UserRole = currentRole;
                
                dialogLoadedOnce = true;

            }
            else
            {
                UserRole = savedUserRole;
            }
            IsNewEntity = uowBuilder.IsNewEntity;
            ConfigureEntityChangingRelations();


        }

        protected void ConfigureEntityChangingRelations()
        {
            SetPropertyChangeRelation(e => e.State,
                () => StateName
            );
        }

        #region Commands

        private DelegateCommand addSumCommand;
        public DelegateCommand AddSumCommand => addSumCommand ?? (addSumCommand = new DelegateCommand(
            () =>
            {
                var cashRequestItemViewModel = new CashRequestItemViewModel(
                    EntityUoWBuilder.ForCreateInChildUoW(UoW),
                    unitOfWorkFactory,
                    CommonServices,
                    UserRole,
                    CurrentEmployee
                );
                
                TabParent.AddSlaveTab(
                    this,cashRequestItemViewModel
                );
                
                cashRequestItemViewModel.EntitySaved += (sender, args) =>
                {
                    if (args.Entity is CashRequestSumItem item)
                    {
                        Entity.AddItem(item);
                        item.CashRequest = Entity;
                        UoW.Save(item);
                    }
                };
            }, () => true
        ));
        
        private DelegateCommand editSumCommand;
        public DelegateCommand EditSumCommand => editSumCommand ?? (editSumCommand = new DelegateCommand(
            () =>
            {
                var cashRequestItemViewModel = new CashRequestItemViewModel(
                    EntityUoWBuilder.ForOpenInChildUoW(SelectedItem.Id, UoW),
                    unitOfWorkFactory,
                    CommonServices,
                    UserRole,
                    CurrentEmployee
                );
                
                TabParent.AddSlaveTab(
                    this,
                    cashRequestItemViewModel);
            }, () => true
        ));
        
        private DelegateCommand deleteSumCommand;
        public DelegateCommand DeleteSumCommand => deleteSumCommand ?? (deleteSumCommand = new DelegateCommand(
            () => {
                if (Entity.ObservableSums.Contains(SelectedItem))
                {	
                    Entity.ObservableSums.Remove(SelectedItem);
                }
            }, () => true
        ));
        
        private DelegateCommand afterSaveCommand;
        public DelegateCommand AfterSaveCommand => afterSaveCommand ?? (afterSaveCommand = new DelegateCommand(
            () => {
                SaveAndClose();

                if (AfterSave(out var messageText))
                    CommonServices.InteractiveService.ShowMessage(ImportanceLevel.Info,$"Cозданы следующие авансы:\n{messageText}" );
            }, () => true
        ));
            
        private DelegateCommand giveSumCommand;
        public DelegateCommand GiveSumCommand => giveSumCommand ?? (giveSumCommand = new DelegateCommand(
            () => {
                if (SelectedItem.Expense == null) 
                {
                    CreateNewExpenseForSelectedItem();
                    Entity.ChangeState(CashRequest.States.Closed);
                }
            }, () => true
        ));
        
        #endregion Commands

        #region Properties

        public bool IsNewEntity { get; private set; }
        public bool IsAdminPanelVisible { get; set; }

        public CashRequestSumItem SelectedItem { get; set; }
        
        #region Editability

        public bool CanEditOnlyCoordinator => UserRole == UserRole.Coordinator;

        
        public bool CanEditOnlyinStateNAGandRoldFinancier => (Entity.State == CashRequest.States.New ||
                                                              Entity.State == CashRequest.States.Agreed ||
                                                              Entity.State == CashRequest.States.GivenForTake) &&
                                                             UserRole == UserRole.Financier;

        public bool CanEditSumVisible => UserRole == UserRole.RequestCreator || UserRole == UserRole.Coordinator;
        //редактировать можно только не выданные
        public bool CanEditSumSensitive => SelectedItem != null && SelectedItem.Expense == null;


        #endregion Editability

        #region Visibility

        public bool VisibleOnlyForFinancer => UserRole == UserRole.Financier;
        public bool VisibleOnlyForStatusUpperThanCreated => Entity.State != CashRequest.States.New;

        #endregion Visibility
        
        #region Permissions

        public bool CanEdit => PermissionResult.CanUpdate;
        public bool CanAddItems => CanEdit;
        public bool CanDeleteItems => CanEdit && SelectedItem != null;
        
        public bool CanGiveSum => UserRole == UserRole.Cashier && (Entity.State == CashRequest.States.GivenForTake || Entity.State == CashRequest.States.PartiallyClosed);
        public bool CanDeleteSum => uowBuilder.IsNewEntity;
        //Подтвердить
        public bool CanAccept =>
            (Entity.State == CashRequest.States.New || Entity.State == CashRequest.States.OnClarification);

        //Согласовать
        public bool CanApprove => Entity.State == CashRequest.States.Submited && UserRole == UserRole.Coordinator;
        public bool CanConveyForResults => UserRole == UserRole.Financier && Entity.State == CashRequest.States.Agreed;
        public bool CanReturnToRenegotiation => Entity.State == CashRequest.States.Agreed ||
                                                Entity.State == CashRequest.States.GivenForTake ||
                                                Entity.State == CashRequest.States.PartiallyClosed ||
                                                Entity.State == CashRequest.States.Canceled;

        public bool CanCancel => Entity.State == CashRequest.States.Submited ||
                                 Entity.State == CashRequest.States.OnClarification ||
                                 Entity.State == CashRequest.States.New ||
                                 ((Entity.State == CashRequest.States.GivenForTake) &&
                                  UserRole == UserRole.Coordinator);
        
        

        #endregion Permissions
        
        #endregion Properties

        #region Methods

        private UserRole getUserRole(int userId)
        {
            
            if (checkRole("role_financier_cash_request", userId)){
                return UserRole.Financier;
            } else if (checkRole("role_coordinator_cash_request", userId)){
                return UserRole.Coordinator;
            } else if (checkRole("role_сashier", userId)) {
                return UserRole.Cashier;
            } else {
                if (Entity.Author == null){
                    return UserRole.RequestCreator;
                } else if (Entity.Author.Id == CurrentEmployee.Id){
                    return UserRole.RequestCreator;
                } else 
                    throw new Exception("Пользователь не подходит ни под одну из ролей, он не должен был иметь возможность сюда зайти");
            }
            
        }

        public static bool checkRole(string roleName, int userId) => ServicesConfig.CommonServices.PermissionService
            .ValidateUserPresetPermission(roleName, userId);


        private void CreateNewExpenseForSelectedItem()
        {
            SelectedItem?.CreateNewExpense(
                UoW, 
                CurrentEmployee,
                Entity.Subdivision,
                Entity.ExpenseCategory,
                Entity.Basis,
                Entity.Organization
            );
            if (SelectedItem != null)
                SumsGiven.Add(SelectedItem);
        }

        public string LoadOrganizationsSums()
        {
            var builder = new StringBuilder();

            var balanceList = cashRepository.GetCashBalanceForOrganizations(UoW);
            foreach (var operationNode in balanceList)
            {
                builder.Append(operationNode.Name + ": ");
                builder.Append(operationNode.Balance + "\n");
            }
            return builder.ToString();
        }

        public bool AfterSave(out string messageText)
        {
            if (SumsGiven.Count != 0) {
                var builder = new StringBuilder();
                builder.Append("Подотчетное лицо\tСумма\n");
                foreach (CashRequestSumItem sum in SumsGiven)
                {
                    builder.Append(sum.AccountableEmployee.Name + "\t" + sum.Sum + "\n");
                }
                messageText = builder.ToString();
                return true;
            } else {
                messageText = "";
                return false;
            }
        }

        //Подтвердить
        private DelegateCommand acceptCommand;
        public DelegateCommand AcceptCommand => acceptCommand ?? (acceptCommand = new DelegateCommand(
            () =>
            {
                Entity.ChangeState(CashRequest.States.Submited);
            }, () => true
        ));
        //Согласовать
        private DelegateCommand approveCommand;
        public DelegateCommand ApproveCommand => approveCommand ?? (approveCommand = new DelegateCommand(
            () =>
            {
                Entity.ChangeState(CashRequest.States.Agreed);
            }, () => true
        ));
        //Отменить
        private DelegateCommand cancelCommand;
        public DelegateCommand CancelCommand => cancelCommand ?? (cancelCommand = new DelegateCommand(
            () =>
            {
                if (string.IsNullOrEmpty(Entity.CancelReason) && UserRole == UserRole.Coordinator) {
                    CommonServices.InteractiveService.ShowMessage(ImportanceLevel.Warning,"Причина отмены должна быть заполнена");
                } else {
                    Entity.ChangeState(CashRequest.States.Canceled);
                }
            }, () => true
        ));
        //Передать на выдачу
        private DelegateCommand conveyForResultsCommand;
        public DelegateCommand ConveyForResultsCommand => conveyForResultsCommand ?? (conveyForResultsCommand = new DelegateCommand(
            () =>
            {
                Entity.ChangeState(CashRequest.States.GivenForTake);
            }, () => true
        ));
        
        //Отправить на пересогласование((вернуть)на уточнение)
        private DelegateCommand returnToRenegotiationCommand;
        public DelegateCommand ReturnToRenegotiationCommand => returnToRenegotiationCommand ?? (returnToRenegotiationCommand = new DelegateCommand(
            () =>
            {
                if (string.IsNullOrEmpty(Entity.ReasonForSendToReappropriate)){
                    CommonServices.InteractiveService.ShowMessage(
                        ImportanceLevel.Warning,
                        "Причина отправки на пересогласование должна быть заполнена"
                    );
                } else {
                    Entity.ChangeState(CashRequest.States.OnClarification);
                }
            }, () => true
        ));
        
        #endregion


        public void RememberRole(Object role)
        {
            savedUserRole = (UserRole)role;
        }
    }
    public enum UserRole
    {
        [Display(Name = "Заявитель")]
        RequestCreator,
        [Display(Name = "Согласователь")]
        Coordinator,
        [Display(Name = "Финансист")]
        Financier,
        [Display(Name = "Кассир")]
        Cashier,
        [Display(Name = "Другие")]
        Other
    }
}