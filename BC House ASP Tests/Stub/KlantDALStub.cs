using System;
using System.Collections.Generic;
using System.Text;
using BC_House_ASP.Interface;

namespace BC_House_ASP_Tests.Stub
{
    class KlantDALStub : IKlantDAL
    {

        public bool? ExistReturnValue = null;

        public void AddKlant(string klantNaam, string klantEmail, string telefoonNummer, string klantPassword, string postcode, string huisNummer, string straat, string woonplaats)
        {
            if (ExistReturnValue == null)
            {
                throw new NullReferenceException("Invalid use of stub code. First set field ExistsReturnValue");
            }
            ExistReturnValue = true;
        }

        public bool CheckEmailExistance(string klantEmail)
        {
            if (ExistReturnValue == null)
            {
                throw new NullReferenceException("Invalid use of stub code. First set field ExistsReturnValue");
            }
            return ExistReturnValue.Value;
        }

        public bool CheckPasswordByEmail(string klantPassword, string klantEmail)
        {
            if (ExistReturnValue == null)
            {
                throw new NullReferenceException("Invalid use of stub code. First set field ExistsReturnValue");
            }
            return ExistReturnValue.Value;
        }
    }
}
