using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class CPPLanguage : ILanguage
    {
        public void Build()
        {
            Console.WriteLine("Cu ajutorul compilatorului C++ compilam programa in cod binar");
        }

        public void Execute()
        {
            Console.WriteLine("Rulati fisierul programului executabil");
        }
    }
}
