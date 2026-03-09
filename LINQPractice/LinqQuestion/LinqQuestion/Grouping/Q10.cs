using LinqQuestion.Grouping;
using System;
using System.Collections.Generic;
using System.Text;

//10.Group students by Pass / Fail status (Marks ≥ 40 → Pass) and count how many students fall into
//each group.


namespace LinqQuestion.Grouping
{
    //public class Student
    //{
    //    public string Name;
    //    public string Class;
    //    public int Marks;
    //}
    internal class Q10
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
                new Student{Name="F",Class="10B",Marks=37},
            };

            var result = students.GroupBy(s => (s.Marks >= 40 ? "Pass" : "Fail"))
                                 .Select(group => new 
                                 {
                                    Status = group.Key,
                                     Count = group.Count()
                                 });

            foreach (var r in result)
            {
                Console.WriteLine($"{r.Status} -- {r.Count}");
            }

        }
    }
}
