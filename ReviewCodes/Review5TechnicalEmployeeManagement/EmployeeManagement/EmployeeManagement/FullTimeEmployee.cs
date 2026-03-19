using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement
{
    public class FullTimeEmployee : Employee
    {
        private double monthlySalary;

        public double MonthlySalary
        {
            get { return monthlySalary; }
            set
            {
                if (value <= 0)
                    throw new EmployeeExceptions("Monthly salary greater than 0");

                monthlySalary = value;
            }
        }

        public FullTimeEmployee(int id,string name,string email,string phone,string department,double monthlySalary)
           : base(id, name, email, phone, department)
        {
            MonthlySalary = monthlySalary;
        }

        public override double CalculateSalary()
        {
            return MonthlySalary;
        }

        public override void Display()
        {
            Console.WriteLine($"Employee Type: Full Time Employee");
            Console.WriteLine($"Monthly Salary: {MonthlySalary}");
            Console.WriteLine();
        }
    }
}
