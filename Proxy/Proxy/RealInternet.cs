using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class RealInternet : IInternet
    {
        public void ConnectTo(string serverhost)
        {
            Console.WriteLine("Conecting to " + serverhost);
        }
    }
}
