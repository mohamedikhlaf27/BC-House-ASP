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

        [Fact]
        public void Check_Get_Beefburgers_In_Container()
        {
            //Arrange
            var productDALStub = new ProductDALStub();
            var productContainer = new ProductContainer(productDALStub);
            productDALStub.ExistReturnValue = false;

            //Act
            productContainer.BeefBurgers();

            //Assert
            Assert.True(productDALStub.ExistReturnValue);

        }

        [Fact]
        public void Check_Get_Drinks_In_Container()
        {
            //Arrange
            var productDALStub = new ProductDALStub();
            var productContainer = new ProductContainer(productDALStub);
            productDALStub.ExistReturnValue = false;

            //Act
            productContainer.Drinks();

            //Assert
            Assert.True(productDALStub.ExistReturnValue);
        }

        [Fact]
        public void Check_If_Get_List()
        {
            //Arrange
            var productDALStub = new ProductDALStub();
            var productContainer = new ProductContainer(productDALStub);
            List<Product> products = new List<Product>();

            productDALStub.ExistReturnValue = false;

            //Act
            var productList = productContainer.GetList();

            //Assert
            Assert.Equal(products, productList);
        }
    }
}
