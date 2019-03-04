using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Brigadir
    {
        static void Main(string[] args)
        {
            ArmataComponent soldat1 = new SoldatBuilder().SetName("Dutcovici Radu").Build();
            ArmataComponent soldat2 = new SoldatBuilder().SetName("Igor Mamolea").Build();
            ArmataComponent soldat3 = new SoldatBuilder().SetName("Terminator").Build();
            ArmataComponent soldat4 = new SoldatBuilder().SetName("Cujba Vasile").Build();


            ArmataComponent armataMica = new PlutonBuilder().SetName("armata mica").
                Add(soldat1).Add(soldat3).Build();

            ArmataComponent armataMare= new PlutonBuilder().SetName(" armata mare").
                Add(soldat4).Add(armataMica).Add(soldat2).Build();

            armataMica.Print();
            Console.WriteLine("------------------------------------------------------");
            armataMare.Print();


            /*
            ArmataComponent armata = new CompositePluton("Plutonul 108");
            armata.Add(new Soldat("Soldat gradul 1"));
            armata.Add(new Soldat("Soldat gradul 2"));
            armata.Add(new Soldat("Soldat gradul 3"));
            armata.Add(new Soldat("Sergent inferior"));
            armata.Print();
            Console.WriteLine("-----------------------------------");
            ArmataComponent armata2 = new CompositePluton("Plutonul 109");
            armata2.Add(new Soldat("Soldat gradul 2"));
            armata2.Add(new Soldat("Soldat gradul 3"));
            armata2.Add(new Soldat("Sergent inferior"));
           
            armata2.Print();
            */

            Console.ReadLine();

        }
    }
}
