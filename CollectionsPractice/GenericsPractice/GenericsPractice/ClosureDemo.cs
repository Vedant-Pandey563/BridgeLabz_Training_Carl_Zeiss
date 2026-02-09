using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsPractice
{
    internal class ClosureDemo
    {
        static Action MakeCounter()
        {
            int count = 0;
            return () =>
            {
                count++;
                Console.WriteLine("Count = " + count);
            };
        }

        static void Main()
        {
            var Counter = MakeCounter();
            Counter();
            Counter();
            Counter();
        }
    }
}
