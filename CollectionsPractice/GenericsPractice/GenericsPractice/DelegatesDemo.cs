using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsPractice
{
    internal class DelegatesDemo
    {
        delegate void MyDelegate(string msg);

        static void ShowMessage(string msg)
        {
            Console.WriteLine("Msg : "+msg);
        }

        static void A(string s) => Console.WriteLine("A: "+s);
        static void B(string s) => Console.WriteLine("B : " + s);

        delegate int MathOp(int x, int y);

        static int Add(int a, int b) => a + b;
        static int Subtract(int a, int b) => a - b;

        static void Process(Action task)
        {
            Console.WriteLine("Starting Task");
            task();
            Console.WriteLine("Task Finished");
        }

        static void Main()
        {
            MyDelegate d = ShowMessage;
            d("Hello Delegate Method");
            Console.WriteLine();
            Console.ReadLine();

            Console.WriteLine("Multicast Delegates");
            MyDelegate Md = A;
            Md += B;
            Md("Hi");
            Console.WriteLine();
            Console.ReadLine();

            Console.WriteLine("Delegate + Return Values");
            MathOp op = Add;
            Console.WriteLine(op(5,3));

            op = Subtract;
            Console.WriteLine(op(5,3));
            Console.ReadLine();

            Console.WriteLine("Built in Delegates");
            Action<string> print = s => Console.WriteLine(s);
            print("Hello Action");
            Console.WriteLine();
            Func<int, int, int> add = (a, b) => a + b;
            Console.WriteLine(add(10, 5));
            Console.ReadLine();

            Console.WriteLine("Delegate as Parameter");
            Process(() => Console.WriteLine("Doing Work"));

        }

    }
}
