using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aufgabe3_Client.Service_References.HttpIdentityService;

namespace Aufgabe3_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new ServiceClient("BasicHttpEndpoint");
            client.ClientCredentials.UserName.UserName = @"NLA-MAC\Sample";
            client.ClientCredentials.UserName.Password = "sample";

            var userName = client.WhoAmI();
            Console.WriteLine("I am: {0}", userName);
            Console.ReadLine();
        }
    }
}
