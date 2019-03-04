using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class ConcretProduct : LaptopBuilder
    {
        Laptop laptop = new Laptop();

        public override void setModel()
        {
            laptop.Model = "Lenovo Legion Y720";
            Console.WriteLine("Model: " + laptop.Model);
        }

        public override void setProcessor()
        {
            laptop.Processor = "Intel Core i7-770HQ";
            Console.WriteLine("Processor: " + laptop.Processor);
        }

        public override void setGraphicsCard()
        {
            laptop.GraphicsCard = "GTX 1060";
            Console.WriteLine("Graphics Card: " + laptop.GraphicsCard);
        }

        public override void setRam()
        {
            laptop.Ram = 16;
            Console.WriteLine("RAM: " + laptop.Ram);
        }

        public override void setHdd()
        {
            laptop.Hdd = 1000;
            Console.WriteLine("HDD: " + laptop.Hdd);
        }

        public override void setSsd()
        {
            laptop.Ssd = 128;
            Console.WriteLine("SSD: " + laptop.Ssd);
        }

       public override Laptop getResult()
        {
            return laptop;
        }
    }
}