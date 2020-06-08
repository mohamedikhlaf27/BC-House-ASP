using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace BC_House_ASP.Models
{
    public class Winkelwagen
    {
        [Key]
        public int id { get; set; }
        public string productNaam { get; set; }
        public bool status { get; set; }
        public DateTime bestellingDatum { get; set; }
        public int hoeveelheid { get; set; }
        public virtual Product Product { get; set; }

        //public int Quantity { get; set; }

        //private int _productId;
        //public int ProductId
        //{
        //    get { return _productId; }
        //    set
        //    {
        //        // To ensure that the Prod object will be re-created
        //        _product = null;
        //        _productId = value;
        //    }
        //}

        //private Product _product = null;
        //public Product Prod
        //{
        //    get
        //    {
        //        // Lazy initialization - the object won't be created until it is needed
        //        if (_product == null)
        //        {
        //            _product = new Product();
        //        }
        //        return _product;
        //    }
        //}

        //public string Description
        //{
        //    get { return Prod.omschrijving; }
        //}

        //public double UnitPrice
        //{
        //    get { return Prod.prijs; }
        //}

        //public double TotalPrice
        //{
        //    get { return UnitPrice * Quantity; }
        //}


        //// CartItem constructor just needs a productId
        //public Winkelwagen(int productId)
        //{
        //    this.ProductId = productId;
        //}


        //public bool Equals(Winkelwagen item)
        //{
        //    return item.ProductId == this.ProductId;
        //}
    }
}
