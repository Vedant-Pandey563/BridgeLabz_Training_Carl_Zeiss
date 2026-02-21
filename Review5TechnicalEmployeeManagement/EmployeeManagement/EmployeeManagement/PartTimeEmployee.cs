using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement
{
    public class PartTimeEmployee : Employee
    {
        private double hourlyRate;
        private int hoursWorked;

        public double HourlyRate
        {
            get { return hourlyRate; }
            set
            {
                if (value <= 0)
                    throw new EmployeeExceptions("Hourly salary greater than 0");

                hourlyRate = value;
            }
        }

        public int HoursWorked
        {
            get { return hoursWorked; }
            set
            {
                if (value < 0) // max hours in month
                    throw new EmployeeExceptions("Invalid hours worked.");

                hoursWorked = value;
            }
        }

        public  PartTimeEmployee(int id, string name, string email, string phone, string department, double hourlyRate,
            int hoursWorked)
           : base(id, name, email, phone, department)
        {
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }

        public override double CalculateSalary()
        {
            return hourlyRate * HoursWorked;
        }

        public override void Display()
        {
            Console.WriteLine("Employee Type: Part Time");
            Console.WriteLine($"Hourly Rate: {HourlyRate}");
            Console.WriteLine($"Hours Worked: {HoursWorked}");
            Console.WriteLine($"Salary: {CalculateSalary()}");
            Console.WriteLine();
        }
    }
}
