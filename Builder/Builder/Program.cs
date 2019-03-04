using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {

            LaptopBuilder laptopbuilder = new ConcretProduct();
            Director director = new Director(laptopbuilder);
            director.ConstructLaptop();
            Laptop laptop = laptopbuilder.getResult();
            
            Console.ReadKey();
        }
    }
}
