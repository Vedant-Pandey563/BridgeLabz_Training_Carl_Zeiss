//using System;
//using System.Threading;

//class BankAccount
//{
//    private int Balance = 1000;
//    private readonly object _lock = new object();

//    public void Deposit(int amount)
//    {
//        lock (_lock)
//        {
//            Balance += amount;
//            Console.WriteLine($"Deposited: {amount}, Balance: {Balance}");
//        }
//    }

//    public void CheckBalance()
//    {
//        lock (_lock)
//        {
//            Console.WriteLine($"Checked Balance: {Balance}");
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        BankAccount account = new BankAccount();

//        // ThreadPool for deposit
//        ThreadPool.QueueUserWorkItem(_ =>
//        {
//            for (int i = 0; i < 5; i++)
//            {
//                account.Deposit(100);
//                Thread.Sleep(500);
//            }
//        });

//        // ThreadPool for checking balance
//        ThreadPool.QueueUserWorkItem(_ =>
//        {
//            for (int i = 0; i < 5; i++)
//            {
//                account.CheckBalance();
//                Thread.Sleep(300);
//            }
//        });

//        // IMPORTANT: wait for completion
//        Thread.Sleep(3000);
//    }
//}



///////////////////////////////////
/////

//using System;
//using System.Threading.Tasks;

//class BankAccount
//{
//    private int Balance = 1000;
//    private readonly object _lock = new object();

//    public void Deposit(int amount)
//    {
//        lock (_lock)
//        {
//            Balance += amount;
//            Console.WriteLine($"Deposited: {amount}, Balance: {Balance}");
//        }
//    }

//    public int GetBalance()
//    {
//        lock (_lock)
//        {
//            return Balance;
//        }
//    }
//}

//class Program
//{
//    static async Task Main()
//    {
//        BankAccount account = new BankAccount();

//        Task depositTask = Task.Run(() =>
//        {
//            for (int i = 0; i < 5; i++)
//                account.Deposit(100);
//        });

//        Task checkTask = Task.Run(() =>
//        {
//            for (int i = 0; i < 5; i++)
//                Console.WriteLine($"Checked: {account.GetBalance()}");
//        });

//        await Task.WhenAll(depositTask, checkTask);

//        Console.WriteLine($"Final Balance: {account.GetBalance()}");
//    }
//}