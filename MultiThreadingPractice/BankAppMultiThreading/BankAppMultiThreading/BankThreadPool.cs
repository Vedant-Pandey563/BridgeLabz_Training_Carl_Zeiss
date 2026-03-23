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