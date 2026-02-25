using System;
using System.Collections.Generic;
using System.Text;

namespace LINQPractice.LinqBasics
{
    internal class LinqElementOps
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 2, 8, 1, 10, 3, 6, 9, 4, 7 };
            int first = numbers.First();
            Console.WriteLine("Using First() " +first);

            int[] mt = { };
            int empty = mt.FirstOrDefault();
            Console.WriteLine("FirstorDefault() " +empty);

            int[] one = { 1 };
            int single = one.Single();
            Console.WriteLine("Single " +single);

            int at = numbers.ElementAt(5);
            Console.WriteLine("Element at 5 " +at);

            bool result = numbers.Any(n => n > 8);
            Console.WriteLine("Any op , n>8 " +result);
            bool result2 = numbers.All(n => n > 5);
            Console.WriteLine("All op, n>5 " +result2);
            bool result3 = numbers.Contains(4);
            Console.WriteLine("Contains op, checking for 4 " +result3);
        }
    }
}
