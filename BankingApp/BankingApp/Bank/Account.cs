using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp.Bank
{
    public class Account
    {
        private String accountName;
        private int accountNumber;
        private double accountbalance;
        // static variable common across all the classes
        private static int Account_InstanceCount = 1;

        public Account()
        {

        }

        public Account(String accountName, double accountbalance)
        {
            //increases the count every time an object is created.
            this.accountNumber = Account_InstanceCount++;
            this.accountName = accountName;
            this.accountbalance = accountbalance;

        }
        public Account(String accountName)
        {
            this.accountNumber = Account_InstanceCount++;
            this.accountName = accountName;
            this.accountbalance = 0;


        }
        //Getter and Setter Methods using properties
        public String AccountName
        {
            get { return accountName; }
            set { accountName = value; }
        }
        public int AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }
        // another way to write get and set methods using properties
        public double AccountBalance
        {
            get => accountbalance;
            set => accountbalance = value;
        }

        //one line method
        public void withDrawMoney(double withdrawalAmount) => accountbalance = accountbalance - withdrawalAmount;

        public void depositeMoney(double depositeAmount)
        {
            accountbalance = accountbalance + depositeAmount;
        }
        public void ChangeAccountName(String newAccountName)
        {
            accountName = newAccountName;
        }
        public void displayAccountdetails()
        {
            Console.WriteLine("Account Name: " + accountName);
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Account Balance: " + accountbalance);
        }
    }
}
