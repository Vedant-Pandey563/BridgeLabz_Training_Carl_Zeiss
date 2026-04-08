using Microsoft.Data.SqlClient;
using System;
using Dapper;
using System.Collections.Generic;
using System.Text;

namespace DapperDemo
{
    internal class UtilitiesDemo
    {
        //static async Task Main()
        //{
        //    var connStr = "Server=VP-Laptop\\SQLEXPRESS;Database=DemoDb;Trusted_Connection=True;TrustServerCertificate=True;";
        //    using var conn = new SqlConnection(connStr);

        //    var products = await conn.QueryAsync<Product>(
        //        "SELECT * FROM Products"
        //    );

        //    foreach (var p in products)
        //    {
        //        Console.WriteLine(p.ProductName);
        //    }


        //}

        static void Main()
        {
            var connStr = "Server=VP-Laptop\\SQLEXPRESS;Database=DemoDb;Trusted_Connection=True;TrustServerCertificate=True;";

            using var conn = new SqlConnection(connStr);
            conn.Open();
            using var transaction = conn.BeginTransaction();


            try
            {
                conn.Execute(
                    "Insert Into Products(ProductName, UnitPrice, UnitsInStock,Discontinued) " +
                    "Values(@n,@p,@s,@d),";
            }
        }

    }
}
