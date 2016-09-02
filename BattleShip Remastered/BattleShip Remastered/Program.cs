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

        static char[,] GameMap = new char[7, 5]; //creates game field with chars for efficient management

        static void Main(string[] args)
        {
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

            for (int i = 0; i < random_amount_of_bs; i++)
            {
                int Xpos = r.Next(0, 6);
                int Ypos = r.Next(0, 4);
                if (check_ship_exists(Xpos, Ypos) != true) //Calls check_ship_exists if a cordinate is empty
                {
                    GameMap[Xpos, Ypos] = shipchar; //set ship as living
                }

            }

            drawmap();

            //create random amount of ships

            //start game loop until ships are 0

            //1. display field

            //receive coordinates

            //check coordinates

            //there are living ships -> goto 1

            //all ships are down -> exit loop, end game screen


            Console.ReadLine();


        }


        //functions

        static void drawmap()
        {
            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    Console.Write(GameMap[x, y]);
                    
                }
            Console.WriteLine();
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

    }
}
