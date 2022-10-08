using Filmolib.Models;
using System.Linq;
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

            UserUsername = _db.Users.Find(AuthorizedUser).Username;
            UserPassword = _db.Users.Find(AuthorizedUser).Password;
            UserEmail    = _db.Users.Find(AuthorizedUser).Email;
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
