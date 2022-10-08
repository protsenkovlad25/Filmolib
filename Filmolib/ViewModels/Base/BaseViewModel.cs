using Filmolib.Models.Entities;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Filmolib.ViewModels.Base
{
    class BaseViewModel : INotifyPropertyChanged
    {
        public User? AuthorizedUser { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
