using BC_House_ASP.Interface;
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
        /// </summary>

        IKlantDAL klantDAL;

        public Validatie validatie { get; set; }

        public KlantContainer(IKlantDAL klantDAL)
        {
            this.klantDAL = klantDAL;
        }

        // methodes voor login
        // checkt of dat de gebruiker bestaat
        public bool CheckIfUserExists(string klantEmail, string klantPassword)
        {
  
            if (!klantDAL.CheckEmailExistance(klantEmail))
            {
                return false;
            }
            else if (!klantDAL.CheckPasswordByEmail(klantPassword, klantEmail))
            {
                return false;
            }
            return true;
        }

        // methodes voor registeren
        public void Accountmaken(string klantNaam, string klantEmail, int telefoonNummer, string klantPassword, string postcode, string huisNummer, string straat, string woonplaats)
        {
            klantDAL.AddKlant(klantNaam, klantEmail, telefoonNummer, klantPassword, postcode, huisNummer, straat, woonplaats);
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
