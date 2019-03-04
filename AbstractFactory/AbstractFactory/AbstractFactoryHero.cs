using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    abstract class AbstractFactoryHeroes
    {
        public abstract AbstractSamurai CreateSam();
        public abstract AbstractMag CreateMagician();
        public abstract AbstractAsassin CreateAsassin();
    }
}
