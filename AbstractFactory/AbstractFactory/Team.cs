using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Team
    {
        private AbstractSamurai abstractSamurai;
        private AbstractMag abstractMag;
        private AbstractAsassin abstractAsassin;
        private static Team instance = new Team();

        private Team()
        {
            
        }

        public static Team getInstance()
        {
            return instance;
        }

        public void setTeam(AbstractFactoryHeroes hero)
        {
            instance.abstractSamurai = hero.CreateSam();
            instance.abstractMag = hero.CreateMagician();
            instance.abstractAsassin = hero.CreateAsassin();
        }

        public void Run()
        {
            abstractSamurai.DescriptionHero();
            Console.WriteLine();
            abstractMag.DescriptionHero();
            Console.WriteLine();
            abstractAsassin.DescriptionHero();
        }
    }
}
