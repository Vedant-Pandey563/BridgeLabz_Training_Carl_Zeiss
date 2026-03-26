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

            }
        }
    }
}

