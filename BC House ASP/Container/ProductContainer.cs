using BC_House_ASP.Interface;
using BC_House_ASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BC_House_ASP.Container
{
    public class ProductContainer
    {
        IProductDAL productDAL;

        public static List<Product> productslist { get; set; } = new List<Product>();

        public ProductContainer(IProductDAL productDAL)
        {
            this.productDAL = productDAL;
        }

        public List<Product> GetList()
        {
            return productslist;
        }

        public void ClearList()
        {
            productslist = new List<Product>();
            productslist.Clear();
        }

        public void AllProducts()
        {
            productDAL.AllProducts();
        }
    }
}

