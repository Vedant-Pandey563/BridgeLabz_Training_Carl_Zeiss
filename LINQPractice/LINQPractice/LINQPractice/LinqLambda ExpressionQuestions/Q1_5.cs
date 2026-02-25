using System;
using System.Collections.Generic;
using System.Text;

//5. Date-Based Filtering
//Given a list of Order objects with OrderDate , write a LINQ query to fetch all orders placed in
//the current year using lambda expressions.


namespace LINQPractice.LinqQuestions
{
    public class Order
    {
        public int ID;
        public DateTime OrderDate;
        public string ProductName ;
    }
    internal class Q1_5
    {
        static void Main(string[] args)
        {
            List<Order> orders = new List<Order>()
            {
                new Order{ID=1,OrderDate = new DateTime(2025,1,10),ProductName="Mouse"},
                new Order{ID=2,OrderDate = new DateTime(2024,3,10),ProductName="Keyboard"},
                new Order{ID=3,OrderDate = new DateTime(2026,8,10),ProductName="Laptop"},
                new Order{ID=4,OrderDate = new DateTime(2024,12,10),ProductName="Speaker"},
                new Order{ID=5,OrderDate = DateTime.Now ,ProductName="USB"},
                new Order{ID=6,OrderDate = new DateTime(2025,7,10),ProductName="Camera"},
            };

            int currentyear = DateTime.Now.Year;//curr year

            var result = orders.Where(o=>o.OrderDate.Year == currentyear);

            Console.WriteLine("Order placed in the year");

            foreach(var order in result)
            {
                Console.WriteLine($"OrderId: {order.ID},Product: {order.ProductName},Date: {order.OrderDate}");
            }

        }
    }
}
