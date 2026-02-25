using System;
using System.Collections.Generic;
using System.Text;

//2.Sorting with Lambda
//Write a program to sort a list of integers in descending order using LINQ’s
//OrderByDescending with a lambda expression and print the result.


namespace LINQPractice.LinqQuestions
{
    internal class Q1_2
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 2, 8, 1, 10, 3, 6, 9, 4, 7 };

            var result = numbers.OrderByDescending(n=>n);

            Console.WriteLine("Order by Descending");

            foreach(var n in result)
            {
                Console.Write($"{n}, ");
            }
        }
    }
}
