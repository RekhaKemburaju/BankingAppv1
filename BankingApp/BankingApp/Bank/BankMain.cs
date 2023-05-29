using BankingApp.Bank;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BankingApp.Bank
{
    class BankMain
    {
        public static void Main(String[] args)
        {
            //Exercise 3
            /*
            // Hard code 
            AccountDetails acctDeatilObj = new AccountDetails("Rekha");
            acctDeatilObj.displayAccountdetails();
            acctDeatilObj.depositeMoney(100);
            acctDeatilObj.displayAccountdetails();
            acctDeatilObj.withDrawMoney(50);
            acctDeatilObj.displayAccountdetails();
            */

            /*
            //using User Input
            Console.Out.WriteLine("Please provide your name");
            string name = Console.ReadLine();
            AccountDetails acctDeatilObj2 = new AccountDetails(name);       
            Console.Out.WriteLine($"Account No :  { acctDeatilObj2.AccountNumber} has the balance of {acctDeatilObj2.AccountBalance}");

            Console.Out.WriteLine("Deposit amount :");
            double deposite = Double.Parse(Console.ReadLine());
            acctDeatilObj2.depositeMoney(deposite);
            Console.Out.WriteLine("Balance after deposite is " + acctDeatilObj2.AccountBalance);

            Console.Out.WriteLine("Withdraw amount :");
            double withdarw = Double.Parse(Console.ReadLine());
            acctDeatilObj2.withDrawMoney(withdarw);
            Console.Out.WriteLine("Balance after withdarwal is " + acctDeatilObj2.AccountBalance);
            */

            /*
            Account accountObj1 = new Account("Rekha");
            Account accountObj2 = new Account("siva");
            Account accountObj3 = new Account("kaarthik");
            accountObj1.AccountBalance = 100;
            accountObj2.AccountBalance = 100;
            accountObj3.AccountBalance = 100;

            Bank bankObj = new Bank();
            bankObj.addNewAccount(accountObj1);
            bankObj.addNewAccount(accountObj2);
            bankObj.addNewAccount(accountObj3);

           
            // search account by name LINQ
            Account a1= bankObj.getAccountByAccountNameQuery("Rekha");
            a1.displayAccountdetails();

            //search account by accountId LINQ
            a1 = bankObj.getAccountByAccountNoQuery(3);
            a1.displayAccountdetails();

            //search account by accountId
            a1 = bankObj.getAccountByAccountNoQuery(2);
            a1.displayAccountdetails();

            Console.Out.WriteLine("Total Balance "+ bankObj.getTotalBalancesOfAllAccounts());
            */


            
            Account accountObj;
            Bank bankObj = new Bank();
            int choice = 0;
            while (choice != 1)
            {
                int accountNum = 0;
                Account a = new Account();
                Boolean result = false;
                Console.Out.WriteLine("1 - Leave the Bank");
                Console.Out.WriteLine("2 - Create new Bank account");
                Console.Out.WriteLine("3 - Deposite Money");
                Console.Out.WriteLine("4 - Withdarw Money");
                Console.Out.WriteLine("5 - Change Account Name");
                Console.Out.WriteLine("6 - Get Account Balance");
                Console.Out.WriteLine("7 - Get Account Name");
                Console.Out.WriteLine("8 - Show Account Detail");

                Console.Out.WriteLine("Enter your Choice >");
                choice = Int32.Parse(Console.ReadLine());

                if (choice == 1 || choice == 2)
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Out.WriteLine("Bye Bye");
                            break;
                        case 2:
                            Console.Out.WriteLine("Enter Account Name :");
                            accountObj = new Account(Console.ReadLine());
                            bankObj.addNewAccount(accountObj);
                            accountObj.displayAccountdetails();
                            break;

                    }
                }
                else if((2<choice) && (choice<9))
                {
                    Console.Out.WriteLine("Enter Account Number>");
                    accountNum = Int32.Parse(Console.ReadLine());
                    //a = bankObj.getAccountByAccountNo(accountNum);
                    a = bankObj.getAccountByAccountNoQuery(accountNum);
                    result = checkAccountExist(a, accountNum);
                    if (result)
                    {
                        switch (choice)
                        {                            
                            case 3:
                                Console.Out.WriteLine("Enter Deposite Amount>");
                                a.depositeMoney(double.Parse(Console.ReadLine()));
                                break;
                            case 4:
                                Console.Out.WriteLine("Enter Withdarw amount>");
                                a.withDrawMoney(double.Parse(Console.ReadLine()));
                                break;
                            case 5:
                                Console.Out.WriteLine("Enter new account Name > ");
                                a.AccountName = Console.ReadLine();
                                break;
                            case 6:
                                Console.Out.WriteLine("Your account balance is : " + a.AccountBalance);
                                break;
                            case 7:
                                Console.Out.WriteLine("Your account name is : " + a.AccountName);
                                break;
                            case 8:
                                a.displayAccountdetails();
                                break;  
                            default:
                                Console.Out.WriteLine("Please enter 1 to 8 only");
                                break;
                        }

                    }


                }
                else
                {
                    Console.Out.WriteLine("Please enter 1 to 8 only");
                    
                }
               
 
            }
            Boolean checkAccountExist(Account a, int accountNum)
            {
                if (a.AccountNumber == 0)
                {
                    Console.Out.WriteLine(" Account Number " + accountNum + " DO NOT EXIST");
                    return false;
                    
                }
                
                return true;
            }



            //Exerice 10 inheritence and Exercise 11 polymorphism

            BusinessCustomer bc1 = new BusinessCustomer("Tom", "Singapore 123", 1234);
            //bc1.showBusinessCustomerDetails();

            PersonalCustomer pc1 = new PersonalCustomer("Peter", "Melbouren 199", 456, "05 May 1980");
            //pc1.showPerosnalCustomerDetails();
         
            Bank bankObj1 = new Bank();
            bankObj1.addCustomer(pc1);
            bankObj1.addCustomer(bc1);

            List<Customer> custList = bankObj1.getCustomerList();

            for (int i=0; i< custList.Count;i++)
            {
                if (custList[i] is BusinessCustomer)
                {
                    BusinessCustomer bc = (BusinessCustomer)custList[0];
                    bc.showBusinessCustomerDetails();
                }
                else if (custList[i] is PersonalCustomer)
                {;
                    PersonalCustomer pc = (PersonalCustomer)custList[0];
                    pc.showPerosnalCustomerDetails();
                }

            }

            














        }
    }
}
