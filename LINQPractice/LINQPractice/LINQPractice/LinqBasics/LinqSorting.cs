using System;
using System.Collections.Generic;
using System.Text;

namespace LINQPractice.LinqBasics
{
    internal class LinqSorting
    {
        static void Main()
        {
            int[] numbers = { 5, 2, 8, 1, 10, 3 , 6, 9,4,7 };

            Console.WriteLine("OrderBy sort");
            var sort = numbers.OrderBy(n => n);

            foreach( var n in sort)
            {
                Console.Write($"{n}, ");
            }
            Console.WriteLine();

            Console.WriteLine("OrderByDescending Sort");
            var revsort = numbers.OrderByDescending(n => n);

            foreach( var n in revsort)
            {
                Console.Write($"{n}, ");
            }
            Console.WriteLine();

            List<Student> students = new List<Student>()
            {
                new Student { Name = "A", Marks = 66 },
                new Student { Name = "D", Marks = 76 },
                new Student { Name = "B", Marks = 76 },
                new Student { Name = "C", Marks = 90 }
            };

            Console.WriteLine("ThenBy sort");
            var sorted = students
                .OrderBy(s => s.Marks)
                .ThenBy(s => s.Name);
            
            foreach(var s in sorted)
            {
                Console.WriteLine($"{s.Name} : {s.Marks}");
            }
            Console.WriteLine();
        }
    }
}
