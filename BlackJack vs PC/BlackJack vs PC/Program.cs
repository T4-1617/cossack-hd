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
        static bool pcsturn = true;
        static int playerpoints = 0; //points received when winning turns
        static int pcpoints = 0;
        static int playerscore; //score is a variable for the current set of obtained cards
        static int pcscore;
        static int types = 16;
        static int cardsleft = (types * 13) - 1;
        static bool[,] cardBools = new bool[types, 13]; //used for card status
        static bool keepPlaying = true;

        static void Main(string[] args)
        {


            resetCardArray();

            while (keepPlaying)
            {
                Console.Clear();

                //
                //MAIN LOGICS
                //
                while (pcscore < 21 && playerscore < 21 && keepPlaying)
                {
                    
                    //PC's turn
                    if (pcsturn)
                    {
                        Console.Clear();
                        pcscore += giveCard(false, false);
                        Console.WriteLine();
                        Console.WriteLine(String.Format("Datorn har {0} kortpoäng! Du har {1} kortpoäng.", pcscore, playerscore));
                        if (pcscore > 20 || cardsleft == 0)
                            break;



                    }


                    //USER's turn
                    if (keepPlaying && playerinput("Tryck J om du vill dra ett kort, annars tryck N och datorn drar sitt kort."))
                    {
                        pcsturn = true;
                        Console.Clear();
                        playerscore += giveCard(true, false);

                        if (playerscore > 21 || cardsleft == 0)
                            break;

                        Console.WriteLine();
                        playerinput((String.Format("Du har {0} kortpoäng! Datorn ligger på {1}. Tryck J för att fortsätta.", playerscore, pcscore)));
                    }
                    else
                    {
                        Console.Clear();
                        pcscore += giveCard(false, true);
                        pcsturn = false;
                        
                        if (pcscore > 20)
                            keepPlaying = false;
                        Console.WriteLine();
                        Console.WriteLine(String.Format("Datorn har {0} kortpoäng!", pcscore));
                    }


                }

                Console.Clear();

                if (pcscore > 21)
                {
                    pcpoints--;
                    Console.WriteLine("Datorn har spruckit!");
                }

                if (playerscore > 21)
                {
                    playerpoints--;
                    Console.WriteLine("Du har spruckit!");
                }

                if (pcscore == 21)
                {
                    pcpoints += 3;
                    playerpoints--;
                    Console.WriteLine("Datorn vann!");
                }
                if (playerscore == 21)
                {
                    playerpoints += 3;
                    pcpoints--;
                    Console.WriteLine("Du vann!");
                }

                Console.WriteLine(String.Format("Datorn fick {0} kortpoäng och du fick {1} kortpoäng.", pcscore, playerscore));
                Console.WriteLine(String.Format("Datorns vinstpoäng är {0} och dina vinstpoäng är {1}", pcpoints, playerpoints));
                //
                //MANAGING CARD AVAILABILITY
                //
                if (cardsleft > 0)
                {
                    //Console.Clear();
                    pcscore = 0;
                    playerscore = 0;
                    if (playerinput("Tryck J för att börja om! Tryck N för att avsluta.") == false)
                        break;
                }

                if (cardsleft < 17)
                {
                    //Console.Clear();
                    resetCardArray();
                    cardsleft = (types * 13) - 1;
                    pcscore = 0;
                    playerscore = 0;
                    Console.WriteLine("Korten har lämnats tillbaka in och blandats om! Tryck Enter för att fortsätta.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }

        }





        static int giveCard(bool user, bool cheat)
        {
            int attempts = 0;

            //normal situation
            int lowestdesired = 0;
            int highestdesired = 13;

            if (cheat) //PC can chose a better card
            {
                highestdesired = 21 - pcscore;
                if (highestdesired > 13)
                    highestdesired = 13;               

                if (playerscore > 10)
                    lowestdesired = 9;
            }

            int score;
            if (user)
                score = playerscore;
            else
                score = pcscore;

            int randomtype = 0;
            int randomnumber = 0;
            while (true)
            {
                randomtype = randomgenerator.Next(0, types);
                randomnumber = randomgenerator.Next(0, highestdesired);

                if (cardBools[randomtype, randomnumber] == false) //if finds an unused card
                {
                    cardsleft--;
                    break;
                }
                //else
                    //Console.WriteLine("Dålig slump, slumpar på nytt.");

                attempts++;

                if (attempts > 10)
                {
                    attempts = 0;
                    highestdesired++;
                    lowestdesired--;
                    if (highestdesired > 10)
                        highestdesired = 10;
                    if (lowestdesired < 0)
                        lowestdesired = 0;
                }
                
            }
            cardBools[randomtype, randomnumber] = true; //sets the card as used
            printcardname(user, randomtype, randomnumber); //calls print card name method for the given card


            //ACE and 10+ manager
            if (randomnumber > 9) //card is 10, joker, king or queen
            {
                return 10; //all give 10 points
            }
            if (randomnumber == 0 && (21 - score) > 10)
            {
                return 10;
            }

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


        static void resetCardArray()
        {
            for (int t = 0; t < types; t++) //count types
            {
                for (int n = 0; n < 13; n++) //count cards inside a type
                {
                    cardBools[t, n] = false; //set card as not given
                }
            }
        }

        //prints name of a card in one line
        static void printcardname(bool user, int type, int numb)
        {

            int localtype = type; //used in the switch below

            int localtypefactor = localtype / 4;

            if (localtype > 3) //if the type has to be repeated
            {
                localtype -= 4 * localtypefactor; //subtract by 4
            }


            if (user)
                Console.Write("Du fick ett kort som är: ");
            else
                Console.Write("Datorn drog ett kort som är: ");


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