using System;
using System.Collections.Generic;
using System.Text;

namespace ExcpetionsPractice1
{
    internal class InnerExcpetions
    {
        static void Main (string[] args)
        {
            try
            {
                try
                {
                    int x = 10;
                    int y = 0;

                    int z = x / y;

                }
                catch(Exception ex)
                {
                    throw new Exception("Exception in inner try", ex);
                }
            }//inner try fin

            catch(Exception ex) 
            {
                Console.WriteLine("Current Excpetion :" + ex.Message);

                if(ex.InnerException != null)
                {
                    Console.WriteLine("Inner Excpetions" + ex.InnerException.Message);
                }

            }
        }
    }
}
