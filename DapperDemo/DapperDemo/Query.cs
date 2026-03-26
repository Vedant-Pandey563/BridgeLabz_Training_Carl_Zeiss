using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using System.Text;

namespace DapperDemo
{
    internal class Query
    {
        static void Main()
        {
            var connStr = "Server=VP-Laptop\\SQLEXPRESS;Database=DemoDb;Trusted_Connection=True;TrustServerCertificate=True;";

            using (IDbConnection conn = new SqlConnection(connStr)) 
            {
                var products1 = conn.Query<Product>("SELECT * FROM Products");

                foreach(var p in products1)
                {
                    Console.WriteLine($"\n{p.ProductName} -- {p.ProductID} -- {p.UnitPrice}");
                }


                Console.WriteLine("\nQueryfirst");
                var product2 = conn.QueryFirst<Product>("Select * from Products");
                Console.WriteLine(product2.ProductName);


                var products3 = conn.QueryFirstOrDefault<Product>("SELECT * FROM Products WHERE ProductID = 9");

                if (products3 == null)
                {
                    Console.WriteLine("No product found");
                }
                else
                {
                    Console.WriteLine($"{products3.ProductName}");
                }

                var product4 = conn.QuerySingle<Product>("SELECT * FROM Products WHERE ProductID = 6");

                Console.WriteLine($"{product4.ProductName}");

                
                int count = conn.QueryFirst<int>("SELECT COUNT(*) FROM Products");
                Console.WriteLine(count);

                var result = conn.Query("SELECT ProductName, UnitPrice FROM Products");

                foreach (var row in result)
                {
                    Console.WriteLine(row.ProductName);
                }

                var product = conn.QueryFirst<Product>(
                    "SELECT * FROM Products WHERE ProductID = @Id",
                    new { Id = 1 });
                Console.WriteLine($"{product.ProductName}");

                Console.WriteLine("-----------------------");
                var products = conn.Query<Product>(
                        "SELECT * FROM Products WHERE UnitPrice > @Price AND UnitsInStock > @Stock",
                        new { Price = 5.0, Stock = 10 });

                foreach(var p in products)
                {
                    Console.WriteLine(p.ProductName);
                }

            }


        }

    }


}
