using System;
using System.Collections.Generic;
using System.Text;

namespace ExcpetionsPractice1
{
    internal class ExceptionDucking
    {
        static void Method2()
        {
            int x = 10;
            int y = 0;
            int z = x/y; //exception
        }
        static void Method1()
        {
            Method2(); //not handled here
        }
        static void Main()
        {
            try
            {
                Method1();//handled here
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Excpetion handled in main " +ex.Message);
            }
        }
    }
}
