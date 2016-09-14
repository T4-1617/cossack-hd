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
            this.lbxCars = new System.Windows.Forms.ListBox();
            this.lblCars = new System.Windows.Forms.Label();
            this.lblProp = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbxProps = new System.Windows.Forms.ListBox();
            this.pnlProps.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProps
            // 
            this.pnlProps.Controls.Add(this.lbxProps);
            this.pnlProps.Controls.Add(this.btnCancel);
            this.pnlProps.Controls.Add(this.btnSave);
            this.pnlProps.Controls.Add(this.btnEdit);
            this.pnlProps.Location = new System.Drawing.Point(337, 27);
            this.pnlProps.Name = "pnlProps";
            this.pnlProps.Size = new System.Drawing.Size(253, 316);
            this.pnlProps.TabIndex = 0;
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
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(86, 280);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
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
            // lbxProps
            // 
            this.lbxProps.FormattingEnabled = true;
            this.lbxProps.Location = new System.Drawing.Point(4, 4);
            this.lbxProps.Name = "lbxProps";
            this.lbxProps.Size = new System.Drawing.Size(239, 264);
            this.lbxProps.TabIndex = 3;
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlProps;
        private System.Windows.Forms.ListBox lbxProps;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ListBox lbxCars;
        private System.Windows.Forms.Label lblCars;
        private System.Windows.Forms.Label lblProp;
    }
}

