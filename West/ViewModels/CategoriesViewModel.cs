using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using West.Models;

namespace West.ViewModels
{
    public class CategoriesViewModel : INotifyPropertyChanged
    {

        private ObservableCollection<Expense> expenseList;
        public ObservableCollection<Expense> ExpenseList
        {
            get
            {
                return expenseList;
            }
            set
            {
                expenseList = value;
                OnPropertyChanged("ExpenseList");

            }
        }



        public CategoriesViewModel()
        {
            //ExpenseList = new ObservableCollection<Expense>();
            LoadExpenseList();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void LoadExpenseList()
        {

            var expenses = Expense.GetExpenses();
            ExpenseList = new ObservableCollection<Expense>();
            ExpenseList.Clear();

            foreach(Expense expense in expenses)
            {
                ExpenseList.Add(expense);
            }

        }
    }
}
