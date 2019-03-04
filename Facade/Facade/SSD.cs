using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class SSD
    {
        public int memory;
        public string producer;

        public SSD(int memory, string producer)
        {
            this.producer = producer;
            this.memory = memory;
        }

        public void DetailsSsd()
        {
            Console.WriteLine("Memory Ssd:" + memory);
            Console.WriteLine("Producer:" + producer);
        }
    }
}
