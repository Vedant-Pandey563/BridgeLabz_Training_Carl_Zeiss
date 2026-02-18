using System;
using System.Collections.Generic;
using System.Text;

namespace FileStreamPractice
{
       
    public class Student
    {
        public int Id;
        public string Name;
        public int age;
        public int marks;
    }
    internal class CsvObject
    {
        static void Main(string[] args)
        {
            List<Student> students2 = new List<Student>()
            { new Student{Id=4,Name = "jjk",age=21, marks=0},
              new Student {Id=5,Name = "abc", age=44, marks = 71}
            };

            using (StreamWriter sw = new StreamWriter("students.csv"))
            {
                sw.WriteLine("Id,Name,Age,Marks");


                foreach (Student s in students2)
                {
                    sw.WriteLine(
                     $"{s.Id},{s.Name},{s.age},{s.marks}");
                }
            }



            //reading csv as objects
            List <Student> students = new List <Student> ();

            using (StreamReader sr = new StreamReader("students.csv")) 
            {
                sr.ReadLine();

                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split(',');
                    Student s = new Student();

                    s.Id = int.Parse(data[0]);
                    s.Name = data[1];
                    s.age = int.Parse(data[2]);
                    s.marks = int.Parse(data[3]);

                    students.Add(s);
                }
            }

            foreach (Student s in students)
            {
                Console.WriteLine($"Id : {s.Id} , Name : {s.Name} , Age : {s.age} , Marks: {s.marks} ");
            }
        }
    }
}
