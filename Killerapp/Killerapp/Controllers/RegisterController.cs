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
            ViewData["Email"] = collection["Email"];
            ViewData["Password"] = collection["Password"];
            ViewData["PasswordRepeat"] = collection["PasswordRepeat"];
            ViewData["Voornaam"] = collection["Voornaam"];
            ViewData["Achternaam"] = collection["Achternaam"];

            Register register = new Register(collection["Email"], collection["Password"], collection["PasswordRepeat"], collection["Voornaam"], collection["Achternaam"]);

            RegisterLogic reglogic = new RegisterLogic();

            if(reglogic.checkPassword(register) == true)
            {
                reglogic.insertRegisterInfo(register);
                return RedirectToAction("Login", "Login");
            }

            return RedirectToAction("Register", "Register");
        }
    }
}