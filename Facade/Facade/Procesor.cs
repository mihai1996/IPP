using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Procesor
    {
        public string name;
        public string generation;

        public Procesor(string name, string generation)
        {
            this.name = name;
            this.generation = generation;
        }

        public void DetailsPro()
        {
            Console.WriteLine("Nume procesor:" + name);
            Console.WriteLine("Generatia procesor:" + generation);
        }
    }
}
