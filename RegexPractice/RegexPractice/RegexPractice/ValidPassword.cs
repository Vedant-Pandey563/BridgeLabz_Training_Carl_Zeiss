    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    namespace RegexPractice
    {
        internal class ValidPassword
        {
            static bool IsValidPassword(string password)
            {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@$%&*?]).{8,}$";

                Regex rg = new Regex(pattern);

                return rg.IsMatch(password);
            }

            static void Main(string[] args)
            {
                Console.WriteLine("Password Valid");
                Console.WriteLine("Enter the password : ");
                string password = Console.ReadLine();

                Console.WriteLine("Password wntered is : " +(IsValidPassword(password)));
            }
        }
    }
