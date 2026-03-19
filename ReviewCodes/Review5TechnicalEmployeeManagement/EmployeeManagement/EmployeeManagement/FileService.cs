using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace EmployeeManagement
{
    internal class FileService
    {
        private string filePath; //creating new filepath

        public FileService(string filePath)
        {
            this.filePath = filePath;
        }

        // method to write employee data
        public void SaveEmployees(List<Employee> employees)
        {
            // StreamWriter writes text to file
            using (StreamWriter writer = new StreamWriter(filePath))
            {

                foreach (Employee emp in employees)
                {
                    Console.WriteLine(emp);
                    writer.WriteLine("ID: " + emp.ID);
                    writer.WriteLine("Name: " + emp.Name);
                    writer.WriteLine("Email: " + emp.Email);
                    writer.WriteLine("Phone: " + emp.Phone);
                    writer.WriteLine("Department: " + emp.Department);
                    writer.WriteLine("Salary: " + emp.CalculateSalary());
                    writer.WriteLine();
                }
            }

            Console.WriteLine("Employees saved to file successfully.");
        }

        public void ReadEmployees()
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found.");
                return;
            }

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;

                Console.WriteLine("Reading from File");
                Console.WriteLine();

                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}

