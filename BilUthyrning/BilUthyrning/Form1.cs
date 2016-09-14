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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlProps.Visible = false;


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

            lbxProps.Items.Clear();

            lbxProps.Items.Add(c.returnSelectedProp("id"));
            lbxProps.Items.Add(c.returnSelectedProp("regnr"));
            lbxProps.Items.Add(c.returnSelectedProp("model"));
            lbxProps.Items.Add(c.returnSelectedProp("color"));
            lbxProps.Items.Add(c.returnSelectedProp("available"));
            lbxProps.Items.Add(c.returnSelectedProp("currentUser"));
            lbxProps.Items.Add(c.returnSelectedProp("mileage"));

        }

        private string fancystringformat(Car c, string propname)
        {
            //return c.propname.ToString();
            return "";

        }


        private void populateDemo()
        {

        //Car demo = new Car(ID, "REGNR", AVAIL, "MODELNAME", "COLOR", MILEAGE);
            Car c0 = new Car(0, "MLG420", "Volvo V70", "Black", false, "Köra Bil 100%", 19226);

            Car c1 = new Car(1, "POTATIS", "Wolksvagen Fox", "Light Brown", false, "Medveten Varelse", 19226);

            Car c2 = new Car(2, "NCP360", "Porsche 911", "Orange", true, "Generic Name", 21);

            Car c3 = new Car(3, "NOP101", "Volvo XC90", "Green", true, "Någon Person", 57384);

            Car c4 = new Car(3, "UWM800", "Volvo XC90", "White", false, "Annan Människa", 573843544);



            myCars.Add(c0);
            myCars.Add(c1);
            myCars.Add(c2);
            myCars.Add(c3);
            myCars.Add(c4);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlProps.Visible = false;
        }
    }
}
