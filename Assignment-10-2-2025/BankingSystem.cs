using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    abstract class BankAccount
    {
        private string accountNumber;
        private string holderName;
        private double balance;
        public BankAccount(string accountNumber, string holderName, double
        balance)
        {
            this.accountNumber = accountNumber;
            this.holderName = holderName;
            this.balance = balance;
        }

        public string AccountNumber { get { return accountNumber; } }
        public string HolderName { get { return holderName; } }
        public double Balance
        {
            get { return balance; }
            protected set
            {
                balance = value;
            }
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited {amount:C} into{accountNumber}. New balance: {balance: C}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        public virtual void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrew Rs.{amount} from{accountNumber}. Remaining balance: Rs.{balance}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
            }
        }

        public abstract double CalculateInterest();
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Account: {accountNumber}, Holder:{holderName}, Balance: Rs.{balance} ");
        }

    }

    interface ILoanable
    {
        void ApplyForLoan(double amount);
        double CalculateLoanEligibility();
    }

    class SavingsAccount : BankAccount, ILoanable
    {
        private double interestRate = 0.04; // 4% interest
        public SavingsAccount(string accountNumber, string holderName,
        double balance) : base(accountNumber, holderName, balance) { }
        public override double CalculateInterest()
        {
            return Balance * interestRate;
        }
        public void ApplyForLoan(double amount)
        {
            Console.WriteLine($"Loan of Rs.{amount} applied for savings account { AccountNumber}.");
        }

        public double CalculateLoanEligibility()
        {
            return Balance * 5; // Eligible for 5x balance loan
        }
    }

    class CurrentAccount : BankAccount
    {
        private double interestRate = 0.02; // 2% interest
        public CurrentAccount(string accountNumber, string holderName,
        double balance) : base(accountNumber, holderName, balance) { }
        public override double CalculateInterest()
        {
            return Balance * interestRate;
        }
    }
}
