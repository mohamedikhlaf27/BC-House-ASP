using BC_House_ASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BC_House_ASP.Interface
{
    public interface IWinkelwagen
    {
        public Winkelwagen Getproduct(int ProductID);
    }
}
