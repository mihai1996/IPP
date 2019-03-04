using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    // Claass used to get a playeer using HashMap (Returns 
    // an existing player if a player of given type exists. 
    // Else creates a new player and returns it. 

    class PlayerFactory
    {
        /* HashMap stores the reference to the object 
       of Terrorist(TS) or CounterTerrorist(CT).  */

        private static readonly Dictionary<string, IPlayer> key = new Dictionary<string, IPlayer>();  
        
        // method get a player
        public static IPlayer GetPlayer(string type)
        {
            IPlayer p = null;

            // Daca un obiect pentru TS sau CT a fost deja creat pur si simplu returneaza referinta

            if (key.ContainsKey(type))
            {
                p = key[type];
            }
            else
            {
                //creaza un obiect ts/ct
                switch (type)
                {
                    case "Terrorist":
                        Console.WriteLine("Terrorist Created");
                        p = new Terrorist();
                        break;
                    case "CounterTerrorist":
                        Console.WriteLine("CounterTerrorist Created");
                        p = new CounterTerrorist();
                        break;
                    default:
                        Console.WriteLine("ERROR CODE");
                        break;
                }
                // odata creat intrducetil in dictionar key
                key[type] = p;
            }
            return p;
        }
    }
}
