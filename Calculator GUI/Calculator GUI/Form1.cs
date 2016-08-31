using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float numb1 = float.Parse(txbNumb1.Text);
            float numb2 = float.Parse(txbNumb2.Text);
            float result = 0;
            string actiondescr = "";

            if (rbtnPlus.Checked)
            {
                actiondescr = txbNumb1.Text + " plus " + txbNumb2.Text + " ger: ";
                result = numb1 + numb2;
            }
            if (rbtnMinus.Checked)
            { 
                actiondescr = txbNumb1.Text + " minus " + txbNumb2.Text + " ger: ";
                result = numb1 - numb2;
            }
            if (rbtnDivide.Checked)
            { 
                actiondescr = txbNumb1.Text + " dividera med " + txbNumb2.Text + " ger: ";
                result = numb1 / numb2;
            }
            if (rbtnMult.Checked)
            { 
                actiondescr = txbNumb1.Text + " multiplicera med " + txbNumb2.Text + " ger: ";
                result = numb1 * numb2;
            }


            lsBoxResults.Items.Add(actiondescr + result.ToString());
        }
    }
}
