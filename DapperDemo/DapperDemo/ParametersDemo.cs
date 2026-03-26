using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DapperDemo
{
    internal class ParametersDemo
    {
        static void Main()
        {
            var connStr = "Server=VP-Laptop\\SQLEXPRESS;Database=DemoDb;Trusted_Connection=True;TrustServerCertificate=True;";

            using (var conn = new SqlConnection(connStr))
            {


                //var parameters = new DynamicParameters();
                //parameters.Add("Id", 1);
                //parameters.Add("Name", dbType: DbType.String, direction: ParameterDirection.Output, size: 100);

                //conn.Execute(
                //    "SELECT @Name = ProductName FROM Products WHERE ProductID = @Id",
                //    parameters
                //);

                //string name = parameters.Get<string>("Name");
                //Console.WriteLine(name);


                //var ids = new[] { 1, 2, 3 };

                //var products = conn.Query<Product>(
                //    "SELECT * FROM Products WHERE ProductID IN @Ids",
                //    new { Ids = ids }
                //);

                //var products = conn.Query<Product>(
                //    "SELECT * FROM Products WHERE ProductName LIKE @Name",
                //    new { Name = "%Ch%" }
                //);

                
                var table = new DataTable();
                table.Columns.Add("Id", typeof(int));

                table.Rows.Add(1);
                table.Rows.Add(2);
                table.Rows.Add(3);

                var parameters = new DynamicParameters();
                parameters.Add("@Ids", table.AsTableValuedParameter("ProductIdTableType"));

                var products = conn.Query<Product>(
                    "SELECT * FROM Products WHERE ProductID IN (SELECT Id FROM @Ids)",
                    parameters
                );

                foreach (var product in products)
                {
                    Console.WriteLine($"{product.ProductName}");
                }

            }


        }
    }
}
