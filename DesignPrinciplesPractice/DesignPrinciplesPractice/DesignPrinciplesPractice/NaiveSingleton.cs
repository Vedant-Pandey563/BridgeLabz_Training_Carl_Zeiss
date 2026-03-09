using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciplesPractice
{
    public sealed class Singleton //sealed prevent inheritance
    {
        private Singleton() { } // pvt constructor 

        private static Singleton instance; //static var hold instance

        public static Singleton GetInstance() //public static method to access intance
        {
            if(instance == null )
            {
                instance = new Singleton();
            }

            return instance;
        }
    }
    internal class NaiveSingleton
    {
        static void Main( string[] args )
        {
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            Console.WriteLine($"Checking singleton validity : {(s1==s2)}");
        }
    }
}
