using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement
{
    public class ContractEmployee : Employee
    {
        private double contractAmount;
        private int contractMonths;

        public double ContractAmount
        {
            get { return contractAmount; }
            set
            {
                if (value <= 0)
                    throw new EmployeeExceptions("Contract amount greater than 0.");

                contractAmount = value;
            }
        }
        public int ContractMonths
        {
            get { return contractMonths; }
            set
            {
                if (value <= 0)
                    throw new EmployeeExceptions("Contract duration must be greater 1.");

                contractMonths = value;
            }
        }
        public ContractEmployee(int id, string name, string email, string phone, string department, double contractAmount,
            int contractMonths)
           : base(id, name, email, phone, department)
        {
            Console.WriteLine(" this is Contract employee");
            ContractAmount = contractAmount;
            ContractMonths = contractMonths;
        }

        public override double CalculateSalary()
        {
            return ContractAmount / ContractMonths;
        }

        public override void Display()
        {
            Console.WriteLine("Employee Type: Contract");
            Console.WriteLine($"Contract Amount: {ContractAmount}");
            Console.WriteLine($"Duration (Months): {ContractMonths}");
            Console.WriteLine($"Monthly Salary: {CalculateSalary()}");
            Console.WriteLine();
        }
    }
}
