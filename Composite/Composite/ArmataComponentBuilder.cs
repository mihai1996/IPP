using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    abstract class ArmataComponentBuilder
    {
        abstract public ArmataComponent Build();
        abstract public ArmataComponentBuilder SetName(string name);
        abstract public ArmataComponentBuilder Add(ArmataComponent component);
    }
}
