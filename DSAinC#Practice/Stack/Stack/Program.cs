using System.Collections.Generic;
namespace Stack
{
    internal class Program
    {
        static void StackSize(Stack<int> s)
        {
            Console.WriteLine("Calculating Stack Size ...");
            int size = 0;
            foreach (int i in s)
            {
                size++;
            }

            Console.WriteLine("Stack Size is " + size);
            Console.WriteLine();
        }
        static void PrintStack(Stack<int> s)
        {
            Console.WriteLine("Printing Stack");

            foreach(int i in s)
            {
                Console.WriteLine("|" + i + "|");
                Console.WriteLine("---");
            }

            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Stack");

            Stack<int> s1= new Stack<int>();

            s1.Push(5);
            s1.Push(4);
            s1.Push(3);

            Console.WriteLine("Stack peek " + s1.Peek());

            Console.WriteLine("Stack pop " + s1.Pop());

            s1.Push(6);
            s1.Push(7);

            PrintStack(s1);
            StackSize(s1);
        }
    }
}
