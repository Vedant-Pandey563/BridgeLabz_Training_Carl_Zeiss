using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPractice
{
    internal class ReplaceNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Replacing All Occurence of digits in input");
            Console.WriteLine("Enter String Input : ");
            string input = Console.ReadLine();
            Console.WriteLine();

            Regex regex = new Regex(@"\d+");

            string result = regex.Replace(input, " ..X.. ");

            Console.WriteLine("Replced string : " +result);
        }
    }
}
