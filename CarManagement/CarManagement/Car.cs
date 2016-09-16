using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagement
{
    public class Car
    {
        public string regNumb;
        public string make;
        public string model;
        public string color;
        public bool available;



        public Car(string newRegNumb, string newMake, string newModel, string newColor, bool newAvailable)
        {
            regNumb = newRegNumb;
            make = newMake;
            model = newModel;
            color = newColor;
            available = newAvailable;
        }


        public void carRent(bool rent)
        {
            if (rent)
                available = false;
            else
                available = true;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2}", make, model, color);
        }
    }



}
