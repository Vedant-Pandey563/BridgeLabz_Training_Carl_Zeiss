using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementApp
{
    public class InvalidCategoryException : Exception
    {
        public InvalidCategoryException(string message) : base(message)
        { 

        }
    }
}
