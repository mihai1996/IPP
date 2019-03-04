using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    abstract class Car
    {
        public string ModelName { get; set; }
        public int Year { get; set; }
        public int Motor { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }

        public Car(string ModelName, int Year, int Motor, string Color, int Price)
        {
            this.ModelName = ModelName;
            this.Year = Year;
            this.Motor = Motor;
            this.Color = Color;
            this.Price = Price;
        }

        public abstract Car Clone();
        public abstract void GetInfo();
    }
}
