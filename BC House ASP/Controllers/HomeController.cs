using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BC_House_ASP.Models;
using BC_House_ASP.Interface;
using BC_House_ASP.Database;
using BC_House_ASP.Container;

namespace BC_House_ASP.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        IProductDAL productDAL;
        ProductContainer productContainer;
        public HomeController()
        {
            this.productDAL = new ProductDAL();
            productContainer = new ProductContainer(productDAL);
            //ILogger<HomeController> logger
            //_logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        //[HttpGet]
        //public ActionResult DisplayProducts()
        //{
            
        //    List<Product> productslist = productContainer.GetList();

        //    return PartialView("../Partials/_productDisplay", productslist);

        //}

        [HttpGet]
        public ActionResult GetBeefBurgers()
        {
            productContainer.ClearList();
            productContainer.BeefBurgers();
            List<Product> productslist = productContainer.GetList();

            return PartialView("../Partials/_productDisplay", productslist);
        }

        [HttpGet]
        public ActionResult GetBeefBurgersMenu()
        {
            productContainer.ClearList();
            productContainer.BeefBurgersMenu();
            List<Product> productslist = productContainer.GetList();

            return PartialView("../Partials/_productDisplay", productslist);
        }

        [HttpGet]
        public ActionResult GetChickenBurgers()
        {
            productContainer.ClearList();
            productContainer.ChickenBurgers();
            List<Product> productslist = productContainer.GetList();

            return PartialView("../Partials/_productDisplay", productslist);
        }

        [HttpGet]
        public ActionResult GetChickenBurgersMenu()
        {
            productContainer.ClearList();
            productContainer.ChickenBurgerMenu();
            List<Product> productslist = productContainer.GetList();

            return PartialView("../Partials/_productDisplay", productslist);
        }

        [HttpGet]
        public ActionResult GetBuckets()
        {
            productContainer.ClearList();
            productContainer.Buckets();
            List<Product> productslist = productContainer.GetList();

            return PartialView("../Partials/_productDisplay", productslist);
        }

        [HttpGet]
        public ActionResult GetPortie()
        {
            productContainer.ClearList();
            productContainer.Portie();
            List<Product> productslist = productContainer.GetList();

            return PartialView("../Partials/_productDisplay", productslist);
        }

        [HttpGet]
        public ActionResult GetFriet()
        {
            productContainer.ClearList();
            productContainer.Friet();
            List<Product> productslist = productContainer.GetList();

            return PartialView("../Partials/_productDisplay", productslist);
        }

        [HttpGet]
        public ActionResult GetIcecream()
        {
            productContainer.ClearList();
            productContainer.Icecream();
            List<Product> productslist = productContainer.GetList();

            return PartialView("../Partials/_productDisplay", productslist);
        }

        [HttpGet]
        public ActionResult GetSaus()
        {
            productContainer.ClearList();
            productContainer.Saus();
            List<Product> productslist = productContainer.GetList();

            return PartialView("../Partials/_productDisplay", productslist);
        }

        [HttpGet]
        public ActionResult GetDrinks()
        {
            productContainer.ClearList();
            productContainer.Drinks();
            List<Product> productslist = productContainer.GetList();

            return PartialView("../Partials/_productDisplay", productslist);
        }

        [HttpGet]
        public ActionResult AllProducts()
        {
            productContainer.ClearList();
            productContainer.AllProducts();
            List<Product> productslist = productContainer.GetList();

            return PartialView("../Partials/_productDisplay", productslist);
        }


        [HttpGet]
        public ActionResult FilterProducts(string categorie)
        {
            productContainer.ClearList();
            productContainer.AllProducts();
            List<Product> productslist = productContainer.GetList();

            foreach (var product in from product in productslist
                                where product.Tag == categorie
                                select new { product.productNaam, product.prijs, product.omschrijving})
            {
            }
            return PartialView("../Partials/_productDisplay", productslist);
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}


    }
}
