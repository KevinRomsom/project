using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Logic;
using Models;

namespace Killerapp.Controllers
{
    public class DrinksController : Controller
    {
        // GET: Drinks
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DrinksAdmin()
        {
            return View();
        }


        [HttpPost]

        public ActionResult DrinksAdmin(FormCollection col)
        {
            ViewData["Naam"] = col["Naam"];
            ViewData["Merk"] = col["Merk"];
            ViewData["Soort"] = col["Soort"];
            ViewData["Categorie"] = col["Categorie"];
            ViewData["Beschrijving"] = col["Beschrijving"];
            ViewData["Prijs"] = col["Prijs"];
            ViewData["ImageLink"] = col["ImageLink"];

            Drinks d = new Drinks(col["Naam"], col["Merk"], col["Soort"], col["Categorie"], col["Beschrijving"], Convert.ToDouble(col["Prijs"]), col["ImageLink"]);

            return RedirectToAction("DrinksAdmin", "Drinks");
        }
    }
}