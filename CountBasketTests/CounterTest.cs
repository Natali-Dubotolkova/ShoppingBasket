using CountBasket.Counter;
using CountBasket.Interfaces;
using CountBasket.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CountBasketTests
{
    [TestClass]
    public class CounterTest
    {
        [TestMethod]
        public void DutyTaxCounter_NormalWork()
        {
            //Arange
            ITaxCounter taxCounter;
            taxCounter = new DutyTaxCounter();
            var price = 534.89d;
            var expected = 26.75d;

            //Act
            var actual = taxCounter.GetTax(price);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BasicTaxCounter_NormalWork()
        {
            //Arange
            ITaxCounter taxCounter;
            taxCounter = new BasicTaxCounter();
            var price = 534.89d;
            var expected = 53.50d;

            //Act
            var actual = taxCounter.GetTax(price);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TaxCounter_NullProductTitle_ReturnArgumentNullException()
        {
            //Arange
            var products = new List<Product>
            {
                new Product(1, "Vanilla ice-cream", 15.08),
                new Product(1, "imported crate of Almond Snickers", 75.99),
                new Product(1, "", 55.00),
                new Product(1, "Imported Bottle of Wine", 10.00)
            };
            //Act
            TaxCounter.Counter(products);
        }


    }
}
