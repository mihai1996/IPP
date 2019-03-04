using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactoryHeroes factory1 = new HeroesFactory();
            Team.getInstance().setTeam(factory1);
            Team.getInstance().Run();

            Console.WriteLine("\n\n**************************\n\n");

            AbstractFactoryHeroes factory2 = new PremiumFactoryHeroes();
            Team.getInstance().setTeam(factory2);
            Team.getInstance().Run();

            Console.ReadLine();
        }
    }
}
