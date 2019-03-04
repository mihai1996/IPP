using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Soldat : ArmataComponent
    {
        public Soldat()
        {

        }

        public override void Add(ArmataComponent arm)
        {
            throw new NotImplementedException();
        }
        public override void Remove(ArmataComponent arm)
        {
            throw new NotImplementedException();
        }

        public override void Print()
        {
            Console.WriteLine(name);
        }
    }
}
