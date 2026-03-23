//class BankAccount
//{
//    private int Balance = 1000;
//    private readonly object _lock = new object();

//    public void Deposit(int amount)
//    {
//        lock (_lock)
//        {
//            Balance += amount;
//            Console.WriteLine($"Deposited: {amount}, New Balance: {Balance}");
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

//        Thread depositThread = new Thread(() =>
//        {
//            for (int i = 0; i < 5; i++)
//            {
//                account.Deposit(100);
//                Thread.Sleep(500);
//            }
//        });

//        Thread checkThread = new Thread(() =>
//        {
//            for (int i = 0; i < 5; i++)
//            {
//                account.CheckBalance();
//                Thread.Sleep(300);
//            }
//        });

//        depositThread.Start();
//        checkThread.Start();

//        depositThread.Join();
//        checkThread.Join();
//    }
//}