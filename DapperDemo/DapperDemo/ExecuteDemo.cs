using Microsoft.Data.SqlClient;
using System;
using Dapper;

namespace DapperDemo
{
    internal class ExecuteDemo
    {
        static void Main()
        {
            var connStr = "Server=VP-Laptop\\SQLEXPRESS;Database=DemoDb;Trusted_Connection=True;TrustServerCertificate=True;";

            using (var conn = new SqlConnection(connStr))
            {
                //string sql = @"
                //    INSERT INTO Products 
                //    (ProductName, UnitPrice, UnitsInStock, Discontinued)
                //    VALUES (@Name, @Price, @Stock, @Discontinued);
                //";

                //int rows = conn.Execute(sql, new
                //{
                //    Name = "Spaghetti",
                //    Price = 1500,
                //    Stock = 25,
                //    Discontinued = false   
                //});

                //Console.WriteLine($"Rows Inserted: {rows}");

                //string sql = @"
                //        UPDATE Products 
                //        SET UnitPrice = @Price
                //        WHERE ProductID = @Id;
                //    ";

                //int rows = conn.Execute(sql, new
                //{
                //    Price = 2000,
                //    Id = 1
                //});

                //Console.WriteLine($"Rows Updated: {rows}");

                //string sql = "DELETE FROM Products WHERE ProductID = @Id";

                //int rows = conn.Execute(sql, new { Id = 2 });

                //Console.WriteLine($"Rows Deleted: {rows}");

                int count = conn.ExecuteScalar<int>(
                                "SELECT COUNT(*) FROM Products"
                            );

                Console.WriteLine($"Total: {count}");
            }


        }
    }
}