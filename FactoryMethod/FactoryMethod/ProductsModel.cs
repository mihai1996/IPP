using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    abstract class ProductsModel
    {
        public string Name { get; set; }
        public string Os { get; set; }
        public int Ram { get; set; }
        public int Memory { get; set; }

        public ProductsModel(string Name, string Os, int Ram, int Memory)
        {
            this.Name = Name;
            this.Os = Os;
            this.Ram = Ram;
            this.Memory = Memory;
        }

        abstract public FactoryMagTeh Create();
    }
}
