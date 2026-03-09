using System;
using System.Collections.Generic;
using System.Text;

//9.Group sales records by month and calculate the total sales per month.

namespace LinqQuestion.Grouping
{
    public class Sale
    {
        public DateTime SaleDate;
        public decimal Amount;
    }
    internal class Q9
    {
        static void Main(string[] args)
        {
            List<Sale> sales = new List<Sale>()
            {
                new Sale{SaleDate=new DateTime(2026,1,10), Amount=1000},
                new Sale{SaleDate=new DateTime(2026,1,20), Amount=2000},
                new Sale{SaleDate=new DateTime(2026,2,5), Amount=1500},
                new Sale{SaleDate=new DateTime(2026,2,25), Amount=2500},
                new Sale{SaleDate= DateTime.Now, Amount=3000}
            };

            var result = sales.GroupBy(s => s.SaleDate.Month)
                              .Select(group => new
                              {
                                  Month = group.Key,
                                  TotalSales = group.Sum(s => s.Amount)
                              });

            foreach (var r in result)
            {
                Console.WriteLine($"Month: {r.Month} -- Total Sales: {r.TotalSales}");
            }



        }
    }
}
