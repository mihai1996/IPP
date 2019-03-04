using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Director
    {
        LaptopBuilder laptopbuilder;

        public Director(LaptopBuilder laptopbuilder)
        {
            this.laptopbuilder = laptopbuilder;
        }

        public void ConstructLaptop()
        {
            laptopbuilder.setModel();
            laptopbuilder.setGraphicsCard();
            laptopbuilder.setProcessor();
            laptopbuilder.setRam();
            laptopbuilder.setHdd();
            laptopbuilder.setSsd();
        }
    }
}
