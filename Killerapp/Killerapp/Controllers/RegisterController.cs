using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Logic;
using Models;

namespace Killerapp.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(FormCollection collection)
        {
            ViewData["Email"] = collection[1];
            ViewData["Password"] = collection[2];
            ViewData["PasswordRepeat"] = collection[3];
            ViewData["Voornaam"] = collection[4];
            ViewData["Achternaam"] = collection[5];

            Register register = new Register();

            RegisterLogic reglogic = new RegisterLogic();

            if(reglogic.checkPassword(collection[2], collection[3]) == true)
            {
                reglogic.insertRegisterInfo(register);
                return RedirectToAction("Login", "Login");
            }

            return RedirectToAction("Register", "Register");
        }
    }
}