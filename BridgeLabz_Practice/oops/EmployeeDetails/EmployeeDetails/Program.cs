using System;

namespace EmployeeDetails
{
    class Employee
    {
        private string name;
        private int id;
        private string department;
        private double salary;

        public Employee(string name, int id, string department,double salary)// constructor to intialize and use private employee attributes
        {
            this.name = name;
            this.id = id;
            this.department = department;
            this.salary = salary;
        }

       public void DisplayDetails() //display employee details
        {
            Console.WriteLine("Employee Details:");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Department: {department}");
            Console.WriteLine($"Salary: {salary}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Enter Employee Details:");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Id:");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Department: ");
            string department = Console.ReadLine();

            Console.WriteLine("Salary :");
            double salary = Convert.ToDouble(Console.ReadLine());

            Employee emp = new Employee(name, id, department, salary);

            emp.DisplayDetails();

            Console.ReadLine();

        }
    }
}
