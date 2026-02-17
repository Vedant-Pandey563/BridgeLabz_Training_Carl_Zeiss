using System;
using System.Collections.Generic;
using System.Text;

namespace ExcpetionsPractice1
{
    internal class ExcptionsFinally
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Try 1");
                Console.WriteLine("Inside try");

                int x = 10;
                int y = 0;

                int z = x / y;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Inside catch");
            }
            finally
            {
                Console.WriteLine("Inside finally");
            }

            Console.WriteLine("");

            try
            {
                Console.WriteLine("Try 2");
                Console.WriteLine("Inside try ");

                int x = 10;
                int y = 2;

                int z = x / y;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Inside catch");
            }
            finally
            {
                Console.WriteLine("Inside finally");
            }

            Console.WriteLine();
            Console.WriteLine( Test() );
        }

        static int Test()
        {
            try
            {
                return 10;
            }
            finally
            {
                Console.WriteLine("Finally executed");
            }
        }
    }
}
