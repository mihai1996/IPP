using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proxy
{
    class ProxyInternet : IInternet
    {
        IInternet internet = new RealInternet();
           
        
        public void ConnectTo(string serverhost)
        {
            List<string> bannedSites = new List<string>();
            bannedSites.Add("abc.com");
            bannedSites.Add("rdk.ru");
            bannedSites.Add("xxx.com");
            bannedSites.Add("imn.md");

            if (bannedSites.Contains(serverhost.ToLower()))
            {
                Console.WriteLine("Acces Denied");
            }
            else
            {
                Console.WriteLine("Acces received");
            }
            internet.ConnectTo(serverhost);
        }
    }
}
