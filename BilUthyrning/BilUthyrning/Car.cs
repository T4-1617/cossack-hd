using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilUthyrning
{
    class Car
    {
        public int id { get; set; } //id for internal handling
        public string regnumb { get; set; } //registration number, important
        public bool available { get; set; } //essential for proper functionality
        public string model { get; set; } //essential for proper displaying
        public string color { get; set; } //important in many cases
        public int mileage { get; set; } //important for service

        public string currentUser { get; set; } //a nice to have if you want your car back


        public override string ToString()
        {
            return string.Format("{0}, {1}", model, color); //returns handy strings to display in listbox
        }


        public void batchProperties(int newID, string newREGNUMB, bool newAVAILABLE, string newMODEL, string newCOLOR, int newMILEAGE)
        {
            id = newID;
            regnumb = newREGNUMB;
            available = newAVAILABLE;
            model = newMODEL;
            color = newCOLOR;
            mileage = newMILEAGE;
        }
    }
}
