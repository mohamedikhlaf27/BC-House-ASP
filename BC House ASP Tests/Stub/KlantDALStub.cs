using System;
using System.Collections.Generic;
using System.Text;
using BC_House_ASP.Interface;
using BC_House_ASP.Models;

namespace BC_House_ASP_Tests.Stub
{
    class KlantDALStub : IKlantDAL
    {

        public bool? ExistReturnValue = null;

        public void AddKlant(Klant klant)
        {
            if (ExistReturnValue == null)
            {
                throw new NullReferenceException("Invalid use of stub code. First set field ExistsReturnValue");
            }
            ExistReturnValue = true;
        }

        public bool CheckEmailExistance(Klant klant)
        {
            if (ExistReturnValue == null)
            {
                throw new NullReferenceException("Invalid use of stub code. First set field ExistsReturnValue");
            }
            return ExistReturnValue.Value;
        }

        public bool CheckPasswordByEmail(Klant klant)
        {
            if (ExistReturnValue == null)
            {
                throw new NullReferenceException("Invalid use of stub code. First set field ExistsReturnValue");
            }
            return ExistReturnValue.Value;
        }

        public Klant GetKlant(Klant klant)
        {
            klant.Id = 12;
            if (ExistReturnValue == null)
            {
                throw new NullReferenceException("Invalid use of stub code. First set field ExistsReturnValue");
            }
            return klant;
        }
    }
}
