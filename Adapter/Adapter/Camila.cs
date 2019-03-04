using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Camila : IAnimal
    {
        private int pret;

        public Camila(int pret)
        {
            this.pret = pret;
        }

        public void Show()
        {
            Console.WriteLine("Pret:" + pret);
        }
        public void Move()
        {
            Console.WriteLine("Camila merge prin desert");
        }

    }
}
