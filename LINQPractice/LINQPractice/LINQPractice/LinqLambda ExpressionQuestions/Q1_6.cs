using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

//6.Finding Maximum Value
//Write a LINQ query to find the highest-priced product from a list of products using lambda
//expressions.

namespace LINQPractice.LinqQuestions
{
    public class Product
    {
        public string Name;
        public int Price;
    }
    internal class Q1_6
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product{Name="Pen",Price=10},
                new Product{Name="Pencil",Price=7},
                new Product{Name="Eraser",Price=5},
                new Product{Name="Compass",Price=67}    
            };

            var result = products.OrderByDescending(p => p.Price)
                                 .First();

            Console.WriteLine("Highest price product :");
            Console.WriteLine($"Name: {result.Name},Price: {result.Price}");
        }
    }
}
