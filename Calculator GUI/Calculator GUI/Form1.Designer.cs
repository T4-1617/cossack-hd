namespace Calculator_GUI
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
            this.txbNumb1 = new System.Windows.Forms.TextBox();
            this.txbNumb2 = new System.Windows.Forms.TextBox();
            this.grpBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnPlus = new System.Windows.Forms.RadioButton();
            this.rbtnMinus = new System.Windows.Forms.RadioButton();
            this.rbtnDivide = new System.Windows.Forms.RadioButton();
            this.rbtnMult = new System.Windows.Forms.RadioButton();
            this.lblNumb1 = new System.Windows.Forms.Label();
            this.lblNumb2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lsBoxResults = new System.Windows.Forms.ListBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.grpBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbNumb1
            // 
            this.txbNumb1.Location = new System.Drawing.Point(12, 31);
            this.txbNumb1.Name = "txbNumb1";
            this.txbNumb1.Size = new System.Drawing.Size(100, 20);
            this.txbNumb1.TabIndex = 0;
            // 
            // txbNumb2
            // 
            this.txbNumb2.Location = new System.Drawing.Point(333, 29);
            this.txbNumb2.Name = "txbNumb2";
            this.txbNumb2.Size = new System.Drawing.Size(100, 20);
            this.txbNumb2.TabIndex = 1;
            // 
            // grpBox1
            // 
            this.grpBox1.Controls.Add(this.rbtnMult);
            this.grpBox1.Controls.Add(this.rbtnDivide);
            this.grpBox1.Controls.Add(this.rbtnMinus);
            this.grpBox1.Controls.Add(this.rbtnPlus);
            this.grpBox1.Location = new System.Drawing.Point(119, 12);
            this.grpBox1.Name = "grpBox1";
            this.grpBox1.Size = new System.Drawing.Size(207, 73);
            this.grpBox1.TabIndex = 2;
            this.grpBox1.TabStop = false;
            this.grpBox1.Text = "Operation";
            // 
            // rbtnPlus
            // 
            this.rbtnPlus.AutoSize = true;
            this.rbtnPlus.Checked = true;
            this.rbtnPlus.Location = new System.Drawing.Point(7, 20);
            this.rbtnPlus.Name = "rbtnPlus";
            this.rbtnPlus.Size = new System.Drawing.Size(59, 17);
            this.rbtnPlus.TabIndex = 0;
            this.rbtnPlus.TabStop = true;
            this.rbtnPlus.Text = "+ (plus)";
            this.rbtnPlus.UseVisualStyleBackColor = true;
            // 
            // rbtnMinus
            // 
            this.rbtnMinus.AutoSize = true;
            this.rbtnMinus.Location = new System.Drawing.Point(121, 20);
            this.rbtnMinus.Name = "rbtnMinus";
            this.rbtnMinus.Size = new System.Drawing.Size(64, 17);
            this.rbtnMinus.TabIndex = 1;
            this.rbtnMinus.TabStop = true;
            this.rbtnMinus.Text = "- (minus)";
            this.rbtnMinus.UseVisualStyleBackColor = true;
            // 
            // rbtnDivide
            // 
            this.rbtnDivide.AutoSize = true;
            this.rbtnDivide.Location = new System.Drawing.Point(7, 43);
            this.rbtnDivide.Name = "rbtnDivide";
            this.rbtnDivide.Size = new System.Drawing.Size(99, 17);
            this.rbtnDivide.TabIndex = 2;
            this.rbtnDivide.TabStop = true;
            this.rbtnDivide.Text = "/ (dividera med)";
            this.rbtnDivide.UseVisualStyleBackColor = true;
            // 
            // rbtnMult
            // 
            this.rbtnMult.AutoSize = true;
            this.rbtnMult.Location = new System.Drawing.Point(121, 43);
            this.rbtnMult.Name = "rbtnMult";
            this.rbtnMult.Size = new System.Drawing.Size(72, 17);
            this.rbtnMult.TabIndex = 3;
            this.rbtnMult.TabStop = true;
            this.rbtnMult.Text = "x (gånger)";
            this.rbtnMult.UseVisualStyleBackColor = true;
            // 
            // lblNumb1
            // 
            this.lblNumb1.AutoSize = true;
            this.lblNumb1.Location = new System.Drawing.Point(32, 15);
            this.lblNumb1.Name = "lblNumb1";
            this.lblNumb1.Size = new System.Drawing.Size(59, 13);
            this.lblNumb1.TabIndex = 3;
            this.lblNumb1.Text = "Första talet";
            // 
            // lblNumb2
            // 
            this.lblNumb2.AutoSize = true;
            this.lblNumb2.Location = new System.Drawing.Point(358, 13);
            this.lblNumb2.Name = "lblNumb2";
            this.lblNumb2.Size = new System.Drawing.Size(58, 13);
            this.lblNumb2.TabIndex = 4;
            this.lblNumb2.Text = "Andra talet";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button1.Location = new System.Drawing.Point(119, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "KÖR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lsBoxResults
            // 
            this.lsBoxResults.FormattingEnabled = true;
            this.lsBoxResults.Location = new System.Drawing.Point(12, 172);
            this.lsBoxResults.Name = "lsBoxResults";
            this.lsBoxResults.Size = new System.Drawing.Size(426, 225);
            this.lsBoxResults.TabIndex = 6;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(13, 153);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(49, 13);
            this.lblResults.TabIndex = 7;
            this.lblResults.Text = "Resultat:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 406);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lsBoxResults);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNumb2);
            this.Controls.Add(this.lblNumb1);
            this.Controls.Add(this.grpBox1);
            this.Controls.Add(this.txbNumb2);
            this.Controls.Add(this.txbNumb1);
            this.Name = "Form1";
            this.Text = "Kalkylator";
            this.grpBox1.ResumeLayout(false);
            this.grpBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNumb1;
        private System.Windows.Forms.TextBox txbNumb2;
        private System.Windows.Forms.GroupBox grpBox1;
        private System.Windows.Forms.RadioButton rbtnMult;
        private System.Windows.Forms.RadioButton rbtnDivide;
        private System.Windows.Forms.RadioButton rbtnMinus;
        private System.Windows.Forms.RadioButton rbtnPlus;
        private System.Windows.Forms.Label lblNumb1;
        private System.Windows.Forms.Label lblNumb2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lsBoxResults;
        private System.Windows.Forms.Label lblResults;
    }
}

