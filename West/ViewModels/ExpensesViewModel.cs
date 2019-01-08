using System;
using System.ComponentModel;
using System.Windows.Input;
using West.Models;
using West.Views;
using Xamarin.Forms;

namespace West.ViewModels
{
    public class ExpensesViewModel : INotifyPropertyChanged
    {
        public double amount;
        public double Amount { get
            {
                return amount;
            }
             set {
                amount = value;
                OnPropertyChanged("Amount");
             }
        }

        public string item;
        public string Item
        {
            get
            {
                return item;
            }
            set
            {
                item = value;
                OnPropertyChanged("Item"); 
            }
        }
        public ICommand AddCommand => new Command(AddExpense);

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private void AddExpense(object obj)
        {
            Expense NewExpense = new Expense {

                Name = Item,
                Amount = Amount
                
            };

            Expense.InsertExpense(NewExpense);

         
        }

        public ExpensesViewModel()
        {

        }
    }
}
