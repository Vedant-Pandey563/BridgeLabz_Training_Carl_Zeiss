using System;
using System.Collections.Generic;
using System.Text;

namespace LINQPractice.LinqBasics
{
    public class Employee
    {
        public string EmpName;
        public int EmpId;
        public int DeptId;
    }

    public class Department
    {
        public string DeptName;
        public int DeptId;
        public string Location;
    }
    internal class EmployeeQ2
    {
        static void Main(string[]args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee{EmpName="A",EmpId=1,DeptId=101},
                new Employee{EmpName="B",EmpId=2,DeptId=102},
                new Employee{EmpName="C",EmpId=3,DeptId=102},
                new Employee{EmpName="D",EmpId=4,DeptId=101},
            };

            List<Department> departments = new List<Department>()
            {
                new Department{DeptName="IT",DeptId=101,Location="Chennai"},
                new Department{DeptName="Finance",DeptId=102,Location="Blr"},
            };

            var result = employees.Join
                (departments,
                    emp => emp.DeptId,
                    dept => dept.DeptId,
                    (emp,dept) => new
                    {
                        EmployeeName = emp.EmpName,
                        DepartmentName = dept.DeptName,
                        Location = dept.Location
                    }
                );

            foreach(var r in result)
            {
                Console.WriteLine($"Employee Name:{r.EmployeeName} -- Department Name:{r.DepartmentName} -- Location: {r.Location}");
            }
        }
    }
}
