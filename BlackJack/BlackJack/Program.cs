using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KortSpel
{
    class Program
    {

        static Random randomgenerator = new Random();
        static int score;
        static bool[,] cardBools = new bool[8, 13]; //used for card status

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("TRYCK ENTER FÖR ATT BÖRJA");


                resetCardArray();

                for (score = 0; score < 21;)
                {
                    Console.ReadLine();

                    score += giveCard();
                    Console.WriteLine();
                    Console.WriteLine(score.ToString());
                }
                if (score == 21)
                {
                    Console.WriteLine("Du vann! Tryck J om du vill spela igen. Tryck N för att avsluta programmet.");
                }
                else
                {
                    Console.WriteLine(String.Format("Du fick {0} för många påäng. Tryck J om du vill spela igen. Tryck N för att avsluta programmet.", (score - 21)));
                }

                Console.ReadLine();

            }
        }


        static void resetCardArray()
        {
            for (int t = 0; t < 8; t++) //count types
            {
                for (int n = 0; n < 13; n++) //count cards inside a type
                {
                    cardBools[t, n] = false; //set card as not given
                }
            }
        }


        static int giveCard()
        {
            int randomtype = randomgenerator.Next(0, 8);
            int randomnumber = randomgenerator.Next(0, 13);

            if (cardBools[randomtype, randomnumber] == true)
            {
                return giveCard();
            }
            else
            {
                cardBools[randomtype, randomnumber] = true;
                printcardname(randomtype, randomnumber);
                return (randomnumber + 1);
            }

        }


        //prints name of a card in one line
        static void printcardname(int type, int numb)
        {

            int localtype = type; //used in the switch below

            if (localtype > 3) //if the type has to be repeated
            {
                localtype -= 4; //subtract by 4
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