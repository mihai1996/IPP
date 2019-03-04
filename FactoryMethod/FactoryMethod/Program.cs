using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryMagTeh mag = new FactorySectionPC();
            ProductsModel pc = new ModelPC("Lenovo y720", "Windows 10", 16, 100000);
            Console.WriteLine();
            mag = new FactorySectionPhone();
            ProductsModel smartphone  = new ModelPhone("Samsung s7 Edge", "Android 8", 4, 32);

            Console.ReadKey();
        }
    }
}
