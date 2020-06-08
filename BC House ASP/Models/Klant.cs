using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BC_House_ASP.Models
{
    public class Klant
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Naam")]
        public string klantNaam { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Key]
        [Display(Name = "Wachtwoord")]
        public string klantPassword { get; set; }

        [Required]
        [EmailAddress]
        [Key]
        [Display(Name = "Email")]
        public string klantEmail { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Telefoonnummer")]
        public string telefoonNummer { get; set; }

        [Required]
        [Display(Name = "Straat")]
        public string straat { get; set; }

        [Required]
        [Display(Name = "Huisnummer")]
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
