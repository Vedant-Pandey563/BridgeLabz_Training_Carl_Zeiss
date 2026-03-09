using LinqQuestion.Grouping;
using System;
using System.Collections.Generic;
using System.Text;

//5.Group employees by department and count how many employees joined in each department

namespace LinqQuestion.Grouping
{
    //public class Employee
    //{
    //    public string Name;
    //    public int Id;
    //    public string Department;
    //}
    internal class Q5
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee{Name="A",Id=1,Department="IT"},
                new Employee{Name="B",Id=2,Department="HR"},
                new Employee{Name="C",Id=3,Department="IT"},
                new Employee{Name="D",Id=4,Department="Fin"},
                new Employee{Name="E",Id=5,Department="HR"},
                new Employee{Name="F",Id=6,Department="IT"}
            };

            var result = employees.GroupBy(e => e.Department)
                                  .Select(group => new
                                  { 
                                      Dept= group.Key,
                                      Count = group.Count()
                                  });

            foreach(var d in  result)
            {
                Console.WriteLine($"Department :{d.Dept} -- Count = {d.Count}");
            }
        }
    }
}
