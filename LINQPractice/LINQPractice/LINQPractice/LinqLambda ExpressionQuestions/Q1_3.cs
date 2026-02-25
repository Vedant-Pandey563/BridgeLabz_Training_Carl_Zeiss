using System;
using System.Collections.Generic;
using System.Text;

//3.Grouping and Aggregation
//Given a list of Product objects (ProductName, Category, Price), use LINQ to group products by
//category and calculate the total price of products in each category.


namespace LINQPractice.LinqQuestions
{
    internal class Q1_3
    {
        public class Product
        {
            public string ProductName;
            public string Category;
            public int Price;
        }

        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product{ProductName="Pen",Category="Stationary",Price= 10},
                new Product{ProductName="Pencil",Category="Stationary",Price= 7},
                new Product{ProductName="Phone",Category="Technology",Price= 50000},
                new Product{ProductName="Speaker",Category="Technology",Price= 1200},
                new Product{ProductName="Banana",Category="Food",Price= 15}
            };


            var result = products.GroupBy(p => p.Category)
                                 .Select(group => new
                                 {
                                     Category = group.Key,
                                     TotalPrice = group.Sum(p=>p.Price)
                                 });



            Console.WriteLine("Product grouping");

            foreach(var r in result)
            {
                Console.WriteLine($"{r.Category} -- {r.TotalPrice}");
            }
        }

    }
}
