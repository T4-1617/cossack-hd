namespace BilUthyrning
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
            this.pnlProps = new System.Windows.Forms.Panel();
            this.cbxAvailable = new System.Windows.Forms.CheckBox();
            this.tbxPrp7 = new System.Windows.Forms.TextBox();
            this.tbxPrp6 = new System.Windows.Forms.TextBox();
            this.tbxPrp5 = new System.Windows.Forms.TextBox();
            this.tbxPrp4 = new System.Windows.Forms.TextBox();
            this.tbxPrp3 = new System.Windows.Forms.TextBox();
            this.tbxPrp2 = new System.Windows.Forms.TextBox();
            this.tbxPrp1 = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lbxCars = new System.Windows.Forms.ListBox();
            this.lblCars = new System.Windows.Forms.Label();
            this.lblProp = new System.Windows.Forms.Label();
            this.pnlProps.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProps
            // 
            this.pnlProps.Controls.Add(this.cbxAvailable);
            this.pnlProps.Controls.Add(this.tbxPrp7);
            this.pnlProps.Controls.Add(this.tbxPrp6);
            this.pnlProps.Controls.Add(this.tbxPrp5);
            this.pnlProps.Controls.Add(this.tbxPrp4);
            this.pnlProps.Controls.Add(this.tbxPrp3);
            this.pnlProps.Controls.Add(this.tbxPrp2);
            this.pnlProps.Controls.Add(this.tbxPrp1);
            this.pnlProps.Controls.Add(this.btnCancel);
            this.pnlProps.Controls.Add(this.btnSave);
            this.pnlProps.Controls.Add(this.btnEdit);
            this.pnlProps.Location = new System.Drawing.Point(337, 27);
            this.pnlProps.Name = "pnlProps";
            this.pnlProps.Size = new System.Drawing.Size(253, 316);
            this.pnlProps.TabIndex = 0;
            // 
            // cbxAvailable
            // 
            this.cbxAvailable.AutoSize = true;
            this.cbxAvailable.Location = new System.Drawing.Point(4, 110);
            this.cbxAvailable.Name = "cbxAvailable";
            this.cbxAvailable.Size = new System.Drawing.Size(69, 17);
            this.cbxAvailable.TabIndex = 4;
            this.cbxAvailable.Text = "Available";
            this.cbxAvailable.UseVisualStyleBackColor = true;
            // 
            // tbxPrp7
            // 
            this.tbxPrp7.Location = new System.Drawing.Point(3, 160);
            this.tbxPrp7.Name = "tbxPrp7";
            this.tbxPrp7.Size = new System.Drawing.Size(239, 20);
            this.tbxPrp7.TabIndex = 3;
            this.tbxPrp7.Text = "Mileage";
            this.tbxPrp7.Click += new System.EventHandler(this.tbxPrp7_Click);
            // 
            // tbxPrp6
            // 
            this.tbxPrp6.Location = new System.Drawing.Point(4, 134);
            this.tbxPrp6.Name = "tbxPrp6";
            this.tbxPrp6.Size = new System.Drawing.Size(239, 20);
            this.tbxPrp6.TabIndex = 3;
            this.tbxPrp6.Text = "Current user";
            this.tbxPrp6.Click += new System.EventHandler(this.tbxPrp6_Click);
            // 
            // tbxPrp5
            // 
            this.tbxPrp5.Location = new System.Drawing.Point(4, 108);
            this.tbxPrp5.Name = "tbxPrp5";
            this.tbxPrp5.Size = new System.Drawing.Size(239, 20);
            this.tbxPrp5.TabIndex = 3;
            this.tbxPrp5.Text = "Availability";
            // 
            // tbxPrp4
            // 
            this.tbxPrp4.Location = new System.Drawing.Point(4, 82);
            this.tbxPrp4.Name = "tbxPrp4";
            this.tbxPrp4.Size = new System.Drawing.Size(239, 20);
            this.tbxPrp4.TabIndex = 3;
            this.tbxPrp4.Text = "Color";
            this.tbxPrp4.Click += new System.EventHandler(this.tbxPrp4_Click);
            // 
            // tbxPrp3
            // 
            this.tbxPrp3.Location = new System.Drawing.Point(4, 56);
            this.tbxPrp3.Name = "tbxPrp3";
            this.tbxPrp3.Size = new System.Drawing.Size(239, 20);
            this.tbxPrp3.TabIndex = 3;
            this.tbxPrp3.Text = "Model";
            // 
            // tbxPrp2
            // 
            this.tbxPrp2.Location = new System.Drawing.Point(4, 30);
            this.tbxPrp2.Name = "tbxPrp2";
            this.tbxPrp2.Size = new System.Drawing.Size(239, 20);
            this.tbxPrp2.TabIndex = 3;
            this.tbxPrp2.Text = "Regnr";
            // 
            // tbxPrp1
            // 
            this.tbxPrp1.Location = new System.Drawing.Point(4, 4);
            this.tbxPrp1.Name = "tbxPrp1";
            this.tbxPrp1.Size = new System.Drawing.Size(239, 20);
            this.tbxPrp1.TabIndex = 3;
            this.tbxPrp1.Text = "ID";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(168, 280);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(86, 280);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(4, 281);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lbxCars
            // 
            this.lbxCars.FormattingEnabled = true;
            this.lbxCars.Location = new System.Drawing.Point(29, 27);
            this.lbxCars.Name = "lbxCars";
            this.lbxCars.Size = new System.Drawing.Size(264, 316);
            this.lbxCars.TabIndex = 1;
            this.lbxCars.SelectedIndexChanged += new System.EventHandler(this.lbxCars_SelectedIndexChanged);
            // 
            // lblCars
            // 
            this.lblCars.AutoSize = true;
            this.lblCars.Location = new System.Drawing.Point(29, 8);
            this.lblCars.Name = "lblCars";
            this.lblCars.Size = new System.Drawing.Size(28, 13);
            this.lblCars.TabIndex = 2;
            this.lblCars.Text = "Cars";
            // 
            // lblProp
            // 
            this.lblProp.AutoSize = true;
            this.lblProp.Location = new System.Drawing.Point(337, 8);
            this.lblProp.Name = "lblProp";
            this.lblProp.Size = new System.Drawing.Size(54, 13);
            this.lblProp.TabIndex = 3;
            this.lblProp.Text = "Properties";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 440);
            this.Controls.Add(this.lblProp);
            this.Controls.Add(this.lblCars);
            this.Controls.Add(this.lbxCars);
            this.Controls.Add(this.pnlProps);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlProps.ResumeLayout(false);
            this.pnlProps.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlProps;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ListBox lbxCars;
        private System.Windows.Forms.Label lblCars;
        private System.Windows.Forms.Label lblProp;
        private System.Windows.Forms.TextBox tbxPrp6;
        private System.Windows.Forms.TextBox tbxPrp5;
        private System.Windows.Forms.TextBox tbxPrp4;
        private System.Windows.Forms.TextBox tbxPrp3;
        private System.Windows.Forms.TextBox tbxPrp2;
        private System.Windows.Forms.TextBox tbxPrp1;
        private System.Windows.Forms.TextBox tbxPrp7;
        private System.Windows.Forms.CheckBox cbxAvailable;
    }
}

