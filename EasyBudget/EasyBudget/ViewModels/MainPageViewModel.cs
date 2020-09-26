using EasyBudget.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyBudget.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Main Page";
        }

        #region Lifecycle


        #endregion

        public override void Initialize(INavigationParameters parameters)
        {
            base.Initialize(parameters);

            Expense expense1 = new Expense() {Price = 1, Categorie = ExpenseTypes.Gas, Date = DateTime.Now, Name = "Gas Station"};
            Expense expense2 = new Expense() {Price = 1, Categorie = ExpenseTypes.Gas, Date = DateTime.Now, Name = "Gas Station"};
            Expense expense3 = new Expense() {Price = 1, Categorie = ExpenseTypes.Gas, Date = DateTime.Now, Name = "Gas Station"};
            Expense expense4 = new Expense() {Price = 1, Categorie = ExpenseTypes.Gas, Date = DateTime.Now, Name = "Gas Station"};
            Expense expense5 = new Expense() {Price = 1, Categorie = ExpenseTypes.Gas, Date = DateTime.Now, Name = "Gas Station"};

            ListOfExpenses = new List<Expense>();

            ListOfExpenses.Add(expense1);
            ListOfExpenses.Add(expense2);
            ListOfExpenses.Add(expense3);
            ListOfExpenses.Add(expense4);
            ListOfExpenses.Add(expense5);

            
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
        }

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {
            base.OnNavigatedFrom(parameters);
        }

        public override void Destroy()
        {
            base.Destroy();
        }

        #region Proprities

        private List<Expense> _ListOfExpenses;
        public List<Expense> ListOfExpenses
        {
            get => _ListOfExpenses;
            set => SetProperty(ref _ListOfExpenses, value);
        }

        #endregion

    }
}
