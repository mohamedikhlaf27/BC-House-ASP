using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace BC_House_ASP.Models
{
    public class Product
    {
        [Key]
        public int id { get; set; }
        public string productNaam { get; set; }
        public double prijs { get; set; }
        public string omschrijving { get; set; }
        public string tag { get; set; }
    }
}
