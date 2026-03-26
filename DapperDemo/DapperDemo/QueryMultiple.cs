using Microsoft.Data.SqlClient;
using System;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DapperDemo
{
    internal class QueryMultiple
    {
        static void Main()
        {
            var connStr = "Server=VP-Laptop\\SQLEXPRESS;Database=DemoDb;Trusted_Connection=True;TrustServerCertificate=True;";

            using (IDbConnection conn = new SqlConnection(connStr))
            {
                        string sql = @"
                SELECT * FROM Products;
                SELECT COUNT(*) FROM Products;
                SELECT * FROM Products WHERE UnitPrice > 5;
            ";

                using (var multi = conn.QueryMultiple(sql))
                {
                    var allProducts = multi.Read<Product>().ToList();
                    var count = multi.ReadFirst<int>();
                    var expensiveProducts = multi.Read<Product>().ToList();

                    Console.WriteLine($"Total Count: {count}");

                    Console.WriteLine("\nAll Products:");
                    foreach (var p in allProducts)
                        Console.WriteLine(p.ProductName);

                    Console.WriteLine("\nExpensive Products:");
                    foreach (var p in expensiveProducts)
                        Console.WriteLine(p.ProductName);
                }
            }
        }
    }
}
