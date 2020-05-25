using BC_House_ASP.Container;
using BC_House_ASP.Models;
using BC_House_ASP_Tests.Stub;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BC_House_ASP_Tests.ProductTests
{
    public class ProductTest
    {
        [Fact]
        public void Check_If_Get_All_Products_From_Database()
        {
            // arrange
            var productDALStub = new ProductDALStub();

            productDALStub.ExistReturnValue = false;

            // act 
            productDALStub.AllProducts();

            // assert
            Assert.True(productDALStub.ExistReturnValue);
        }

        [Fact]
        public void Check_If_Get_All_BeefBurgers_From_Database()
        {
            // arrange
            var productDALStub = new ProductDALStub();

            productDALStub.ExistReturnValue = false;

            // act 
            productDALStub.FilterBeefBurgers();

            // assert
            Assert.True(productDALStub.ExistReturnValue);
        }

        [Fact]
        public void Check_If_Get_All_BeefBurgersMenu_From_Database()
        {
            // arrange
            var productDALStub = new ProductDALStub();

            productDALStub.ExistReturnValue = false;

            // act 
            productDALStub.FilterBeefBurgersMenu();

            // assert
            Assert.True(productDALStub.ExistReturnValue);
        }

        [Fact]
        public void Check_If_Get_All_ChickenBurger_From_Database()
        {
            // arrange
            var productDALStub = new ProductDALStub();

            productDALStub.ExistReturnValue = false;

            // act 
            productDALStub.FilterChickenBurger();

            // assert
            Assert.True(productDALStub.ExistReturnValue);
        }

        [Fact]
        public void Check_If_Get_All_ChickenBurgerMenu_From_Database()
        {
            // arrange
            var productDALStub = new ProductDALStub();

            productDALStub.ExistReturnValue = false;

            // act 
            productDALStub.FilterChickenBurgerMenu();

            // assert
            Assert.True(productDALStub.ExistReturnValue);
        }

        [Fact]
        public void Check_If_Get_All_Buckets_From_Database()
        {
            // arrange
            var productDALStub = new ProductDALStub();

            productDALStub.ExistReturnValue = false;

            // act 
            productDALStub.FilterBuckets();

            // assert
            Assert.True(productDALStub.ExistReturnValue);
        }

        [Fact]
        public void Check_If_Get_All_Portie_From_Database()
        {
            // arrange
            var productDALStub = new ProductDALStub();

            productDALStub.ExistReturnValue = false;

            // act 
            productDALStub.FilterPortie();

            // assert
            Assert.True(productDALStub.ExistReturnValue);
        }

        [Fact]
        public void Check_If_Get_All_Friet_From_Database()
        {
            // arrange
            var productDALStub = new ProductDALStub();

            productDALStub.ExistReturnValue = false;

            // act 
            productDALStub.FilterFriet();

            // assert
            Assert.True(productDALStub.ExistReturnValue);
        }

        [Fact]
        public void Check_If_Get_All_Icecream_From_Database()
        {
            // arrange
            var productDALStub = new ProductDALStub();

            productDALStub.ExistReturnValue = false;

            // act 
            productDALStub.FilterIcecream();

            // assert
            Assert.True(productDALStub.ExistReturnValue);
        }

        [Fact]
        public void Check_If_Get_All_Saus_From_Database()
        {
            // arrange
            var productDALStub = new ProductDALStub();

            productDALStub.ExistReturnValue = false;

            // act 
            productDALStub.FilterSaus();

            // assert
            Assert.True(productDALStub.ExistReturnValue);
        }

        [Fact]
        public void Check_If_Get_All_Drinks_From_Database()
        {
            // arrange
            var productDALStub = new ProductDALStub();

            productDALStub.ExistReturnValue = false;

            // act 
            productDALStub.FilterDrinks();

            // assert
            Assert.True(productDALStub.ExistReturnValue);
        }

        [Fact]
        public void Check_If_Product_Saves_In_List()
        {
            // arrange
            var productDALStub = new ProductDALStub();
            productDALStub.ExistReturnValue = false;

            // act 
            productDALStub.SaveProductsInList();

            // assert
            Assert.True(productDALStub.ExistReturnValue);
        }
    }
}
