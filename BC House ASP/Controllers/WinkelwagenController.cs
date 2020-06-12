using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BC_House_ASP.Container;
using BC_House_ASP.Database;
using BC_House_ASP.Models;
using Microsoft.AspNetCore.Mvc;

namespace BC_House_ASP.Controllers
{
    public class WinkelwagenController : Controller
    {
        WinkelwagenContainer winkelwagenContainer;

        public WinkelwagenController()
        {
            winkelwagenContainer = new WinkelwagenContainer(new WinkelwagenDAL());
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
        public void AddToCard (int productID, int Quantity)
        {
            Product product = new Product();
            Winkelwagen winkelwagen = new Winkelwagen(product.id);
            winkelwagen.Prod.id = productID;
            winkelwagen.hoeveelheid = Quantity;

            SetQuantity(product, winkelwagen);
            winkelwagenContainer.AddProductToCart(product, winkelwagen);
        }

        public void SetQuantity(Product productID, Winkelwagen Quantity)
        {
            winkelwagenContainer.SetProductQuantity(productID, Quantity);
        }

        [HttpPost]
        public void ProductRemove(int productID)
        {
            Product product = new Product();
            Winkelwagen winkelwagen = new Winkelwagen(product.id);
            winkelwagen.Prod.id = productID;
            winkelwagenContainer.RevomeProduct(winkelwagen);
        }
    }
}