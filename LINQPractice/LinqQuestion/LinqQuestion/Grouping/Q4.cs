using System;
using System.Collections.Generic;
using System.Text;

//4.Given a list of orders ( OrderId , CustomerId, Amount ), group orders by CustomerId and
//calculate the total order amount per customer.

namespace LinqQuestion.Grouping
{
    internal class Q4
    {
        public class Order
        {
            public int OrderId;
            public int CustomerId;
            public int Amount;
        }
        static void Main(string[] args)
        {
            List<Order> orders = new List<Order>() 
            {
                new Order{OrderId = 101,CustomerId=1,Amount=100},
                new Order{OrderId = 102,CustomerId=3,Amount=200},
                new Order{OrderId = 103,CustomerId=2,Amount=40},
                new Order{OrderId = 104,CustomerId=2,Amount=450},
                new Order{OrderId = 105,CustomerId=1,Amount=60},
                new Order{OrderId = 106,CustomerId=3,Amount=100},
            };

            var results = orders.GroupBy(g => g.CustomerId)
                                .Select(group => new 
                                {
                                    CustomerId = group.Key,
                                    Amount = group.Sum(g => g.Amount)
                                });

            foreach(var  order in results)
            {
                Console.WriteLine($"CustomerID : {order.CustomerId} -- Total Anount:{order.Amount}");
            }
        }
    }
}
