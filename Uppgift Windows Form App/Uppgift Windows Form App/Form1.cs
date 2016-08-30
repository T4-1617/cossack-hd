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

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (txbName != "" && txbLastName != "")
                MessageBox.Show("Hej, " + txbName.Text + " " + txbLastName.Text+"!");
            else
                MessageBox.Show("Du har inte matat in fullständig information.");
        }
    }
}
