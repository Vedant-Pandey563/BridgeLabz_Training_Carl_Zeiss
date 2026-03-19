using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement
{
    public abstract class Employee // employee base class
    {
        private int id;
        private string name;
        private string email;
        private string phone;
        private string department;

        public int ID
        {
            get { return id; }

            set
            {
                if (value <= 0)
                    throw new EmployeeExceptions("Employee ID must be positive."); // id > 1

                id = value;
            }
        }

        //getting and setting emp values 
        //each setter has custom exception for it
        public string Name
        {
            get { return name; }
            set 
            {
                if (!EmployeeValidator.IsValidName(value))
                {
                    throw new EmployeeExceptions("Invalid Name format.");
                }
                name = value;
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                if (!EmployeeValidator.IsValidEmail(value))
                {
                    throw new EmployeeExceptions("Invalid Email format.");
                }
                email = value;
            }
        }
        public string Phone
        {
            get { return phone; }
            set
            {
                if (!EmployeeValidator.IsValidPhone(value))
                {


                    throw new EmployeeExceptions("Invalid Phone Number.");
                }
                phone = value;
            }
        }
        public string Department
        {
            get { return department; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new EmployeeExceptions("Department cannot be empty.");
                }
                department = value;
            }
        }

        public Employee(int id,string name, string email, string phone, string department) // base constructor
        {
            Console.WriteLine("this is Employee");
            ID= id;
            Name = name;
            Email = email;
            Phone = phone;
            Department = department;
        }

        public abstract double CalculateSalary(); //abstract class for child emp salry calc

        public virtual void Display()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Phone: {phone}");
            Console.WriteLine($"Department: {department}");
        }
    }
}
