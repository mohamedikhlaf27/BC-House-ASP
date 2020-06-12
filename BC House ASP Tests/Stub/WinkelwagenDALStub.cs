using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BC_House_ASP.Interface;
using BC_House_ASP.Models;

namespace BC_House_ASP_Tests.Stub
{
    public class WinkelwagenDALStub : IWinkelwagen
    {
        public bool? ExistReturnValue = null;

        public Winkelwagen Getproduct(int ProductID)
        {
            Winkelwagen winkelwagen = new Winkelwagen(ProductID);
            if (ExistReturnValue == null)
            {
                throw new NullReferenceException("Invalid use of stub code. First set field ExistsReturnValue");
            }
            ExistReturnValue = true;
            return winkelwagen;
        }
    }
}
