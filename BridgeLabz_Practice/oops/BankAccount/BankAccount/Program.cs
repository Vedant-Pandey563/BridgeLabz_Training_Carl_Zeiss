using System;
namespace BankAccount
{
    class BankAccount
    {
        public int accountNumber;
        protected string accountHolder;
        private double balance;

        public BankAccount (int accountNumber, string accountHolder, double balance)
        {
            this.accountNumber = accountNumber;
            this.accountHolder = accountHolder;
            this.balance = balance;
        }

        public double getBalance()
        {
            return balance;
        }
        public void setBalance(double balance)
        {
            this.balance = balance;
        }

        public void displayBalance()
        {
            Console.WriteLine("Account Number : " + accountNumber);
            Console.WriteLine("Account Holder :" + accountHolder);
            Console.WriteLine("Balance:"+balance);
        }
    }

    class SavingsAccount : BankAccount
    {
        public SavingsAccount(int accountNumber, string accountHolder, double balance) : base(accountNumber, accountHolder, balance)
        {
            Console.WriteLine("Savings Account Number : " +accountNumber);
            Console.WriteLine("Savings Account Holder :" +accountHolder);
            Console.WriteLine("Savings Account Balance:"+getBalance());
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount b1 = new BankAccount(123456, "A", 9.2);
            b1.displayBalance();

            b1.setBalance(3.14);

            Console.WriteLine("Bank Account after Updating Balance:");
            b1.displayBalance();

            SavingsAccount s1 = new SavingsAccount(8976, "B",6.7);
        }
    }
}
