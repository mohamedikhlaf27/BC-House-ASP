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
    public class WinkelwagenContainerTest
    {
        [Fact]
        public void Check_AddProductToCard_1_product()
        {
            //Arrange
            Product product = new Product();
            Winkelwagen winkelwagen = new Winkelwagen(product.id);
            var winkelwagenDALStub = new WinkelwagenDALStub();
            var WinkelwagenContainer = new WinkelwagenContainer(winkelwagenDALStub);
            winkelwagenDALStub.ExistReturnValue = false;

            //Act
            var winkelwagenList = WinkelwagenContainer.GetList();
            WinkelwagenContainer.AddProductToCart(product, winkelwagen);

            var result = winkelwagenList.Count();
            var expected = 1;
            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Check_AddProductToCard_If_list_already_contains_2_product()
        {
            //Arrange
            Product product = new Product();
            Winkelwagen winkelwagen = new Winkelwagen(product.id);
            var winkelwagenDALStub = new WinkelwagenDALStub();
            var winkelwagenContainer = new WinkelwagenContainer(winkelwagenDALStub);
            winkelwagenDALStub.ExistReturnValue = false;

            //Act
            var winkelwagenList = winkelwagenContainer.GetList();
            winkelwagen = winkelwagenDALStub.Getproduct(product.id);

            Winkelwagen product1 = new Winkelwagen(product.id);
            Winkelwagen product2 = new Winkelwagen(product.id);

            winkelwagenList.Add(product1);
            winkelwagenList.Add(product2);

            winkelwagenContainer.AddProductToCart(product, winkelwagen);

            var result = winkelwagenList.Count();
            var expected = 3;
            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Check_If_Get_List()
        {
            //Arrange
            var winkelwagenDALStub = new WinkelwagenDALStub();
            var winkelwagenContainer = new WinkelwagenContainer(winkelwagenDALStub);
            List<Winkelwagen> products = new List<Winkelwagen>();

            winkelwagenDALStub.ExistReturnValue = false;

            //Act
            var winkelwagenList = winkelwagenContainer.GetList();

            //Assert
            Assert.Equal(products, winkelwagenList);
        }

        [Fact]
        public void Check_if_list_is_cleared()
        {
            //Arrange
            var winkelwagenDALStub = new WinkelwagenDALStub();
            var winkelwagenContainer = new WinkelwagenContainer(winkelwagenDALStub);
            List<Winkelwagen> products = new List<Winkelwagen>();
            Product product = new Product();
            Winkelwagen winkelwagenProduct = new Winkelwagen(product.id);

            //Act
            products.Add(winkelwagenProduct);
            products.Add(winkelwagenProduct);
            products.Add(winkelwagenProduct);

            var list = winkelwagenContainer.GetList();
            winkelwagenContainer.ClearList();
            //Assert
            var result = list.Count();
            var expected = 0;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Check_SetProductQuantity()
        {
            //Arrange
            Product product = new Product();
            Winkelwagen winkelwagen = new Winkelwagen(product.id);

            var winkelwagenDALStub = new WinkelwagenDALStub();
            var winkelwagenContainer = new WinkelwagenContainer(winkelwagenDALStub);

            //Act

            Winkelwagen product1 = new Winkelwagen(product.id);
            product1.Prod.id = 1;
            product1.hoeveelheid = 1;

            Winkelwagen product2 = new Winkelwagen(product.id);
            product2.Prod.id = 1;
            product2.hoeveelheid = 1;

            winkelwagenContainer.SetProductQuantity(product, winkelwagen);

            var result = product1.hoeveelheid;
            var expected = product2.hoeveelheid;

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]

        public void Check_RemoveProduct_From_List()
        {
            //Arrange

            Product product = new Product();
            Winkelwagen winkelwagen = new Winkelwagen(product.id);

            var winkelwagenDALStub = new WinkelwagenDALStub();
            var winkelwagenContainer = new WinkelwagenContainer(winkelwagenDALStub);
            List<Winkelwagen> products = new List<Winkelwagen>();

            // Act
            var winkelwagenList = winkelwagenContainer.GetList();

            Winkelwagen product1 = new Winkelwagen(product.id);
            Winkelwagen product2 = new Winkelwagen(product.id);

            winkelwagenList.Add(product1);
            winkelwagenList.Add(product2);

            winkelwagenContainer.RevomeProduct(product2);

            var result = winkelwagenList.Count();
            var expected = 1;

            //Assert
            Assert.Equal(expected, result);
        }
    }
}
