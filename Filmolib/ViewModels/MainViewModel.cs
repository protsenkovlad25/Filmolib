using Filmolib.Views;
using Filmolib.Models.Entities;
using System.Windows.Controls;
using System.Windows.Input;

namespace Filmolib.ViewModels
{
    class MainViewModel : Base.BaseViewModel
    {
        public UserControl ContentPage { get; set; }
        public string AuthorizationButton { get; set; }
        public User? AuthorizedUser { get; set; }

        public MainViewModel()
        {
            if (AuthorizedUser is null)
            {
                AuthorizationButton = "Sign Up";
                ContentPage = new RegistrationPage();
            }   
            else
            {
                AuthorizationButton = "Sign Out";
                ContentPage = new ProfilePage();
            }
        }

        public ICommand OpenAuthorizationPage
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    if (AuthorizedUser is null)
                    {
                        AuthorizationButton = "Sign Up";
                        ContentPage = new RegistrationPage();
                    }
                    else
                    {
                        AuthorizationButton = "Sign Out";
                        ContentPage = new ProfilePage();
                    }
                });
            }
        }

        public ICommand OpenRegistrationPage
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    ContentPage = new RegistrationPage();
                });
            }
        }

        public ICommand OpenProfilePage
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    ContentPage = new ProfilePage();
                });
            }
        }
    }
}
