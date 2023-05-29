using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp.Bank
{
    public class BusinessCustomer:Customer
    {
        private int ABN;

        public BusinessCustomer(string name, string address, int ABN) : base(name, address)
        {
            this.ABN = ABN;
        }
        public int _ABN
        {
            get { return ABN; }
            set { ABN = value; }
        }
        public void showBusinessCustomerDetails()
        {
            Console.WriteLine("Customer Name: " + base.CustName);
            Console.WriteLine("Customer Address: " + base.CustAddress);
            Console.WriteLine("ABN: " + ABN);

        }

    }
}
