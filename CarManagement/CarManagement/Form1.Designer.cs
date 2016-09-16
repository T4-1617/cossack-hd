namespace CarManagement
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewAvailable = new System.Windows.Forms.Button();
            this.btnAddCars = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAction = new System.Windows.Forms.Button();
            this.tbxRN = new System.Windows.Forms.TextBox();
            this.tbxMake = new System.Windows.Forms.TextBox();
            this.tbxModel = new System.Windows.Forms.TextBox();
            this.tbxColor = new System.Windows.Forms.TextBox();
            this.lblCarCount = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbxColor);
            this.panel1.Controls.Add(this.tbxModel);
            this.panel1.Controls.Add(this.tbxMake);
            this.panel1.Controls.Add(this.tbxRN);
            this.panel1.Controls.Add(this.btnAction);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(38, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 341);
            this.panel1.TabIndex = 0;
            // 
            // btnViewAvailable
            // 
            this.btnViewAvailable.Location = new System.Drawing.Point(38, 37);
            this.btnViewAvailable.Name = "btnViewAvailable";
            this.btnViewAvailable.Size = new System.Drawing.Size(98, 23);
            this.btnViewAvailable.TabIndex = 1;
            this.btnViewAvailable.Text = "Show Available";
            this.btnViewAvailable.UseVisualStyleBackColor = true;
            this.btnViewAvailable.Click += new System.EventHandler(this.btnViewAvailable_Click);
            // 
            // btnAddCars
            // 
            this.btnAddCars.Location = new System.Drawing.Point(142, 37);
            this.btnAddCars.Name = "btnAddCars";
            this.btnAddCars.Size = new System.Drawing.Size(75, 23);
            this.btnAddCars.TabIndex = 2;
            this.btnAddCars.Text = "Add Car";
            this.btnAddCars.UseVisualStyleBackColor = true;
            this.btnAddCars.Click += new System.EventHandler(this.btnAddCars_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(223, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Return Car";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(399, 329);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(73, 111);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(100, 23);
            this.btnAction.TabIndex = 1;
            this.btnAction.Text = "Action";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // tbxRN
            // 
            this.tbxRN.Location = new System.Drawing.Point(73, 4);
            this.tbxRN.Name = "tbxRN";
            this.tbxRN.Size = new System.Drawing.Size(100, 20);
            this.tbxRN.TabIndex = 2;
            // 
            // tbxMake
            // 
            this.tbxMake.Location = new System.Drawing.Point(73, 31);
            this.tbxMake.Name = "tbxMake";
            this.tbxMake.Size = new System.Drawing.Size(100, 20);
            this.tbxMake.TabIndex = 3;
            // 
            // tbxModel
            // 
            this.tbxModel.Location = new System.Drawing.Point(73, 58);
            this.tbxModel.Name = "tbxModel";
            this.tbxModel.Size = new System.Drawing.Size(100, 20);
            this.tbxModel.TabIndex = 4;
            // 
            // tbxColor
            // 
            this.tbxColor.Location = new System.Drawing.Point(73, 85);
            this.tbxColor.Name = "tbxColor";
            this.tbxColor.Size = new System.Drawing.Size(100, 20);
            this.tbxColor.TabIndex = 5;
            // 
            // lblCarCount
            // 
            this.lblCarCount.AutoSize = true;
            this.lblCarCount.Location = new System.Drawing.Point(41, 12);
            this.lblCarCount.Name = "lblCarCount";
            this.lblCarCount.Size = new System.Drawing.Size(134, 13);
            this.lblCarCount.TabIndex = 4;
            this.lblCarCount.Text = "There are X cars available!";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(41, 71);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(76, 13);
            this.lblMsg.TabIndex = 6;
            this.lblMsg.Text = "MessageLabel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "RegNumb";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Maker";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Color";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 504);
            this.Controls.Add(this.lblCarCount);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnAddCars);
            this.Controls.Add(this.btnViewAvailable);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbxColor;
        private System.Windows.Forms.TextBox tbxModel;
        private System.Windows.Forms.TextBox tbxMake;
        private System.Windows.Forms.TextBox tbxRN;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnViewAvailable;
        private System.Windows.Forms.Button btnAddCars;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblCarCount;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

