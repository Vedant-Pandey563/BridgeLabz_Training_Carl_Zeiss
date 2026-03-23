//using System.Threading;
//using System.Threading.Tasks;
//namespace BankAppMultiThreading
//{

//    class BankAccount
//    {
//        private int Balance = 1000;
//        private SemaphoreSlim _semaphore = new SemaphoreSlim(1, 1);//1 tread semaphore

//        public async Task DepositAsync(int amount)
//        {
//            await _semaphore.WaitAsync(); // acquire

//            try
//            {
//                int temp = Balance;
//                await Task.Delay(1); // simulate async work
//                temp += amount;
//                await Task.Delay(1);
//                Balance = temp;

//                Console.WriteLine($"Deposited: {amount}, Balance: {Balance}");
//            }
//            finally
//            {
//                _semaphore.Release(); // release
//            }
//        }
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
//    }
//    internal class Program
//    {
//        static async Task Main()
//        {
//            Console.WriteLine("Bank App MultiThreading");

//            BankAccount account = new BankAccount();

//            Task depositTask = Task.Run(async () =>
//            {
//                for (int i = 0; i < 10; i++)
//                {
//                    await account.DepositAsync(100);
//                }
//            });

//            Task checkTask = Task.Run(async () =>
//            {
//                for (int i = 0; i < 10; i++)
//                {
//                    int balance = await account.GetBalanceAsync();
//                    Console.WriteLine($"Checked: {balance}");
//                }
//            });


//            await Task.WhenAll(depositTask, checkTask);

//            Console.WriteLine("Completed");

//        }

//    }
//}
