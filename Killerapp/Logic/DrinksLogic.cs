using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace Logic
{
    public class DrinksLogic
    {
        DBDrinksAdmin daldrinks;

        public void insertDrinks(Drinks d)
        {
            daldrinks = new DBDrinksAdmin();

            string naam = d.Naam;
            string categorie = d.Categorie;
            string soort = d.Soort;
            string merk = d.Merk;
            string beschrijving = d.Beschrijving;
            double prijs = d.Prijs;
            string foto = d.ImageLink;

            daldrinks.InsertDrinks(naam, merk, soort, categorie, beschrijving, prijs, foto);
        }
    }
}
