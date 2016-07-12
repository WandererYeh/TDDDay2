using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotterShoppingCart.Library;

namespace PotterShoppingCart.Tests
{
    [TestClass()]
    public class PotterShoppingCartTests
    {
        [TestMethod()]
        public void CalculateOrderSumTest_Buy_Only_One_Book1_Should_Be_100() {
            var target = new PotterShoppingCart.Library.PotterShoppingCart();
            var expected = 100;
            var actual = target.CalculateOrderSum();
            Assert.AreEqual(expected, actual);
        }
    }
}
