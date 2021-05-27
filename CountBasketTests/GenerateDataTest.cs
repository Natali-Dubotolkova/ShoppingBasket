using CountBasket.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CountBasketTests
{
    [TestClass]
    public class GenerateDataTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GenerteDataFromString_ReturnArgumentNullException()
        {
            //Arange
            var data = "";
            //Act
            GenerateData.GenerateDataFromString(data);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void GenerteDataFromString_InputString_ReturnFormatException()
        {
            //Arange
            var data = "123456u7yhtgfd";
            //Act
            GenerateData.GenerateDataFromString(data);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GenerteDataFromString_InputNegativeCost_ReturnArgumentException()
        {
            //Arange
            var data = @"Shopping Basket 1:
                       1 16lb bag of Skittles at -16.00
                       1 Walkman at 99.99
                       1 bag of microwave Popcorn at 0.99";
            //Act
            GenerateData.GenerateDataFromString(data);
        }
    }
}
