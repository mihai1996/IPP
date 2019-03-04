using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class FranzelutaConcretComponent : TortComponent
    {
        public FranzelutaConcretComponent() : base("Franzeluta tort")
        {

        }

        public override int GetCost()
        {
            return 70;
        }
    }
}
