using System;
namespace demoConst
{
    internal class Program
    {
        int i; bool b;
        static void Main(string[] args)
        {
            Program p = new demoConst.Program();
            Console.WriteLine("Value of i is:" +p.i);
            Console.WriteLine("Value of b is:" +p.b);

        }
    }
}
