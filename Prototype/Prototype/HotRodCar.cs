using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class HotRodCar : Car
    {
        public string Region { get; set; }

        public HotRodCar(string ModelName, string Region, int Year, int Motor, string Color, int Price) : base(ModelName, Year, Motor, Color, Price)
        {
            this.Region = Region;
        }

        public override Car Clone()
        {
            return new HotRodCar(ModelName, Region, Year, Motor, Color, Price);
        }

        public override void GetInfo()
        {
            Console.WriteLine("Model: " + ModelName);
            Console.WriteLine("Region: " + Region);
            Console.WriteLine("Year: " + Year);
            Console.WriteLine("Motor:" + Motor);
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Price: " + Price);
        }
    }
}
