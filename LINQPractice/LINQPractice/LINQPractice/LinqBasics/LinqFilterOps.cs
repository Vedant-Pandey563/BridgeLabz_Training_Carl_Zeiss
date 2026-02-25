using System;
using System.Collections.Generic;
using System.Text;

namespace LINQPractice.LinqBasics
{
    public class Student
    {
        public string Name;
        public int Marks;
    }
    internal class LinqFilterOps
    {
        static void Main()
        {
           List<Student> students = new List<Student> ()
            {
                new Student { Name = "A", Marks = 66 },
                new Student { Name = "B", Marks = 76 },
                new Student { Name = "C", Marks = 68 }
            };

            var toppers = students.Where(s => s.Marks > 75);

            foreach(var s in toppers)
            {
                Console.WriteLine(s.Name);
            }
        }
    }
}
