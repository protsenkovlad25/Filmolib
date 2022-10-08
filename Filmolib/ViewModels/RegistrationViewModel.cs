using Filmolib.Models.Entities;
using Filmolib.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using System.Collections.ObjectModel;

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
                    if (NewUsername != null && NewPassword != null && NewEmail != null)
                    {
                        if (_db.Users.FirstOrDefault(u => u.Username == NewUsername) != null)
                            MessageBox.Show("A user with this username already exists");
                        else if (_db.Users.FirstOrDefault(u => u.Email == NewEmail) != null)
                            MessageBox.Show("A user with this email already exists");
                        else
                        {
                            User newUser = new User()
                            {
                                Username = NewUsername,
                                Password = NewPassword,
                                Email = NewEmail
                            };

                            if (_db.Users.Add(newUser).State != EntityState.Added)
                                throw new DbUpdateException($"{newUser.Username} could not save to database");
                            if (_db.SaveChanges() < 1)
                                throw new DbUpdateException($"{newUser.Username} could not save to database");
                            else
                            {
                                AuthorizedUser = newUser;
                                MessageBox.Show($"{newUser.Username} save to database");
                            }
                        }
                    }
                    else MessageBox.Show("One of the fields is empty. Fill in the field");
                });
            }
        }
    }
}
