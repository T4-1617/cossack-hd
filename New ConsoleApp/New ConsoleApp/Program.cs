using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad är ditt förnamn?");
            string first_name = Console.ReadLine();
            Console.WriteLine("Tack! Vad heter du i efternamn?");
            string last_name = Console.ReadLine();

            Console.WriteLine("Hej, " + first_name + "!");

            Console.ReadKey();
        }
    }
}
