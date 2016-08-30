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
            string first_name = "";
            string last_name = "";

            Console.WriteLine("Vad är ditt förnamn?");
            first_name = Console.ReadLine();

            while (first_name == "")
            {
                Console.WriteLine("Du har inte matat in någon text. Vänligen, skriv ditt namn");
                first_name = Console.ReadLine();
            }


            Console.WriteLine("Tack! Vad heter du i efternamn?");
            last_name = Console.ReadLine();

            Console.WriteLine("Hej, " + first_name + "!");

            Console.ReadKey();
        }
    }
}
