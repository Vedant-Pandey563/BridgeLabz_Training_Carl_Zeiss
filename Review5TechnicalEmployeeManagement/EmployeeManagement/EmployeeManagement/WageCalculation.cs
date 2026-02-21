using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement
{
    internal class WageCalculation
    {
        private EmployeeCollections collect;

        public WageCalculation(EmployeeCollections collect)
        {
            this.collect = collect;
        }

        public double GetTotalSalaryExpense()
        {
            double total = 0;

            List<Employee> employees = collect.GetAllEmployees();//getting all emps

            foreach (var employee in employees)
            {
                total += employee.CalculateSalary();
            }

            return total;
        }

        public Employee GetHighestPaidEmployee()
        {
            List<Employee> employees = collect.GetAllEmployees();

            if (employees.Count == 0)
            {
                return null;
            }

            Employee highest = employees[0];//inital first emp as highest 

            foreach (var employee in employees)
            {
                if (employee.CalculateSalary() > highest.CalculateSalary()) //compare salary
                {
                    highest = employee;
                }
            }

            return highest;
        }

        public double GetAverageSalary()
        {
            List<Employee> employees = collect.GetAllEmployees();

            if (employees.Count == 0)
            {
                return 0;
            }

            double total = GetTotalSalaryExpense(); //using total salry

            return total / employees.Count;
        }

        public void DisplaySalarySummary()
        {
            Console.WriteLine("Salary Calclations");

            Console.WriteLine($"Total Salary Expense: {GetTotalSalaryExpense()}");

            Employee highest = GetHighestPaidEmployee();

            if (highest != null)
            {
                Console.WriteLine("Highest Paid Employee:");
                highest.Display();
            }

            Console.WriteLine($"Average Salary: {GetAverageSalary()}");
            Console.WriteLine();

        }

    }
}
