using System;
using System.Collections.Generic;
using System.Text;

//8.Given a list of employees ( Department , Salary ), group by department and calculate the
//minimum, maximum, and average salary.

namespace LinqQuestion.Grouping
{
    public class Employees
    {
        public string Name;
        public int Salary;
        public string Department;
    }
    internal class Q8
    {
        static void Main(string[] args)
        {
            List<Employees> employees = new List<Employees>()
            {
                new Employees{Name="A",Salary=40000,Department="IT"},
                new Employees{Name="B",Salary=50000,Department="HR"},
                new Employees{Name="C",Salary=40000,Department="Fin"},
                new Employees{Name="D",Salary=45000,Department="Fin"},
                new Employees{Name="E",Salary=20000,Department="HR"},
                new Employees{Name="F",Salary=90000,Department="IT"}
            };

            var result = employees.GroupBy(e => e.Department)
                                  .Select(group => new 
                                  {
                                      Department = group.Key,
                                      Minimum = group.Min(e => e.Salary),
                                      Maximum = group.Max(e => e.Salary),
                                      Average = group.Average(e=>e.Salary)
                                  });

            foreach(var r in result)
            {
                Console.WriteLine($"Department: {r.Department} -- Minimum Salary = {r.Minimum} -- " +
                    $" Maximum Salary = {r.Maximum} -- Average Salary = {r.Average}");
                Console.WriteLine();
            }
        }
    }
}
