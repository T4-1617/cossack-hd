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
            lbxProps.Visible = false;
            populateDemo();

            foreach (Car item in myCars)
            {
                lbxCars.Items.Add(item);
            }

        }


        private void populateDemo()
        {

        //Car demo = new Car(ID, "REGNR", AVAIL, "MODELNAME", "COLOR", MILEAGE);
            Car c0 = new Car(0, "MLG420", true, "Volvo V70", "Black", 69);
            Car c1 = new Car(1, "POTATIS", false, "Wolksvagen Fox", "Light Brown", 9000);
            Car c2 = new Car(2, "NCP360", true, "Porsche 911", "Orange", 21);
            Car c3 = new Car(3, "NOP101", true, "Volvo XC90", "Green", 57384);
            Car c4 = new Car(4, "UWM800", false, "Volvo XC90", "Green", 3544);


            myCars.Add(c0);
            myCars.Add(c1);
            myCars.Add(c2);
            myCars.Add(c3);
            myCars.Add(c4);

        }
    }
}
