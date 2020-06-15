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
        public int ID { get; set; }
        public bool status { get; set; }
        public DateTime bestellingDatum { get; set; }
        public int hoeveelheid { get; set; }

        private int _productId;
        public int ProductId
        {
            get { return _productId; }
            set
            {
                // To ensure that the Prod object will be re-created
                _product = null;
                _productId = value;
            }
        }

        private Product _product = null;
        public Product Prod
        {
            get
            {
                // Lazy initialization - the object won't be created until it is needed
                if (_product == null)
                {
                    _product = new Product();
                }
                return _product;
            }
        }

        public Winkelwagen(int productID)
        {
            this.ProductId = productID;
        }

        public double prijs { get; set; }

        public double TotalPrice
        {
            get { return prijs * hoeveelheid; }
        }

        //public bool Equals(Winkelwagen item)
        //{
        //    return item.ProductId == this.ProductId;
        //}
    }
}
