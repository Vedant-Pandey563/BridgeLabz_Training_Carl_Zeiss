using System;
using System.Collections.Generic;
using System.Text;

//8.String Operations with LINQ
//Given a list of strings, write a LINQ query to find all strings that start with the letter ‘A’ and have a
//length greater than 5.

namespace LINQPractice.LinqQuestions
{
    internal class Q1_8
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> { "abc", "apples", "hello", "donkey", "alligator", "rome", "america", "pop" };

            var result = list.Where(s => s.StartsWith("a") && s.Length > 5);

            Console.WriteLine("Strings starting with a and length>5 ");
            foreach(var r in result)
            {
                Console.Write($"{r} ,");
            }
        }
    }
}
