using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Drinks
    {
        public string Naam { get; set; }
        public string Merk { get; set; }
        public string Soort { get; set; }
        public string Categorie { get; set; }
        public string Beschrijving { get; set; }
        public double Prijs { get; set; }
        public string ImageLink { get; set; }

        public Drinks(string naam, string merk, string soort, string categorie, string beschrijving, double prijs, string foto)
        {
            this.Naam = naam;
            this.Merk = merk;
            this.Soort = soort;
            this.Categorie = categorie;
            this.Beschrijving = beschrijving;
            this.Prijs = prijs;
            this.ImageLink = foto;
        }
    }
}
