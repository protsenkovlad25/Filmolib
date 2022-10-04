using System.Collections.Generic;

namespace Filmolib.Models.Entities
{
    class Catalog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Ranked { get; set; }

        public int? UserId { get; set; }
        public User User { get; set; }

        public ICollection<Film> Films { get; set; }

        public Catalog()
        {
            Films = new List<Film>();
        }
    }
}
