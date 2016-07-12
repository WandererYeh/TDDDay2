using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotterShoppingCart.Library
{
    public class PotterShoppingCart
    {
        public int CalculateOrderSum(List<Order> orders) {
            int sum = 0;

            var orderList = (
                from order in orders
                group order by new { order.Name, order.Price } into g
                select new Order { Name = g.Key.Name, Price = g.Key.Price, Qty = g.Sum(order => order.Qty) }
            ).ToList();

            foreach (var v in orderList)
            {
                sum += v.Price;
            }

            return sum;
        }
    }

    public class Order {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Qty { get; set; }
    }
}
