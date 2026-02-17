using System;
using System.Collections.Generic;
using System.Text;

namespace ExcpetionsPractice1
{
    internal class FinallyMultiCatch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Finally + Multiple Catch Blocks");

            int x, y, z;

            try
            {
                Console.WriteLine("Enter First Number: ");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number: ");
                y = int.Parse(Console.ReadLine());

                z = x / y;
                Console.WriteLine("Result : " + z);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Second cannot be zero " + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter integrs only" + ex.Message);
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("Finally block executed.");
            }
        }
    }
}
