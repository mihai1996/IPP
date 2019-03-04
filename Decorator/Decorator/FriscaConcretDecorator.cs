using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class FriscaConcretDecorator : TortDecorator
    {
        public FriscaConcretDecorator(TortComponent t) : base(t.Name + ", cu firsca", t)
        {

        }

        public override int GetCost()
        {
            return tort.GetCost() + 20;
        }
    }
}
