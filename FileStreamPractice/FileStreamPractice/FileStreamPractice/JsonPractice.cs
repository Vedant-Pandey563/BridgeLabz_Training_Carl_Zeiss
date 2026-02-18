using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace FileStreamPractice
{
    public class student
    {
       public int id { get; set; }
       public string name { get; set; }
       public int age { get; set; }
       public int marks { get; set; }
    }

    internal class JsonPractice
    {
        static void Main(string[] args)
        {
            student s = new student()
            {
                id = 101,
                name = "G-Obi",
                age = 34,
                marks=67
            };

            string json = JsonSerializer.Serialize(s);

            File.WriteAllText("student.json", json);
            Console.WriteLine("Created JSON file");


            //reading json data
            Console.WriteLine("Readind JSON Data");

            string json2 = File.ReadAllText("student.json");

            student s2 = JsonSerializer.Deserialize<student>(json2);

            Console.WriteLine(s2.id);
            Console.WriteLine(s2.name);
            Console.WriteLine(s2.age);
            Console.WriteLine(s2.marks);


        }
    }
}
