using System;

BankAccount account = new BankAccount("Alex", 5000);

AccountOperation depositOperation = account.Deposit;
AccountOperation withdrawOperation = account.Withdraw;

depositOperation(800);
account.PrintBalance();

withdrawOperation(400);
account.PrintBalance();

withdrawOperation(4000);
account.PrintBalance();

delegate void AccountOperation(double amount);

class BankAccount
{
    private double balance;
    private string Name;

    public BankAccount(string Name, double initialBalance)
    {
        this.Name = Name;
        this.balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine($"На счет \"{Name}\" внесено {amount}");
    }

    public void Withdraw(double amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
            Console.WriteLine($"Со счета \"{Name}\" снято {amount}");
        }
        else
        {
            Console.WriteLine("Недостаточно средств");
        }
    }

    public void PrintBalance()
    {
        Console.WriteLine($"Текущий баланс {Name}: {balance}");
    }
}

