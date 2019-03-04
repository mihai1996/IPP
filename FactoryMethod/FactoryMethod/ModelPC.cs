using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class ModelPC : ProductsModel
    {
        public override FactoryMagTeh Create()
        {
            return new FactorySectionPC();
        }

        public ModelPC(string Name, string Os, int Ram, int Memory) : base(Name, Os, Ram, Memory)
        {
            Console.WriteLine("Nume produs:" + Name);
            Console.WriteLine("Sistema de operare:" + Os);
            Console.WriteLine("RAM:" + Ram);
            Console.WriteLine("Memorie:" + Memory);
        }
    }
}