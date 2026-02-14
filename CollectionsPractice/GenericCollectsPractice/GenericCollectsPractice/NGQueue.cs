using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace NonGenericCollectsPractice
{
    internal class NGQueue
    {
        static void PrintQueue(Queue queue)
        {
            Console.WriteLine("Queue elements :");
            foreach (object item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

            static void Main(string[] args)
        {
            // Creating Queue
            Queue queue = new Queue();

            Console.WriteLine("ENQUEUE");
            Console.WriteLine();

            // EnQ
            queue.Enqueue(10);       
            queue.Enqueue("Hello");  
            queue.Enqueue(3.14);     
            queue.Enqueue(true);    

            PrintQueue(queue);

            //  Count
            Console.WriteLine("\nCount: " + queue.Count);

            // Peek
            Console.WriteLine("\n PEEK ");
            Console.WriteLine("Front element: " + queue.Peek());

            //  DeQ
            Console.WriteLine("\n DEQUEUE");
            object removed = queue.Dequeue();
            Console.WriteLine("Removed element: " + removed);

            PrintQueue(queue);

            //  Casting 
            Console.WriteLine("\n Object based Casting");
            string text = (string)queue.Dequeue();  // unbox element from obj
            Console.WriteLine("Unboxed string: " + text);

            // Iterate Queue
            Console.WriteLine("\n ITERATE");
            foreach (object item in queue)
            {
                Console.WriteLine(item);
            }

            // 8️⃣ Clear Queue
            Console.WriteLine("\n Clearing ");
            queue.Clear();
            Console.WriteLine("Count after clear: " + queue.Count);

        }
    }
}
