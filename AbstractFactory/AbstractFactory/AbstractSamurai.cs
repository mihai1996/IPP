using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    abstract class AbstractSamurai
    {
        public int Heart { get; set; }
        public int Mana { get; set; }
        public int Armor { get; set; }

        public AbstractSamurai(int heart, int mana, int armor)
        {
            this.Heart = heart;
            this.Mana = mana;
            this.Armor = armor;
        }

        public abstract void DescriptionHero();
    }
}
