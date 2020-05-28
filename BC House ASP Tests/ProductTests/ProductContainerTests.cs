using BC_House_ASP.Container;
using BC_House_ASP.Models;
using BC_House_ASP_Tests.Stub;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace BC_House_ASP_Tests.ProductTests
{
    public class ProductContainerTests
    {
        [Fact]
        public void Check_Get_AllProducts_In_Container()
        {
            //Arrange
            var productDALStub = new ProductDALStub();
            var productContainer = new ProductContainer(productDALStub);
            productDALStub.ExistReturnValue = false;

            //Act
            productContainer.AllProducts();

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

        [Fact]
        public void Check_if_list_is_cleared()
        {
            //Arrange
            var productDALStub = new ProductDALStub();
            var productContainer = new ProductContainer(productDALStub);
            List<Product> products = new List<Product>();
            Product product = new Product();

            //Act
            products.Add(product);
            products.Add(product);
            products.Add(product);

            var list = productContainer.GetList();
            productContainer.ClearList();
            //Assert
            var result = list.Count();
            var expected = 0;

            Assert.Equal(expected, result);

        }
    }
}
