using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class HDD
    {
        public int memory;
        public string producer;

        public HDD(int memory, string producer)
        {
            this.producer = producer;
            this.memory = memory;
        }

        public void DetailsHdd()
        {
            Console.WriteLine("Memory HDD:" + memory);
            Console.WriteLine("Producer:" + producer);
        }
    }
}
