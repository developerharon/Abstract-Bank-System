using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractBankSystem
{
    class DepositAccount : Account
    {
        public DepositAccount(Customer customer, float interestRate) : this (customer, 0.0d, interestRate)
        {

        }

        public DepositAccount(Customer customer, double balance, float interestRate) : base (customer, balance, interestRate)
        {
            this.AccountType = "Deposit";
        }

        public override double Withdraw(double amount)
        {
            if (this.Balance < amount)
            {
                Console.WriteLine("You have insuffient amount in your balance");
                return this.Balance;
            }

            this.Balance = this.Balance - amount;
            return this.Balance;
        }

        public override double CalculateInterest(int NumberOfMonth)
        {
            if (Balance < 0)
            {
                Console.WriteLine("Cannot calculate interest with negative balance");
                return 0.00d;
            }

            if (Balance < 1000)
            {
                return 0.0d;
            }
            double interest = NumberOfMonth * this.InterestRate;
            return interest;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Account holders name: " + this.customer.ToString());
            result.AppendLine("Company Account: " + this.customer.IsCompany);
            result.AppendLine("Account Balance: " + this.Balance);
            result.AppendLine("Interest Rate: " + this.InterestRate);
            return result.ToString();
        }
    }
}
