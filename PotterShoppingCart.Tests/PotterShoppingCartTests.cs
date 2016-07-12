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
            var orders = new List<Order> {
                new Order { Name = "Book1", Price = 100, Qty = 1 }
            };

            var target = new PotterShoppingCart.Library.PotterShoppingCart();
            var expected = 100;
            var actual = target.CalculateOrderSum(orders);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CountOrderSumTest_Buy_One_Book1_One_Book2_Should_Be_190()
        {
            var orders = new List<Order> {
                new Order { Name = "Book1", Price = 100, Qty = 1 },
                new Order { Name = "Book2", Price = 100, Qty = 1 }
            };

            var target = new PotterShoppingCart.Library.PotterShoppingCart();
            var expected = 190;
            var actual = target.CalculateOrderSum(orders);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CountOrderSumTest_Buy_One_Book1_One_Book2_One_Book3_Should_Be_270()
        {
            var orders = new List<Order> {
                new Order { Name = "Book1", Price = 100, Qty = 1 },
                new Order { Name = "Book2", Price = 100, Qty = 1 },
                new Order { Name = "Book3", Price = 100, Qty = 1 }
            };

            var target = new PotterShoppingCart.Library.PotterShoppingCart();
            var expected = 270;
            var actual = target.CalculateOrderSum(orders);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CountOrderSumTest_Buy_One_Book1_One_Book2_One_Book3_One_Book4_Should_Be_320() {
            var orders = new List<Order> {
                new Order { Name = "Book1", Price = 100, Qty = 1 },
                new Order { Name = "Book2", Price = 100, Qty = 1 },
                new Order { Name = "Book3", Price = 100, Qty = 1 },
                new Order { Name = "Book4", Price = 100, Qty = 1 }
            };

            var target = new PotterShoppingCart.Library.PotterShoppingCart();
            var expected = 320;
            var actual = target.CalculateOrderSum(orders);
            Assert.AreEqual(expected, actual);
        }
    }
}
