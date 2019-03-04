using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    interface IPlayer
    {
        void AssignWeapon(string weapon);
        void Mission();
    }
}
