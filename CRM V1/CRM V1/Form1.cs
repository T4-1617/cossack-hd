using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_V1
{
    public partial class CRM_MainWind : Form
    {

        System.Collections.ArrayList myCustomers = new System.Collections.ArrayList();


        public CRM_MainWind()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();

            int random = 0;


            c.fName = txbFname.Text;
            c.lName = txbLname.Text;
            c.id = random;
            c.isActive = true;

            myCustomers.Add(c);

            lblCounter.Text = String.Format("Du har {0} kunder!", myCustomers.Count);

            lboxCustomers.Items.Clear();

            foreach (Customer d in myCustomers)
            {
                lboxCustomers.Items.Add(d.fullName());
            }
            

        }

        public int generaterandom()
        {
            Random r = new Random();

            return r.Next(100, 200);
        }

        private void lboxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
