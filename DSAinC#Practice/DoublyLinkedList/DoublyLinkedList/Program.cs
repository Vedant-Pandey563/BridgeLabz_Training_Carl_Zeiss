namespace DoublyLinkedList
{
    class Node
    {
        public int data;
        public Node next;
        public Node prev;

        public Node(int d)
        {
            data = d;
            next = null;
            prev = null;
        }
    }
    class DoublyLinkedList
    {
        private Node head;
        public void PrintList()
        {
            Node temp = head;

            while (temp != null)
            {
                Console.Write(temp.data + " <-> ");
                temp = temp.next;
            }
            Console.WriteLine("Null");
            Console.WriteLine();
        }

        public void Add(int data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
                return;
            }

            Node temp = head;

            while (temp.next != null)
            {
                temp = temp.next;
            }

            temp.next = newNode;
            newNode.prev = temp;

            return;
        }

        public void AddFirst(int data)
        {
            Node newNode = new Node(data);

            if(head != null)
            {
                head.prev = newNode;
            }

            newNode.next = head;
            newNode.prev = null;

            head = newNode;
        }

        public void AddIndex(int index,int data)
        {
            Node newNode = new Node(data);

            if (index == 0)
            {
                AddFirst(data);
                return;
            }
            int cnt = 0;

            Node temp = head;

            while(cnt != index && temp != null)
            {
                cnt++;
                temp = temp.next;
            }

            Node prevNode = temp.prev;

            newNode.prev = prevNode;
            prevNode.next = newNode;
            newNode.next = temp;
            temp.prev = newNode;

        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Doubly Linked List");
            DoublyLinkedList l1 = new DoublyLinkedList();
            l1.Add(1);
            l1.PrintList();
            
            l1.Add(2);
            l1.Add(3);
            l1.PrintList();

            l1.AddFirst(6);
            l1.PrintList();

            l1.AddIndex(3, 8);
            l1.PrintList();

            l1.AddIndex(0, 100);
            l1.PrintList();
        }
    }
}
