using System;
using System.Collections.Generic;
using System.Text;

namespace demoConst
{
    internal class ParameterizedConDemo
    {
        int a; 
        public ParameterizedConDemo(int i)
        {
            a=i;
            Console.WriteLine("Value of i is: " + i);
        }

        public void Display()
        {
            Console.WriteLine("Value of a is: " + a);
        }

        static void Main()
        {
            ParameterizedConDemo cd1 = new ParameterizedConDemo(10);
            ParameterizedConDemo cd2 = new ParameterizedConDemo(20);

            cd1.Display();
            cd2.Display();

        }
    }
}
