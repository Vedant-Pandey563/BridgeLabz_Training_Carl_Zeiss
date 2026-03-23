//using System;
//using System.Threading;
//using System.Threading.Tasks;
//using System.Collections.Concurrent;

//namespace BankAppMultiThreading
//{
//    class BankAccount
//    {
//        private int Balance = 1000;

//        // For parallel safety (CPU-bound)
//        private readonly object _lock = new object();

//        // Thread-safe transaction storage
//        private readonly ConcurrentQueue<int> transactions = new ConcurrentQueue<int>();

//        // Synchronous deposit (used by Parallel.For)
//        public void Deposit(int amount)
//        {
//            lock (_lock)
//            {
//                Balance += amount;
//            }

//            transactions.Enqueue(amount);
//        }

//        // Read balance safely
//        public int GetBalance()
//        {
//            lock (_lock)
//            {
//                return Balance;
//            }
//        }

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
//            Console.WriteLine("Bank App MultiThreading - Parallel Version\n");

//            BankAccount account = new BankAccount();

//            //  PARALLEL CPU-BOUND DEPOSITS
//            Task parallelDepositTask = Task.Run(() =>
//            {
//                Parallel.For(0, 20, i =>
//                {
//                    account.Deposit(100);

//                    Console.WriteLine(
//                        $"[Parallel Deposit] Thread {Thread.CurrentThread.ManagedThreadId} -> Balance: {account.GetBalance()}"
//                    );
//                });
//            });

//            //Concurrent balance checking (async style)
//            Task checkTask = Task.Run(async () =>
//            {
//                for (int i = 0; i < 10; i++)
//                {
//                    int balance = account.GetBalance();
//                    Console.WriteLine($"[Check] Balance: {balance}");

//                    await Task.Delay(150);
//                }
//            });

//            await Task.WhenAll(parallelDepositTask, checkTask);

//            Console.WriteLine("\nFinal Balance: " + account.GetBalance());

//            Console.WriteLine("\nTransactions:");
//            account.PrintTransactions();

//            Console.WriteLine("\nCompleted");
//        }
//    }
//}