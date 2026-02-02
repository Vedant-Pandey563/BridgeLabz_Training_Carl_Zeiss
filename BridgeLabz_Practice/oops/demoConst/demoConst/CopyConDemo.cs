using System;
using System.Collections.Generic;
using System.Text;

namespace demoConst
{
    internal class CopyConDemo
    {
        int x;

        public CopyConDemo(int i)
        {
            x = i;
        }
        public CopyConDemo(CopyConDemo obj)
        {
            x= obj.x;
        }

        public void Display()
        {
            Console.WriteLine("Values of x is :"+x);
        }
        static void Main()
        {
            CopyConDemo cd1 = new CopyConDemo(12);
            cd1.Display();
            CopyConDemo cd2 = new CopyConDemo(cd1);
            cd2.Display();
        }
    }
}
