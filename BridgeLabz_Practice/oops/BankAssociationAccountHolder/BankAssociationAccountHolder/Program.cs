namespace BankAssociationAccountHolder
{
    public class Account
    {
        public int accountNumber {  get; }
        public double balance {get; set;}
        public Bank Bank { get; }

        public Account (int accountNumber, Bank bank)//intialization constructor
        {
            this.accountNumber = accountNumber;
            Bank = bank;
        }

        public void Deposit (double amount)
        {
            balance += amount;
        }
    }

    public class Customer
    {
        public string name { get; }
        private List<Account> accounts;

        public Customer(string name)
        {
            this.name = name;
            accounts = new List<Account>();
        }

        public void AddAccount(Account account)
        {
            accounts.Add(account);
        }

        public void ViewBalance()
        {
            Console.WriteLine($"Balance for {name}");
            foreach (var account in accounts)
            {
                Console.WriteLine(
                    $"Bank: {account.Bank.BankName}," +
                    $"Account No: {account.accountNumber}," +
                    $"Balance: {account.balance}"
                    );
            }
        }
    }

    public class Bank
    {
        public string BankName { get; }
        private List<Account> accounts;
        private int nextAccountNumber = 1001;

        public Bank(string bankName)
        {
            this.BankName = bankName;
            accounts = new List<Account>();
        }

        public Account NewAccount (Customer customer)
        {
            Account account = new Account(nextAccountNumber++, this);
            accounts.Add(account);
            customer.AddAccount(account);

            return account;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank hdfc = new Bank("HDFC Bank");
            Bank sbi = new Bank("SBI");

            Customer A = new Customer("A");

            Account acc1 = hdfc.NewAccount(A);
            Account acc2 = sbi.NewAccount(A);

            Customer B = new Customer("B");
            Account acc3 = hdfc.NewAccount(B);
            

            acc1.Deposit(83924);
            acc2.Deposit(1234);

            A.ViewBalance();
            B.ViewBalance();
        }
    }
}
