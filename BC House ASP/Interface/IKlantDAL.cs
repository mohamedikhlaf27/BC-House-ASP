using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BC_House_ASP.Interface
{
    public interface IKlantDAL
    {
        void AddKlant(string klantNaam, string klantEmail, string telefoonNummer, string klantPassword, string postcode, string huisNummer, string straat, string woonplaats);

        bool CheckPasswordByEmail(string klantPassword, string klantEmail);
        bool CheckEmailExistance(string klantEmail);
    }
}
