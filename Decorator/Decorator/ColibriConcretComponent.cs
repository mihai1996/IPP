using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class ColibriConcretComponent : TortComponent
    {
        public ColibriConcretComponent() : base("Tort colibri")
        {

        }

        public override int GetCost()
        {
            return 100;
        }
    }
}
