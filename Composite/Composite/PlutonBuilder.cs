using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class PlutonBuilder : ArmataComponentBuilder
    {
        private ArmataComponent pluton = new CompositePluton();

        public override ArmataComponent Build()
        {
            return pluton;
        }

        public override ArmataComponentBuilder SetName(string name)
        {
            pluton.name = name;
            return this;
        }

        public override ArmataComponentBuilder Add(ArmataComponent component)
        {
            pluton.Add(component);
            return this;
        }
    }
}
