namespace EmployeeLinkedList
{
    class Employee
    {
        public int EmpId;
        public string EmpName;
        public string dept;
        public double salary;

        public Employee (int EmpId, string EmpName, string dept, double salary)
        {
            this.EmpId = EmpId;
            this.EmpName = EmpName;
            this.dept = dept;
            this.salary = salary;
        }
    }

    class EmpNode
    {
        public Employee data;
        public EmpNode next;

        public EmpNode(Employee data)
        {
            this.data = data;
            this.next = null;
        }
    }

    class EmployeeLinkedList
    {
        private EmpNode head;

        public void Add(Employee emp)
        {
            EmpNode newNode = new EmpNode(emp);

            if(head == null)
            {
                head = newNode;
                return;
            }

            EmpNode temp = head;

            while(temp.next != null)
            {
                temp = temp.next;
            }

            temp.next = newNode;
        }

        public void Print()
        {
            EmpNode temp = head;

            while(temp != null)
            {
                Console.Write(temp.data.EmpName + "->");

                temp = temp.next;
            }

            Console.WriteLine("Null");
            Console.WriteLine();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Linked List");

            Employee emp1 = new Employee(2,"A","CS",2345);
            Employee emp2 = new Employee(3, "cdji", "scs", 23);

            EmployeeLinkedList list1 = new EmployeeLinkedList();

            list1.Add(emp1);
            list1.Print();

            list1.Add(emp2);
            list1.Print();
        }
    }
}
