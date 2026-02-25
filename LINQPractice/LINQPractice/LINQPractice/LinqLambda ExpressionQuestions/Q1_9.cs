using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

//9.Any, All, Contains
//Given a list of integers, use LINQ to check:
//If any number is negative
//If all numbers are positive

namespace LINQPractice.LinqQuestions
{
    internal class Q1_9
    {
        static void Main(string[]args)
        {
            int[] numbers = { 5, 2, 8, 1, 10, 3, 6, 9, 4, 7 };

            bool NegativeCheck = numbers.Any(n => n < 0);
            bool PositiveCheck = numbers.All(n => n > 0);

            Console.WriteLine($"Any negative numbers {NegativeCheck} or All Postive Numbers {PositiveCheck}");

        }
    }
}
