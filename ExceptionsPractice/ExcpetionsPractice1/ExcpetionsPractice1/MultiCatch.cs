using System;
using System.Collections.Generic;
using System.Text;

namespace ExcpetionsPractice1
{
    internal class MultiCatch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiple Catch Blocks");

            int x, y, z ;

            try
            {
                Console.WriteLine("Enter First Number: ");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number: ");
                y = int.Parse(Console.ReadLine());

                z = x / y;
                Console.WriteLine("Result : "+z );
            }

            /*catch (Exception ex)
            {
                Console.WriteLine("General exception"); causes error here parent before child
            }*/

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Second cannot be zero " + ex.Message );
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Please enter integrs only" + ex.Message);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Number entered is very large " +ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("General exception");
            }
        }
    }
}
