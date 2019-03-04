using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class TortComponent
    {
        public string Name { get; protected set;}

        public TortComponent(string n)
        {
            this.Name = n;
        }
        public abstract int GetCost();
    }
}
