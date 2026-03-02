using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp
{
    public class BankAccount
    {
        public decimal Balance { get; private set; } = 0m;

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive");
            }
                Balance += amount;
        }


        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Withdraw amount must be positive");

            if (amount > Balance)
                throw new InvalidOperationException("Insufficient funds");

            Balance -= amount;
        }
    }
}
