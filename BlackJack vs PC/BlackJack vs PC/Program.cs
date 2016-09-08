using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_vs_PC
{
    class Program
    {

        static Random randomgenerator = new Random();
        static int playerscore;
        static int pcscore;
        static int cardsleft = 207;
        static bool[,] cardBools = new bool[16, 13]; //used for card status
        static bool keepPlaying = true;

        static void Main(string[] args)
        {


            resetCardArray();

            while (keepPlaying)
            {
                Console.Clear();
                if (cardsleft > 0)
                {

                    for (playerscore = 0; playerscore < 21;)
                    {
                        if (playerinput("Tryck J för att få ett kort; tryck N för att avsluta."))
                        {
                            Console.Clear();
                            int cardscore = giveCard();

                            //debug
                            Console.WriteLine();
                            Console.WriteLine("Cards left: " + cardsleft);

                            if (cardscore > 9) //card is 10, joker, king or queen
                            {
                                cardscore = 10; //all give 10 points
                            }
                            if (cardscore == 1 && (21 - playerscore) > 10)
                            {
                                cardscore = 10;
                            }
                            playerscore += cardscore;
                            cardsleft--;
                            Console.WriteLine();
                            Console.WriteLine(string.Format("Du har {0} poäng.", playerscore.ToString()));
                        }
                        else
                        {
                            keepPlaying = false;
                            Console.Clear();
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Det är slut på kort! Tryck Enter för att avsluta.");
                    Console.ReadLine();
                    keepPlaying = false;
                }
                if (playerscore == -1)
                {
                    Console.WriteLine("Du vann! Tryck Enter för att avsluta programmet.");
                    keepPlaying = false;
                    Console.ReadLine();
                }
                else if (playerscore > 21)
                {
                    Console.WriteLine(String.Format("Du fick {0} för många påäng.", (playerscore - 21)));
                }
                if (cardsleft > 0 && keepPlaying)
                {
                    //Console.Clear();
                    keepPlaying = playerinput("Tryck J för att börja om!");
                }
            }

        }
    







        static void resetCardArray()
        {
            for (int t = 0; t < 16; t++) //count types
            {
                for (int n = 0; n < 13; n++) //count cards inside a type
                {
                    cardBools[t, n] = false; //set card as not given
                }
            }
        }


        static int giveCard()
        {
            int randomtype = 0;
            int randomnumber = 0;
            while (true)
            {
                randomtype = randomgenerator.Next(0, 16);
                randomnumber = randomgenerator.Next(0, 13);

                if (cardBools[randomtype, randomnumber] == false) //if finds an unused card
                {
                    break;
                }
            }
            cardBools[randomtype, randomnumber] = true; //sets the card as used
            printcardname(randomtype, randomnumber); //calls print card name method for the given card
            return (randomnumber + 1); //return score for the card
        }

        static bool playerinput(string message)
        {
            Console.WriteLine(message);
            ConsoleKeyInfo key = Console.ReadKey();
            char keychar = key.KeyChar;

            switch (keychar)
            {
                case 'j':
                    return true;
                case 'n':
                    return false;
                default:
                    return playerinput("message");
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