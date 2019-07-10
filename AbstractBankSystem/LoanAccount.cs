using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractBankSystem
{
    internal class LoanAccount : Account
    {
        public LoanAccount(Customer customer, float interestRate) : this(customer, 0.0d, interestRate)
        {

        }

        public LoanAccount(Customer customer, double balance, float interestRate) : base(customer, balance, interestRate)
        {
            this.AccountType = "Loan";
        }

        public override double CalculateInterest(int NumberOfMonths)
        {
            double interest = 0;
            // Companies have no interest for the first two months
            if (this.customer.IsCompany && NumberOfMonths > 2)
            {
                int monthsOverTwo = NumberOfMonths - 2;
                interest = monthsOverTwo * this.interestRate;
            }
            
            // Individual have no interst for the first three months
            if (!this.customer.IsCompany && NumberOfMonths > 3)
            {
                int monthsOverThree = NumberOfMonths - 3;
                interest = monthsOverThree * this.interestRate;
            }

            return interest;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Account holders name: " + this.customer.ToString());
            result.AppendLine("Company Account: " + this.customer.IsCompany);
            result.AppendLine("Account Balance: " + this.balance);
            result.AppendLine("Interest Rate: " + this.interestRate);
            return result.ToString();
        }
    }
}
