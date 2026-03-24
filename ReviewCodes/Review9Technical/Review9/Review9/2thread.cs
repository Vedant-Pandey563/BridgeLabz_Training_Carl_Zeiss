using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//You are building a Payment Processing API.
//1) System receives 100+ payment requests
//2)But you must allow only 3 payments at a time
//semaphoreslim
//4) Remaining requests should wait (not fail)
//5) After one completes → next should start automatically
//try catch also to be used 



namespace Review8
{

    internal class SemaphoreProblem
    {
        private static SemaphoreSlim semaphore = new SemaphoreSlim(3);

        public static async Task ProcessPaymentAsync(int paymentID)
        {
            await semaphore.WaitAsync();

            try
            {
                Console.WriteLine($"Payment{paymentID} started ");
                await Task.Delay(2000);
                Console.WriteLine($"Payment {paymentID} completed");
                await Task.Delay(2000);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error processing payment ");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                semaphore.Release();
            }
        }

        public static async Task Main(string[]args)
        {
            List<Task> tasks = new List<Task>();

            for(int i =1; i<=15;i++)
            {
                int paymentID = i;
                tasks.Add(ProcessPaymentAsync(paymentID));
            }

            await Task.WhenAll(tasks);

            Console.WriteLine();
        }

    }
}
