using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class NuciConcretDecorator : TortDecorator
    {
        public NuciConcretDecorator(TortComponent t) : base(t.Name + ", cu nuci", t)
        {

        }

        public override int GetCost()
        {
            return tort.GetCost() + 50;
        }
    }
}
