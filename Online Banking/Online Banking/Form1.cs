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
            Customer c = new Customer(tbxFName.Text, tbxLName.Text);

            if (!c.createAccount(double.Parse(tbxFirstMoney.Text), genAccountID()))
            {
                MessageBox.Show("Minsta beloppet för att öpnna kontot är 500 SEK!");
                return;
            }
            customers.Add(c);

            updateCustomerList();
        }

        private void updateCustomerList()
        {
            lbxCustomers.Items.Clear();

            foreach (Customer cus in customers)
            {
                lbxCustomers.Items.Add(cus);
                MessageBox.Show("Addec customer to lbxCustomers");
            }

            lbxCustomers.SelectedIndex = 0;
        }

        private void updateAccountsList()
        { 
            Customer customer = (Customer)lbxCustomers.SelectedItem;

            System.Collections.ArrayList currentAccounts = customer.accounts;

            lbxAccounts.Items.Clear();

            foreach (Account acc in currentAccounts)
            {
                MessageBox.Show("added account to lbx");
                lbxAccounts.Items.Add(acc);
            }

            lbxAccounts.SelectedIndex = 0;

            displayAccountMoney();
        }

        private void displayAccountMoney()
        {
            Account account = (Account)lbxAccounts.SelectedItem;
            tbxDisplayMoney.Text = account.getMoney().ToString();
        }


        private long genAccountID()
        {
            long random = 0;
            bool uniqueID = false;
            while (uniqueID == false)
            {
                random = randomGen.Next(10000000, 99999999);
                uniqueID = true;

                foreach (Customer cus in customers)
                {
                    foreach (Account acc in cus.accounts)
                    {
                        if (acc.AccountNumber == random)
                            uniqueID = false;
                    }
                }
            }
            return random;
        }


        private void rbtnUIControl(object sender, EventArgs e)
        {
            interfaceIsCustomer(rbtnCus.Checked);
        }

        private void rbtnEmp_CheckedChanged(object sender, EventArgs e)
        {
            interfaceIsCustomer(false);
        }

        private void interfaceIsCustomer(bool v)
        {
            if (v)
            {
                lblCreateNewBriefing.Text = "Skriv in dina uppgifter för att bli kund hos oss och skapa ditt första konto";
                btnMenuRegCus.Text = "Registrera dig som kund och öppna första kontot";
                btnMenuBrowse.Text = "Se, skapa dina konton och genomföra in/utsättningar";
            }
            else
            {
                lblCreateNewBriefing.Text = "Skriv in kundens uppgifter för att skapa ett konto åt hen";
                btnMenuRegCus.Text = "Registrera en ny kund och öppna ett kontro åt hen";
                btnMenuBrowse.Text = "Se kunder och deras konton samt transaktionshistoria";
            }

            grpBoxDoTransaction.Visible = v;
            grpBoxTransactionHistory.Visible = !v;
            

        }

        private void btnRegCusConfirm_Click(object sender, EventArgs e)
        {
            addCustomer();
        }

        private void btnAddNewAccount_Click(object sender, EventArgs e)
        {
            pnlAddAccount.Visible = true;
        }

        private void btnConfirmAddAccount_Click(object sender, EventArgs e)
        {
            Customer c = (Customer)lbxCustomers.SelectedItem;

            c.accounts.Add(new Account(int.Parse(tbxNewAccountMoney.Text), genAccountID()));

            updateCustomerList();
            pnlAddAccount.Visible = false;
        }

        private void lbxAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            displayAccountMoney();
        }

        private void lbxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateAccountsList();
        }
    }
}
