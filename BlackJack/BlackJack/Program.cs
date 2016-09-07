using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KortSpel
{
    class Program
    {


        static bool[,] cardsnumbs = new bool[8, 13]; //used for card status


        static void Main(string[] args)
        {

            Console.WriteLine("TRYCK ENTER FÖR ATT BÖRJA");

            Console.ReadLine();

            generateCardArray();

            for (int type = 0; type < 8; type++)
            {
                for (int number = 0; number < 13; number++)
                {
                    printcardname(type, number);
                    Console.WriteLine();
                }
            }

            Console.ReadLine();


        }


        static void generateCardArray()
        {
            for (int t = 0; t < 8; t++) //count types
            {
                for (int n = 0; n < 13; n++) //count cards inside a type
                {
                    cardsnumbs[t, n] = false; //set card as not given
                }
            }
        }


        //prints name of a card in one line
        static void printcardname(int type, int numb)
        {

            int localtype = type; //used in the switch below

            if (localtype > 3)
            {
                localtype -= 4;
            }

            switch (localtype)
            {
                case 0:
                    Console.Write("Clubs ");
                    break;
                case 1:
                    Console.Write("Spades ");
                    break;
                case 2:
                    Console.Write("Diamonds ");
                    break;
                case 3:
                    Console.Write("Hearts ");
                    break;

            }
            switch (numb)
            {
                case 0:
                    Console.Write("Ace");
                    break;
                case 10:
                    Console.Write("Joker");
                    break;
                case 11:
                    Console.Write("Queen");
                    break;
                case 12:
                    Console.Write("King");
                    break;
                default:
                    if (numb > 0 && numb < 11)
                    {
                        Console.Write((numb + 1).ToString());
                    }
                    break;
            }




        }
    }
}