using System;
using System.Collections.Generic;
using System.Text;

//7.Grouping with Count
//Given a list of Employee objects (Id, Name, Department), use LINQ to group employees by
//department and display the number of employees in each department.

namespace LINQPractice.LinqQuestions

{
    //public class Employee
    //{
    //    public string Name;
    //    public int Salary;
    //    public string Department;
    //}
    internal class Q1_7
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee{Name="A", Salary=60000, Department="IT"},
                new Employee{Name="B", Salary=30000, Department="HR"},
                new Employee{Name="E", Salary=50000, Department="HR"},
                new Employee{Name="D", Salary=80000, Department="CEO"},
                new Employee{Name="E", Salary=40000, Department="IT"}
            };

            var result = employees.GroupBy(e => e.Department)
                .Select(group=>new
                {
                    Department = group.Key,
                    EmployeeCount = group.Count()
                });

            Console.WriteLine("Groping by Department");

            foreach(var r in result)
            {
                Console.WriteLine($"Department: {r.Department} ,Count: {r.EmployeeCount} ");
            }

        }
    }
}
