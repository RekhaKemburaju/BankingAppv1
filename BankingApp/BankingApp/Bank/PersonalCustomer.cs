using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp.Bank
{
    public class PersonalCustomer:Customer
    {
        private int TFN;
        private DateTime DOB;

        public PersonalCustomer(string name, string address, int tfn, String dOB) : base(name, address)
        {
            this.TFN = tfn;
            setDOB(dOB);
            DOB = getDOB();

        }
        public int _TFN
        {
            get => TFN;
            set => TFN = value;
        }
        public DateTime getDOB()
        {
            return DOB;
        }
        public void setDOB(String dateString)
        {
            DOB = DateTime.Parse(dateString);
        }
        public void showPerosnalCustomerDetails()
        {
            Console.WriteLine("Customer Name: " + base.CustName);
            Console.WriteLine("Customer Address: " + base.CustAddress);
            Console.WriteLine("ABN: " + TFN);
            Console.WriteLine("DOB :" + DOB);

        }


    }
}
