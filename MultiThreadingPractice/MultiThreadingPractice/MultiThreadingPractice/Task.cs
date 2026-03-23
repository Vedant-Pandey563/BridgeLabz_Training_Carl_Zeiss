using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace MultiThreadingPractice
{
    internal class TaskDemo 
    {
        static async Task Main(string[] args)
        {
            Task task = Task.Run(() =>
            {
                Console.WriteLine("Running task");
            });

            //Console.ReadLine();
            task.Wait();

            Task t2 = new Task(() =>
            {
                Console.WriteLine("Task Created");
            });

            t2.Start();

            Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Long Task");
            },TaskCreationOptions.LongRunning);

            Task<int> t3 = Task.Run(() =>
            {
                return 10 + 20;
            });

            int result = await t3;
            Console.WriteLine(result);


            Task t4 = Task.Run(() => Console.WriteLine("Task 4"));
            Task t5 = Task.Run(() => Console.WriteLine("Task 5"));

            await Task.WhenAll(t4, t5);

            Task t6 = Task.Delay(3000);
            Task t7 = Task.Delay(1000);

            Task first = await Task.WhenAny(t6, t7);


        }
    }
}
