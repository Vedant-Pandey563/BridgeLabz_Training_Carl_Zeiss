using System;
using System.Collections.Generic;
using System.Text;

//3.Perform a right join using LINQ (simulate using GroupJoin ) between orders and customers.

namespace LinqJoinQs
{
    internal class Q3
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>()
                {
                    new Customer{Id=1, Name="Alice"},
                    new Customer{Id=2, Name="Bob"}
                };

            List<Order> orders = new List<Order>()
                {
                    new Order{OrderId=101, CustomerId=1, Product="Laptop"},
                    new Order{OrderId=102, CustomerId=1, Product="Mouse"},
                    new Order{OrderId=103, CustomerId=3, Product="Keyboard"}
                };

            var result = orders
                        .GroupJoin(
                            customers,
                            o => o.CustomerId,   // Order key
                            c => c.Id,           // Customer key
                            (order, custGroup) => new { order, custGroup }
                        )
                        .SelectMany(
                            x => x.custGroup.DefaultIfEmpty(),
                            (x, customer) => new
                            {
                                OrderId = x.order.OrderId,
                                Product = x.order.Product,
                                CustomerName = customer?.Name ?? "No Customer"
                            });

            foreach (var r in result)
            {
                Console.WriteLine($"{r.OrderId} -- {r.Product} -- {r.CustomerName}");
            }


        }

    }
}
