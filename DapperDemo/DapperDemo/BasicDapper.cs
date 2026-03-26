using System;
using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

class Program2
{
    static void Main()
    {
        var connStr = "Server=VP-Laptop\\SQLEXPRESS;Database=DemoDb;Trusted_Connection=True;TrustServerCertificate=True;";

        using (IDbConnection db = new SqlConnection(connStr))
        {
            var products = db.Query<Product>("SELECT ProductID, ProductName, UnitPrice, UnitsInStock FROM Products");

            foreach (var p in products)
            {
                Console.WriteLine($"{p.ProductID} | {p.ProductName} | {p.UnitPrice}");
            }
        }
    }
}

