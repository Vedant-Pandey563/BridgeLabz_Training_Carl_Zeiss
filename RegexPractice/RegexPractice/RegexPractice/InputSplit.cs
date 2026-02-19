using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPractice
{
    internal class InputSplit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string sentence:");
            string input = Console.ReadLine();


            Console.WriteLine("Split by whitespace");
            string[] words = Regex.Split(input,@"\s");

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine("Split by multiple delimiters");
            string[] result = Regex.Split(input, @"[,;:\s]");
            
            foreach (string word in result)
            {
                Console.WriteLine(word); 
            }
        }
    }
}
