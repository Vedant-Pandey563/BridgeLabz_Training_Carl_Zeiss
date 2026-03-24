using MultiThreadingPractice;
using System;
using System.Collections.Generic;
using System.Text;

namespace MultiThreadingPractice
{
    internal class MultiUserProcessing
    {
        static int counter = 0;
        static object _lock = new object();

        static void UserWork(string user)
        {
            for (int i = 0; i < 3; i++)
            {
                lock (_lock) // synchronization
                {
                    counter++;
                    Console.WriteLine($"{user} updated counter to {counter} on Thread {Thread.CurrentThread.ManagedThreadId}");
                }

                Thread.Sleep(500);
            }
        }

        public static void Main()
        {
            Console.WriteLine("Starting Parallel Users...\n");

            // Step 1: Users array
            string[] users = { "User1", "User2", "User3", "User4", "User5" };

            // Step 2: Parallel execution
            Parallel.ForEach(users, user =>
            {
                UserWork(user);
            });

            Console.WriteLine($"\nFinal Counter: {counter}");
        }
    }
}