using System;
using System.Collections.Generic;
using System.Text;

namespace LinqJoinQs
{
    class Customer
    {
        public int Id;
        public string Name;
    }

    class Order
    {
        public int OrderId;
        public int CustomerId;
        public string Product;
    }
    internal class Q2
    {
        static void Main()
        {
            List<Customer> customers = new List<Customer>()
        {
            new Customer{Id=1, Name="A"},
            new Customer{Id=2, Name="B"},
            new Customer{Id=3, Name="C"}
        };

            List<Order> orders = new List<Order>()
        {
            new Order{OrderId=101, CustomerId=1, Product="Laptop"},
            new Order{OrderId=102, CustomerId=1, Product="Mouse"},
            new Order{OrderId=103, CustomerId=2, Product="Phone"}
        };

            var result = customers
                .GroupJoin(
                    orders,
                    c => c.Id,
                    o => o.CustomerId,
                    (customer, orderGroup) => new { customer, orderGroup }
                )
                .SelectMany(
                    x => x.orderGroup.DefaultIfEmpty(),
                    (x, order) => new
                    {
                        CustomerName = x.customer.Name,
                        Product = order?.Product ?? "No Orders"
                    });

            foreach (var r in result)
            {
                Console.WriteLine($"{r.CustomerName} -- {r.Product}");
            }
        }

    }
}
