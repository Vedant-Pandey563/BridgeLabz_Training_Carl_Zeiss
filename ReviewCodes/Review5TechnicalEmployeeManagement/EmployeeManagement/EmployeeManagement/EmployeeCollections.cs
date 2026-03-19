using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement
{
    internal class EmployeeCollections
    {
        //list of employess
        private List<Employee> employeeList;

        //dictionary of emp
        private Dictionary<int, Employee> employeeDictionary;

        //dict for dept grp
        private Dictionary<string, List<Employee>> departmentDictionary;

        public EmployeeCollections()
        {
            employeeList = new List<Employee>();
            employeeDictionary = new Dictionary<int, Employee>();
            departmentDictionary = new Dictionary<string, List<Employee>>();
        }

        public void AddEmployee(Employee employee)
        {
            // Check duplicate ID
            if (employeeDictionary.ContainsKey(employee.ID))
            {
                throw new EmployeeExceptions("Duplicate ID.");
            }
            // Add in list
            employeeList.Add(employee);

            // Add in dict
            employeeDictionary.Add(employee.ID, employee);

            if (!departmentDictionary.ContainsKey(employee.Department))//check if dept exist in dict
            {
                departmentDictionary[employee.Department] = new List<Employee>();//add new dept 
            }

            departmentDictionary[employee.Department].Add(employee);
        }

        //getting emp by id
        public Employee GetEmployeeById(int id)
        {
            if (employeeDictionary.ContainsKey(id))
            {
                return employeeDictionary[id];
            }
            return null;
        }

        //get all emp
        public List<Employee> GetAllEmployees()
        {
            return employeeList;
        }

        //get emp by dept
        public List<Employee> GetEmployeesByDepartment(string department)
        {
            if (departmentDictionary.ContainsKey(department))
            {
                return departmentDictionary[department];
            }

            return new List<Employee>();
        }


        public void RemoveEmployee(int id)
        {
            if (!employeeDictionary.ContainsKey(id))
            {
                throw new EmployeeExceptions("Employee not found.");
            }

            //new emp obj
            Employee employee = employeeDictionary[id];

            // Remove from List
            employeeList.Remove(employee);

            // Remove from Dictionary
            employeeDictionary.Remove(id);
        }

        // Display All Employees
        public void DisplayAllEmployees()
        {
            foreach (var employee in employeeList)
            {
                employee.Display();
            }
        }
    }
}
