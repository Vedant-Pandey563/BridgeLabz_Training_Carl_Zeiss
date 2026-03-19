using System;

class Person
{
    public string Name { get; set; }

    public void DisplayName()
    {
        Console.WriteLine($"Name: {Name}");
    }
}

class Employee : Person   // Inheritance is-a
{
    public int EmployeeId { get; set; }

    public void DisplayEmployee()
    {
        Console.WriteLine($"Employee ID: {EmployeeId}");
    }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee();

        emp.Name = "A";

        emp.EmployeeId = 101;

        // Inherit
        emp.DisplayName();

        // Child
        emp.DisplayEmployee();
    }
}
