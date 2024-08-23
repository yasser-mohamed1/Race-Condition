# Race Condition Demo in C#

## Overview

This project demonstrates a race condition in C# by simulating a simple bank account system. Multiple threads attempt to deposit and withdraw funds simultaneously, leading to data inconsistency due to unsynchronized access to the account balance. The project also shows how to solve this issue using the `lock` statement to synchronize the threads.

## What is a Race Condition?

A race condition occurs when two or more threads attempt to modify the state of a shared resource simultaneously without proper synchronization, resulting in unpredictable behavior.

## Example Problem

The project simulates a bank account system where two threads perform multiple transactions on a shared account. Without proper synchronization, the final account balance becomes inconsistent.

## Solution

We use a `lock` mechanism in C# to ensure that only one thread can modify the account balance at a time, preventing race conditions.

## Getting Started

### Prerequisites

- Visual Studio or any C# IDE
- .NET SDK (Core or Framework)

### Installing

1. Clone the repository.

```bash
git clone git@github.com:yasser-mohamed1/Race-Condition.git
```

2. Open the project in Visual Studio or your preferred IDE.
3. Build and run the solution.

### Usage

The program simulates multiple threads accessing and modifying the account balance:

- `Deposit and Withdraw`: Methods without synchronization that cause a race condition.
- `DepositWithLock` and `WithdrawWithLock`: Methods using lock to avoid race conditions.

You can run the code to observe the final balance, both with and without locks.

### Code Example

Here’s an example of a method that causes a race condition:

```csharp
public void Deposit(int amount)
{
    _balance += amount;
}
```

Here’s a solution using a lock to prevent the race condition:

```csharp
public void DepositWithLock(int amount)
{
    lock (_lock)
    {
        _balance += amount;
    }
}
```

### License

This project is licensed under the MIT License – see the LICENSE file for details.

### Conclusion

This project provides a basic example of how race conditions can occur in a multithreaded application and demonstrates how you can resolve them using thread synchronization techniques like the lock keyword.
