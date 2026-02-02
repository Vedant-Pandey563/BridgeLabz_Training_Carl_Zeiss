using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Animel
    {
        public Animel() 
        {
            Console.WriteLine("Animal Constructor");
        }
    }

    class Dig : Animel 
    {
        public Dig() : base()
        {
            Console.WriteLine("Dog Constructor");
        }
    }
    internal class AnimalConstructor
    {
        static void Main()
        {
            Dig d = new Dig();
        }
    }
}
