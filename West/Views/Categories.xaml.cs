using System;
using System.Collections.Generic;
using West.ViewModels;
using Xamarin.Forms;

namespace West.Views
{
    public partial class Categories : ContentPage
    {
        CategoriesViewModel ViewModel;
        public Categories()
        {
            InitializeComponent();
            ViewModel = Resources["CategoriesViewModel"] as CategoriesViewModel;
            ExpensesList.ItemTapped += (object sender, ItemTappedEventArgs e) => {
                // don't do anything if we just de-selected the row.
                if (e.Item == null) return;

                if (sender is ListView lv) lv.SelectedItem = null;

  
        };
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ViewModel.LoadExpenseList();
        }

    }
}
