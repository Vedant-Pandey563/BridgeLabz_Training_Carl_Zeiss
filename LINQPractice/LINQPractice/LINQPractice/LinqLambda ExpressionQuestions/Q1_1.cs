using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

//1.Filtering with Conditions
//Given a list of Employee objects (Name, Department, Salary), write a LINQ query using a lambda
//expression to fetch all employees whose salary is greater than ₹50,000 and belong to the "IT"
//department.


namespace LINQPractice.LinqQuestions
{
    public class Employee
    {
        public string Name;
        public int Salary;
        public string Department;
    }


    internal class Q1_1
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee{Name="A", Salary=60000, Department="IT"},
                new Employee{Name="B", Salary=30000, Department="HR"},
                new Employee{Name="C", Salary=40000, Department="IT"}
            };

            var result = employees.Where(e => e.Department == "IT" && e.Salary > 50000);

            Console.WriteLine("IT department employee with salary>50000");

            foreach(var e in result)
            {
                Console.WriteLine($"{e.Name} -- {e.Salary} -- {e.Department}");
            }
        }
    }
}
