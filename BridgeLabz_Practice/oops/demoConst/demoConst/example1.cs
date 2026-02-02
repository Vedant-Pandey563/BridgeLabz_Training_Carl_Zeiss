using System;
using System.Collections.Generic;
using System.Text;

namespace demoConst
{
    internal class example1
    {
        public int PublicVar = 10;
        protected int ProtectedVar = 20;
        internal int InternalVar = 30;
        private int PrivateVar = 40;

        public void Display()
        {
            Console.WriteLine("Public Variable: " + PublicVar);
            Console.WriteLine("Protected Variable: " + ProtectedVar);
            Console.WriteLine("Internal Variable: " + InternalVar);
            Console.WriteLine("Private Variable: " + PrivateVar);
        }

        static void Main()
        {
            example1 obj = new example1();
            obj.Display();
        }
    }
}
