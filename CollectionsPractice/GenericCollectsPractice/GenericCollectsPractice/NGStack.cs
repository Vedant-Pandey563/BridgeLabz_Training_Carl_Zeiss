using System;
using System.Collections;
using System.Text;

namespace NonGenericCollectsPractice
{
    internal class NGStack
    {
        static void PrintStack(Stack stack)
        {
            Console.WriteLine("Stack elements:");
            foreach (object item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        static void Main(string [] args)
        {
            Stack stack = new Stack(); Console.WriteLine("Non Generic Stack"); Console.WriteLine();

            Console.WriteLine("Push elements");
            Console.WriteLine();
            stack.Push(10);
            stack.Push("yo");
            stack.Push(3.4);
            stack.Push(true);

            PrintStack(stack);

            Console.WriteLine("Count " + stack.Count);
            Console.WriteLine();

            Console.WriteLine("Peeking top element : " + stack.Peek());
            Console.WriteLine();

            Console.WriteLine("Popping");
            bool pop = (bool)stack.Pop();
            Console.WriteLine("Popped element : " +pop);

            Console.WriteLine("\n ITERATE STACK ");
            foreach (object item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nCLEAR STACK");
            stack.Clear();
            Console.WriteLine("Count after clear: " + stack.Count);
        }
    }
}
