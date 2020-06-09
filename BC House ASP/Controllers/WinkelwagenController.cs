using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BC_House_ASP.Container;
using BC_House_ASP.Models;
using Microsoft.AspNetCore.Mvc;

namespace BC_House_ASP.Controllers
{
    public class WinkelwagenController : Controller
    {
        WinkelwagenContainer winkelwagenContainer;

        public WinkelwagenController()
        {
            winkelwagenContainer = new WinkelwagenContainer();
        }

        public IActionResult Winkelwagen()
        {
            return View();
        }

        [HttpGet]
        public ActionResult WinkelwagenOverzicht()
        {
            List<Winkelwagen> productslist = winkelwagenContainer.GetList();
            return PartialView("../Partials/_WinkelwagenList", productslist);
        }

        [HttpPost]
        // Producten toevoegen aan winkelwagen
        public void AddToCard(int productID, int Quintity)
        {
            SetQuantity(productID, Quintity);
            winkelwagenContainer.AddProductToCart(productID);
        }

        public void SetQuantity(int productID, int Quintity)
        {
            winkelwagenContainer.SetProductQuantity(productID, Quintity);
        }

        public void ProductRemove(int productID)
        {
            winkelwagenContainer.RevomeProduct(productID);
        }
    }
}