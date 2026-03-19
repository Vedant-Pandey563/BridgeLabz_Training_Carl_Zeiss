namespace LinkedList
{
    class Node // class to make node 
    {
        public int data;
        public Node next;

        public Node(int d)
        {
            data = d;
            next = null;
        }
    }
    class SingleLinkedList
    {
        private Node head;

        public void Add(int new_data)
        {
            Node newNode = new Node(new_data);
            
            if (head == null)
            {
                head = newNode;
                return;
            }

            Node temp = head;

            while(temp.next != null)
            {
                temp = temp.next;
            }

            temp.next = newNode;
        }

        public void PrintList()
        {
            Node temp = head;
            while(temp != null)
            {
                Console.Write(temp.data + "->");

                temp = temp.next;
            }
            Console.WriteLine("Null");
            
        }

        public void AddFirst(int newdata)
        {
            Node newNode = new Node(newdata);

            newNode.next = head;

            head = newNode;

        }

        public void AddTarget(int target, int newdata)
        {
            Node newNode = new Node(newdata);

            if(target == 0)// insert at head
            {
              AddFirst(newdata);
                return;
            }

            Node temp = head;
            for(int i = 0; i < target - 1 && temp != null ; i++) //traversing LL till target
            {
                temp = temp.next;
            }

            if(temp == null)
            {
                Console.WriteLine(target + " is at an invalid Postion");
                return;
            }

            newNode.next = temp.next;
            temp.next = newNode;

        }

        public int Search(int target)
        {
            Node temp = head;
            int index = 0;

            while(temp != null)
            {
                if(temp.data == target)
                {
                    return index;
                }
                temp = temp.next;
                index++;
            }
            
            return index;

        }

        public void Delete(int target)
        {
            if (head == null)
            {
                return;
            }

            if(head.data == target)
            {
                head = head.next;
                return;
            }

            Node temp = head;

            while (temp.next != null && temp.next.data != target)
            {
                temp=temp.next;
            }

            if(temp.next != null)
            {
                temp.next = temp.next.next;
            }
        }
     }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List");
            
            SingleLinkedList list1 = new SingleLinkedList();

            list1.Add(4);
            list1.Add(5);
            list1.Add(6);

            list1.PrintList();

            list1.AddFirst(8);

            list1.PrintList();

            list1.AddTarget(2, 90);

            list1.PrintList();

            list1.AddTarget(6, 0);

            Console.WriteLine( "Element found at " + list1.Search(4));

            list1.Delete(90);

            list1.PrintList();
        }
    }
}
