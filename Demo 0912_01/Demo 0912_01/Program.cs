using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_0912_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car(); //skapar objekt enligt klassmallen

            c.Color = "Red";

            Console.WriteLine(c.Color);



            Car d;

            d = c;

            d.Color = "Blue";

            Console.WriteLine("Bilens färg är " + c.Color);
            Console.WriteLine("Bilens färg är " + d.Color);


            //value type

            int i = 10;
            int j;
            j = i;
            j = 20;

            Console.WriteLine(String.Format("i={0} och j={1}", i,j));


            Console.ReadLine();
        }
    }

    public class Car
    {
        public string RegistrationNumber { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }
    }
}
