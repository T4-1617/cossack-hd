using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMV3
{
    public partial class CRMV3 : Form
    {
        public System.Collections.ArrayList contacts;
        System.Random randomGen = new System.Random();

        public CRMV3()
        {
            contacts = new System.Collections.ArrayList();
            InitializeComponent();

            cmbxNewType.Items.Add("Kund");
            cmbxNewType.Items.Add("Anställd");
            cmbxNewType.Items.Add("Leverantör");
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            switch ((string)cmbxNewType.SelectedItem)
            {
                case "Kund":
                    contacts.Add(new Customer() { FirstName = tbxNewFName.Text, LastName = tbxNewLName.Text,
                        Phone = tbxNewPhone.Text, ID = genCustID() });
                    break;

                case "Anställd":
                    contacts.Add(new Employee() { FirstName = tbxNewFName.Text, LastName = tbxNewLName.Text,
                        Phone = tbxNewPhone.Text, ID = genEmpID(),
                        Salary = float.Parse(tbxNewSalary.Text),
                        Title = tbxNewTitle.Text });
                    break;

                case "Leverantör":
                    contacts.Add(new Distributor() { FirstName = tbxNewFName.Text, LastName = tbxNewLName.Text,
                        Phone = tbxNewPhone.Text, Company = tbxNewCompany.Text });
                    break;

                default:
                    break;
            }

            updateListBox();

            tbxNewCompany.Text = String.Empty;
            tbxNewFName.Text = String.Empty;
            tbxNewLName.Text = String.Empty;
            tbxNewPhone.Text = String.Empty;
            tbxNewSalary.Text = String.Empty;
            tbxNewTitle.Text = String.Empty;


        }

        private void updateListBox()
        {
            lbxView.Items.Clear();

            foreach (var v in contacts)
            {
                lbxView.Items.Add(v);
            }
        }

        private int genEmpID()
        {
            int j = 0;
            for (int i = 0; i < contacts.Count; i++)
            {
                if (contacts[i] is Employee)
                {
                    j++;
                }
            }
            return j;
        }

        private int genCustID()
        {
            int random = 0;
            bool uniqueID = false;
            while (uniqueID == false)
            {
                random = randomGen.Next(0, 9000);

                uniqueID = true;

                for (int i = 0; i < contacts.Count; i++)
                {
                    if (contacts[i] is Customer)
                    {
                        Customer c = (Customer)contacts[i];
                        if (c.ID == random)
                        {
                            uniqueID = false;
                        }
                    }
                }
            }
            return random;

        }

        private void cmbxNewType_SelectedIndexChanged(object sender, EventArgs e)
        {
            activateAddControls(true);
        }

        private void activateAddControls(bool state)
        {
            tbxNewFName.ReadOnly = !state;
            tbxNewLName.ReadOnly = !state;
            tbxNewPhone.ReadOnly = !state;

            switch ((string)cmbxNewType.SelectedItem)
            {
                case "Anställd":
                    tbxNewSalary.ReadOnly = !state;
                    tbxNewTitle.ReadOnly = !state;
                    tbxNewCompany.ReadOnly = state;
                    break;

                case "Leverantör":
                    tbxNewSalary.ReadOnly = state;
                    tbxNewTitle.ReadOnly = state;
                    tbxNewCompany.ReadOnly = !state;
                    break;

                default:
                    tbxNewSalary.ReadOnly = true;
                    tbxNewTitle.ReadOnly = true;
                    tbxNewCompany.ReadOnly = true;
                    break;
            }

            if (state == false)
            {
                tbxNewSalary.ReadOnly = true;
                tbxNewTitle.ReadOnly = true;
                tbxNewCompany.ReadOnly = true;
            }
        }
    }
}
