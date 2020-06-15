using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BC_House_ASP.Container;
using BC_House_ASP.Database;
using BC_House_ASP.Interface;
using BC_House_ASP.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BC_House_ASP.Controllers
{
    public class KlantController : Controller
    {
        KlantContainer klantContainer;

        public KlantController()
        {
            klantContainer = new KlantContainer(new KlantDAL());
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
                return View("Login");
            }
            else if (klant.klantPassword == null)
            {
                return View("Login");
            }
            else if (klantContainer.CheckIfUserExists(klant))
            {
                Klant currentKlant = new Klant();

                currentKlant = klantContainer.LoginKlant(klant);
              
                HttpContext.Session.SetString("Id", currentKlant.Id.ToString());
                HttpContext.Session.SetString("klantNaam", currentKlant.klantNaam);
                HttpContext.Session.SetString("klantEmail", currentKlant.klantEmail);
                HttpContext.Session.SetString("telefoonNummer", currentKlant.telefoonNummer);
                HttpContext.Session.SetString("straat", currentKlant.straat);
                HttpContext.Session.SetString("huisNummer", currentKlant.huisNummer);
                HttpContext.Session.SetString("woonplaats", currentKlant.woonplaats);
                HttpContext.Session.SetString("postcode", currentKlant.postcode);

                //Go to homepage
                return RedirectToAction("Home", currentKlant);
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
            if (klant.klantNaam == null || klant.klantEmail == null || klant.telefoonNummer == null || klant.klantPassword == null || 
                klant.postcode == null || klant.huisNummer == null || klant.straat == null || klant.woonplaats == null)
            {
                ModelState.AddModelError("klantEmail", "Vul alle gegevens in!");
                return View("Register");
            }
            else if (klantContainer.registerCheck(klant))
            {
                klantContainer.Accountmaken(klant);
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