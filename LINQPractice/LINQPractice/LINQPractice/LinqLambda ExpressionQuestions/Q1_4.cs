using System;
using System.Collections.Generic;
using System.Text;

//4.Projection using Select
//Given a list of Student objects (Id, Name, Marks), use LINQ to project only Name and Grade
//(Grade = Pass if Marks ≥ 40 else Fail)

namespace LINQPractice.LinqQuestions
{
    public class Student
    {
        public string Name;
        public int Id;
        public int Marks;
    }
    internal class Q1_4
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student{Name="A",Id=1,Marks=30},
                new Student{Name="B",Id=2,Marks=50},
                new Student{Name="C",Id=3,Marks=40},
                new Student{Name="D",Id=4,Marks=70},
                new Student{Name="E",Id=5,Marks=41},
            };

            var result = students.Select(s => new
            {
                Name = s.Name,
                Grade = s.Marks>40?"Pass":"Fail"
            });

            Console.WriteLine("Student Results");
            foreach(var r in result)
            {
                Console.WriteLine($"{r.Name} -- {r.Grade}");
            }

        }

    }
}
