using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp.Bank
{
    public class Customer
    {
        private string custName;
        private String custAddress;


        public Customer(string custName, string custAddress)
        {
            this.custName = custName;
            this.custAddress = custAddress;

        }
        public String CustName
        {
            get { return custName; }
            set { custName = value; }
        }
        public String CustAddress
        {
            get { return custAddress; }
            set { custAddress = value; }
        }
    }
}
