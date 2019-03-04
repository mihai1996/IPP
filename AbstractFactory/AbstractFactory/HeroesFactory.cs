using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class HeroesFactory : AbstractFactoryHeroes
    {
        public override AbstractSamurai CreateSam()
        {
            return new Samurai(1932, 879, 16);
        }

        public override AbstractMag CreateMagician()
        {
            return new Magician(1784, 1430, 9);
        }

        public override AbstractAsassin CreateAsassin()
        {
            return new Asassin(2346, 1206, 10);
        }
    }
}
