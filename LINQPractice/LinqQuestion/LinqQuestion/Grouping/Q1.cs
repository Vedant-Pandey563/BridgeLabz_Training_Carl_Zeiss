using System;
using System.Collections.Generic;
using System.Text;

//1.Given a list of Employee objects ( Id , Name, Department ), group employees by
//Department and display each department with employee names

namespace LinqQuestion.Grouping
{
    public class Employee
    {
        public string Name;
        public int Id;
        public string Department;
    }
    internal class Q1
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee{Name="A",Id=1,Department="IT"},
                new Employee{Name="B",Id=2,Department="HR"},
                new Employee{Name="C",Id=3,Department="Fin"},
                new Employee{Name="D",Id=4,Department="Fin"},
                new Employee{Name="E",Id=5,Department="HR"},
                new Employee{Name="F",Id=6,Department="IT"}
            };

            var result = employees.GroupBy(e => e.Department)
                                  .Select(group => new
                                  {
                                      Department = group.Key,
                                      Name = group.Select(e=>e.Name)
                                  });

            foreach(var dept in  result)
            {
                Console.WriteLine($"Department:{dept.Department}");
                foreach(var name in dept.Name)
                {
                    Console.WriteLine($"Employee Name: {name}");
                }
            }
        }
    }
}
