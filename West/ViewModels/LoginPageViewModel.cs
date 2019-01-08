using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace West.ViewModels
{
    public class LoginPageViewModel
    {
        public ICommand LoginCommand => new Command(OnLoginCommand);

        private void OnLoginCommand(object obj)
        {
            Application.Current.MainPage =  new NavigationPage(new MainPage());

        }

        public LoginPageViewModel()
        {
        }
    }
}
