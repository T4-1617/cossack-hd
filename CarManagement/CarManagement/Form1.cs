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

        public Car selectedCar;

        public bool viewcars = false;
        public bool addcars = false;
        public bool showmessage = false;
        public bool carSelected = false;
        public bool returnCar = false;
        public int availableCars;


        public Form1()
        {
            InitializeComponent();
            cars = new System.Collections.ArrayList();
            populateDemo();
            restoreGUI();
            
        }

        private void tbxVisible(bool v)
        {
            tbxColor.Visible = v;
            tbxMake.Visible = v;
            tbxModel.Visible = v;
            tbxRN.Visible = v;
        }

        private void restoreGUI()
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;

            listBox1.Items.Clear();
            listBox1.Visible = false;
            lblMsg.Visible = false;
            panel1.Visible = false;
            tbxVisible(false);

            availableCars = 0;

            foreach (Car x in cars)
            {
                if (x.available)
                {
                    availableCars++;
                }
            }

            lblCarCount.Text = String.Format("There are {0} cars available", availableCars.ToString());
        }

        private void populateDemo()
        {
            cars.Add(new Car ("MLG420", "Volvo", "XC90", "Red", true));
            cars.Add(new Car("POTATIS", "Porsche", "911", "White", false));
            cars.Add(new Car("NCS360", "Volvo", "V70", "Black", true));
            cars.Add(new Car("UWM800", "Wolksvagen", "Gold", "Blue", true));
            cars.Add(new Car("PWR999", "TESTA", "MODEL X", "White", true));
        }

        private void btnViewAvailable_Click(object sender, EventArgs e)
        {
            btnAction.Enabled = true;
            btnAction.Location = (new Point(200, 111));
            viewcars = true;
            addcars = false;
            showmessage = false;
            showListOfCars(true);

        }

        private void showListOfCars(bool avail)
        {
            restoreGUI();
            panel1.Visible = true;
            listBox1.Visible = true;

            listBox1.Items.Clear();
            foreach (Car x in cars)
            {
                if (x.available == avail)
                { 
                    listBox1.Items.Add(x);
                }
            }


            listBox1.Visible = true;

            btnAction.Text = "Book the car";
        }

        private void btnAddCars_Click(object sender, EventArgs e)
        {
            addcars = true;
            viewcars = false;
            returnCar = false;
            restoreGUI();
            listBox1.Items.Clear();
            panel1.Visible = true;
            listBox1.Visible = false;
            tbxVisible(true);
            btnAction.Text = "Add a car";

            btnAction.Location = (new Point(73, 111));

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCar = (Car)listBox1.SelectedItem;
            carSelected = true;
            btnAction.Enabled = true;
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (viewcars && carSelected)
            {
                selectedCar.available = false;
                lblMsg.Visible = true;
                lblMsg.Text = "Thank you for your booking!";
            }


            if (addcars)
            {
                cars.Add(new Car(tbxRN.Text, tbxMake.Text, tbxModel.Text, tbxColor.Text, true));
                
                lblMsg.Text = "Car has been added!";

                tbxRN.Text = string.Empty;
                tbxMake.Text = string.Empty;
                tbxModel.Text = string.Empty;
                tbxColor.Text = string.Empty;
            }


            if (returnCar)
            {
                selectedCar.available = true;
                lblMsg.Text = "Thank you for your business!";

            }


            restoreGUI();
            //panel1.Visible = true;
            lblMsg.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            restoreGUI();
            showListOfCars(false);
            btnAction.Location = (new Point(200, 111));
            addcars = false;
            viewcars = false;
            panel1.Visible = true;
            listBox1.Visible = true;
            btnAction.Visible = true;
            returnCar = true;
            btnAction.Text = "Return car";
        }
    }
}
