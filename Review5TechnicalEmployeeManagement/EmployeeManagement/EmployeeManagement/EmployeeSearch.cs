using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement
{
    internal class EmployeeSearch
    {

        private List<Employee> employees;

        public EmployeeSearch(List<Employee> employees)
        {
            this.employees = employees;
        }


        // Search employee by ID
        public Employee SearchById(int id)
        {
            foreach (Employee emp in employees)
            {
                if (emp.ID == id)
                {
                    return emp;
                }
            }
            return null;
        }


        // Search employee by Name
        public List<Employee> SearchByName(string name)
        {
            List<Employee> result = new List<Employee>();

            foreach (Employee emp in employees)
            {
                if (emp.Name.Equals(name))
                {
                    result.Add(emp);
                }
            }

            return result;

        }
    }
}
