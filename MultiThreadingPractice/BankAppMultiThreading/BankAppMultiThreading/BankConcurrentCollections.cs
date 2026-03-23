//using System;
//using System.Threading;
//using System.Threading.Tasks;
//using System.Collections.Concurrent;

//namespace BankAppMultiThreading
//{
//    public class BankAccount
//    {
//        private int Balance = 1000;

//        // Async-safe lock
//        private readonly SemaphoreSlim _semaphore = new SemaphoreSlim(1, 1);

//        // Thread-safe collection
//        private readonly ConcurrentQueue<int> transactions = new ConcurrentQueue<int>();

//        // Async Deposit
//        public async Task DepositAsync(int amount)
//        {
//            await _semaphore.WaitAsync(); // acquire lock

//            try
//            {
//                Balance += amount;
//                Console.WriteLine($"Deposited: {amount}, Balance: {Balance}");
//            }
//            finally
//            {
//                _semaphore.Release(); // MUST release
//            }

//            // No lock needed here
//            transactions.Enqueue(amount);
//        }

//        // Async Get Balance
//        public async Task<int> GetBalanceAsync()
//        {
//            await _semaphore.WaitAsync();

//            try
//            {
//                return Balance;
//            }
//            finally
//            {
//                _semaphore.Release();
//            }
//        }

//        // Print all transactions
//        public void PrintTransactions()
//        {
//            foreach (var t in transactions)
//            {
//                Console.WriteLine($"Transaction: {t}");
//            }
//        }
//    }

//    internal class Program
//    {
//        static async Task Main()
//        {
//            Console.WriteLine("Bank App MultiThreading");

//            BankAccount account = new BankAccount();

//            // Deposit Task
//            Task depositTask = Task.Run(async () =>
//            {
//                for (int i = 0; i < 10; i++)
//                {
//                    await account.DepositAsync(100);
//                    await Task.Delay(1000); // simulate delay
//                }
//            });

//            // Check Balance Task
//            Task checkTask = Task.Run(async () =>
//            {
//                for (int i = 0; i < 10; i++)
//                {
//                    int balance = await account.GetBalanceAsync();
//                    Console.WriteLine($"Checked Balance: {balance}");
//                    await Task.Delay(1500);
//                }
//            });

//            await Task.WhenAll(depositTask, checkTask);

//            Console.WriteLine($"Final Balance: {await account.GetBalanceAsync()}");

//            Console.WriteLine("\nTransactions:");
//            account.PrintTransactions();

//            Console.WriteLine("\nCompleted");
//        }
//    }
//}