using System;
using System.Collections.Generic;
using System.Text;

namespace Level2oops
{
    internal class Student
    {
        public int rollNumber;
        protected string studentName;
        private double cgpa;

        public Student(int rollNumber, string studentName, double cgpa)
        {
            this.rollNumber = rollNumber;
            this.studentName = studentName;
            this.cgpa = cgpa;
        }

        public double GetCgpa()
        {
            return cgpa;
        }

        public void SetCgpa(double cgpa)
        {
            this.cgpa = cgpa;
        }

        public void DisplayStudentDetails()
        {
            Console.WriteLine("University Student Details");
            Console.WriteLine("Student name : " +studentName);
            Console.WriteLine("Roll Number : " +rollNumber);
            Console.WriteLine("CGPA : " +cgpa);
        }
    }
    class PostGrad : Student
    {
        private string specialization;
        public PostGrad (int rollNumber, string studentName, double cgpa, string specialization)
            : base(rollNumber, studentName, cgpa)
        {
            this.specialization = specialization;
        }

        public void DisplayPostGradDetails()
        {
            Console.WriteLine("Postgraduate Student Details:");
            DisplayStudentDetails();
            Console.WriteLine("Specialization : " +specialization);
        }
    }

    class Program3
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(1, "asdfg", 9.22333);
            s1.DisplayStudentDetails();

            s1.SetCgpa(9.56);

            Console.WriteLine("Student Details after chnaging cgpa");

            s1.DisplayStudentDetails();

            PostGrad pg1 = new PostGrad(2, "qefvr", 8.9876543, "cse");

            pg1.DisplayPostGradDetails();
        }
    }
}
