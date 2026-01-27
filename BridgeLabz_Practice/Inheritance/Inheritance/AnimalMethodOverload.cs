using Inheritance;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Animaal
    {   
        public virtual void Sound()
        {
            Console.WriteLine("Animal Makes a Sound");
        }

    }

    class Doog : Animaal
    {
        public override void Sound()
            {
                Console.WriteLine("Dog Barks");
            }
    }
    
    class Caat : Animaal
    {
        public override void Sound()
        {
            Console.WriteLine("Cat Meows");
        }
    }
    internal class AnimalMethodOverload
    {
        static void Main(string[] args)
        {
            Animaal A = new Animaal();
            Doog D = new Doog();
            Caat C = new Caat();

            A.Sound();
            D.Sound();
            C.Sound();

        }

    }
}
