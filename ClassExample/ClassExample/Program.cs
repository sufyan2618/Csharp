using System;
using System.Collections.Generic;

class Account
{
    public int accountNumber;
    public int accountBalance;
    public string accountName;

    public Account(int accountNumber, string accountName, int accountBalance)
    {
        this.accountNumber = accountNumber;
        this.accountName = accountName;
        this.accountBalance = accountBalance;
    }

    public int Deposit(int amount)
    {
        accountBalance += amount;
        return accountBalance;
    }

    public int Withdraw(int amount)
    {
        accountBalance -= amount; // Fixed withdrawal logic to subtract the amount  
        return accountBalance;
    }

    public virtual void getAccountInfo()
    {
        Console.WriteLine("Account Number: {0}", accountNumber);
        Console.WriteLine("Account Name: {0}", accountName);
        Console.WriteLine("Account Balance: {0}", accountBalance);
    }
}

class SavingAccount : Account
{
    public SavingAccount(int accountNumber, string accountName, int accountBalance)
        : base(accountNumber, accountName, accountBalance)
    {
    }

    public int CalculateAnnualInterest()
    {
        int interestRate;

        if (this.accountBalance < 100000)
        {
            interestRate = 5;
        }
        else if (this.accountBalance >= 100000 && this.accountBalance < 500000)
        {
            interestRate = 10;
        }
        else
        {
            interestRate = 15;
        }

        return (this.accountBalance * interestRate) / 100; // Return calculated interest amount  
    }

    public int CalculateMonthlyInterest()
    {
        int annualInterest = CalculateAnnualInterest();
        return annualInterest / 12; // Return monthly interest based on annual interest  
    }

    public override void getAccountInfo()
    {
        base.getAccountInfo(); // Call base class method  
        // Add details specific to Saving Account  
        Console.WriteLine("Annual Interest: {0}", CalculateAnnualInterest());
        Console.WriteLine("Monthly Interest: {0}", CalculateMonthlyInterest());
    }
}

class AccountTest // Removed the parentheses to fix the class declaration  
{
    public static void Main()
    {
        Account currentAccount = new Account(1, "Sufyan", 2100);
        Account currentAccount1 = new Account(3, "Ali", 2100);
        Account currentAccount2 = new Account(2, "Saif", 2100);
        SavingAccount savingAccount = new SavingAccount(12, "Arslan", 2300);

        List<Account> accounts = new List<Account>
        {
            currentAccount2,
            currentAccount1,
            currentAccount,
            savingAccount
        };

        // Display account information for all accounts  
        foreach (var account in accounts)
        {
            account.getAccountInfo();
            Console.WriteLine(); // Add a newline for better readability  
        }
    }
}