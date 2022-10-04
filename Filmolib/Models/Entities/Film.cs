using System.Collections.Generic;

namespace Filmolib.Models.Entities
{
    class Film
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public float Rating { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        public string PosterSource { get; set; }

        public ICollection<Catalog> Catalogs { get; set; }

        public Film()
        {
            Catalogs = new List<Catalog>();
        }
    }
}
