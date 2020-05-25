using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BC_House_ASP.Interface
{
    public interface IProductDAL
    {
        void AllProducts();
        void FilterBeefBurgers();
        void FilterBeefBurgersMenu();
        void FilterChickenBurger();
        void FilterChickenBurgerMenu();
        void FilterBuckets();
        void FilterPortie();
        void FilterFriet();
        void FilterIcecream();
        void FilterSaus();
        void FilterDrinks();
        void SaveProductsInList();
    }
}
