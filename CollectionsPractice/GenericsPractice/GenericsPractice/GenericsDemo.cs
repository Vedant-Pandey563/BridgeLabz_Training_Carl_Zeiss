using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsPractice
{
    public class ClsCalculator
    {
        public static bool AreEqual<T>(T val1,T val2)
        {
            return val1.Equals(val2);
        }
    }
    internal class GenericsDemo
    {
        public static void Main()
        {
            bool IsEqual = ClsCalculator.AreEqual<double>(10.23, 10.2);

            if(IsEqual)
            {
                Console.WriteLine("Equal Values");
            }
            else
            {
                Console.WriteLine("Unequal Values");
            }
        }
    }
}
