using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class CorporateProgrammer : Programmer
    {
        public CorporateProgrammer(ILanguage lang) : base(lang)
        {
        }

        public override void EarnMoney()
        {
            Console.WriteLine("Primeste salariu la sfirsitul lunii.");
        }
    }
}
