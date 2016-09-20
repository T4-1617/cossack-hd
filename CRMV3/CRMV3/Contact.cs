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
            return String.Format("{0} {1} {2}", FirstName, LastName, Phone);
        }

    }


    public class Customer : Contact
    {
        public Customer()
        {
        }

        public int ID;


        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3}", FirstName, LastName, Phone, ID);
        }
    }

    public class Employee : Contact
    {

        public Employee()
        {
        }

        public float Salary;
        public int ID;
        public string Title;

        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3} {4} {5}", Title, FirstName, LastName, Phone, ID, Salary);
        }

    }

    public class Distributor : Contact
    {
        public Distributor()
        {
        }

        public string Company;

        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3}", FirstName, LastName, Phone, Company);
        }

    }
}
