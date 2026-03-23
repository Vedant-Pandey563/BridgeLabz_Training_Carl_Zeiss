using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Concurrent;

class BankAccount
{
    private int Balance = 1000;
    private readonly SemaphoreSlim _semaphore = new SemaphoreSlim(1, 1);
    private readonly ConcurrentQueue<int> transactions = new ConcurrentQueue<int>();

    public async Task DepositAsync(int amount)
    {
        await _semaphore.WaitAsync();

        try
        {
            if (amount < 0)
                throw new Exception("Invalid deposit amount");

            Balance += amount;
            transactions.Enqueue(amount);

            Console.WriteLine($"Deposited: {amount}, Balance: {Balance}");
        }
        finally
        {
            _semaphore.Release();
        }
    }

    public async Task<int> GetBalanceAsync()
    {
        await _semaphore.WaitAsync();

        try
        {
            return Balance;
        }
        finally
        {
            _semaphore.Release();
        }
    }
}

class Program
{
    static async Task Main()
    {
        BankAccount account = new BankAccount();

        Task t1 = Task.Run(async () =>
        {
            try
            {
                await account.DepositAsync(100);
                await account.DepositAsync(-50); // will throw
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Deposit Error: {ex.Message}");
            }
        });

        Task t2 = Task.Run(async () =>
        {
            try
            {
                int balance = await account.GetBalanceAsync();
                Console.WriteLine($"Balance: {balance}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Check Error: {ex.Message}");
            }
        });

        try
        {
            await Task.WhenAll(t1, t2);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Global Error: {ex.Message}");
        }

        Console.WriteLine("Completed");
    }
}