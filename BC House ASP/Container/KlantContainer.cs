using BC_House_ASP.Interface;
using BC_House_ASP.Models;
using BC_House_ASP.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BC_House_ASP.Container
{
    public class KlantContainer
    {
        /// <summary>
        /// container van de klant 
        /// fdafasfasdfasfasf
        /// </summary>

        IKlantDAL klantDAL;

        public Validatie validatie { get; set; }

        public KlantContainer(IKlantDAL klantDAL)
        {
            this.klantDAL = klantDAL;
        }

        // methodes voor login
        // checkt of dat de gebruiker bestaat
        public bool CheckIfUserExists(Klant klant)
        {
  
            if (!klantDAL.CheckEmailExistance(klant))
            {
                return false;
            }
            else if (!klantDAL.CheckPasswordByEmail(klant))
            {
                return false;
            }
            return true;
        }


        public void Accountmaken(Klant klant)
        {
            klantDAL.AddKlant(klant);
        }

        // check of het in gevulde klopt
        public bool registerCheck(string klantEmail, string klantPassword, string telefoonNummer, string postcode)
        {
            validatie = new Validatie();
            if (!validatie.ValidatieEmail(klantEmail))
            {
                return false;
            }
            else if (!validatie.ValidatieWachtwoord(klantPassword))
            {
                return false;
            }
            else if (!validatie.ValidatieTelefoonNR(telefoonNummer))
            {
                return false;
            }
            else if (!validatie.ValidatiePostcode(postcode))
            {
                return false;
            }
            return true;
        }
    }
}
