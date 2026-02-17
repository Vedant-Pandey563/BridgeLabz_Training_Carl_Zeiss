using System;
using System.Collections.Generic;
using System.Text;

namespace ExcpetionsPractice1
{
    class OddNumberException : Exception
    {
        public OddNumberException(string message) : base(message)
        {

        }
    }
    internal class CustomException
    {
        static void Main(string[]  args)
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if(number%2 !=0 )
            {
                throw new OddNumberException("Odd number not allowed");
            }

            Console.WriteLine("Valid number " + number);
        }
    }
}
