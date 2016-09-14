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
            
        }


        private void populateDemo()
        {
            Car c = new Car { id = 0, regnumb="MLG420", available = true, model = "Volvo V70", color = "Black", currentUser = "None", mileage=69 };
            myCars.Add(c);

            c.batchProperties(1, "POTATIS", false, "Wolksvagen Fox", "´Light Brown", 9000);
            myCars.Add(c);

            c.batchProperties(2, "NCP360", true, "Porsche 911", "Orange", 21);
            myCars.Add(c);

            c.batchProperties(3, "NOP101", true, "Volvo XC90", "Green", 57384);
            myCars.Add(c);

            c.batchProperties(4, "UWM800", false, "Volvo XC90", "Green", 3544);
            myCars.Add(c);

        }
    }
}
