using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class CiocolataConcretDecorator : TortDecorator
    {
        public CiocolataConcretDecorator(TortComponent t) : base(t.Name + ", cu ciocolata", t)
        {

        }

        public override int GetCost()
        {
            return tort.GetCost() + 70;
        }
    }
}
