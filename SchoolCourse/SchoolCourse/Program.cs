namespace SchoolCourse
{
    //student class 
    class Student
    {
        public String Name { get; private set;}
        public int StudentId { get; private set; }

        public Student (string S_name, int S_Id)
        {
            this.Name = name;
            this.StudentId = S_Id;
        }
    }

    //teacher class
    class Teacher
    {
        public string Name { get; private set;}
        public int TeacherId { get; private set; }

        public Teacher (string T_name, int T_Id)
        {   
            this.Name = T_name;
            this.TeacherId = T_Id;
        }
    }

    //course class
    class Course
    { 
        public string CourseName { get; private set;}
        public Teacher Instructor { get; private set; }//teacher used as a datatype
        private List<Student> enrolledStudents; // in list students is used as datatype

        public Course (string Co_name, Teacher Instructor)
        {
           this.CourseName = Co_name;
           this.Instructor = Instructor;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
