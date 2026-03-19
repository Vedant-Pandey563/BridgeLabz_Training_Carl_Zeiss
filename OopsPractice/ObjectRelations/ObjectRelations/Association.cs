using System;

class Student
{
    public string Name { get; set; }

    public Student(string name)
    {
        Name = name;
    }

    public void Learn(Teacher teacher)
    {
        Console.WriteLine($"{Name} is studying from {teacher.Name}");
    }
}

class Teacher
{
    public string Name { get; set; }

    public Teacher(string name)
    {
        Name = name;
    }

    public void Teach(Student student)
    {
        Console.WriteLine($"{Name} is teaching {student.Name}");
    }
}

class Program
{
    static void Main()
    {
        Student s1 = new Student("ab");
        Teacher t1 = new Teacher("Mr.x");

        t1.Teach(s1);
        s1.Learn(t1);

    }
}