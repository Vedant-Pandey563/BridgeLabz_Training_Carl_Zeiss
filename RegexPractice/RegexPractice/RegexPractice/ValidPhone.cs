using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPractice
{
    internal class ValidPhone
    {

        static bool IsValidPhone(string phone)
        {
            string pattern = @"^[0-9]{10}$";

            Regex reg = new Regex(pattern);

            return reg.IsMatch(phone);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Phone Number Validation");
            Console.WriteLine("Enter Phone Number : ");
            string phone = Console.ReadLine();

            Console.WriteLine("Phone number entered is : " + (IsValidPhone(phone)) );
        
        }

    }
}
