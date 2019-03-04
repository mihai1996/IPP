using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class SoldatBuilder : ArmataComponentBuilder
    {
        private ArmataComponent soldat = new Soldat();

        public override ArmataComponent Build()
        {
            return soldat;
        }

        public override ArmataComponentBuilder SetName(string name)
        {
            soldat.name = name;
            return this;
        }

        public override ArmataComponentBuilder Add(ArmataComponent component)
        {
            Console.WriteLine("Soldatul este frunza");
            return this;
        }
    }
}
