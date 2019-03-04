using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class TortDecorator : TortComponent
    {
        protected TortComponent tort;
        
        public TortDecorator(string n, TortComponent tort) : base(n)
        {
            this.tort = tort;
        }
    }
}
