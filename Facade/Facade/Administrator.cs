using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Administrator
    {
        public void FinalWindows(FacadeComputer facade)
        {
            facade.DiskC();
            facade.DiskD();
            facade.System();
            facade.Windows("Windwos 10");
        }
    }
}
