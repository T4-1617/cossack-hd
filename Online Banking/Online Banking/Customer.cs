using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Banking
{

    
    public class Customer
    {

        Customer(string fName, string lName, long id)
        {
            this.fName = fName;
            this.lName = lName;
        }



        public string fName { get; set; }
        public string lName { get; set; }
        public long ID { get; set; }
        public System.Collections.ArrayList accounts = new System.Collections.ArrayList();
    }


    public class Account
    {
        public Account()
        { }

        public double money { get; set; }
        public System.Collections.ArrayList transactions = new System.Collections.ArrayList();


        public void addTransaction(double value, string information)
        {
            Transaction t = new Transaction(value, information);
            transactions.Add(t);
        }
    }


    public class Transaction
    {
        public Transaction(double money, string information)
        {
            this.money = money;
            this.information = information;
        }

        public double money { get; set; }
        public string information { get; set; }
    }







    


}
