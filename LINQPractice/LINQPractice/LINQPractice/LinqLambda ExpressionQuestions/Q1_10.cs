using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Xml.Linq;

//10.Joining Collections
//Given two collections:
//Employee(Id, Name, DepartmentId)
//Department(DepartmentId, DepartmentName)
//Use LINQ with lambda expressions to join both collections and display Employee Name
//along with Department Name .

namespace LINQPractice.LinqQuestions
{
    public class Employees
    {
        public int Id;
        public string Name;
        public int DeptId;
    }
    public class Department
    {
        public string DepartmentName;
        public int DeptId;
    }

    internal class Q1_10
    {
        static void Main(string[] args)
        {
            List<Employees> employees = new List<Employees>()
            {
                new Employees{Id=1, Name="A", DeptId=101},
                new Employees{Id=2, Name="B", DeptId=102},
                new Employees{Id=3, Name="C", DeptId=103},
                new Employees{Id=4, Name="D", DeptId=101}
            };

            List<Department> departments = new List<Department>()
            {
                new Department{DeptId=101, DepartmentName="IT"},
                new Department{DeptId=102, DepartmentName="HR"},
                new Department{DeptId=103, DepartmentName="Finance"}
            };

            var result = employees.Join(
                departments, //inner table
                emp => emp.DeptId, // key1
                dept => dept.DeptId, // key2
                (emp, dept) => new // declare
                {
                    EmployeeName = emp.Name, 
                    DepartmentName = dept.DepartmentName
                }
                );

            Console.WriteLine("Employye with Department");

            foreach(var r in result)
            {
                Console.WriteLine($"Employee Name :{r.EmployeeName} -- Department : {r.DepartmentName} ");
            }

        }
    }
}
