using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractBankSystem
{
    internal abstract class Account
    {
        protected Customer customer;
        public double Balance { get; protected set; }
        public float InterestRate { get; protected set; }
        public string AccountType { get; protected set; }

        public Account(Customer customer, float interestRate) : this(customer, 0.0d, interestRate)
        {

        }

        public Account(Customer customer, double balance, float interestRate)
        {
            this.customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public virtual double Withdraw(double amount)
        {
            throw new InvalidOperationException("You cannot withdraw from this account.");
        }
        public virtual double Deposit(double amount)
        {
            this.Balance += amount;
            return this.Balance;
        }

        public abstract double CalculateInterest(int NumberOfMonths);
    }
}
