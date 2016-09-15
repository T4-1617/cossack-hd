using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_V2
{
    public partial class Form1 : Form
    {

        System.Collections.ArrayList people;

        public Form1()
        {
            InitializeComponent();

            people = new System.Collections.ArrayList();
            radioButton1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) //customer
                people.Add(new Customer() { firstName = textBox1.Text, lastName = textBox2.Text });
            else
                people.Add(new Employee() { firstName = textBox1.Text, lastName = textBox2.Text });


            updateListBoxes();

            textBox1.Focus();
                    
        }

        private void updateListBoxes()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            for (int i = 0; i < people.Count; i++)
            {
                if (people[i].GetType().Name.ToString() == "Customer")
                    listBox1.Items.Add(people[i]);
                if (people[i].GetType().Name.ToString() == "Employee")
                    listBox2.Items.Add(people[i]);
            }
        }
    }
}
