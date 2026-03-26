using System;
using Dapper;
using Microsoft.Data.SqlClient;

class Program
{
    static void Main()
    {
        var connStr = "Server=VP-Laptop\\SQLEXPRESS;Database=DemoDb;Trusted_Connection=True;TrustServerCertificate=True;";

        using (var connection = new SqlConnection(connStr))
        {
            connection.Open();

            Console.WriteLine("Connected Successfully!");

            var count = connection.QueryFirst<int>("SELECT COUNT(*) FROM Products");

            Console.WriteLine($"Total Rows: {count}");
        }
    }
}

public class Product
{
    public int ProductID { get; set; }
    public string ProductName { get; set; }
    public decimal UnitPrice { get; set; }
    public int CategoryID { get; set; }

    public Category Category { get; set; } // for mapping
}

public class Category
{
    public int CategoryID { get; set; }
    public string CategoryName { get; set; }
}