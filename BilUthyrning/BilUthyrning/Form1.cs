using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilUthyrning
{
    public partial class Form1 : Form
    {

        System.Collections.ArrayList myCars = new System.Collections.ArrayList();
        public bool editmode = false;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            defaultFormControls();

            populateDemo();

            foreach (Car item in myCars)
            {
                lbxCars.Items.Add(item);
            }

        }


        private void lbxCars_SelectedIndexChanged(object sender, EventArgs e)
        {

            pnlProps.Visible = true;
            int index = lbxCars.SelectedIndex;
            showproperties(index);

        }


        private void showproperties(int ind)
        {

            Car c = (Car)myCars[ind];


            tbxPrp1.Text = c.returnSelectedProp("id");
            tbxPrp2.Text = c.returnSelectedProp("regnr");
            tbxPrp3.Text = c.returnSelectedProp("model");
            tbxPrp4.Text = c.returnSelectedProp("color");
            tbxPrp5.Text = c.returnSelectedProp("available");
            tbxPrp6.Text = c.returnSelectedProp("currentUser");
            tbxPrp7.Text = c.returnSelectedProp("mileage");


        }





        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            lbxCars.Enabled = false;
            Car c = (Car)myCars[lbxCars.SelectedIndex];
            editmode = true;
            btnSave.Enabled = true;
            tbxPrp4.ReadOnly = false;
            tbxPrp5.Visible = false;
            cbxAvailable.Visible = true;
            tbxPrp6.ReadOnly = false;
            tbxPrp7.ReadOnly = false;
            tbxPrp7.Text = c.returnSelectedProp("puremileagevalue");
            
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            defaultFormControls();
            lbxCars.Enabled = true;
            Car c = (Car)myCars[lbxCars.SelectedIndex];

            c.updateCar(tbxPrp4.Text, cbxAvailable.Checked, tbxPrp6.Text, int.Parse(tbxPrp7.Text));
            editmode = false;

        }



        //UTILS

        private void populateDemo()
        {

            //Car demo = new Car(ID, "REGNR", AVAIL, "MODELNAME", "COLOR", MILEAGE);
            Car c0 = new Car(0, "MLG420", "Volvo V70", "Black", false, "Köra Bil 100%", 19226);

            Car c1 = new Car(1, "POTATIS", "Wolksvagen Fox", "Light Brown", false, "Medveten Varelse", 19226);

            Car c2 = new Car(2, "NCP360", "Porsche 911", "Orange", true, "Generic Name", 21);

            Car c3 = new Car(3, "NOP101", "Volvo XC90", "Green", true, "Någon Person", 57384);

            Car c4 = new Car(4, "UWM800", "Volvo XC90", "White", false, "Annan Människa", 573843544);

            myCars.Add(c0);
            myCars.Add(c1);
            myCars.Add(c2);
            myCars.Add(c3);
            myCars.Add(c4);

        }

        private void defaultFormControls()
        {
            pnlProps.Visible = false;
            btnSave.Enabled = false;
            cbxAvailable.Visible = false;
            btnEdit.Enabled = true;

            tbxPrp1.ReadOnly = true;
            tbxPrp2.ReadOnly = true;
            tbxPrp3.ReadOnly = true;
            tbxPrp4.ReadOnly = true;
            tbxPrp5.ReadOnly = true;
            tbxPrp5.Visible = true;
            tbxPrp6.ReadOnly = true;
            tbxPrp7.ReadOnly = true;

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            defaultFormControls();
            pnlProps.Visible = false;
            lbxCars.Enabled = true;
        }

        private void tbxPrp4_Click(object sender, EventArgs e)
        {
            if (editmode)
                tbxPrp4.Text = "";
        }


        private void tbxPrp6_Click(object sender, EventArgs e)
        {
            if (editmode)
                tbxPrp6.Text = "";
        }

        private void tbxPrp7_Click(object sender, EventArgs e)
        {
        }
    }
}
