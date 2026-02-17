using System;
using System.Collections.Generic;
using System.Text;

namespace ExcpetionsPractice1
{
    class InsuffcientBalanceExcpetion : Exception
    {
        public InsuffcientBalanceExcpetion(string message) : base(message) { }
    }
    internal class BankCustomException
    {
        public static int Balance = 5000;
        public static void Withdraw(int amt)
        {
            if(amt>Balance)
            {
                throw new InsuffcientBalanceExcpetion("Insufficent Balance Bikhari");
            }

            Balance -= amt;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Withdrawl Amount : ");
            int amt = int.Parse(Console.ReadLine());
            Withdraw(amt);
            Console.WriteLine("Balance:" + Balance);

        }
        

    }
}
