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

        [HttpGet]
        public ActionResult GetAllProducts()
        {
            productContainer.ClearList();
            productContainer.AllProducts();
            List<Product> productslist = productContainer.GetList();

            return PartialView("../Partials/_productDisplay", productslist);
        }


        [HttpPost]
        public ActionResult FilterProducts(string categorie)
        {
            productContainer.ClearList();
            productContainer.AllProducts();
            List<Product> productslist = productContainer.GetList();

            List<Product> newProductList = new List<Product>();

            foreach(var product in productslist)
            {
                Product newProduct = new Product();

                if(product.Tag == categorie)
                {
                    newProduct = product;
                    newProductList.Add(newProduct);
                }
            }
            return PartialView("../Partials/_productDisplay", newProductList);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
