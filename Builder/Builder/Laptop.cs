using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Laptop
    {
        public string Model { get; set; }
        public string GraphicsCard { get; set; }
        public string Processor { get; set; }
        public int Ram { set; get; }
        public int Hdd { get; set; }
        public int Ssd { get; set; }
    }
}
