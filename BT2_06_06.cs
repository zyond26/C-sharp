/*Exercise 2: Bank Account Exception Handling

Write a C# program to simulate a simple bank account. Create a BankAccount class with methods to deposit and withdraw funds, and a property to get the account balance. Handle the following exceptions:

If an attempt to withdraw results in a negative balance, throw a custom exception called InsufficientFundsException.
If an attempt to deposit or withdraw with a negative amount, throw a custom exception called NegativeAmountException
*/
using System;

public class InsufficientFundsException : Exception
{
    public InsufficientFundsException(string message) : base(message)
    {
    }
}
public class NegativeAmountException : Exception
{
    public NegativeAmountException(string message) : base(message)
    {
    }
}
public class BankAccount
{
    private decimal balance;

    public decimal Balance
    {
        get { return balance; }
    }
    public void Deposit(decimal amount)
    {
        if (amount < 0)
        {
            throw new NegativeAmountException("so tien gui vao khong duoc am");
        }

        balance += amount;
        Console.WriteLine($"Gui thanh cong {amount}. So du hien tai: {balance}");
    }

    public void Withdraw(decimal amount)
    {
        if (amount < 0)
        {
            throw new NegativeAmountException("So tien rut ra ko duoc am.");
        }

        if (balance - amount < 0)
        {
            throw new InsufficientFundsException("So du khong du de am.");
        }

        balance -= amount;
        Console.WriteLine($"Rut tien ra thanh cong: {amount}. so du hien tai {balance}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            BankAccount account = new BankAccount();

            // các vd sẵn cho số tiền gửi và rút ra 

            account.Deposit(100);
            account.Withdraw(50);
            account.Withdraw(70); // This will throw InsufficientFundsException
            account.Deposit(-20); // This will throw NegativeAmountException
        }
        catch (NegativeAmountException ex)
        {
            Console.WriteLine($"bug: {ex.Message}");
        }
        catch (InsufficientFundsException ex)
        {
            Console.WriteLine($"bug: {ex.Message}");
        }
    }
}
