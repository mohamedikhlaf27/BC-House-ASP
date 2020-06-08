using BC_House_ASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BC_House_ASP.Container
{
    public class WinkelwagenContainer
    {
        public List<Product> WinkelwagenList { get; set; } = new List<Product>();


        public List<Product> GetList()
        {
            return WinkelwagenList;
        }

        public void ClearList()
        {
            WinkelwagenList = new List<Product>();
            WinkelwagenList.Clear();
        }

    }
}
