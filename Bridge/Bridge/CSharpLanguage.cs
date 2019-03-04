using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class CSharpLanguage : ILanguage
    {
        public void Build()
        {
            Console.WriteLine("Folosind compilatorul Roslyn, compilam codul sursă într-un fișier exe");
        }

        public void Execute()
        {
            Console.WriteLine("CLR execută codul binar compilat");
        }
    }
}
