using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPractice
{
    internal class MatchFirstDigit
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Matching First Occurence of digits in input");
            Console.WriteLine("Enter String Input : ");
            string input = Console.ReadLine();

            Regex regex= new Regex(@"\d+");

            Match match = regex.Match(input);

            if(match.Success)
            {
                Console.WriteLine("First match is :" +match.Value);
                Console.WriteLine("Match index is : " +match.Index);
                Console.WriteLine("Match length is :" +match.Length);
            }
            else
            {
                Console.WriteLine("No match");
            }

        }
    }
}
