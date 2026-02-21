using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement
{
    internal class EmployeeExceptions : Exception //custom class for exmployee data field
    {
        public EmployeeExceptions() 
        {
        }

        public EmployeeExceptions(string message)
            : base(message)
        {
        }
    }
}

