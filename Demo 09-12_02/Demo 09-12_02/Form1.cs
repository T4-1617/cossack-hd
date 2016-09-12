using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_09_12_02
{
    public partial class Form1 : Form
    {

        System.Collections.ArrayList MyCustomers = new System.Collections.ArrayList();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();

            c.FirstName = txbFirstName.Text;
            c.LastName = txbLastName.Text;

            MyCustomers.Add(c);


            listBoxCustomers.Items.Clear();

            foreach (Customer item in MyCustomers)
            {
                listBoxCustomers.Items.Add(item.fullname());
            }

        }
    }
}
