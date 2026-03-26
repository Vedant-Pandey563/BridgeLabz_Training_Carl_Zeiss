//using Microsoft.Data.SqlClient;
//using System;
//using Dapper;
//using System.Collections.Generic;
//using System.Data;
//using System.Text;

//namespace DapperDemo
//{
//    internal class QueryUnbuffered
//    {
//        static async Task Main()
//        {
//            var connStr = "Server=VP-Laptop\\SQLEXPRESS;Database=DemoDb;Trusted_Connection=True;TrustServerCertificate=True;";

//            using (IDbConnection conn = new SqlConnection(connStr))
//            {
//                var products = await conn.QueryUnbufferedAsync<Product>(
//                    "SELECT * FROM Products"
//                );

//                await foreach (var p in products)
//                {
//                    Console.WriteLine(p.ProductName);
//                }
//            }
//        }
//    }
//}
