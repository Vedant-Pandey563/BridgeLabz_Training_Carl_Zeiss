using System;
using System.Collections.Generic;
using System.Text;

namespace ExcpetionsPractice1
{
    internal class Un_Checked
    {
        static void Main(string[] args)
        {
            try
            {
                checked
                {
                    int x = int.MaxValue;
                    x = x + 1;
                }
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("OverFlow occured " +ex.Message);
            }

            unchecked
            {
                int x = int.MaxValue;
                x = x + 1;
                Console.WriteLine("Unchecked");
                Console.WriteLine(x);
            }
        }
    }
}
