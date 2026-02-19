using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPractice
{
    internal class MatchAllNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matching All Occurence of digits in input");
            Console.WriteLine("Enter String Input : ");
            string input = Console.ReadLine();
            Console.WriteLine();

            Regex regex = new Regex(@"\d+");

            MatchCollection matches = regex.Matches(input);

            if(matches.Count>0)
            {
                Console.WriteLine(matches.Count +"  matches found");
                foreach (Match match in matches)
                {
                    Console.WriteLine(match.Value);
                }
            }
            else
            {
                Console.WriteLine("No matches");
            }
            
        }
    }
}
