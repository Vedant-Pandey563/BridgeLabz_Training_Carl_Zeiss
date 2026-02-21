using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement
{
    internal class DuplicateDetect
    {
        public static string FindDuplicateEmail(List<Employee> employees)
        {
            HashSet<string> emailSet = new HashSet<string>();// uniq value O(1) 

            foreach (Employee emp in employees)
            {
                if (emailSet.Contains(emp.Email))
                {
                    return emp.Email;
                }

                emailSet.Add(emp.Email);
            }

            return null;
        }
    }
}
