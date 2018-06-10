using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
    }
}