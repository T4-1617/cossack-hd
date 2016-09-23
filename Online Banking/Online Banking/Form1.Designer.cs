namespace Online_Banking
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpBoxToggleUImode = new System.Windows.Forms.GroupBox();
            this.rbtnEmp = new System.Windows.Forms.RadioButton();
            this.rbtnCus = new System.Windows.Forms.RadioButton();
            this.pnlRegCus = new System.Windows.Forms.Panel();
            this.lblCreateNewBriefing = new System.Windows.Forms.Label();
            this.btnRegCusConfirm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxFirstMoney = new System.Windows.Forms.TextBox();
            this.tbxLName = new System.Windows.Forms.TextBox();
            this.tbxFName = new System.Windows.Forms.TextBox();
            this.btnMenuRegCus = new System.Windows.Forms.Button();
            this.grpBoxMenu = new System.Windows.Forms.GroupBox();
            this.btnMenuBrowse = new System.Windows.Forms.Button();
            this.pnlCustManage = new System.Windows.Forms.Panel();
            this.pnlAddAccount = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxNewAccountMoney = new System.Windows.Forms.TextBox();
            this.btnConfirmAddAccount = new System.Windows.Forms.Button();
            this.grpBoxDoTransaction = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnWithDraw = new System.Windows.Forms.Button();
            this.btnConfirmTransaction = new System.Windows.Forms.Button();
            this.tbxTransactionValue = new System.Windows.Forms.TextBox();
            this.btnAddNewAccount = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxDisplayMoney = new System.Windows.Forms.TextBox();
            this.lbxAccounts = new System.Windows.Forms.ListBox();
            this.lbxCustomers = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpBoxTransactionHistory = new System.Windows.Forms.GroupBox();
            this.lbxTransactionsList = new System.Windows.Forms.ListBox();
            this.grpBoxToggleUImode.SuspendLayout();
            this.pnlRegCus.SuspendLayout();
            this.grpBoxMenu.SuspendLayout();
            this.pnlCustManage.SuspendLayout();
            this.pnlAddAccount.SuspendLayout();
            this.grpBoxDoTransaction.SuspendLayout();
            this.grpBoxTransactionHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxToggleUImode
            // 
            this.grpBoxToggleUImode.Controls.Add(this.rbtnEmp);
            this.grpBoxToggleUImode.Controls.Add(this.rbtnCus);
            this.grpBoxToggleUImode.Location = new System.Drawing.Point(12, 12);
            this.grpBoxToggleUImode.Name = "grpBoxToggleUImode";
            this.grpBoxToggleUImode.Size = new System.Drawing.Size(94, 69);
            this.grpBoxToggleUImode.TabIndex = 0;
            this.grpBoxToggleUImode.TabStop = false;
            this.grpBoxToggleUImode.Text = "Välj gränsnitt";
            // 
            // rbtnEmp
            // 
            this.rbtnEmp.AutoSize = true;
            this.rbtnEmp.Location = new System.Drawing.Point(7, 44);
            this.rbtnEmp.Name = "rbtnEmp";
            this.rbtnEmp.Size = new System.Drawing.Size(73, 17);
            this.rbtnEmp.TabIndex = 1;
            this.rbtnEmp.TabStop = true;
            this.rbtnEmp.Text = "Anställdvy";
            this.rbtnEmp.UseVisualStyleBackColor = true;
            this.rbtnEmp.CheckedChanged += new System.EventHandler(this.rbtnUIControl);
            // 
            // rbtnCus
            // 
            this.rbtnCus.AutoSize = true;
            this.rbtnCus.Checked = true;
            this.rbtnCus.Location = new System.Drawing.Point(7, 20);
            this.rbtnCus.Name = "rbtnCus";
            this.rbtnCus.Size = new System.Drawing.Size(61, 17);
            this.rbtnCus.TabIndex = 0;
            this.rbtnCus.TabStop = true;
            this.rbtnCus.Text = "Kundvy";
            this.rbtnCus.UseVisualStyleBackColor = true;
            this.rbtnCus.CheckedChanged += new System.EventHandler(this.rbtnUIControl);
            // 
            // pnlRegCus
            // 
            this.pnlRegCus.Controls.Add(this.lblCreateNewBriefing);
            this.pnlRegCus.Controls.Add(this.btnRegCusConfirm);
            this.pnlRegCus.Controls.Add(this.label4);
            this.pnlRegCus.Controls.Add(this.label3);
            this.pnlRegCus.Controls.Add(this.label2);
            this.pnlRegCus.Controls.Add(this.label1);
            this.pnlRegCus.Controls.Add(this.tbxFirstMoney);
            this.pnlRegCus.Controls.Add(this.tbxLName);
            this.pnlRegCus.Controls.Add(this.tbxFName);
            this.pnlRegCus.Location = new System.Drawing.Point(245, 87);
            this.pnlRegCus.Name = "pnlRegCus";
            this.pnlRegCus.Size = new System.Drawing.Size(485, 187);
            this.pnlRegCus.TabIndex = 1;
            // 
            // lblCreateNewBriefing
            // 
            this.lblCreateNewBriefing.AutoSize = true;
            this.lblCreateNewBriefing.Location = new System.Drawing.Point(4, 10);
            this.lblCreateNewBriefing.Name = "lblCreateNewBriefing";
            this.lblCreateNewBriefing.Size = new System.Drawing.Size(347, 13);
            this.lblCreateNewBriefing.TabIndex = 7;
            this.lblCreateNewBriefing.Text = "Skriv in dina uppgifter för att bli kund hos oss och skapa ditt första konto";
            // 
            // btnRegCusConfirm
            // 
            this.btnRegCusConfirm.Location = new System.Drawing.Point(88, 146);
            this.btnRegCusConfirm.Name = "btnRegCusConfirm";
            this.btnRegCusConfirm.Size = new System.Drawing.Size(117, 23);
            this.btnRegCusConfirm.TabIndex = 6;
            this.btnRegCusConfirm.Text = "Skapa första kontot!";
            this.btnRegCusConfirm.UseVisualStyleBackColor = true;
            this.btnRegCusConfirm.Click += new System.EventHandler(this.btnRegCusConfirm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(11, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "OBS! Första insättningen får inte vara mindre än 500 SEK!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Första isättningen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Efternamn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Förnamn";
            // 
            // tbxFirstMoney
            // 
            this.tbxFirstMoney.Location = new System.Drawing.Point(105, 97);
            this.tbxFirstMoney.Name = "tbxFirstMoney";
            this.tbxFirstMoney.Size = new System.Drawing.Size(100, 20);
            this.tbxFirstMoney.TabIndex = 2;
            // 
            // tbxLName
            // 
            this.tbxLName.Location = new System.Drawing.Point(105, 58);
            this.tbxLName.Name = "tbxLName";
            this.tbxLName.Size = new System.Drawing.Size(100, 20);
            this.tbxLName.TabIndex = 1;
            // 
            // tbxFName
            // 
            this.tbxFName.Location = new System.Drawing.Point(105, 32);
            this.tbxFName.Name = "tbxFName";
            this.tbxFName.Size = new System.Drawing.Size(100, 20);
            this.tbxFName.TabIndex = 0;
            // 
            // btnMenuRegCus
            // 
            this.btnMenuRegCus.Location = new System.Drawing.Point(7, 19);
            this.btnMenuRegCus.Name = "btnMenuRegCus";
            this.btnMenuRegCus.Size = new System.Drawing.Size(187, 43);
            this.btnMenuRegCus.TabIndex = 2;
            this.btnMenuRegCus.Text = "Registrera dig som kund och öppna första kontot";
            this.btnMenuRegCus.UseVisualStyleBackColor = true;
            // 
            // grpBoxMenu
            // 
            this.grpBoxMenu.Controls.Add(this.btnMenuBrowse);
            this.grpBoxMenu.Controls.Add(this.btnMenuRegCus);
            this.grpBoxMenu.Location = new System.Drawing.Point(12, 87);
            this.grpBoxMenu.Name = "grpBoxMenu";
            this.grpBoxMenu.Size = new System.Drawing.Size(200, 133);
            this.grpBoxMenu.TabIndex = 3;
            this.grpBoxMenu.TabStop = false;
            this.grpBoxMenu.Text = "Meny kund";
            // 
            // btnMenuBrowse
            // 
            this.btnMenuBrowse.Location = new System.Drawing.Point(7, 74);
            this.btnMenuBrowse.Name = "btnMenuBrowse";
            this.btnMenuBrowse.Size = new System.Drawing.Size(187, 43);
            this.btnMenuBrowse.TabIndex = 2;
            this.btnMenuBrowse.Text = "Se, skapa dina konton och genomföra in/utsättningar";
            this.btnMenuBrowse.UseVisualStyleBackColor = true;
            // 
            // pnlCustManage
            // 
            this.pnlCustManage.Controls.Add(this.pnlAddAccount);
            this.pnlCustManage.Controls.Add(this.grpBoxDoTransaction);
            this.pnlCustManage.Controls.Add(this.btnAddNewAccount);
            this.pnlCustManage.Controls.Add(this.label9);
            this.pnlCustManage.Controls.Add(this.label8);
            this.pnlCustManage.Controls.Add(this.label7);
            this.pnlCustManage.Controls.Add(this.tbxDisplayMoney);
            this.pnlCustManage.Controls.Add(this.lbxAccounts);
            this.pnlCustManage.Controls.Add(this.lbxCustomers);
            this.pnlCustManage.Controls.Add(this.label6);
            this.pnlCustManage.Controls.Add(this.grpBoxTransactionHistory);
            this.pnlCustManage.Location = new System.Drawing.Point(245, 289);
            this.pnlCustManage.Name = "pnlCustManage";
            this.pnlCustManage.Size = new System.Drawing.Size(485, 412);
            this.pnlCustManage.TabIndex = 4;
            // 
            // pnlAddAccount
            // 
            this.pnlAddAccount.Controls.Add(this.label5);
            this.pnlAddAccount.Controls.Add(this.tbxNewAccountMoney);
            this.pnlAddAccount.Controls.Add(this.btnConfirmAddAccount);
            this.pnlAddAccount.Location = new System.Drawing.Point(138, 302);
            this.pnlAddAccount.Name = "pnlAddAccount";
            this.pnlAddAccount.Size = new System.Drawing.Size(113, 100);
            this.pnlAddAccount.TabIndex = 11;
            this.pnlAddAccount.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ange utgångsbelopp";
            // 
            // tbxNewAccountMoney
            // 
            this.tbxNewAccountMoney.Location = new System.Drawing.Point(7, 36);
            this.tbxNewAccountMoney.Name = "tbxNewAccountMoney";
            this.tbxNewAccountMoney.Size = new System.Drawing.Size(100, 20);
            this.tbxNewAccountMoney.TabIndex = 1;
            // 
            // btnConfirmAddAccount
            // 
            this.btnConfirmAddAccount.Location = new System.Drawing.Point(28, 64);
            this.btnConfirmAddAccount.Name = "btnConfirmAddAccount";
            this.btnConfirmAddAccount.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmAddAccount.TabIndex = 0;
            this.btnConfirmAddAccount.Text = "Bekräfta";
            this.btnConfirmAddAccount.UseVisualStyleBackColor = true;
            this.btnConfirmAddAccount.Click += new System.EventHandler(this.btnConfirmAddAccount_Click);
            // 
            // grpBoxDoTransaction
            // 
            this.grpBoxDoTransaction.Controls.Add(this.label10);
            this.grpBoxDoTransaction.Controls.Add(this.btnAdd);
            this.grpBoxDoTransaction.Controls.Add(this.btnWithDraw);
            this.grpBoxDoTransaction.Controls.Add(this.btnConfirmTransaction);
            this.grpBoxDoTransaction.Controls.Add(this.tbxTransactionValue);
            this.grpBoxDoTransaction.Location = new System.Drawing.Point(257, 118);
            this.grpBoxDoTransaction.Name = "grpBoxDoTransaction";
            this.grpBoxDoTransaction.Size = new System.Drawing.Size(212, 93);
            this.grpBoxDoTransaction.TabIndex = 5;
            this.grpBoxDoTransaction.TabStop = false;
            this.grpBoxDoTransaction.Text = "Genomföra transaktioner";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(128, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Belopp:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(10, 33);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Insättning";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnWithDraw
            // 
            this.btnWithDraw.Location = new System.Drawing.Point(10, 62);
            this.btnWithDraw.Name = "btnWithDraw";
            this.btnWithDraw.Size = new System.Drawing.Size(75, 23);
            this.btnWithDraw.TabIndex = 7;
            this.btnWithDraw.Text = "Uttag";
            this.btnWithDraw.UseVisualStyleBackColor = true;
            // 
            // btnConfirmTransaction
            // 
            this.btnConfirmTransaction.Location = new System.Drawing.Point(128, 61);
            this.btnConfirmTransaction.Name = "btnConfirmTransaction";
            this.btnConfirmTransaction.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmTransaction.TabIndex = 9;
            this.btnConfirmTransaction.Text = "oké";
            this.btnConfirmTransaction.UseVisualStyleBackColor = true;
            // 
            // tbxTransactionValue
            // 
            this.tbxTransactionValue.Location = new System.Drawing.Point(128, 35);
            this.tbxTransactionValue.Name = "tbxTransactionValue";
            this.tbxTransactionValue.Size = new System.Drawing.Size(75, 20);
            this.tbxTransactionValue.TabIndex = 8;
            // 
            // btnAddNewAccount
            // 
            this.btnAddNewAccount.Location = new System.Drawing.Point(138, 273);
            this.btnAddNewAccount.Name = "btnAddNewAccount";
            this.btnAddNewAccount.Size = new System.Drawing.Size(108, 23);
            this.btnAddNewAccount.TabIndex = 10;
            this.btnAddNewAccount.Text = "Skapa ett till konto";
            this.btnAddNewAccount.UseVisualStyleBackColor = true;
            this.btnAddNewAccount.Click += new System.EventHandler(this.btnAddNewAccount_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(257, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Saldo på kontot:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(158, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Välj ditt konto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Välj dig som kund:";
            // 
            // tbxDisplayMoney
            // 
            this.tbxDisplayMoney.Location = new System.Drawing.Point(257, 51);
            this.tbxDisplayMoney.Name = "tbxDisplayMoney";
            this.tbxDisplayMoney.Size = new System.Drawing.Size(100, 20);
            this.tbxDisplayMoney.TabIndex = 3;
            // 
            // lbxAccounts
            // 
            this.lbxAccounts.FormattingEnabled = true;
            this.lbxAccounts.Location = new System.Drawing.Point(138, 51);
            this.lbxAccounts.Name = "lbxAccounts";
            this.lbxAccounts.Size = new System.Drawing.Size(108, 212);
            this.lbxAccounts.TabIndex = 2;
            this.lbxAccounts.SelectedIndexChanged += new System.EventHandler(this.lbxAccounts_SelectedIndexChanged);
            // 
            // lbxCustomers
            // 
            this.lbxCustomers.FormattingEnabled = true;
            this.lbxCustomers.Location = new System.Drawing.Point(7, 51);
            this.lbxCustomers.Name = "lbxCustomers";
            this.lbxCustomers.Size = new System.Drawing.Size(112, 212);
            this.lbxCustomers.TabIndex = 1;
            this.lbxCustomers.SelectedIndexChanged += new System.EventHandler(this.lbxCustomers_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Konton, saldo, ut- och insättningar";
            // 
            // grpBoxTransactionHistory
            // 
            this.grpBoxTransactionHistory.Controls.Add(this.lbxTransactionsList);
            this.grpBoxTransactionHistory.Location = new System.Drawing.Point(257, 81);
            this.grpBoxTransactionHistory.Name = "grpBoxTransactionHistory";
            this.grpBoxTransactionHistory.Size = new System.Drawing.Size(214, 187);
            this.grpBoxTransactionHistory.TabIndex = 5;
            this.grpBoxTransactionHistory.TabStop = false;
            this.grpBoxTransactionHistory.Text = "Transaktionshistoria";
            // 
            // lbxTransactionsList
            // 
            this.lbxTransactionsList.FormattingEnabled = true;
            this.lbxTransactionsList.Location = new System.Drawing.Point(12, 19);
            this.lbxTransactionsList.Name = "lbxTransactionsList";
            this.lbxTransactionsList.Size = new System.Drawing.Size(182, 160);
            this.lbxTransactionsList.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 772);
            this.Controls.Add(this.pnlCustManage);
            this.Controls.Add(this.grpBoxMenu);
            this.Controls.Add(this.pnlRegCus);
            this.Controls.Add(this.grpBoxToggleUImode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpBoxToggleUImode.ResumeLayout(false);
            this.grpBoxToggleUImode.PerformLayout();
            this.pnlRegCus.ResumeLayout(false);
            this.pnlRegCus.PerformLayout();
            this.grpBoxMenu.ResumeLayout(false);
            this.pnlCustManage.ResumeLayout(false);
            this.pnlCustManage.PerformLayout();
            this.pnlAddAccount.ResumeLayout(false);
            this.pnlAddAccount.PerformLayout();
            this.grpBoxDoTransaction.ResumeLayout(false);
            this.grpBoxDoTransaction.PerformLayout();
            this.grpBoxTransactionHistory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxToggleUImode;
        private System.Windows.Forms.RadioButton rbtnEmp;
        private System.Windows.Forms.RadioButton rbtnCus;
        private System.Windows.Forms.Panel pnlRegCus;
        private System.Windows.Forms.TextBox tbxFirstMoney;
        private System.Windows.Forms.TextBox tbxLName;
        private System.Windows.Forms.TextBox tbxFName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCreateNewBriefing;
        private System.Windows.Forms.Button btnRegCusConfirm;
        private System.Windows.Forms.Button btnMenuRegCus;
        private System.Windows.Forms.GroupBox grpBoxMenu;
        private System.Windows.Forms.Button btnMenuBrowse;
        private System.Windows.Forms.Panel pnlCustManage;
        private System.Windows.Forms.TextBox tbxDisplayMoney;
        private System.Windows.Forms.ListBox lbxAccounts;
        private System.Windows.Forms.ListBox lbxCustomers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpBoxDoTransaction;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnWithDraw;
        private System.Windows.Forms.Button btnConfirmTransaction;
        private System.Windows.Forms.TextBox tbxTransactionValue;
        private System.Windows.Forms.Button btnAddNewAccount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpBoxTransactionHistory;
        private System.Windows.Forms.ListBox lbxTransactionsList;
        private System.Windows.Forms.Panel pnlAddAccount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxNewAccountMoney;
        private System.Windows.Forms.Button btnConfirmAddAccount;
    }
}

