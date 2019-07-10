using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractBankSystem
{
    internal class MortgageAccount : Account
    {
        public MortgageAccount(Customer customer, float interestRate) : this(customer, 0.0d, interestRate)
        {

        }

        public MortgageAccount(Customer customer, double balance, float interestRate) : base(customer, balance, interestRate)
        {
            this.AccountType = "Mortgage";
        }
        public override double CalculateInterest(int NumberOfMonths)
        {
            double interest = 0;

            if (this.customer.IsCompany)
            {
                // Interest rate for a company
                if (NumberOfMonths > 12)
                {
                    // If the interest is calculate after 12 months
                    interest = 12 * 0.5 * this.interestRate;
                    int monthsOverAYear = NumberOfMonths - 12;
                    interest += (monthsOverAYear * this.interestRate);
                    return interest;
                }

                // If the interest is after less than an year we calculate and half the interest rate
                interest = NumberOfMonths * 0.5 * this.interestRate;
                return interest;
            }
            else
            {
                // Interst rate for an individual
                // No interest for the first 6 months
                if (NumberOfMonths > 6)
                {
                    int months = NumberOfMonths - 6;
                    interest = months * this.interestRate;
                    return interest;
                }
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
