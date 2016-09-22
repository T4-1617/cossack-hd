using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Banking
{
    public partial class Form1 : Form
    {

        System.Collections.ArrayList customers;
        public System.Random randomGen = new System.Random();

        public Form1()
        {
            InitializeComponent();
            customers = new System.Collections.ArrayList();
        }


        public void addCustomer()
        {
         //   Customer c = new Customer(tbxfName.Text, tbxLName.Text, genCustID());
        }


        private long genCustID()
        {
            long random = 0;
            bool uniqueID = false;
            while (uniqueID == false)
            {
                random = randomGen.Next(10000000, 999999999);
                uniqueID = true;

                foreach (Customer c in customers)
                {
                    if (c.ID == random)
                        uniqueID = false;
                }
            }
            return random;
        }

    }
}
