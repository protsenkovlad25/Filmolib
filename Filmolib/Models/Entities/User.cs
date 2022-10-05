using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Filmolib.Models.Entities
{
    class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Patronymic { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string? AvatarSource { get; set; }

        [NotMapped]
        public Catalog Watchlist { get; set; }
        [NotMapped]
        public Catalog Watched { get; set; }

        public ICollection<Catalog> Catalogs { get; set; }

        public User()
        {
            Watchlist = new Catalog() { UserId = Id };
            Watched = new Catalog() { UserId = Id };
            Catalogs = new List<Catalog>();
        }
    }
}
