using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    // teror treb sa aiba arme si misiuni
    class Terrorist : IPlayer
    {
        //intrinsic attribute
        private readonly string Task;

        // extrinsic attribute
        private string weapon;

        public Terrorist()
        {
            Task = "PLANT A BOMB";
        }

        public void AssignWeapon(string weapon)
        {
            // Alocati o arma 
            this.weapon = weapon;
        }

        public void Mission()
        {
            // Lucru pe misiune
            Console.WriteLine("Terorist cu arme " + weapon + "|" + "Task is " + Task);
        }
    }
}
