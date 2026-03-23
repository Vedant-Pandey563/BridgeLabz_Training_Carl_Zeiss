//using System;
//using System.Threading;
//using System.Threading.Tasks;
//using System.Collections.Concurrent;

//namespace BankAppMultiThreading
//{
//    class BankAccount
//    {
//        private int Balance = 1000;
//        private readonly object _lock = new object();
//        private readonly ConcurrentQueue<int> transactions = new ConcurrentQueue<int>();

//        public void Deposit(int amount)
//        {
//            lock (_lock)
//            {
//                Balance += amount;
//            }

//            transactions.Enqueue(amount);
//            Console.WriteLine($"Deposited: {amount}, Balance: {Balance}");
//        }

//        public int GetBalance()
//        {
//            lock (_lock)
//            {
//                return Balance;
//            }
//        }
//    }

//    internal class Program
//    {
//        static async Task Main()
//        {
//            Console.WriteLine("Bank App with Cancellation");

//            BankAccount account = new BankAccount();

//            CancellationTokenSource cts = new CancellationTokenSource();
//            CancellationToken token = cts.Token;

//            // 🔥 Cancel after 2 seconds
//            cts.CancelAfter(500);

//            // Parallel deposit with cancellation
//            Task depositTask = Task.Run(() =>
//            {
//                try
//                {
//                    Parallel.For(0, 100, (i, state) =>
//                    {
//                        if (token.IsCancellationRequested)
//                        {
//                            Console.WriteLine("Cancellation requested (Deposit)");
//                            state.Stop(); // stop parallel loop
//                            return;
//                        }

//                        account.Deposit(100);
//                        Thread.Sleep(100);
//                    });
//                }
//                catch (OperationCanceledException)
//                {
//                    Console.WriteLine("Deposit cancelled");
//                }
//            }, token);

//            // Async balance checker
//            Task checkTask = Task.Run(async () =>
//            {
//                try
//                {
//                    while (!token.IsCancellationRequested)
//                    {
//                        Console.WriteLine($"Checked Balance: {account.GetBalance()}");
//                        await Task.Delay(300, token);
//                    }
//                }
//                catch (TaskCanceledException)
//                {
//                    Console.WriteLine("Check task cancelled");
//                }
//            }, token);

//            await Task.WhenAll(depositTask, checkTask);

//            Console.WriteLine($"Final Balance: {account.GetBalance()}");
//            Console.WriteLine("Completed");
//        }
//    }
//}