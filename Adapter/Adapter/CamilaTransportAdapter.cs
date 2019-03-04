using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class CamilaTransportAdapter : ITransport
    {
        Camila camel;

        public CamilaTransportAdapter(Camila c)
        {
            camel = c;
        }

        public void Drive()
        {
            camel.Move();
        }

        public void Show()
        {
            camel.Show();
        }
    }
}
