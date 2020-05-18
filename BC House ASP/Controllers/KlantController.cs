using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BC_House_ASP.Container;
using BC_House_ASP.Database;
using BC_House_ASP.Interface;
using BC_House_ASP.Models;
using Microsoft.AspNetCore.Mvc;

namespace BC_House_ASP.Controllers
{
    public class KlantController : Controller
    {
        IKlantDAL klantDAL;
        KlantContainer klantContainer;

        public KlantController()
        {
            this.klantDAL = new KlantDAL();
            klantContainer = new KlantContainer(klantDAL);
        }

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Home()
        {
            return View("../Home/Index");
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Klant klant)
        {
            if (klant.klantEmail == null)
            {
                ////Show error
                //ModelState.AddModelError("klantEmail", "Vul je email in!");
                return View("Login");
            }
            else if (klant.klantPassword == null)
            {
                ////Show error
                //ModelState.AddModelError("klantPassword", "Vul je wachtwoord in!");
                return View("Login");
            }
            else if (klantContainer.CheckIfUserExists(klant.klantEmail, klant.klantPassword))
            {
                //Go to homepage
                return RedirectToAction("Home");
            }
            else
            {
                ////Show wrong password error
                ModelState.AddModelError("klantEmail", "Fout wachtwoord of email.");
                return View("Login");
            }
        }
        [HttpPost]
        public ActionResult Register(Klant klant)
        {
            if (klant.klantNaam == null || klant.klantEmail == null || klant.telefoonNummer == null || klant.klantPassword == null || klant.postcode == null || klant.huisNummer == null || klant.straat == null || klant.woonplaats == null)
            {
                ModelState.AddModelError("klantEmail", "Vul alle gegevens in!");
                return View("Register");
            }
            else if (klantContainer.registerCheck(klant.klantEmail, klant.klantPassword, klant.telefoonNummer, klant.postcode))
            {
                klantContainer.Accountmaken(klant.klantNaam, klant.klantEmail, klant.telefoonNummer, klant.klantPassword, klant.postcode, klant.huisNummer, klant.straat, klant.woonplaats);
                return RedirectToAction("Login");
            }
            else
            {
                ////Show wrong password error
                ModelState.AddModelError("klantEmail", "Vul geldige gegevens in!.");
                return View("Register");
            }
        }

        public ActionResult Logout()
        {
            //HttpContext.Session.Clear();

            return RedirectToAction("Login");
        }
    }
}