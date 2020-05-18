using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BC_House_ASP.Interface
{
    public interface IProductDAL
    {
        void FilterBeefBurgers();

        void FilterDrinks();

        void SaveProductsInList();
    }
}
