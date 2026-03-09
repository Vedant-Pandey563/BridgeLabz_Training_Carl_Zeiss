using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DesignPrinciplesPractice
{
    class ThreadSingleton
    {
        private static ThreadSingleton instance; // static instance 

        private static readonly object lockobject = new object(); // object for locking
        //lock cause only 1 thread to acess thread at a time 

        private ThreadSingleton() 
        {
            Console.WriteLine("Singleton instance created");
        }

        public static ThreadSingleton GetInstance()
        {
            lock(lockobject)
            {
                if(instance == null)
                {
                    instance = new ThreadSingleton();
                }

                return instance;
            }
        }
        public void ShowMessage()
        {
            Console.WriteLine("Singleton Method Executed");
        }

    }
    internal class ThreadSafeSingleton
    {
        static void AccessingSingleton()
        {
            ThreadSingleton obj = ThreadSingleton.GetInstance();
            Console.WriteLine($"Instance HahsCode : {obj.GetHashCode()} ");
            obj.ShowMessage();
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(AccessingSingleton);
            Thread t2 = new Thread(AccessingSingleton);
            Thread t3 = new Thread(AccessingSingleton);

            t1.Start();
            t2.Start();
            t3.Start();
        }
    }
}
