//using System;
//using System.Threading;
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

//        Task depositTask = DepositAsync(account);
//        Task checkTask = CheckAsync(account);

//        await Task.WhenAll(depositTask, checkTask);

//        Console.WriteLine("Completed");
//    }

//    static async Task DepositAsync(BankAccount account)
//    {
//        for (int i = 0; i < 5; i++)
//        {
//            account.Deposit(100);
//            await Task.Delay(500); // non-blocking delay
//        }
//    }

//    static async Task CheckAsync(BankAccount account)
//    {
//        for (int i = 0; i < 5; i++)
//        {
//            Console.WriteLine($"Checked: {account.GetBalance()}");
//            await Task.Delay(300);
//        }
//    }
//}