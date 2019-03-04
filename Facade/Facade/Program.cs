using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Subsistems Computer");
            Console.WriteLine("---------------------------------");
            HDD hdd = new HDD(1000, "Toshiba");
            SSD ssd = new SSD(128, "Samsung");
            Procesor pro = new Procesor("Intel Core(TM) I7", "7700HQ");

            FacadeComputer comp = new FacadeComputer(hdd, ssd, pro);
            Administrator admin = new Administrator();
            admin.FinalWindows(comp);

            //comp.OS = OS.GetInstance("Windows 7");
            //Console.WriteLine(comp.OS.Name);

            Console.ReadLine();
        }
    }
}