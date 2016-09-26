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
        bool TransactionIsCredit;
        System.Collections.ArrayList customers;

        public System.Random randomGen = new System.Random();

        public Form1()
        {
            InitializeComponent();
            customers = new System.Collections.ArrayList();
            resetUIelementAccessibility();

        }


        //
        //  controls
        //
        private void rbtnUIControl(object sender, EventArgs e)
        {
            interfaceIsCustomer(rbtnCus.Checked);
        }

        private void rbtnEmp_CheckedChanged(object sender, EventArgs e)
        {
            interfaceIsCustomer(false);
        }



        //
        //  customer management panel
        //

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

            resetUIelementAccessibility();

            if (rbtnCus.Checked)
                MessageBox.Show("Tack för att du öppnar ett konto hos oss!");
            else
                MessageBox.Show("Ett konto har nu skapats åt kunden.");

            tbxNewAccountMoney.Text = string.Empty;
            tbxFName.Text = string.Empty;
            tbxLName.Text = string.Empty;
        }




        //
        //  account browsing
        //

        private void updateCustomerList()
        {
            lbxCustomers.Items.Clear();

            foreach (Customer cus in customers)
            {
                lbxCustomers.Items.Add(cus);
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
                lbxAccounts.Items.Add(acc);
            }

            lbxAccounts.SelectedIndex = 0;
        }

        private void displayAccountMoney()
        {
            Account account = (Account)lbxAccounts.SelectedItem;
            tbxDisplayMoney.Text = account.getMoney().ToString();
        }





        private void interfaceIsCustomer(bool v)
        {
            if (v)
            {
                lblCreateNewBriefing.Text = "Skriv in dina uppgifter för att bli kund hos oss och skapa ditt första konto";
                btnMenuRegCus.Text = "Registrera dig som kund och öppna första kontot";
                btnMenuBrowse.Text = "Se, skapa dina konton och genomföra in/utsättningar";
                lblChoseAccount.Text = "Välj ditt konto:";
                lblChoseCustomer.Text = "Välj dig som kund:";



            }
            else
            {
                lblCreateNewBriefing.Text = "Skriv in kundens uppgifter för att skapa ett konto åt hen";
                btnMenuRegCus.Text = "Registrera en ny kund och öppna ett kontro åt hen";
                btnMenuBrowse.Text = "Se kunder och deras konton samt transaktionshistoria";
                lblChoseAccount.Text = "Välj kundens konto:";
                lblChoseCustomer.Text = "Välj en kund:";


            }

            resetUIelementAccessibility();
        }

        private void resetUIelementAccessibility()
        {
            pnlAddAccount.Visible = false;
            btnAddNewAccount.Enabled = false;
            lbxAccounts.Visible = false;
            lbxCustomers.Visible = false;
            pnlCustManage.Visible = false;
            pnlRegCus.Visible = false;
            btnConfirmTransaction.Enabled = false;
            tbxTransactionValue.Enabled = false;
            grpBoxDoTransaction.Visible = false;
            grpBoxTransactionHistory.Visible = false;
            tbxNewAccountMoney.Visible = false;
            lblMoneyOn.Visible = false;
            lblChoseAccount.Visible = false;
            tbxDisplayMoney.Visible = false;
            btnAddNewAccount.Visible = false;
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



        private void lbxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblChoseAccount.Visible = true;
            updateAccountsList();
            if (lbxCustomers.SelectedIndex != -1)
            {
                lbxAccounts.Visible = true;
            }
            if (rbtnCus.Checked)
            {
                btnAddNewAccount.Enabled = true;
            }
        }


        private void lbxAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbxNewAccountMoney.Visible = true;
            lblMoneyOn.Visible = true;
            tbxDisplayMoney.Visible = false;
            tbxDisplayMoney.Visible = true;
            btnAddNewAccount.Visible = true;

            displayAccountMoney();
            if (rbtnEmp.Checked)
            {
                
                grpBoxTransactionHistory.Visible = true;
                lbxTransactionsList.Items.Clear();

                Account acc = (Account)lbxAccounts.SelectedItem;
                foreach (Transaction t in acc.transactions)
                {
                    lbxTransactionsList.Items.Add(t);
                }
            }
            else
            {
                grpBoxDoTransaction.Visible = true;
            }
        }


        private void btnMenuBrowse_Click(object sender, EventArgs e)
        {
            resetUIelementAccessibility();
            setViewBrowse();
            
        }

        private void setViewBrowse()
        {
            pnlCustManage.Visible = true;
            lbxAccounts.Visible = false;
            lbxCustomers.Visible = true;
            pnlRegCus.Visible = false;
        }

        private void btnMenuRegCus_Click(object sender, EventArgs e)
        {
            pnlCustManage.Visible = false;
            pnlRegCus.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbxTransactionValue.Enabled = true;
            btnConfirmTransaction.Enabled = true;
            TransactionIsCredit = true;
        }

        private void btnWithDraw_Click(object sender, EventArgs e)
        {
            tbxTransactionValue.Enabled = true;
            btnConfirmTransaction.Enabled = true;
            TransactionIsCredit = false;
        }

        private void btnConfirmTransaction_Click(object sender, EventArgs e)
        {
            Account acc = (Account)lbxAccounts.SelectedItem;
            if (TransactionIsCredit)
            {
                acc.Credit(double.Parse(tbxTransactionValue.Text));
            }
            else
            {
                double currMoney = acc.getMoney();
                if (currMoney > int.Parse(tbxTransactionValue.Text) + 500)
                {
                    acc.Debit(double.Parse(tbxTransactionValue.Text));
                    MessageBox.Show("Uttaget godkänns!");
                }
                else
                {
                    MessageBox.Show("Uttaget godkänns inte eftersom ditt saldo hamnar under 500 SEK.");
                }
            }
            tbxDisplayMoney.Text = acc.getMoney().ToString();
            tbxTransactionValue.Text = String.Empty;
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

    }
}
