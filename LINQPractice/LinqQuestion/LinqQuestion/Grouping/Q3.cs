using System;
using System.Collections.Generic;
using System.Text;

//3.Group a list of students ( Name , Class, Marks ) by Class and find the highest marks in each
//class.

namespace LinqQuestion.Grouping
{
    public class Student
    {
        public string Name;
        public string Class;
        public int Marks;
    }
    internal class Q3
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student{Name="A",Class="10A",Marks=67},
                new Student{Name="B",Class="10B",Marks=96},
                new Student{Name="C",Class="10C",Marks=83},
                new Student{Name="D",Class="10A",Marks=66},
                new Student{Name="E",Class="10C",Marks=50},
                new Student{Name="F",Class="10B",Marks=77},
            };

            var result = students.GroupBy(s => s.Class)
                .Select(group => new
                {
                    Class = group.Key,
                    Marks = group.Max(s=>s.Marks)
                });

            foreach(var c in result)
            {
                Console.WriteLine($"Class: {c.Class} -- Highest Mark: {c.Marks}");
            }
        }
    }
}
