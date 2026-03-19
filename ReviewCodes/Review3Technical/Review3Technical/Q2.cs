/*
 * 
text editor maintains action history as a singly linked list:

i/o:
Action1 → Action2 → Action3 → Action4 → Action5
Due to a bug, the last K actions must be removed.

Task:

Delete the last K nodes from the linked list
Single traversal only

Constraints:

- No length calculation
- No extra data structures
- Only one pass
 * 
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Review3Technical
{
    public class Node
    {
        public string data;
        public Node next;

        public Node(string d)
        {
            data = d;
            next = null;
        }
    }

   
    public class LinkedList
    {
        public Node head;
        public void Add(string d)
        {
            Node newNode = new Node(d);

            if(head == null)
            {
                head= newNode;
                return;
            }

            Node temp = head;

            while(temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = newNode;
        }

        public void Print()
        {
            if (head == null)
            {
                Console.WriteLine("Empty List");
                return;
            }


            Node temp = head;

            while(temp != null)
            {
                Console.Write($"{temp.data}->");
                temp = temp.next;
            }
            Console.Write("Null");
            Console.WriteLine();
            Console.WriteLine();
        }
        public void RemoveK(int k)
        {
            if(head == null)
            {
                Console.WriteLine("Empty list");
                return;
            }
            
            if(k==0)
            {
                return;
            }

            Node fast = head;
            Node slow = head;

            for(int i =0;i<k;i++)//fast will be k steps ahead
            {
                if(fast == null)
                {
                    head = null;
                    return;
                }
                fast = fast.next;
            }

            if (fast == null)
            {
                head = null;
                return;
            }

            while(fast.next !=null)
            {
                slow = slow.next;
                fast = fast.next;
            }

            slow.next = null;//slow is at k-1 , drop from here 


            /*while (k>0) normal travesal , multi steps
            {
                Node temp = head;
                while (temp.next != null && temp.next.next != null)

                {
                    temp = temp.next;
                }

                temp.next = null;

                k--;
            }*/
        }
    }


    
    internal class Q2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List");
            Console.WriteLine();

            LinkedList l1 = new LinkedList();

            l1.Add("Action1");
            l1.Add("Action2");
            l1.Add("Action3");
            l1.Add("Action4");
            l1.Add("Action5");

            l1.Print();

            Console.WriteLine("Enter k values to be removed");

            int k = int.Parse(Console.ReadLine());

            l1.RemoveK(k);

            l1.Print();



        }
    }
}
