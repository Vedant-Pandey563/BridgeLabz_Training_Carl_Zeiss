using System;
using System.Collections.Generic;
using System.Text;

//2.Given a list of Product objects ( Name , Category, Price ), group products by Category
//and calculate the average price for each category

namespace LinqQuestion.Grouping
{
    public class Product
    {
        public string Name;
        public string Category;
        public int Price;
    }
    internal class Q2
    {
        static void Main(string[]args)
        {
            List<Product> products = new List<Product>()
            {
                new Product{Name="Pen",Category="Stationary",Price=25},
                new Product{Name="Pencil",Category="Stationary",Price=15},
                new Product{Name="Laptop",Category="Tech",Price=50000},
                new Product{Name="Mouse",Category="Tech",Price=2000},
                new Product{Name="Apple",Category="Food",Price=100},
                new Product{Name="Banana",Category="Food",Price=40}
            };

            var results = products.GroupBy(p => p.Category)
                                  .Select(group => new
                                  {
                                      Category = group.Key,
                                      Price = group.Sum(p => p.Price)
                                  });

            foreach(var category in results)
            {
                Console.WriteLine($"Category:{category.Category} -- Sum:{category.Price}");
            }
        }


    }
}
