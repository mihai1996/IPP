using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    class CounterStrike
    {
        // All player types and weopons (used by getRandPlayerType() 
        // and getRandWeapon() 
        private static readonly string[] playerType = { "Terrorist", "CounterTerrorist" };

        private static readonly string[] weapons = { "AK-47", "Maverick", "Gut Knife", "Desert Eagle" };

        static void Main(string[] args)
        {
            /* Assume that we have a total of 10 players 
            in the game. */
            for (int i = 0; i < 10; i++)
            {
                /* getPlayer() is called simply using the class 
                   name since the method is a static one */
                IPlayer p = PlayerFactory.GetPlayer(getRandPlayerType());

                /* Assign a weapon chosen randomly uniformly 
                   from the weapon array  */
                p.AssignWeapon(getRandWeapon());

                // Send this player on a mission 
                p.Mission();
            }
            Console.ReadLine();
        }

        // Utility methods to get a random player type and 
        // weapon 
        public static string getRandPlayerType()
        {
            Random r = new Random();

            // Will return an integer between [0,2) 
            int randInt = r.Next(0, 2);

            // return the player stored at index 'randInt' 
            return playerType[randInt];
        }
        public static string getRandWeapon()
        {
            Random r = new Random();

            // Will return an integer between [0,4) 
            int randInt = r.Next(0, 4);

            // Return the weapon stored at index 'randInt' 
            return weapons[randInt];
        }
    }
}
