namespace RaceConditionDemo
{
    class BankAccount
    {
        private object _lock = new object(); // A Locker used to ensure that only one thread can access
                                             // the critical section of code at any given time to prevent race conditions.
        private int _balance;

        public BankAccount(int initialBalance)
        {
            _balance = initialBalance;
        }

        public int Balance => _balance;

        // This method will cause race conditions if accessed by multiple threads
        public void Deposit(int amount)
        {
            _balance += amount;
        }

        // This method will cause race conditions if accessed by multiple threads
        public void Withdraw(int amount)
        {
            _balance -= amount;
        }

        // To fix the race condition, we use a synchronized approach
        public void DepositWithLock(int amount)
        {
            lock (_lock)
            {
                _balance += amount;
            }
        }

        public void WithdrawWithLock(int amount)
        {
            lock (_lock)
            {
                _balance -= amount;
            }
        }
    }
}
