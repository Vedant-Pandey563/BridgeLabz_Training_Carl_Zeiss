using System;
using System.Collections.Generic;
namespace SchoolCourse
{
    //student class 
    class Student
    {
        public String Name { get; private set; }
        public int StudentId { get; private set; }

        public Student(string S_name, int S_Id)
        {
            this.Name = S_name;
            this.StudentId = S_Id;
        }
    }

    //teacher class
    class Teacher
    {
        public string Name { get; private set; }
        public int TeacherId { get; private set; }

        public Teacher(string T_name, int T_Id)
        {
            this.Name = T_name;
            this.TeacherId = T_Id;
        }
    }

    //course class
    class Course
    {
        public string CourseName { get; private set; }
        public Teacher Instructor { get; private set; }//teacher used as a datatype
        private List<Student> enrolledStudents; // in list students is used as datatype

        public Course(string Co_name, Teacher Instructor)
        {
            this.CourseName = Co_name;
            this.Instructor = Instructor;
            enrolledStudents = new List<Student>();
        }

        public void EnrollStudent(Student student)
        {
            enrolledStudents.Add(student);
            Console.WriteLine($"{student.Name} has been enrolled in {CourseName}");
        }

        public void ShowEnrolledStudents()
        {
            Console.WriteLine($"Students Enrolled in {CourseName}:");
            foreach (var student in enrolledStudents)
            {
                Console.WriteLine($"- {student.Name} (ID: {student.StudentId})");
            }
        }


    }

    //class school
    class School
    {
        public string SchoolName { get; private set; }
        private List<Course> courses;

        public School(string schoolName)
        {
            this.SchoolName = schoolName;
            courses = new List<Course>();
        }
        public void AddCourse(Course course)
        {
            courses.Add(course);
            Console.WriteLine($"{course.CourseName} has been added to {SchoolName}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            School school = new School("ABC School");
            Teacher teacher1 = new Teacher("Mr.W", 001);
            Teacher teacher2 = new Teacher("Ms.Q", 002);

            Course math = new Course("Mathematics", teacher1);
            Course science = new Course("Science", teacher2);

            school.AddCourse(math);
            school.AddCourse(science);

            Student student1 = new Student("P", 89);
            Student student2 = new Student("Q", 67);

            math.EnrollStudent(student1);
            math.EnrollStudent(student2);
            science.EnrollStudent(student2);

            math.ShowEnrolledStudents();
            science.ShowEnrolledStudents();

        }
    }
}
