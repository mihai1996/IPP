using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class FacadeComputer
    {
        HDD hard;
        SSD ssd;
        Procesor pro;
        public OS OS;

        public FacadeComputer(HDD hard, SSD ssd, Procesor pro)
        {
            this.hard = hard;
            this.ssd = ssd;
            this.pro = pro;
            
        }

        public void DiskC()
        {
            ssd.DetailsSsd();
        }

        public void DiskD()
        {
            hard.DetailsHdd();
        }

        public void System()
        {
            pro.DetailsPro();
        }

        public void Windows(string osName)
        {
            OS = OS.GetInstance(osName);

            Console.WriteLine("Sistem de oeprare: " + osName);
        }
    }
}
