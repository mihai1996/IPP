using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class CompositePluton : ArmataComponent
    {
        private List<ArmataComponent> militar = new List<ArmataComponent>();

        public CompositePluton()
        {

        }

        public override void Add(ArmataComponent arm)
        {
            militar.Add(arm);
        }

        public override void Remove(ArmataComponent arm)
        {
            militar.Remove(arm);
        }

        public override void Print()
        {
            Console.WriteLine(name);

            foreach(ArmataComponent arm in militar)
            {
                arm.Print();
            }
        }
    }
}
