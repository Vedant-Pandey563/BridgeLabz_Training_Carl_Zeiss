using System.Xml.Linq;

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

        /*public void PrintEmpDetails()
        {
            Console.WriteLine("Employee Details:");
            Console.WriteLine($"Name: {EmpName}");
            Console.WriteLine($"ID: {EmpId}");
            Console.WriteLine($"Department: {dept}");
            Console.WriteLine($"Salary: {salary}");
        }*/
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

            Console.WriteLine("Added new employee"+Environment.NewLine);
        }

        public void Print()
        {
            Console.WriteLine("Printing Employee Details"+ Environment.NewLine);
            EmpNode temp = head;

            while(temp != null)
            {
                Console.Write($"[Employee ID {temp.data.EmpId},"+Environment.NewLine+
                              $"Employee Name {temp.data.EmpName},"+ Environment.NewLine +
                              $"Employee Salary {temp.data.salary},"+ Environment.NewLine +
                              $"Employee Department {temp.data.dept}]"+ Environment.NewLine +
                              "->"+Environment.NewLine );
    
                temp = temp.next;
            }

            Console.WriteLine("[Null]");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine();
        }

        public void Search(int target)
        {
            Console.WriteLine("Searching for EmployeeID : " + target);
            EmpNode temp = head;

            int index = 0;

            while(temp != null)
            {
                if(temp.data.EmpId == target)
                {
                     Console.WriteLine("Employee found at "+index);
                    return;
                }
                temp = temp.next;
                index++;
            }

            Console.WriteLine("Employee Not Found");


        }
        public void Delete(int target)
        {
            if (head == null)
            {
                return;
            }

            if (head.data.EmpId == target)
            {
                head = head.next;
                return;
            }

            EmpNode temp = head;
            
            while(temp.next != null && temp.next.data.EmpId != target)
            {
                temp = temp.next;
            }
            
            if(temp.next != null)
            {
                Console.WriteLine("Employee id: " + temp.data.EmpId +" was found and deleted");
                temp.next = temp.next.next;
                return;
            }

            Console.WriteLine("Employee Id: " + target + " not found");
            Console.WriteLine();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Linked List");

            Employee emp1 = new Employee(2,"A","CS",20000);
            Employee emp2 = new Employee(3,"B","HR", 10000);
            Employee emp3 = new Employee(4, "C", "Sales", 15000);

            EmployeeLinkedList list1 = new EmployeeLinkedList();

            list1.Add(emp1);
            list1.Print();

            list1.Add(emp2);
            list1.Print();

            list1.Add(emp3);
            list1.Print();

            list1.Search(3);
            list1.Search(7);

            list1.Delete(9);
            list1.Delete(3);
            list1.Print();




        }
    }
}
