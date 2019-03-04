using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Diller
    {
        public void Cars()
        {
            Car car = new SportCar("Chevrolet Camaro", 500, 2017, 400, "Yellow", 25000);
            Car clonedCar = car.Clone();
            //car.GetInfo();
            clonedCar.GetInfo();
            Console.WriteLine();
            car = new HotRodCar("Ford Pickup", "America", 1987, 400, "Black", 5500);
            clonedCar = car.Clone();
            //car.GetInfo();
            clonedCar.GetInfo(); //deep an shell
        }
    }
}
