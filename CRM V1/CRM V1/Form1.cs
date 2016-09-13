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
            bool verifiedRandom = false;


            while (verifiedRandom == false)
            {
                random = generaterandom();

                verifiedRandom = true;

                foreach (Customer d in myCustomers)
                {
                    if (random == d.id)
                    {
                        MessageBox.Show("Generated new random");
                        verifiedRandom = false;
                    }
                }

            }


            c.fName = txbFname.Text;
            c.lName = txbLname.Text;
            c.id = random;
            c.isVIP = true;

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
            int index = lboxCustomers.SelectedIndex;
            Customer x = new Customer();
            x = (Customer)myCustomers[index];
            MessageBox.Show(String.Format("{0}, {1}", x.fullName(), x.id));

            cboxVIP.Checked = x.isVIP;

        }



        private void cboxVIP_CheckedChanged(object sender, EventArgs e)
        {
            Customer C = (Customer)myCustomers[lboxCustomers.SelectedIndex];
            C.isVIP = cboxVIP.Checked;

        }
    }
}
