using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    class CounterTerrorist : IPlayer
    {
        //intrinsic attribute
        private readonly string Task;

        // extrinsic attribute
        private string weapon;

        public CounterTerrorist()
        {
            Task = "DIFFUSE BOMB";
        }

        public void AssignWeapon(string weapon)
        {
            // Alocati o arma 
            this.weapon = weapon;
        }

        public void Mission()
        {
            // Lucru pe misiune
            Console.WriteLine("ContraTerorist cu arme " + weapon + "|" + "Task is " + Task);
        }
    }
}
