using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Auto : ITransport
    {
        private string name;
        private string category;
        private int pret;

        public Auto(string name, string category, int pret)
        {
            this.name = name;
            this.category = category;
            this.pret = pret;
        }
        
        public void Show()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Category: " + category);
            Console.WriteLine("Pret: " + pret);
        }
        public void Drive()
        {
            Console.WriteLine("Masina merge pe drum");
        }
    }
}
