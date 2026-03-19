using System;
using System.Collections.Generic;

class Professor
{
    public string Name { get; set; }

    public Professor(string name)
    {
        Name = name;
    }
}

class Department
{
    public string DeptName { get; set; }
    public List<Professor> Professors { get; set; }

    public Department(string deptName, List<Professor> professors)
    {
        DeptName = deptName;

        Professors = professors;
    }

    public void ShowProfessors()
    {
        Console.WriteLine($" Department: {DeptName}");
        foreach (var prof in Professors)
        {
            Console.WriteLine(prof.Name);
        }
    }
}

class Program
{
    static void Main()
    {

        Professor p1 = new Professor("Mr.A");
        Professor p2 = new Professor("Mr.X");

        List<Professor> profList = new List<Professor> { p1, p2 };

        Department d1 = new Department("Computer Sceienc", profList);

        d1.ShowProfessors();

    }
}