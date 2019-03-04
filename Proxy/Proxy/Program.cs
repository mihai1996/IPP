using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            IInternet internet = new ProxyInternet();

            internet.ConnectTo("UTM.md");
            internet.ConnectTo("abc.com");
            internet.ConnectTo("xxx.com");
            internet.ConnectTo("ati.moodle.md");

            Console.ReadLine();
        }
    }
}
