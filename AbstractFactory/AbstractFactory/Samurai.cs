using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Samurai : AbstractSamurai
    {
        public Samurai(int heart, int mana, int armor) : base(heart, mana, armor)
        {

        }
        public override void DescriptionHero()
        {
            Console.WriteLine("Samurai:");
            Console.WriteLine("Heart: " + Heart);
            Console.WriteLine("Mana: " + Mana);
            Console.WriteLine("Armor: " + Armor);
        }
    }
}
