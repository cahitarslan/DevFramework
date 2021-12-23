using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Moq;
using DevFramework.Northwind.DataAccess.Abstract;
using DevFramework.Northwind.Business.Concrete.Managers;
using DevFramework.Northwind.Entities.Concrete;
using FluentValidation;

namespace DevFramework.Northwind.Business.Tests
{
    [TestClass]
    public class ProductManagerTest
    {
        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void product_validation_check()
        {
            Mock<IProductDal> mock = new Mock<IProductDal>();
            ProductManager productManager = new ProductManager(mock.Object);

            productManager.Add(new Product());
        }
    }
}
