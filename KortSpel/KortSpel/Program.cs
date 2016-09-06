using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KortSpel
{
    class Program
    {

        static string[,] cardsnames = new string[4, 13]; //used for card names
        static bool[,] cardsnumbs = new bool[4, 13]; //used for card status
        static Random randomgenerator = new Random();
        static int points = 0;

        static void Main(string[] args)
        {

            generatecardsbytype();

            for (int i = 52; i > 0;)
            {
                Console.WriteLine();
                Console.WriteLine("Tryck Enter för att få ett kort");

                if (Console.ReadKey().Key.Equals(ConsoleKey.Enter))
                {
                    i--;
                    Console.Write(String.Format("Ditt kort nummer {0} är ", (52 - i)));
                    points = points + verifyandgivecard(); //prints card's name, adds points
                    Console.Write(String.Format(", du har {0} poäng och det finns {1} kort kvar. ", points, (i)));
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Det är slut på kort!");

            Console.ReadLine();



        }


        static void generatecardsstatus()
        {
            for (int t = 0; t < 4; t++) //count types
            {
                for (int n = 0; n < 13; n++) //count cards inside a type
                {
                    cardsnumbs[t, n] = false;
                }
            }
        }

        static void generatecardsbytype()
        {
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


        }


        static void generatecardnames(int t, int n, string type)
        {
            if (n > 0 && n < 11)
            {
                cardsnames[t, n] = type + (n + 1);
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


        static int verifyandgivecard() //recursive function 
        {
            int randomtype = randomgenerator.Next(0, 4);
            int randomnumber = randomgenerator.Next(0, 13);

            if (cardsnumbs[randomtype, randomnumber] == true) //if the card is already given
            {
                return verifyandgivecard(); //find another
            }
            else
            {
                Console.Write(cardsnames[randomtype, randomnumber]); //or give new card and shot it
                cardsnumbs[randomtype, randomnumber] = true;
                return (randomnumber + 1);

            }
        }

        static void printallcards()
        {
            for (int t = 0; t < 4; t++)
            {
                for (int n = 0; n < 13; n++)
                {
                    Console.Write(cardsnames[t, n]);
                }

            }
        }


    }
}