using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotterShoppingCart.Library
{
    public class PotterShoppingCart
    {
        Dictionary<int, int> discounts = new Dictionary<int, int> { { 1, 0 }, { 2, 5 }, { 3, 10 }, { 4, 20 }, { 5, 25 } };

        public double CalculateOrderSum(List<Order> orders) {
            double sum = 0;

            var orderList = (
                from order in orders
                group order by new { order.Name, order.Price } into g
                where g.Sum(order => order.Qty) > 0
                select new Order { Name = g.Key.Name, Price = g.Key.Price, Qty = g.Sum(order => order.Qty) }
            ).ToList();

            if (orderList.Count > 0) {
                foreach (var v in orderList)
                {
                    sum += v.Price;
                    v.Qty -= 1;
                }

                int iDistinctCtr = orderList.Count();       //有幾種不同的種類
                int iDiscount = discounts[iDistinctCtr];    //取出折扣率
                sum = sum * ((100 - iDiscount) * 1.0 / 100) + CalculateOrderSum(orderList);
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
