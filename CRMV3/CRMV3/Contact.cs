using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMV3
{
    public abstract class Contact
    {
        public Contact()
        {
        }

        public string FirstName;
        public string LastName;
        public string Phone;

        public override string ToString()
        {
            return String.Format("{0} {1}", FirstName, LastName);
        }
    }


    public class Customer : Contact
    {
        public Customer()
        {
        }

        public int ID;
    }

    public class Employee : Contact
    {
        public Employee()
        {
        }

        public float Salary;
        public int ID;
        public string Title;

    }

    public class Distributor : Contact
    {
        public Distributor()
        {
        }

        public string Company;
    }
}
