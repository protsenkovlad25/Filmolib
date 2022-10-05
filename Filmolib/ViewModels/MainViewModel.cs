using Filmolib.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace Filmolib.ViewModels
{
    class MainViewModel : Base.BaseViewModel
    {
        public UserControl ContentPage { get; set; }

        public RelayCommand OpenRegistrationPage
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
