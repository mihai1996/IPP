using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    abstract class ArmataComponent
    {
        public string name;

        public ArmataComponent()
        {
        }

        public abstract void Add(ArmataComponent arm);
        public abstract void Remove(ArmataComponent arm);
        public abstract void Print();
    }
}
