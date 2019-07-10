using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AbstractBankSystem
{
    internal class Bank
    {
        public string Name { get; private set; }
        public List<Account> Accounts { get; set; }
        public List<Customer> Customers { get; set; }

        public  Bank(string name)
        {
            this.Name = name;
            Accounts = new List<Account>();
            Customers = new List<Customer>();
        }

        public override string ToString()
        {
            StringBuilder bankInformation = new StringBuilder();
            bankInformation.AppendLine("Banks name: " + this.Name);
            bankInformation.AppendLine("\nAccounts we have:");
            foreach (Account account in Accounts)
            {
                bankInformation.AppendLine("\nAccount type: " + account.AccountType);
                bankInformation.Append(account);
            }
            bankInformation.AppendLine("\nCustomers we have:");
            foreach (Customer customer in Customers)
            {
                bankInformation.Append("\n");
                bankInformation.Append(customer);
            }
            return bankInformation.ToString();
        }
    }
}
