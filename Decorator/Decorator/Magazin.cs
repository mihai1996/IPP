using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Magazin
    {
        static void Main(string[] args)
        {
            TortComponent tort1 = new FranzelutaConcretComponent();
            tort1 = new FriscaConcretDecorator(tort1);
            Console.WriteLine("Denumire: " + tort1.Name);
            Console.WriteLine("Pret: " + tort1.GetCost());

            TortComponent tort2 = new FranzelutaConcretComponent();
            tort2 = new FriscaConcretDecorator(tort2);
            tort2 = new NuciConcretDecorator(tort2);
            Console.WriteLine("Denumire: " + tort2.Name);
            Console.WriteLine("Pret: " + tort2.GetCost());

            TortComponent tort3 = new ColibriConcretComponent();
            tort3 = new FriscaConcretDecorator(tort3);
            tort3 = new NuciConcretDecorator(tort3);
            tort3 = new CiocolataConcretDecorator(tort3);
            Console.WriteLine("Denumire: " + tort3.Name);
            Console.WriteLine("Pret: " + tort3.GetCost());

            Console.ReadLine();
        }
    }
}
