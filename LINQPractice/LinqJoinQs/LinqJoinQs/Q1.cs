using System;
using System.Collections.Generic;
using System.Text;

//1.Perform an inner join between Employees and Departments to display employee name and
//department name

namespace LinqJoinQs
{
    public class Employee
    {
        public int Id;
        public string Name;
        public int DeptId;
    }
    public class Department
    {
        public string DeptName;
        public int DeptId;
    }
    internal class Q1
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee{Id=1, Name="A", DeptId=101},
                new Employee{Id=2, Name="B", DeptId=102},
                new Employee{Id=3, Name="C", DeptId=103},
                new Employee{Id=4, Name="D", DeptId=101}
            };

            List<Department> departments = new List<Department>()
            {
                new Department{DeptId=101, DeptName="IT"},
                new Department{DeptId=102, DeptName="HR"},
                new Department{DeptId=103, DeptName="Finance"}
            };

            var result = employees.Join(
                departments, //inner table
                emp => emp.DeptId, // key1
                dept => dept.DeptId, // key2
                (emp, dept) => new // declare
                {
                    EmployeeName = emp.Name,
                    DepartmentName = dept.DeptName
                }
                );

            Console.WriteLine("Employye with Department");

            foreach (var r in result)
            {
                Console.WriteLine($"Employee Name :{r.EmployeeName} -- Department : {r.DepartmentName} ");
            }

        }
    }
}
