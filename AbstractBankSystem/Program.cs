using System;

namespace AbstractBankSystem
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            TestBank();
            //TestLoanAccounts();
            //TestMortgageAccounts();
            //TestDepositAccounts();
            //TestCustomer();
        }

        private static void TestBank()
        {
            Customer ilara = new Company("Ilara Yoghurt");
            Customer bugati = new Company("Bugatti cars");
            Customer blackCollection = new Company("Black Collections");
            Customer haron = new Individual("Haron", "Kipkorir");
            Customer brian = new Individual("Brian", "Smit");
            Customer natLiv = new Individual("Natalie", "Olivia");

            Account haronAccount = new DepositAccount(haron, 1200, 1.5f);
            Account ilaraAccount = new LoanAccount(ilara, 8700, 2.4f);
            Account bugatiAccount = new MortgageAccount(bugati, 1000, 2.3f);
            Account blackAccount = new DepositAccount(blackCollection, 1230, 1.3f);
            Account brianAccount = new LoanAccount(brian, 300, 0f);
            Account natLivAccount = new DepositAccount(natLiv, 200, 2.0f);

            Bank worldBank = new Bank("World Bank");
            worldBank.Customers.Add(ilara);
            worldBank.Customers.Add(bugati);
            worldBank.Customers.Add(blackCollection);
            worldBank.Customers.Add(haron);
            worldBank.Customers.Add(brian);
            worldBank.Customers.Add(natLiv);

            worldBank.Accounts.Add(haronAccount);
            worldBank.Accounts.Add(ilaraAccount);
            worldBank.Accounts.Add(bugatiAccount);
            worldBank.Accounts.Add(blackAccount);
            worldBank.Accounts.Add(brianAccount);
            worldBank.Accounts.Add(natLivAccount);

            Console.WriteLine(worldBank);
        }

        private static void TestCustomer()
        {
            Customer haron = new Individual("Haron", "Kipkorir");
            Customer detox = new Company("Herbal detox");

            Console.WriteLine(haron);
            Console.WriteLine(detox);
            Console.WriteLine(haron.IsCompany);
            Console.WriteLine(detox.IsCompany);
        }

        private static void TestDepositAccounts()
        {
            Customer haron = new Individual("Haron", "Kipkorir");
            Customer bugati = new Company("Bugatti cars");
            Customer trendyCollection = new Company("Trendy T Collections");
            Customer kuddah = new Individual("Anthony", "Karuen");

            Account haronAccount = new DepositAccount(haron, 1200, 1.5f);
            Account bugatiAccount = new DepositAccount(bugati, 1.6f);
            Account kuddahAccount = new DepositAccount(kuddah, -200, 2.3f);
            Account trendyAccount = new DepositAccount(trendyCollection, 5200, 2.3f);

            Console.WriteLine(haronAccount);
            double interest = haronAccount.CalculateInterest(12);
            Console.WriteLine("Haron Interest: {0}", interest);
            Console.WriteLine("Account balance after withdrawal: {0}", haronAccount.Withdraw(400d));
            Console.WriteLine("Haron's Interest after withdrawal: {0}", haronAccount.CalculateInterest(12));
            Console.WriteLine("Account balance after withdrawal: {0}", haronAccount.Withdraw(900));

            Console.WriteLine();
            Console.WriteLine(bugatiAccount);
            Console.WriteLine(kuddahAccount);
            Console.WriteLine(trendyAccount);

            kuddahAccount.Withdraw(200);
            interest = kuddahAccount.CalculateInterest(2);

        }

        private static void TestMortgageAccounts()
        {
            // Create a number of customers
            Customer copperMotors = new Company("Cooper motors");
            Customer pataHustle = new Company("Pata Hustle");
            Customer haron = new Individual("Haron", "Rono");
            Customer brian = new Individual("Brian", "Smit");

            // Create a number of Mortgage bank accounts
            Account cMotosAccount = new MortgageAccount(copperMotors, 5300, 2.3f);
            Account pataHustleAccount = new MortgageAccount(pataHustle, 600, 1.5f);
            Account haronAccount = new MortgageAccount(haron, 300, 1.5f);
            Account brianAccount = new MortgageAccount(brian, 8700, 5.2f);

            // Individual Interest for less than 6 months
            double haronInterest = haronAccount.CalculateInterest(4); // 4 Months
            double brianInterest = brianAccount.CalculateInterest(2); // 2 Months
            Console.WriteLine("Individual Interest for less than 6 months: ");
            Console.WriteLine("Haron's Interest: " + haronInterest);
            Console.WriteLine("Brian's Interest: " + brianInterest);

            // Individual Interest after 6 months:
            haronInterest = haronAccount.CalculateInterest(8);
            brianInterest = brianAccount.CalculateInterest(13);
            Console.WriteLine("\nIndividual Interest after 6 months: ");
            Console.WriteLine("Haron's Interest: " + haronInterest);
            Console.WriteLine("Brian's Interest: " + brianInterest);

            // Company Interest during the first 12 months
            double cMotorsInterst = cMotosAccount.CalculateInterest(8);
            double pataHustleInterest = pataHustleAccount.CalculateInterest(8);
            Console.WriteLine("\nCompany Interest during the first 12 months: ");
            Console.WriteLine("Cooper Interest: " + cMotorsInterst);
            Console.WriteLine("Pata Hustle Interest: " + pataHustleInterest);

            // Company Interest after the first 12 months
            cMotorsInterst = cMotosAccount.CalculateInterest(18);
            pataHustleInterest = pataHustleAccount.CalculateInterest(18);
            Console.WriteLine("\nCompany Interest after the first 12 months: ");
            Console.WriteLine("Cooper Interest: " + cMotorsInterst);
            Console.WriteLine("Pata Hustle Interest: " + pataHustleInterest);

            // Print everyone's infromation
            Console.WriteLine("\nAll Mortgage Account Holders");
            Console.WriteLine(cMotosAccount);
            Console.WriteLine(pataHustleAccount);
            Console.WriteLine(haronAccount);
            Console.WriteLine(brianAccount);
        }

        private static void TestLoanAccounts()
        {
            // Create a number of customers
            Customer copperMotors = new Company("Cooper motors");
            Customer pataHustle = new Company("Pata Hustle");
            Customer haron = new Individual("Haron", "Rono");
            Customer brian = new Individual("Brian", "Smit");

            // Create a number of Mortgage bank accounts
            Account cMotosAccount = new LoanAccount(copperMotors, 5300, 2.3f);
            Account pataHustleAccount = new LoanAccount(pataHustle, 600, 1.5f);
            Account haronAccount = new LoanAccount(haron, 300, 1.5f);
            Account brianAccount = new LoanAccount(brian, 8700, 5.2f);

            // Individual Interest for less than 2 months
            double haronInterest = haronAccount.CalculateInterest(1); // 1 Month
            double brianInterest = brianAccount.CalculateInterest(2); // 2 Months
            Console.WriteLine("Individual Interest for less than 2 months: ");
            Console.WriteLine("Haron's Interest: " + haronInterest);
            Console.WriteLine("Brian's Interest: " + brianInterest);

            // Individual Interest after 2 months:
            haronInterest = haronAccount.CalculateInterest(4);
            brianInterest = brianAccount.CalculateInterest(7);
            Console.WriteLine("\nIndividual Interest after 2 months: ");
            Console.WriteLine("Haron's Interest: " + haronInterest);
            Console.WriteLine("Brian's Interest: " + brianInterest);

            // Company Interest during the first 3 months
            double cMotorsInterst = cMotosAccount.CalculateInterest(2);
            double pataHustleInterest = pataHustleAccount.CalculateInterest(2);
            Console.WriteLine("\nCompany Interest during the first 3 months: ");
            Console.WriteLine("Cooper Interest: " + cMotorsInterst);
            Console.WriteLine("Pata Hustle Interest: " + pataHustleInterest);

            // Company Interest after the first 3 months
            cMotorsInterst = cMotosAccount.CalculateInterest(6);
            pataHustleInterest = pataHustleAccount.CalculateInterest(7);
            Console.WriteLine("\nCompany Interest after the first 3 months: ");
            Console.WriteLine("Cooper Interest: " + cMotorsInterst);
            Console.WriteLine("Pata Hustle Interest: " + pataHustleInterest);

            // Print everyone's infromation
            Console.WriteLine("\nAll Mortgage Account Holders");
            Console.WriteLine(cMotosAccount);
            Console.WriteLine(pataHustleAccount);
            Console.WriteLine(haronAccount);
            Console.WriteLine(brianAccount);
        }
    }
}
