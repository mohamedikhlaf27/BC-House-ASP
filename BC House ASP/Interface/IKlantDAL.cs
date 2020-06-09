using BC_House_ASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BC_House_ASP.Interface
{
    public interface IKlantDAL
    {
        void AddKlant(Klant klant);
        bool CheckPasswordByEmail(Klant klant);
        bool CheckEmailExistance(Klant klant);
        public Klant GetKlant(Klant klant);
    }
}
