using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KortSpel
{
    class Program
    {

        static bool debugmode = true;
        static string[,] cardsnames = new string[4, 13]; //used for card names
        bool[,] cardsnumbs = new bool[3, 13]; //used for card status

        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                if (args[0] == "-debug")

                    debugmode = true;
            }

            Random r = new Random();


            

            for (int t = 0; t < 4; t++) //count types
            {
                for (int n = 0; n < 13; n++) //count cards inside a type
                {
                    switch (t)
                    {
                        case 0:
                            generatecardnames(t, n, "Clubs ");
                            break;
                        case 1:
                            generatecardnames(t, n, "Spades ");
                            break;
                        case 2:
                            generatecardnames(t, n, "Diamonds ");
                            break;
                        case 3:
                            generatecardnames(t, n, "Hearts ");
                            break;

                    }
                }



            }




            for (int t = 0; t < 4; t++)
            {
                for (int n = 0; n < 13; n++)
                {
                    Console.WriteLine(cardsnames[t, n]);
                }

                
            }

            Console.ReadLine();


        }

        static void generatecardnames(int t, int n, string type)
        {
            if (n > 0 && n < 11)
            {
                cardsnames[t, n] = type + (n+1);
            }
            switch (n)
            {
                case 0:
                    cardsnames[t, n] = type + "Ace";
                    break;
                case 10:
                    cardsnames[t, n] = type + "Joker";
                    break;
                case 11:
                    cardsnames[t, n] = type + "Queen";
                    break;
                case 12:
                    cardsnames[t, n] = type + "King";
                    break;
            }

        }


    }
}