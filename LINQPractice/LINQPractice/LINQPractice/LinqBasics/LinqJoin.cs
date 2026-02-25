using System;
using System.Collections.Generic;
using System.Text;

namespace LINQPractice.LinqBasics
{
    public class Students
    {
        public int Id;
        public string Name;
    }
    public class Marks
    {
        public int StudentId;
        public int Score;
    }
    internal class LinqJoin
    {
        static void Main(string[] args)
        {
            List<Students> student = new List<Students>()
            {
                new Students{Id= 1, Name="A"},
                new Students{Id= 2, Name="B"}
            };

            List<Marks> marks = new List<Marks>()
            {
                new Marks {StudentId =1, Score=90 }, 
                new Marks {StudentId =2, Score=80 } 
            };

            var result = student.Join(
                                      marks,
                                      s => s.Id,
                                      m => m.StudentId,
                                      (s,m)=>new
                                      {
                                          Name = s.Name,
                                          Score=m.Score
                                      }
                                        );

            foreach(var r in result)
            {
                Console.WriteLine($"{r.Name} -- {r.Score}");
            }


            Console.WriteLine();
        }
    }
}
