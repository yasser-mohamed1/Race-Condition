using System;
using System.Threading;

namespace RaceConditionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(1000); // Starting with $1000

            // Creating two threads that will try to update the account balance simultaneously.
            Thread thread1 = new Thread(() => PerformTransactions(account));
            Thread thread2 = new Thread(() => PerformTransactions(account));

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            Console.WriteLine($"Final Account Balance: {account.Balance}"); // The reslut should be 1000 !!
                                                                            // Try to use WithLock functions to prevent race conditions.
            Console.ReadLine();
        }

        static void PerformTransactions(BankAccount account)
        {
            for (int i = 0; i < 10000000; i++)
            {
                account.Deposit(1); // Depositing $1
                account.Withdraw(1); // Withdrawing $1
            }
        }
    }
}
