# Abstract Bank System

## Problem Statement
A bank holds different types of account for its customers: deposit accounts, loan accounts and mortgage accounts. Customers can be individual or companies. All accounts have a customer, balance and interest rate (monthly based). Deposit accounts allow depositing and withdrawing of money. Loan and mortgage accounts allow only depositing. All accounts can calculate their interest for a given period (in months). In the general case, it is calculated as follows: number_of_months * interest_rate. Loan accounts have no interest rate during the first 3 meonths if held by individuals and during the first 2 months if held by a company. Deposit accounts have no interest rate if their balance is positive and less than 1000. Mortgage accounts have 1/2 the interest rate during the first 12 months for companies and no interest rate during the first 6 months for individuals.

## Task
To write an object-oriented model of the bank system. Identify the classes, interfaces, base classes and abstract actions and implement the interest calculation functionality.

## Clarification of the problem statement. 
1. Customers can be individual or companies.
2. All accounts have a customer.
3. A bank hold different types of accounts for its customers: deposit accounts, loan accounts, and mortgage accounts.

## What is expected of us based on the problem statement.
1. We need a way to differentiate a customer as either an individual or company. We can either create on class customer and have a bool field inside it that tells us whether the current object represents a individual or a company or create three classes, Customer, Individual and Company. Individual and Company inherit from Customer. Customer has a bool auto-property IsCompany, that gets field automatically in the constructors of Individual and Company with the respective value false and true. I went with the latter 3 classes idea, bad choice, too much code, choose wise!
2. We need a way to hold the different accounts the bank had for its customer, and based on that, we can generate three classes, DepositAccount, MortgageAccount and LoanAccount. But since these three classes have a lot in common, such as, they all require a customer, they all calculate interest, they all allow depositing of money, and they all have a balance and an interest, we can create an abstract class Account, with fields and methods they share in common and an abstract method CalculateInterest(). The method Deposit() would also be implemented in this class because it's the same code throughout the three classes.

## What I did..
I created three classes, Customer, Individual and Company to represent the customers of the bank, implementation in this repository. I also created four classes, Account, LoanAccount, MortgageAccount and DepositAccount to represent the accounts offered by the bank. And I added an extra class Bank to represent the whole bank which has a list of accounts, customers in the bank and the name of the bank. I wrote manual tests to test the abstract bank and I'm glad it turned out fine. 

## Environment used
Visual Studio 2019, Console app(.NET core 2.2)