using BC_House_ASP.Container;
using BC_House_ASP.Models;
using BC_House_ASP_Tests.Stub;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace BC_House_ASP_Tests.WinkelwagenTests
{
    public class WinkelwagenTest
    {

        [Fact]
        public void Check_GetProduct()
        {
            //Arrange
            Product product = new Product();
            Winkelwagen winkelwagen = new Winkelwagen(product.id);

            var winkelwagenDALStub = new WinkelwagenDALStub();
            var winkelwagenContainer = new WinkelwagenContainer(winkelwagenDALStub);

            winkelwagenDALStub.ExistReturnValue = false;

            //Act
            winkelwagen = winkelwagenDALStub.Getproduct(product.id);

            //Assert
            Assert.True(winkelwagenDALStub.ExistReturnValue);
        }
    }
}
