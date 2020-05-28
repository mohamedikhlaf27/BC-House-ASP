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
            productDALStub.SelectAllProducts();

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
