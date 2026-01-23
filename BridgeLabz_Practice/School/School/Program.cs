namespace School
{
    class School
    {
        public string StudentName;// insatnce var
        public static int TotalStudents; // class var

        public School(string studentName)// constructor declare
        {
            StudentName = studentName;
            TotalStudents++;
        }
        public void DisplayStudent()// display instance method each studnet diff name
        {
            Console.WriteLine("Student Name:" + StudentName);
        }

        public static void DisplayTotalStudents()//class method same total for all
        {
            Console.WriteLine("Total Students: " + TotalStudents);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            School student1 = new School("A");
            School student2 = new School("B");

            student1.DisplayStudent();
            student2.DisplayStudent();

            School.DisplayTotalStudents();
        }
    }
}
