using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BC_House_ASP.Interface;

namespace BC_House_ASP_Tests.Stub
{
    public class ProductDALStub : IProductDAL
    {
        public bool? ExistReturnValue = null;

        public void AllProducts()
        {
            if (ExistReturnValue == null)
            {
                throw new NullReferenceException("Invalid use of stub code. First set field ExistsReturnValue");
            }
            ExistReturnValue = true;
        }

        public void FilterBeefBurgers()
        {
            if (ExistReturnValue == null)
            {
                throw new NullReferenceException("Invalid use of stub code. First set field ExistsReturnValue");
            }
            ExistReturnValue = true;
        }

        public void FilterBeefBurgersMenu()
        {
            if (ExistReturnValue == null)
            {
                throw new NullReferenceException("Invalid use of stub code. First set field ExistsReturnValue");
            }
            ExistReturnValue = true;
        }

        public void FilterBuckets()
        {
            if (ExistReturnValue == null)
            {
                throw new NullReferenceException("Invalid use of stub code. First set field ExistsReturnValue");
            }
            ExistReturnValue = true;
        }

        public void FilterChickenBurger()
        {
            if (ExistReturnValue == null)
            {
                throw new NullReferenceException("Invalid use of stub code. First set field ExistsReturnValue");
            }
            ExistReturnValue = true;
        }

        public void FilterChickenBurgerMenu()
        {
            if (ExistReturnValue == null)
            {
                throw new NullReferenceException("Invalid use of stub code. First set field ExistsReturnValue");
            }
            ExistReturnValue = true;
        }

        public void FilterDrinks()
        {
            if (ExistReturnValue == null)
            {
                throw new NullReferenceException("Invalid use of stub code. First set field ExistsReturnValue");
            }
            ExistReturnValue = true;
        }

        public void FilterFriet()
        {
            if (ExistReturnValue == null)
            {
                throw new NullReferenceException("Invalid use of stub code. First set field ExistsReturnValue");
            }
            ExistReturnValue = true;
        }

        public void FilterIcecream()
        {
            if (ExistReturnValue == null)
            {
                throw new NullReferenceException("Invalid use of stub code. First set field ExistsReturnValue");
            }
            ExistReturnValue = true;
        }

        public void FilterPortie()
        {
            if (ExistReturnValue == null)
            {
                throw new NullReferenceException("Invalid use of stub code. First set field ExistsReturnValue");
            }
            ExistReturnValue = true;
        }

        public void FilterSaus()
        {
            if (ExistReturnValue == null)
            {
                throw new NullReferenceException("Invalid use of stub code. First set field ExistsReturnValue");
            }
            ExistReturnValue = true;
        }

        public void SaveProductsInList()
        {
            if (ExistReturnValue == null)
            {
                throw new NullReferenceException("Invalid use of stub code. First set field ExistsReturnValue");
            }
            ExistReturnValue = true;
        }
    }
}
