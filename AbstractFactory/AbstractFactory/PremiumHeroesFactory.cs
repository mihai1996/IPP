using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class PremiumFactoryHeroes : AbstractFactoryHeroes
    {
        public override AbstractSamurai CreateSam()
        {
            return new Samurai(2400, 1000, 18);
        }

        public override AbstractMag CreateMagician()
        {
            return new Magician(1900, 1730, 11);
        }

        public override AbstractAsassin CreateAsassin()
        {
            return new Asassin(3000, 1706, 15);
        }
    }
}
