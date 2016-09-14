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
        public string currentUser { get; set; } //a nice to have if you want your car back
        public int mileage { get; set; } //important for service


        public override string ToString()
        {
            return string.Format("{0}, {1}", model, color); //returns handy strings to display in listbox
        }


        public Car(int newID, string newREGNUMB, string newMODEL, string newCOLOR, bool newAVAILABLE, string newCurrentUser, int newMILEAGE)
        {
            id = newID;
            regnumb = newREGNUMB;
            model = newMODEL;
            color = newCOLOR;
            available = newAVAILABLE;
            currentUser = newCurrentUser;
            mileage = newMILEAGE;
        }

        public void updateCar(int newID, string newREGNUMB, string newMODEL, string newCOLOR, bool newAVAILABLE, string newCurrentUser, int newMILEAGE)
        {
            id = newID;
            regnumb = newREGNUMB;          
            model = newMODEL;
            color = newCOLOR;
            available = newAVAILABLE;
            currentUser = newCurrentUser;
            mileage = newMILEAGE;
        }


        public string returnSelectedProp(string propname)
        {
            //list of available propnames below!

            //lbxProps.Items.Add(c.returnSelectedProp("id"));
            //lbxProps.Items.Add(c.returnSelectedProp("regnr"));
            //lbxProps.Items.Add(c.returnSelectedProp("model"));
            //lbxProps.Items.Add(c.returnSelectedProp("color"));
            //lbxProps.Items.Add(c.returnSelectedProp("available"));
            //lbxProps.Items.Add(c.returnSelectedProp("currentUser"));
            //lbxProps.Items.Add(c.returnSelectedProp("mileage"));


            switch (propname)
            {
                case "id":
                    return string.Format("ID: {0}", id.ToString());

                case "regnr":
                    return string.Format("Registration number: {0}", regnumb);

                case "model":
                    return string.Format("Model: {0}", model);

                case "available":
                    if (available)
                        return "Status: Available";
                    else
                        return "Status: Not available";

                case "currentUser":
                    return string.Format("Current user is: {0}", currentUser);


                case "color":
                    return string.Format("Color: {0}", color);


                case "mileage":
                    return string.Format("Mileage: {0} km", mileage.ToString());


                default:
                    return "Invalid propname argument!!11";


            }


        }


    }
}
