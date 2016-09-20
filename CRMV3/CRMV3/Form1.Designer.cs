namespace CRMV3
{
    partial class CRMV3
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
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.cmbxNewType = new System.Windows.Forms.ComboBox();
            this.lbxView = new System.Windows.Forms.ListBox();
            this.grpBxAdd = new System.Windows.Forms.GroupBox();
            this.btnCancelNew = new System.Windows.Forms.Button();
            this.lblStats = new System.Windows.Forms.Label();
            this.grpBxViewEdit = new System.Windows.Forms.GroupBox();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.txbFName = new System.Windows.Forms.TextBox();
            this.txbLName = new System.Windows.Forms.TextBox();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.txbIDs = new System.Windows.Forms.TextBox();
            this.txbCompany = new System.Windows.Forms.TextBox();
            this.txbSalary = new System.Windows.Forms.TextBox();
            this.txbTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblIDs = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblNewSalary = new System.Windows.Forms.Label();
            this.lblNewCompany = new System.Windows.Forms.Label();
            this.lblNewPhone = new System.Windows.Forms.Label();
            this.lblNewLName = new System.Windows.Forms.Label();
            this.lblNewFName = new System.Windows.Forms.Label();
            this.lblTitleNew = new System.Windows.Forms.Label();
            this.tbxNewTitle = new System.Windows.Forms.TextBox();
            this.tbxNewSalary = new System.Windows.Forms.TextBox();
            this.tbxNewCompany = new System.Windows.Forms.TextBox();
            this.tbxNewPhone = new System.Windows.Forms.TextBox();
            this.tbxNewLName = new System.Windows.Forms.TextBox();
            this.tbxNewFName = new System.Windows.Forms.TextBox();
            this.lblChoseType = new System.Windows.Forms.Label();
            this.grpBxAdd.SuspendLayout();
            this.grpBxViewEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Location = new System.Drawing.Point(103, 146);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(75, 23);
            this.btnSaveNew.TabIndex = 0;
            this.btnSaveNew.Text = "Spara";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // cmbxNewType
            // 
            this.cmbxNewType.FormattingEnabled = true;
            this.cmbxNewType.Location = new System.Drawing.Point(61, 24);
            this.cmbxNewType.Name = "cmbxNewType";
            this.cmbxNewType.Size = new System.Drawing.Size(121, 21);
            this.cmbxNewType.TabIndex = 1;
            this.cmbxNewType.SelectedIndexChanged += new System.EventHandler(this.cmbxNewType_SelectedIndexChanged);
            // 
            // lbxView
            // 
            this.lbxView.FormattingEnabled = true;
            this.lbxView.Location = new System.Drawing.Point(6, 28);
            this.lbxView.Name = "lbxView";
            this.lbxView.Size = new System.Drawing.Size(191, 147);
            this.lbxView.TabIndex = 2;
            this.lbxView.SelectedIndexChanged += new System.EventHandler(this.lbxView_SelectedIndexChanged);
            // 
            // grpBxAdd
            // 
            this.grpBxAdd.Controls.Add(this.lblChoseType);
            this.grpBxAdd.Controls.Add(this.lblNewSalary);
            this.grpBxAdd.Controls.Add(this.lblNewCompany);
            this.grpBxAdd.Controls.Add(this.lblNewPhone);
            this.grpBxAdd.Controls.Add(this.lblNewLName);
            this.grpBxAdd.Controls.Add(this.lblNewFName);
            this.grpBxAdd.Controls.Add(this.lblTitleNew);
            this.grpBxAdd.Controls.Add(this.tbxNewTitle);
            this.grpBxAdd.Controls.Add(this.tbxNewSalary);
            this.grpBxAdd.Controls.Add(this.tbxNewCompany);
            this.grpBxAdd.Controls.Add(this.tbxNewPhone);
            this.grpBxAdd.Controls.Add(this.tbxNewLName);
            this.grpBxAdd.Controls.Add(this.tbxNewFName);
            this.grpBxAdd.Controls.Add(this.btnCancelNew);
            this.grpBxAdd.Controls.Add(this.btnSaveNew);
            this.grpBxAdd.Controls.Add(this.cmbxNewType);
            this.grpBxAdd.Location = new System.Drawing.Point(12, 12);
            this.grpBxAdd.Name = "grpBxAdd";
            this.grpBxAdd.Size = new System.Drawing.Size(451, 183);
            this.grpBxAdd.TabIndex = 3;
            this.grpBxAdd.TabStop = false;
            this.grpBxAdd.Text = "Registrera nya kontakter:";
            // 
            // btnCancelNew
            // 
            this.btnCancelNew.Location = new System.Drawing.Point(184, 146);
            this.btnCancelNew.Name = "btnCancelNew";
            this.btnCancelNew.Size = new System.Drawing.Size(75, 23);
            this.btnCancelNew.TabIndex = 2;
            this.btnCancelNew.Text = "Avbryt";
            this.btnCancelNew.UseVisualStyleBackColor = true;
            this.btnCancelNew.Click += new System.EventHandler(this.btnCancelNew_Click);
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.Location = new System.Drawing.Point(12, 158);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(0, 13);
            this.lblStats.TabIndex = 4;
            // 
            // grpBxViewEdit
            // 
            this.grpBxViewEdit.Controls.Add(this.lblSalary);
            this.grpBxViewEdit.Controls.Add(this.lblCompany);
            this.grpBxViewEdit.Controls.Add(this.lblIDs);
            this.grpBxViewEdit.Controls.Add(this.lblPhone);
            this.grpBxViewEdit.Controls.Add(this.lblLName);
            this.grpBxViewEdit.Controls.Add(this.lblFName);
            this.grpBxViewEdit.Controls.Add(this.lblTitle);
            this.grpBxViewEdit.Controls.Add(this.txbTitle);
            this.grpBxViewEdit.Controls.Add(this.txbSalary);
            this.grpBxViewEdit.Controls.Add(this.txbCompany);
            this.grpBxViewEdit.Controls.Add(this.txbIDs);
            this.grpBxViewEdit.Controls.Add(this.txbPhone);
            this.grpBxViewEdit.Controls.Add(this.txbLName);
            this.grpBxViewEdit.Controls.Add(this.txbFName);
            this.grpBxViewEdit.Controls.Add(this.btnCancelEdit);
            this.grpBxViewEdit.Controls.Add(this.btnSaveEdit);
            this.grpBxViewEdit.Controls.Add(this.lbxView);
            this.grpBxViewEdit.Location = new System.Drawing.Point(12, 213);
            this.grpBxViewEdit.Name = "grpBxViewEdit";
            this.grpBxViewEdit.Size = new System.Drawing.Size(628, 192);
            this.grpBxViewEdit.TabIndex = 5;
            this.grpBxViewEdit.TabStop = false;
            this.grpBxViewEdit.Text = "Se och redigera kontakter:";
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.Location = new System.Drawing.Point(438, 163);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(103, 23);
            this.btnSaveEdit.TabIndex = 3;
            this.btnSaveEdit.Text = "Spara ändringar";
            this.btnSaveEdit.UseVisualStyleBackColor = true;
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.Location = new System.Drawing.Point(547, 163);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(75, 23);
            this.btnCancelEdit.TabIndex = 4;
            this.btnCancelEdit.Text = "Avbryt";
            this.btnCancelEdit.UseVisualStyleBackColor = true;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // txbFName
            // 
            this.txbFName.Location = new System.Drawing.Point(351, 28);
            this.txbFName.Name = "txbFName";
            this.txbFName.ReadOnly = true;
            this.txbFName.Size = new System.Drawing.Size(100, 20);
            this.txbFName.TabIndex = 5;
            // 
            // txbLName
            // 
            this.txbLName.Location = new System.Drawing.Point(351, 54);
            this.txbLName.Name = "txbLName";
            this.txbLName.ReadOnly = true;
            this.txbLName.Size = new System.Drawing.Size(100, 20);
            this.txbLName.TabIndex = 5;
            // 
            // txbPhone
            // 
            this.txbPhone.Location = new System.Drawing.Point(351, 80);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.ReadOnly = true;
            this.txbPhone.Size = new System.Drawing.Size(100, 20);
            this.txbPhone.TabIndex = 5;
            // 
            // txbIDs
            // 
            this.txbIDs.Location = new System.Drawing.Point(522, 80);
            this.txbIDs.Name = "txbIDs";
            this.txbIDs.ReadOnly = true;
            this.txbIDs.Size = new System.Drawing.Size(100, 20);
            this.txbIDs.TabIndex = 5;
            // 
            // txbCompany
            // 
            this.txbCompany.Location = new System.Drawing.Point(522, 28);
            this.txbCompany.Name = "txbCompany";
            this.txbCompany.ReadOnly = true;
            this.txbCompany.Size = new System.Drawing.Size(100, 20);
            this.txbCompany.TabIndex = 5;
            // 
            // txbSalary
            // 
            this.txbSalary.Location = new System.Drawing.Point(522, 54);
            this.txbSalary.Name = "txbSalary";
            this.txbSalary.ReadOnly = true;
            this.txbSalary.Size = new System.Drawing.Size(100, 20);
            this.txbSalary.TabIndex = 5;
            // 
            // txbTitle
            // 
            this.txbTitle.Location = new System.Drawing.Point(237, 28);
            this.txbTitle.Name = "txbTitle";
            this.txbTitle.ReadOnly = true;
            this.txbTitle.Size = new System.Drawing.Size(52, 20);
            this.txbTitle.TabIndex = 6;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(203, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Titel:";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(297, 31);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(51, 13);
            this.lblFName.TabIndex = 7;
            this.lblFName.Text = "Förnamn:";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(290, 57);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(58, 13);
            this.lblLName.TabIndex = 7;
            this.lblLName.Text = "Efternamn:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(302, 83);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(46, 13);
            this.lblPhone.TabIndex = 7;
            this.lblPhone.Text = "Telefon:";
            // 
            // lblIDs
            // 
            this.lblIDs.AutoSize = true;
            this.lblIDs.Location = new System.Drawing.Point(498, 83);
            this.lblIDs.Name = "lblIDs";
            this.lblIDs.Size = new System.Drawing.Size(21, 13);
            this.lblIDs.TabIndex = 7;
            this.lblIDs.Text = "ID:";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(474, 31);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(46, 13);
            this.lblCompany.TabIndex = 7;
            this.lblCompany.Text = "Företag:";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(491, 57);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(28, 13);
            this.lblSalary.TabIndex = 7;
            this.lblSalary.Text = "Lön:";
            // 
            // lblNewSalary
            // 
            this.lblNewSalary.AutoSize = true;
            this.lblNewSalary.Location = new System.Drawing.Point(299, 91);
            this.lblNewSalary.Name = "lblNewSalary";
            this.lblNewSalary.Size = new System.Drawing.Size(28, 13);
            this.lblNewSalary.TabIndex = 22;
            this.lblNewSalary.Text = "Lön:";
            // 
            // lblNewCompany
            // 
            this.lblNewCompany.AutoSize = true;
            this.lblNewCompany.Location = new System.Drawing.Point(282, 65);
            this.lblNewCompany.Name = "lblNewCompany";
            this.lblNewCompany.Size = new System.Drawing.Size(46, 13);
            this.lblNewCompany.TabIndex = 21;
            this.lblNewCompany.Text = "Företag:";
            // 
            // lblNewPhone
            // 
            this.lblNewPhone.AutoSize = true;
            this.lblNewPhone.Location = new System.Drawing.Point(110, 117);
            this.lblNewPhone.Name = "lblNewPhone";
            this.lblNewPhone.Size = new System.Drawing.Size(46, 13);
            this.lblNewPhone.TabIndex = 19;
            this.lblNewPhone.Text = "Telefon:";
            // 
            // lblNewLName
            // 
            this.lblNewLName.AutoSize = true;
            this.lblNewLName.Location = new System.Drawing.Point(98, 91);
            this.lblNewLName.Name = "lblNewLName";
            this.lblNewLName.Size = new System.Drawing.Size(58, 13);
            this.lblNewLName.TabIndex = 18;
            this.lblNewLName.Text = "Efternamn:";
            // 
            // lblNewFName
            // 
            this.lblNewFName.AutoSize = true;
            this.lblNewFName.Location = new System.Drawing.Point(105, 65);
            this.lblNewFName.Name = "lblNewFName";
            this.lblNewFName.Size = new System.Drawing.Size(51, 13);
            this.lblNewFName.TabIndex = 24;
            this.lblNewFName.Text = "Förnamn:";
            // 
            // lblTitleNew
            // 
            this.lblTitleNew.AutoSize = true;
            this.lblTitleNew.Location = new System.Drawing.Point(11, 65);
            this.lblTitleNew.Name = "lblTitleNew";
            this.lblTitleNew.Size = new System.Drawing.Size(30, 13);
            this.lblTitleNew.TabIndex = 17;
            this.lblTitleNew.Text = "Titel:";
            // 
            // tbxNewTitle
            // 
            this.tbxNewTitle.Location = new System.Drawing.Point(45, 62);
            this.tbxNewTitle.Name = "tbxNewTitle";
            this.tbxNewTitle.ReadOnly = true;
            this.tbxNewTitle.Size = new System.Drawing.Size(52, 20);
            this.tbxNewTitle.TabIndex = 16;
            // 
            // tbxNewSalary
            // 
            this.tbxNewSalary.Location = new System.Drawing.Point(330, 88);
            this.tbxNewSalary.Name = "tbxNewSalary";
            this.tbxNewSalary.ReadOnly = true;
            this.tbxNewSalary.Size = new System.Drawing.Size(100, 20);
            this.tbxNewSalary.TabIndex = 12;
            // 
            // tbxNewCompany
            // 
            this.tbxNewCompany.Location = new System.Drawing.Point(330, 62);
            this.tbxNewCompany.Name = "tbxNewCompany";
            this.tbxNewCompany.ReadOnly = true;
            this.tbxNewCompany.Size = new System.Drawing.Size(100, 20);
            this.tbxNewCompany.TabIndex = 11;
            // 
            // tbxNewPhone
            // 
            this.tbxNewPhone.Location = new System.Drawing.Point(159, 114);
            this.tbxNewPhone.Name = "tbxNewPhone";
            this.tbxNewPhone.ReadOnly = true;
            this.tbxNewPhone.Size = new System.Drawing.Size(100, 20);
            this.tbxNewPhone.TabIndex = 9;
            // 
            // tbxNewLName
            // 
            this.tbxNewLName.Location = new System.Drawing.Point(159, 88);
            this.tbxNewLName.Name = "tbxNewLName";
            this.tbxNewLName.ReadOnly = true;
            this.tbxNewLName.Size = new System.Drawing.Size(100, 20);
            this.tbxNewLName.TabIndex = 15;
            // 
            // tbxNewFName
            // 
            this.tbxNewFName.Location = new System.Drawing.Point(159, 62);
            this.tbxNewFName.Name = "tbxNewFName";
            this.tbxNewFName.ReadOnly = true;
            this.tbxNewFName.Size = new System.Drawing.Size(100, 20);
            this.tbxNewFName.TabIndex = 8;
            // 
            // lblChoseType
            // 
            this.lblChoseType.AutoSize = true;
            this.lblChoseType.Location = new System.Drawing.Point(11, 27);
            this.lblChoseType.Name = "lblChoseType";
            this.lblChoseType.Size = new System.Drawing.Size(44, 13);
            this.lblChoseType.TabIndex = 26;
            this.lblChoseType.Text = "Välj typ:";
            // 
            // CRMV3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 418);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.grpBxAdd);
            this.Controls.Add(this.grpBxViewEdit);
            this.Name = "CRMV3";
            this.Text = "CRM V3";
            this.grpBxAdd.ResumeLayout(false);
            this.grpBxAdd.PerformLayout();
            this.grpBxViewEdit.ResumeLayout(false);
            this.grpBxViewEdit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.ComboBox cmbxNewType;
        private System.Windows.Forms.ListBox lbxView;
        private System.Windows.Forms.GroupBox grpBxAdd;
        private System.Windows.Forms.Label lblChoseType;
        private System.Windows.Forms.Label lblNewSalary;
        private System.Windows.Forms.Label lblNewCompany;
        private System.Windows.Forms.Label lblNewPhone;
        private System.Windows.Forms.Label lblNewLName;
        private System.Windows.Forms.Label lblNewFName;
        private System.Windows.Forms.Label lblTitleNew;
        private System.Windows.Forms.TextBox tbxNewTitle;
        private System.Windows.Forms.TextBox tbxNewSalary;
        private System.Windows.Forms.TextBox tbxNewCompany;
        private System.Windows.Forms.TextBox tbxNewPhone;
        private System.Windows.Forms.TextBox tbxNewLName;
        private System.Windows.Forms.TextBox tbxNewFName;
        private System.Windows.Forms.Button btnCancelNew;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.GroupBox grpBxViewEdit;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblIDs;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txbTitle;
        private System.Windows.Forms.TextBox txbSalary;
        private System.Windows.Forms.TextBox txbCompany;
        private System.Windows.Forms.TextBox txbIDs;
        private System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.TextBox txbLName;
        private System.Windows.Forms.TextBox txbFName;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.Button btnSaveEdit;
    }
}

