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
using Microsoft.AspNetCore.Http;

namespace BC_House_ASP.Controllers
{
    public class HomeController : Controller
    {

        ProductContainer productContainer;
        public HomeController()
        {
            productContainer = new ProductContainer(new ProductDAL());
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

            ViewData["targetProduct"] = productslist;
            return PartialView("../Partials/_productDisplay", productslist);
        }

        [HttpPost]
        public ActionResult FilterProducts(string categorie)
        {
            productContainer.ClearList();
            productContainer.AllProducts();
            List<Product> productslist = productContainer.GetList();
            List<Product> newProductList = new List<Product>();

           
            foreach (var product in productslist)
            {
                Product newProduct = new Product();

                if(product.tag == categorie)
                {
                    newProduct = product;
                    newProductList.Add(newProduct);                    
                }
            }
            return PartialView("../Partials/_productDisplay", newProductList);
        }
    }
}
