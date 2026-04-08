using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DapperDemo
{
    internal class MappingDemo
    {

        static void Main()
        {
            var connStr = "Server=VP-Laptop\\SQLEXPRESS;Database=DemoDb;Trusted_Connection=True;TrustServerCertificate=True;";

            using (var conn = new SqlConnection(connStr))
            {
                var result = conn.Query(
                    "Select ProductName,UnitPrice from Products");
                foreach (var row in result)
                {
                    Console.WriteLine($"{row.ProductName} - {row.UnitPrice}");
                }
                Console.WriteLine();
                var products = conn.Query<Product>(
                    "SELECT ProductID, ProductName, UnitPrice FROM Products");

                foreach (var product in products)
                {
                    Console.WriteLine($"{product.ProductName}");
                }

                string sql = @"
                        SELECT 
                            p.ProductID, p.ProductName, p.UnitPrice,
                            c.CategoryID, c.CategoryName
                        FROM Products p
                        INNER JOIN Categories c ON p.CategoryID = c.CategoryID;
                    ";

                Console.WriteLine("multi mapping");
                Console.WriteLine();
                var productJoin = conn.Query<Product, Category, Product>(
                    sql,
                    (product, category) =>
                    {
                        product.Category = category;
                        return product;
                    },
                    splitOn: "CategoryID"
                );

                foreach (var p in productJoin)
                {
                    Console.WriteLine($"{p.ProductName} -> {p.Category?.CategoryName}");
                }
                Console.WriteLine();

                Console.WriteLine("Multi Result");

                var sql2 = @"
                        Select * from Products;
                        Select * from Categories;
                        ";

                using(var multi = conn.QueryMultiple(sql2))
                {
                    var product = multi.Read<Product>().ToList();
                    var categories = multi.Read<Category>().ToList();

                    foreach (var p in product)
                    {
                        Console.WriteLine($"{p.ProductName} ----");
                    }
                    foreach (var c in categories)
                    {
                        Console.WriteLine($"{c.CategoryName}");
                    }
                }

                Console.WriteLine("Mulyi type mapping");
                Console.WriteLine();
                var result1 = conn.Query(
                    "Select ProductName,UnitPrice From Products");

                foreach (var row in result)
                {
                    string name = row.ProductName;
                    decimal price = row.UnitPrice;
                    Console.WriteLine(name + price );
                }

            }
        }
    }
}

