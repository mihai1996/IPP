using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class SportCar : Car
    {
        public int Power { get; set; }

       public SportCar(string ModelName, int Power, int Year, int Motor, string Color, int Price) : base(ModelName, Year, Motor, Color, Price)
        {
            this.Power = Power;
        }

        public override Car Clone()
        {
            return new SportCar(ModelName, Power, Year, Motor, Color, Price);
        }

        public override void GetInfo()
        {
            Console.WriteLine("Model: " + ModelName);
            Console.WriteLine("Power: " + Power);
            Console.WriteLine("Year: " + Year);
            Console.WriteLine("Motor:" + Motor);
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Price: " + Price);
        }
    }
}
