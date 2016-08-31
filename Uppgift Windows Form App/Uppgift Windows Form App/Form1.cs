using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_Windows_Form_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void control_and_show()
        {
            if (txbName.Text != "" && txbLastName.Text != "")
                MessageBox.Show("Hej, " + txbName.Text + " " + txbLastName.Text + "!");
            else
                MessageBox.Show("Du har inte matat in fullständig information.");
        }


        private void btnAction_Click(object sender, EventArgs e)
        {
            control_and_show();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                control_and_show();
            }
        }
    }
}

