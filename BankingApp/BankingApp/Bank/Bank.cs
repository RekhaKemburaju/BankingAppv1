using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankingApp.Bank
{
    public class Bank
    {
        private List<Account> accountList;
        private List<Customer> customerList;

        public Bank()
        {
            accountList = new List<Account>();
            customerList = new List<Customer>();
        }
        public List<Customer> getCustomerList()
        {
            return customerList;
        }
        public void addNewAccount(Account a)
        {
            accountList.Add(a);
        }
        public void addCustomer(Customer c)
        {
            accountList.Add(c);
        }
        public void displayAllAccountDetails()
        {
            for (int i = 0; i < accountList.Count; i++)
            {
                accountList[i].displayAccountdetails();
            }
        }
        public double getTotalBalancesOfAllAccounts()
        {
            double totalBalances = 0;
            for (int i = 0; i < accountList.Count; i++)
            {
                totalBalances = totalBalances + accountList[i].AccountBalance;
            }
            return totalBalances;

        }
        public Account getAccountByAccountNo(int accountNo)
        {
            Account account1 = new Account();
            for (int i = 0; i < accountList.Count; i++)
            {
                if (accountList[i].AccountNumber == accountNo)
                {

                    account1 = accountList[i];

                }

            }
            return account1;
        }
        public Account getAccountByAccountNoQuery(int accountNo)
        {

            Account account1 = new Account();
            var queryResult = from accounts in accountList
                              where accounts.AccountNumber == accountNo
                              select accounts;

            queryResult.ToList().ForEach(acc => account1 = acc);

            /*  foreach (var acc in queryResult) {
                 account1 = acc;
               }*/

            return account1;
        }
        public Account getAccountByAccountNameQuery(string accountName)
        {

            Account account1 = new Account();
            var queryResult = from accounts in accountList
                              where accounts.AccountName == accountName
                              select accounts;

            queryResult.ToList().ForEach(acc => account1 = acc);

            /*  foreach (var acc in queryResult) {
                 account1 = acc;
               }*/

            return account1;
        }

    }
}
