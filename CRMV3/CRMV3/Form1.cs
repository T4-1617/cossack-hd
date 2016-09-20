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
            //Create array for contacts
            contacts = new System.Collections.ArrayList();
            InitializeComponent();

            //add options to Combo Box
            cmbxNewType.Items.Add("Kund");
            cmbxNewType.Items.Add("Anställd");
            cmbxNewType.Items.Add("Leverantör");
        }

        
        private void cmbxNewType_SelectedIndexChanged(object sender, EventArgs e)
        {   //when chosing an option in add menu, set according textboxes as read only or writeable
            activateAddControls(true);
        }


        //when saving a new contact
        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            switch ((string)cmbxNewType.SelectedItem) //depending on selected option
            {
                case "Kund": //add new contacts  accordingly
                    contacts.Add(new Customer()
                    {
                        FirstName = tbxNewFName.Text,
                        LastName = tbxNewLName.Text,
                        Phone = tbxNewPhone.Text,
                        ID = genCustID()
                    });
                    break;

                case "Anställd":
                    contacts.Add(new Employee()
                    {
                        FirstName = tbxNewFName.Text,
                        LastName = tbxNewLName.Text,
                        Phone = tbxNewPhone.Text,
                        ID = genEmpID(),
                        Salary = float.Parse(tbxNewSalary.Text),
                        Title = tbxNewTitle.Text
                    });
                    break;

                case "Leverantör":
                    contacts.Add(new Distributor()
                    {
                        FirstName = tbxNewFName.Text,
                        LastName = tbxNewLName.Text,
                        Phone = tbxNewPhone.Text,
                        Company = tbxNewCompany.Text
                    });
                    break;

                default:
                    break;
            }

            updateListBox(); //update the listbox which displays all existing contacts

            tbxNewCompany.Text = String.Empty; //empty the textboxes
            tbxNewFName.Text = String.Empty;
            tbxNewLName.Text = String.Empty;
            tbxNewPhone.Text = String.Empty;
            tbxNewSalary.Text = String.Empty;
            tbxNewTitle.Text = String.Empty;
        }



        private void lbxView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //selected a new item in the listbox
            txbTitle.Text = String.Empty; //empty the textboxes in view area
            txbSalary.Text = String.Empty;
            txbFName.Text = String.Empty;
            txbLName.Text = String.Empty;
            txbTitle.Text = String.Empty;
            txbSalary.Text = String.Empty;
            txbPhone.Text = String.Empty;


            if (lbxView.SelectedIndex != -1) //if the index is proper
            {
                if (lbxView.SelectedItem is Customer) //depending on contact type
                {
                    Customer cus = (Customer)lbxView.SelectedItem; //show information in textboxes according to the type
                    txbFName.Text = cus.FirstName;
                    txbLName.Text = cus.LastName;
                    txbPhone.Text = cus.Phone;
                    txbIDs.Text = cus.ID.ToString();
                }

                if (lbxView.SelectedItem is Employee)
                {
                    Employee emp = (Employee)lbxView.SelectedItem;
                    txbFName.Text = emp.FirstName;
                    txbLName.Text = emp.LastName;
                    txbPhone.Text = emp.Phone;
                    txbIDs.Text = emp.ID.ToString();
                    txbTitle.Text = emp.Title;
                    txbSalary.Text = emp.Salary.ToString();
                }

                if (lbxView.SelectedItem is Distributor)
                {
                    Distributor dis = (Distributor)lbxView.SelectedItem;
                    txbFName.Text = dis.FirstName;
                    txbLName.Text = dis.LastName;
                    txbPhone.Text = dis.Phone;
                    txbCompany.Text = dis.Company;
                }

            }
        }


        private void updateListBox()
        {
            lbxView.Items.Clear();

            foreach (var v in contacts)
            {
                lbxView.Items.Add(v);
            }
        }

        private int genEmpID() //generates employee ID starting with 0
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

        private int genCustID() //generates *unique* customer ID, random in range 0 to 9000
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
