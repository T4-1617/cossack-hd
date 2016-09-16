using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManagement
{
    public partial class Form1 : Form
    {
        System.Collections.ArrayList cars;



        public bool viewcars = false;
        public bool addcars = false;
        public bool showmessage = false;


        public Form1()
        {
            InitializeComponent();

            lblMsg.Visible = false;

            cars = new System.Collections.ArrayList();
        }




    }
}
