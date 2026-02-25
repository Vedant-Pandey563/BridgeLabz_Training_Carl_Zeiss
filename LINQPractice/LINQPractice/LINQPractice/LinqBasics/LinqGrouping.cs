using System;
using System.Collections.Generic;
using System.Text;

namespace LINQPractice.LinqBasics
{
    internal class LinqGrouping
    {
        static void Main(string[] args )
        {
            Console.WriteLine("Grouping");

            int[] numbers = { 5, 2, 8, 1, 10, 3, 6, 9, 4, 7 };

            var grps = numbers.GroupBy(n=> n%2 );

            foreach(var g in grps)
            {
                Console.WriteLine("Grp key: " + g.Key);

                foreach(var num in g)
                {
                    Console.WriteLine(num);
                }
            }
            Console.WriteLine();

            List<Student> students = new List<Student>()
                {
                    new Student { Name="A", Marks=80 },
                    new Student { Name="B", Marks=40 },
                    new Student { Name="C", Marks=62 },
                    new Student { Name="D", Marks=60 }
                };

            var groups = students.GroupBy(s => s.Marks/10);

            foreach (var group in groups)
            {
                Console.WriteLine("Marks: " + group.Key);

                foreach (var student in group)
                    Console.WriteLine(student.Name);
            }

            Console.WriteLine();
            Console.WriteLine("Aggregation");

            int count = numbers.Count();
            Console.WriteLine("Count : " +count);
            int CondCount = numbers.Count(n => n>3);
            Console.WriteLine("Conditional Count " +CondCount);
            int sum = numbers.Sum();
            Console.WriteLine("Sum "+sum);
            int CondSum = numbers.Sum(n => n % 3);
            Console.WriteLine("Conditional Sum " +CondSum);
            int min = numbers.Min();
            Console.WriteLine("Minimum " +min);
            int max = numbers.Max();
            Console.WriteLine("Maximum "+max);
            double avg = numbers.Average();
            Console.WriteLine("Average "+avg);

            Console.WriteLine("Custom Aggregate");
            int aggr = numbers.Aggregate((a, b) => a * b);
            Console.WriteLine(aggr);

            int[] same = { 1, 1, 3, 6, 5, 7, 4, 3, 5, 7 };

            var unique = numbers.Distinct();
            foreach (var n in unique)
            {
                Console.Write($"{n}, " );
            }
        }
    }
}
