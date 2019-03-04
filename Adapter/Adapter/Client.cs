using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Client
    {
        public void Travel(ITransport transport)
        {
            transport.Show();
            transport.Drive();
        }
    }
}
