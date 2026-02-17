using System;
using System.Collections.Generic;
using System.Text;

namespace ExcpetionsPractice1
{
    internal class BasicFilter
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0, z = 0;

            try
            {
                Console.WriteLine("Enter First Number: ");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number: ");
                y = int.Parse(Console.ReadLine());

                z = x / y;
                Console.WriteLine("Result : " + z);
            }
            catch (DivideByZeroException ex) when (x>50)
            {
                Console.WriteLine("Divide by zero and numerator > 50");
            }
        }
    }
}
