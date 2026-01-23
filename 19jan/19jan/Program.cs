using System;
using System.Numerics;

namespace _19jan

{
    internal class Program
    {
        void Greet()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("How are you ?");
        }

        public double kmToMiles(double km)
        {
            double kmToMilesFactor = 0.621371;
            return km * kmToMilesFactor;
        }
        public static double KmToMiles(double km)
        {
            double kmToMilesFactor = 0.621371;
            return km * kmToMilesFactor;

        }
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");

            /*string str1 = @"
            This is 

            multi line 

            String";

            Console.WriteLine(str1);


                int[,] arr = new int[3, 3];
                Console.WriteLine("Enter array elements");

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        arr [i, j] = int.Parse(Console.ReadLine());
                    }
                }

                int sum = 0;
                Console.WriteLine("The elements of the 2D Array are:");
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(arr[i, j] + " ");
                        sum += arr[i, j];
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("The sum of array elements is : " +sum);
            */

            /*  Program obj = new Program();
              obj.Greet();
              Console.WriteLine("Called method Greet");

              Program obj2  = new Program();
              Console.WriteLine("Enter the distance in Kilometers : ");
              double km = double.Parse(Console.ReadLine());

              double miles = obj2.kmToMiles(km);
              Console.WriteLine("Distance in miles : " +miles);
            
            Console.WriteLine("Enter distance in km : ");
            double km = Convert.ToDouble(Console.ReadLine());

            double miles = KmToMiles(km);
            Console.WriteLine("Distance in miles : " + miles);
            */

            int no = 25;
            Console.WriteLine($"The square of {no} is {Math.Sqrt(no)}");
            int base_no = 2;
            int power = 5;

            Console.WriteLine($"{base_no} raised to {power} is {Math.Pow(base_no,power)}");
        }

    }
}
