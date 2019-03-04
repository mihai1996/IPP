using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            Auto auto = new Auto("Audi RS", "Sport Car", 20000);
            Console.WriteLine("Calatorie cu masina");
            client.Travel(auto);
            Console.WriteLine("-------------------------------------");
            Camila camel = new Camila(500);
            //Adapter
            ITransport camelTransport = new CamilaTransportAdapter(camel);
            Console.WriteLine("Calatorie cu Camila");
            client.Travel(camelTransport);

            Console.ReadLine();
        }
    }
}
