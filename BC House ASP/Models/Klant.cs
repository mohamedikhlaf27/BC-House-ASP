using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BC_House_ASP.Models
{
    public class Klant
    {
        [Required]
        [Display(Name = "Naam")]
        public string klantNaam { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Wachtwoord")]
        public string klantPassword { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string klantEmail { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Telefoon nummer")]
        public int telefoonNummer { get; set; }

        [Required]
        [Display(Name = "Straat")]
        public string straat { get; set; }

        [Required]
        [Display(Name = "Huis nummer")]
        public string huisNummer { get; set; }

        [Required]
        [DataType(DataType.PostalCode)]
        [Display(Name = "Postcode")]
        public string postcode { get; set; }

        [Required]
        [Display(Name = "Woonplaats")]
        public string woonplaats { get; set; }
    }
}
