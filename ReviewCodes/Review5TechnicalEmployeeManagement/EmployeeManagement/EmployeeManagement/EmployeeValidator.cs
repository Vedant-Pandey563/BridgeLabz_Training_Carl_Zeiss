using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace EmployeeManagement
{
    internal static class EmployeeValidator
    {
        //regex fields
        static readonly Regex nameRegex = new Regex(@"^[A-Za-z ]{2,}$");
        static readonly Regex emailRegex = new Regex(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$");
        static readonly Regex phoneRegex = new Regex(@"^[6-9]\d{9}$");

        //regex mthods
        public static bool IsValidName(string name)
        {
            return nameRegex.IsMatch(name);
        }

        public static bool IsValidEmail(string email)
        {
            return emailRegex.IsMatch(email);
        }


        public static bool IsValidPhone(string phone)
        {
            return phoneRegex.IsMatch(phone);
        }
    }
}
