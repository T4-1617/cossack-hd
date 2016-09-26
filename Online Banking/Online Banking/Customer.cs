using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Banking
{


    public class Customer
    {

        public Customer(string fName, string lName)
        {
            this.fName = fName;
            this.lName = lName;
        }

        private string fName { get; set; }
        private string lName { get; set; }


        public System.Collections.ArrayList accounts = new System.Collections.ArrayList();

        public System.Collections.ArrayList getAccounts()
        {
            return accounts;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", fName, lName);
        }


        public bool createAccount(double initDeposit, long randomAccountNumber)
        {
            if (initDeposit >= 500)
            {
                accounts.Add(new Account(initDeposit, randomAccountNumber));
                return true;
            }
            else
                return false;
        }
    }



    public class Account
    {
        public Account(double Money, long AccountNumber)
        {
            this.AccountNumber = AccountNumber;
            Credit(Money);
        }

        private double Money { get; set; }
        public long AccountNumber { get; set; }
        public System.Collections.ArrayList transactions = new System.Collections.ArrayList();



        public override string ToString()
        {
            return string.Format("{0}", AccountNumber);
        }

        public void Credit(double value)
        {
            Transaction t = new Transaction(value, "Insättning");
            Money = Money + value;
            transactions.Add(t);
        }

        public void Debit(double value)
        {
            Transaction t = new Transaction(value, "Uttag");
            Money = Money - value;
            transactions.Add(t);
        }

        public double getMoney()
        {
            return Money;
        }

    }


    public class Transaction
    {
        public Transaction(double money, string information)
        {
            this.money = money;
            this.information = information;
        }

        private double money { get; set; }
        private string information { get; set; }

        public override string ToString()
        {
            return string.Format("{0}: {1} SEK", information, money.ToString());
        }
    }
}


