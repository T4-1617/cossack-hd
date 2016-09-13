namespace CRM_V1
{
    partial class CRM_MainWind
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
            this.lblFName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.txbFname = new System.Windows.Forms.TextBox();
            this.txbLname = new System.Windows.Forms.TextBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.lblCounter = new System.Windows.Forms.Label();
            this.lboxCustomers = new System.Windows.Forms.ListBox();
            this.cboxVIP = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(29, 39);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(48, 13);
            this.lblFName.TabIndex = 0;
            this.lblFName.Text = "Förnamn";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(29, 66);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(55, 13);
            this.lblLName.TabIndex = 1;
            this.lblLName.Text = "Efternamn";
            // 
            // txbFname
            // 
            this.txbFname.Location = new System.Drawing.Point(86, 36);
            this.txbFname.Name = "txbFname";
            this.txbFname.Size = new System.Drawing.Size(100, 20);
            this.txbFname.TabIndex = 2;
            // 
            // txbLname
            // 
            this.txbLname.Location = new System.Drawing.Point(86, 63);
            this.txbLname.Name = "txbLname";
            this.txbLname.Size = new System.Drawing.Size(100, 20);
            this.txbLname.TabIndex = 3;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(111, 113);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnAddCustomer.TabIndex = 4;
            this.btnAddCustomer.Text = "Lägg till kunden";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Location = new System.Drawing.Point(63, 266);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(110, 13);
            this.lblCounter.TabIndex = 5;
            this.lblCounter.Text = "Du har inga kunder :<";
            // 
            // lboxCustomers
            // 
            this.lboxCustomers.FormattingEnabled = true;
            this.lboxCustomers.Location = new System.Drawing.Point(32, 152);
            this.lboxCustomers.Name = "lboxCustomers";
            this.lboxCustomers.Size = new System.Drawing.Size(154, 95);
            this.lboxCustomers.TabIndex = 6;
            this.lboxCustomers.SelectedIndexChanged += new System.EventHandler(this.lboxCustomers_SelectedIndexChanged);
            // 
            // cboxVIP
            // 
            this.cboxVIP.AutoSize = true;
            this.cboxVIP.Location = new System.Drawing.Point(193, 152);
            this.cboxVIP.Name = "cboxVIP";
            this.cboxVIP.Size = new System.Drawing.Size(43, 17);
            this.cboxVIP.TabIndex = 7;
            this.cboxVIP.Text = "VIP";
            this.cboxVIP.UseVisualStyleBackColor = true;
            this.cboxVIP.CheckedChanged += new System.EventHandler(this.cboxVIP_CheckedChanged);
            // 
            // CRM_MainWind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 324);
            this.Controls.Add(this.cboxVIP);
            this.Controls.Add(this.lboxCustomers);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.txbLname);
            this.Controls.Add(this.txbFname);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.lblFName);
            this.Name = "CRM_MainWind";
            this.Text = "CRM V1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.TextBox txbFname;
        private System.Windows.Forms.TextBox txbLname;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.ListBox lboxCustomers;
        private System.Windows.Forms.CheckBox cboxVIP;
    }
}

