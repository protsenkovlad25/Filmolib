using Filmolib.Models.Entities;
using Filmolib.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Filmolib.ViewModels
{
    class RegistrationViewModel : Base.BaseViewModel
    {
        private readonly FilmolibContext _db;

        public string? NewUsername { get; set; }
        public string? NewPassword { get; set; }
        public string? NewEmail { get; set; }

        public RegistrationViewModel()
        {
            _db = new FilmolibContext();
        }

        public ICommand AddUser
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    //User newUser = new User()
                    //{
                    //    Username = NewUsername,
                    //    Password = NewPassword,
                    //    Email = NewEmail,
                    //    AvatarSource = "",
                    //    Name = "",
                    //    Surname = "",
                    //    Patronymic = "",
                    //    PhoneNumber = ""
                    //};

                    //if (_db.Users.Add(newUser).State != EntityState.Added)
                    //    throw new DbUpdateException($"{newUser.Username} could not save to database");
                    //if (_db.SaveChanges() < 1)
                    //    throw new DbUpdateException($"{newUser.Username} could not save to database");
                });
            }
        }
    }
}
