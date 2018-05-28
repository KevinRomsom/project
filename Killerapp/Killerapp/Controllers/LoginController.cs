using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Logic;
using Models;

namespace Killerapp.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection collection)
        {
            //html <input type="example" gebruiken ipv het huidige
                ViewData["Email"] = collection[1];
                ViewData["Password"] = collection[2];

            User user = new User(collection[1], collection[2]);

            LoginLogic logic = new LoginLogic();

            if (logic.checkLogin(user))
            {
                return RedirectToAction("Index", "Home");
            }

            return RedirectToAction("Login", "Login");

        }

        
    }
}