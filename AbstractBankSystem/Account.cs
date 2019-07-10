using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractBankSystem
{
    internal abstract class Account
    {
        protected Customer customer;
        protected double balance;
        protected float interestRate;
        public string AccountType { get; protected set; }

        public Account(Customer customer, float interestRate) : this(customer, 0.0d, interestRate)
        {

        }

        public Account(Customer customer, double balance, float interestRate)
        {
            this.customer = customer;
            this.balance = balance;
            this.interestRate = interestRate;
        }

        public void Deposit(double amount)
        {
            this.balance += amount;
        }

        public abstract double CalculateInterest(int NumberOfMonths);
        public virtual double Withdraw(double amount)
        {
            throw new InvalidOperationException("You cannot withdraw from this account.");
        }
    }
}
