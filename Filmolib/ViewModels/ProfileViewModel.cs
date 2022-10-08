using Filmolib.Models;
using System.Windows.Input;

namespace Filmolib.ViewModels
{
    class ProfileViewModel : Base.BaseViewModel
    {
        private FilmolibContext _db;

        public string UserUsername { get; set; }
        public string UserPassword { get; set; }
        public string UserEmail { get; set; }

        public ProfileViewModel()
        {
            _db = new FilmolibContext();
        }

        private void Initialize()
        {
            
        }

        public ICommand Command
        {
            get
            {
                return new RelayCommand(obj =>
                {

                });
            }
        }
    }
}
