﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using classesLibrary;

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

            cmbxNewType.SelectedIndex = 0;

            cbxShowCustomers.Checked = true;
            cbxShowDistributors.Checked = true;
            cbxShowEmployees.Checked = true;
        }


        private void cmbxNewType_SelectedIndexChanged(object sender, EventArgs e)
        {   //when chosing an option in add menu, set according textboxes as read only or writeable
            activateAddControls(true);
        }


        //when saving a new contact
        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            switch (cmbxNewType.SelectedIndex) //depending on selected option
            {
                case 0: //add new contacts  accordingly
                    contacts.Add(new Customer()
                    {
                        FirstName = tbxNewFName.Text,
                        LastName = tbxNewLName.Text,
                        Phone = tbxNewPhone.Text,
                        ID = genCustID()
                    });
                    break;

                case 1:

                    if (tbxNewSalary.Text == string.Empty)
                        tbxNewSalary.Text = "0";

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

                case 2:
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
            emptyNewContactTextBoxes();

            int customersCount = 0;
            int employeesCount = 0;
            int distributorsCount = 0;

            foreach (var con in contacts)
            {
                if (con is Customer)              
                    customersCount++;
                if (con is Employee)
                    employeesCount++;
                if (con is Distributor)
                    distributorsCount++;
            }
            lblStats.Text = String.Format("Det finns {0} kunder, {1} anställda och {2} leverantörer registrerade i CRM.",
                customersCount.ToString(), employeesCount.ToString(), distributorsCount.ToString());
        }

        private void btnCancelNew_Click(object sender, EventArgs e)
        {
            emptyNewContactTextBoxes();
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
            txbIDs.Text = String.Empty;
            txbCompany.Text = String.Empty;

            txbTitle.ReadOnly = true;
            txbSalary.ReadOnly = true;
            txbFName.ReadOnly = true;
            txbLName.ReadOnly = true;
            txbTitle.ReadOnly = true;
            txbSalary.ReadOnly = true;
            txbPhone.ReadOnly = true;
            txbIDs.ReadOnly = true;
            txbCompany.ReadOnly = true;

            if (lbxView.SelectedIndex != -1) //if the index is proper
            {
                Contact c = (Contact)lbxView.SelectedItem;

                txbFName.Text = c.FirstName;
                txbLName.Text = c.LastName;
                txbPhone.Text = c.Phone;

                if (lbxView.SelectedItem is Customer) //depending on contact type
                {
                    Customer cus = (Customer)lbxView.SelectedItem; //show information in textboxes according to the type
                    txbIDs.Text = cus.ID.ToString();

                    txbFName.ReadOnly = false;
                    txbLName.ReadOnly = false;
                    txbPhone.ReadOnly = false;
                }

                if (lbxView.SelectedItem is Employee)
                {
                    Employee emp = (Employee)lbxView.SelectedItem;
                    txbIDs.Text = emp.ID.ToString();
                    txbTitle.Text = emp.Title;
                    txbSalary.Text = emp.Salary.ToString();

                    txbFName.ReadOnly = false;
                    txbLName.ReadOnly = false;
                    txbPhone.ReadOnly = false;
                    txbTitle.ReadOnly = false;
                    txbSalary.ReadOnly = false;
                }

                if (lbxView.SelectedItem is Distributor)
                {
                    Distributor dis = (Distributor)lbxView.SelectedItem;
                    txbCompany.Text = dis.Company;

                    txbFName.ReadOnly = false;
                    txbLName.ReadOnly = false;
                    txbPhone.ReadOnly = false;
                    txbCompany.ReadOnly = false;
                }
            }
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {

            Contact c = (Contact)lbxView.SelectedItem;
            c.FirstName = txbFName.Text;
            c.LastName = txbLName.Text;
            c.Phone = txbPhone.Text;

            var con = lbxView.SelectedItem;

            if (con is Customer)
            {
                Customer contact = (Customer)lbxView.SelectedItem;
                contact.ID = int.Parse(txbIDs.Text);
            }

            if (con is Employee)
            {
                Employee emp = (Employee)lbxView.SelectedItem;
                emp.ID = int.Parse(txbIDs.Text);
                emp.Title = txbTitle.Text;
                emp.Salary = int.Parse(txbSalary.Text);
            }

            if (con is Distributor)
            {
                Distributor dis = (Distributor)lbxView.SelectedItem;
                dis.Company = txbCompany.Text;
            }

            lbxView_SelectedIndexChanged(sender, e);
            updateListBox();
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            lbxView_SelectedIndexChanged(sender, e);
        }

        private void cbxShowCustomers_CheckedChanged(object sender, EventArgs e)
        {
            updateListBox();
            lbxView.SelectedIndex = -1;
        }

        private void cbxShowEmployees_CheckedChanged(object sender, EventArgs e)
        {
            updateListBox();
            lbxView.SelectedIndex = -1;
        }

        private void cbxShowDistributors_CheckedChanged(object sender, EventArgs e)
        {
            updateListBox();
            lbxView.SelectedIndex = -1;
        }

        private void updateListBox()
        {
            lbxView.Items.Clear();

            foreach (var v in contacts)
            {
                if (v is Customer && cbxShowCustomers.Checked)
                    lbxView.Items.Add(v);
            }

            foreach (var v in contacts)
            {
                if (v is Employee && cbxShowEmployees.Checked)
                    lbxView.Items.Add(v);
            }

            foreach (var v in contacts)
            {
                if (v is Distributor && cbxShowDistributors.Checked)
                    lbxView.Items.Add(v);
            }
        }

        private int genEmpID() //generates employee ID starting with 0
        {
            int j = 0;
            for (int i = 0; i < contacts.Count; i++)
            {
                if (contacts[i] is Employee)
                    j++;
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
        }

        private void emptyNewContactTextBoxes()
        {
            tbxNewCompany.Text = String.Empty;
            tbxNewFName.Text = String.Empty;
            tbxNewLName.Text = String.Empty;
            tbxNewPhone.Text = String.Empty;
            tbxNewSalary.Text = String.Empty;
            tbxNewTitle.Text = String.Empty;
        }
    }
}