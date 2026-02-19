using System;
using System.Text.RegularExpressions;


namespace RegexPractice
{
    internal class ValidEmail
    {
        static bool IsValidEmail(string email) 
        {
            string pattern = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";

            Regex regex = new Regex(pattern);

            return regex.IsMatch(email);    
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Regex Pracitce");
            Console.WriteLine("Email Validation");

            Console.WriteLine("Please enter email id : ");
            string email = Console.ReadLine();

            Console.WriteLine("Given email is : " + (IsValidEmail(email)));
            


        }
    }
}
