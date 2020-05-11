using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BC_House_ASP.Container;
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
            //this.klantDAL = klantdal;
            klantContainer = new KlantContainer(klantDAL);
        }

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Klant klant)
        {
            if (klant.klantEmail == null)
            {
                ////Show error
                //ModelState.AddModelError("Email", "Vul je email in!");
                return View("Login");
            }
            else if (klant.klantPassword == null)
            {
                ////Show error
                //ModelState.AddModelError("Password", "Vul je wachtwoord in!");
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
                //ModelState.AddModelError("Password", "Wrong password or email");
                return View("Login");
            }
        }
        [HttpPost]
        public IActionResult Register(Klant klant)
        {
            if (klant.klantNaam == "" || klant.klantEmail == "" || Convert.ToString(klant.telefoonNummer) == "" || klant.klantPassword == "" || klant.postcode == "" || klant.huisNummer == "" || klant.straat == "" || klant.woonplaats == "")
            {
                ModelState.AddModelError("Password", "Vul alle gegevens in!");
                if (klantContainer.registerCheck(klant.klantEmail, klant.klantPassword, Convert.ToString(klant.telefoonNummer), klant.postcode))
                {

                    klantContainer.Accountmaken(klant.klantNaam, klant.klantEmail, klant.telefoonNummer, klant.klantPassword, klant.postcode, klant.huisNummer, klant.straat, klant.woonplaats);
                    return RedirectToAction("Login");
                }
            }
            return View("Register");
        }

        public ActionResult Logout()
        {
            //HttpContext.Session.Clear();

            return RedirectToAction("Login");
        }
    }
}