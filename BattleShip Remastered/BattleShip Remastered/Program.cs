using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip_Remastered
{
    class Program
    {
        //declare common variables here

        static char waterchar = '~';
        static char shipchar = 'U';
        static bool use_debug = false;

        static char[,] GameMap = new char[7, 5]; //creates game field with chars for efficient management

        static void Main(string[] args)
        {
            //handles launch argument (debug)
            if (args.Length != 0)
            {
                if (args[0] == "-debug")
                {
                    Console.WriteLine("DEBUG MODE");
                    use_debug = true;
                }
            }

            //creating battleships
            Random r = new Random(); //creating random generator
            int random_amount_of_bs = r.Next(3, 6); //generating random value for the ships

            //filling the battlemap with water
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    GameMap[x, y] = waterchar;
                }
            }

            //creating ships
            for (int i = 0; i < random_amount_of_bs;)
            {
                int Xpos = r.Next(0, 6);
                int Ypos = r.Next(0, 4);
                if (check_ship_exists(Xpos, Ypos) != true) //Calls check_ship_exists if a cordinate is empty
                {
                    i++;
                    GameMap[Xpos, Ypos] = shipchar; //set ship as living
                }

            }

            drawmap(); //draw the map before the game begins

            int shots_fired = 0;


            //game loop, works until all ships are dead
            for (int number_of_living_bs = random_amount_of_bs; 0 < number_of_living_bs;) 
            {
                
                Console.WriteLine("Skriv koordinater i format \"A1\"");
                string input = Console.ReadLine();
                Console.Clear();

                if (input.Length == 2 && char.IsLetter(input[0]) && char.IsDigit(input[1])) //checks types of characters
                {
                    int coord_letter = Char.ToUpper(input[0]) - 64; //TSO! transforms character to alphabetical position
                    int coord_digit = int.Parse(input[1].ToString()); //transofrms second character in input to int via string
                    shots_fired++;

                    if (use_debug)
                        Console.WriteLine("Inskrivna koordinater i int : " + coord_letter.ToString() + " " + coord_digit.ToString());

                    if (coord_letter > 0 && coord_letter < 8 && coord_digit > 0 && coord_digit < 6)
                    {
                        if (check_ship_exists(coord_letter - 1, coord_digit - 1))
                        {
                            number_of_living_bs--;
                            GameMap[coord_letter - 1, coord_digit - 1] = 'X';
                            if (number_of_living_bs > 0)
                            {
                                Console.Beep(2000, 300);
                                Console.WriteLine("Du träffade ett skepp! Nu finns det " + number_of_living_bs + " skepp kvar!");
                                Console.Beep(3000, 500);
                            }
                            else //all ships are down
                            {
                                Console.WriteLine("");
                                Console.WriteLine(
                                    "Du vann efter "
                                    + shots_fired
                                    + " skott och sänkte "
                                    + random_amount_of_bs
                                    +" skepp!");

                                playmelody();

                            }

                        }
                        else //missed
                        {
                            Console.Beep(2000, 300); 
                            GameMap[coord_letter - 1, coord_digit - 1] = '.';
                            Console.WriteLine("Du missade! Det finns " + number_of_living_bs + " skepp kvar!");
                            Console.Beep(1000, 500);

                        }
                        Console.WriteLine("");
                        Console.WriteLine("Skott avfyrade: " + shots_fired);
                        drawmap();
                    }

                    else //out of range
                    {
                        Console.Beep(500, 500);
                        drawmap();
                        Console.WriteLine("Dina skott måste gå mellan A1 och G5 (inklusive)");
                        Console.Beep(500, 250);
                    }
                }
                else //improper input format
                {
                    Console.Beep(500, 500);
                    drawmap();
                    Console.WriteLine("Skriv in ordentliga koordinater, t.ex B3 (b3 går bra också)");
                    Console.Beep(500, 250);
                }


            }



            Console.ReadLine();


        }


        //functions

        static void drawmap()
        {
            Console.WriteLine(" ABCDEFG"); //adds alphabetical reference line
            for (int y = 0; y < 5; y++)
            {
                Console.Write((y+1).ToString()); //adds numerical reference line
                for (int x = 0; x < 7; x++)
                {
                    if (GameMap[x, y] == shipchar) //special case, handling differently depending on debug
                    {
                        switch (use_debug)
                        {
                            case true:
                                Console.Write(shipchar); //show ship as is
                                break;
                            case false:
                                Console.Write(waterchar); //shows ships as water
                                break;
                        }
                    }
                    else
                    { 
                    Console.Write(GameMap[x, y]); //it's not a ship, show as is
                    }

                }
                Console.WriteLine(); //skip to next line

            }



        }

        //util to check if a ship exists in the giving position, returns bool
        static bool check_ship_exists(int x, int y)
        {
            if (GameMap[x, y] == shipchar)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void playmelody()
        {
            //tones in Hz for usage in the sequence
            int a4 = 440*2;
            int b4 = 494*2;
            int c4 = 523*2;
            int d4 = 587*2;
            int e4 = 660*2;
            int f4 = 698*2;
            int g4 = 783*2;

            //sequence
            Console.Beep(f4, 400);
            Console.Beep(g4, 200);
            Console.Beep(f4, 200);

            Console.Beep(e4, 400);
            Console.Beep(c4, 400);

            Console.Beep(a4 / 1, 400);
            Console.Beep(g4 / 2, 200);
            Console.Beep(a4 / 1, 200);
            Console.Beep(b4 / 1, 800);


        }

    }
}
