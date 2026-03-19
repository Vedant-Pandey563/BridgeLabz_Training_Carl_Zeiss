using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    class Ticket
    {
        Queue<string> q = new Queue<string>();

        public void AddCustomer(string name)
        {
            q.Enqueue(name);
            Console.WriteLine($"Added {name} to Queue");
        }

        public void ServeCustomer()
        {
            if (q.Count == 0)
            {
                Console.WriteLine("Queue is Empty");
                Console.WriteLine();
                return;
            }

            string x = q.Dequeue();
            Console.WriteLine($"{x} has been served");
            Console.WriteLine();
        }

        public void ShowQueue()
        {
            if (q.Count == 0)
            {
                Console.WriteLine("Queue is Empty");
                Console.WriteLine();
                return;
            }

            Console.WriteLine("People in queue");
            
            foreach(string s in q)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
        }

    }
    internal class TicketQueue
    {
        public static void Main()
        {
            Console.WriteLine("Ticket System");
            Console.WriteLine();

            Ticket t = new Ticket();

            t.AddCustomer("A");
            t.AddCustomer("B");
            t.AddCustomer("C");

            t.ShowQueue();
            t.ServeCustomer();

            t.ServeCustomer();

            t.AddCustomer("D");

            t.ShowQueue();
            t.ServeCustomer();
            t.ServeCustomer();
            t.ShowQueue();
        }
    }
}
