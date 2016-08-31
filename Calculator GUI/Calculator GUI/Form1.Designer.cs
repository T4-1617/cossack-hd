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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.grpBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.lblNumb1 = new System.Windows.Forms.Label();
            this.lblNumb2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lsBoxResults = new System.Windows.Forms.ListBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.grpBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(333, 29);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // grpBox1
            // 
            this.grpBox1.Controls.Add(this.radioButton4);
            this.grpBox1.Controls.Add(this.radioButton3);
            this.grpBox1.Controls.Add(this.radioButton2);
            this.grpBox1.Controls.Add(this.radioButton1);
            this.grpBox1.Location = new System.Drawing.Point(119, 12);
            this.grpBox1.Name = "grpBox1";
            this.grpBox1.Size = new System.Drawing.Size(207, 73);
            this.grpBox1.TabIndex = 2;
            this.grpBox1.TabStop = false;
            this.grpBox1.Text = "Operation";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "+ (plus)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(121, 20);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(64, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "- (minus)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 43);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(99, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "/ (dividera med)";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(121, 43);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(72, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "x (gånger)";
            this.radioButton4.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Kalkylator";
            this.grpBox1.ResumeLayout(false);
            this.grpBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox grpBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label lblNumb1;
        private System.Windows.Forms.Label lblNumb2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lsBoxResults;
        private System.Windows.Forms.Label lblResults;
    }
}

