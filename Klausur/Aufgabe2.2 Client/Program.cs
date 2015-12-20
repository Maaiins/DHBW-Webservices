using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aufgabe2._2_Client.Service_References.TcpService;

namespace Aufgabe2._2_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your Calculation: 1-2");
            var client = new ServiceClient("netTcpEndpoint");
            var result = client.diff(new Arguments { Arg1 = 1, Arg2 = 2 });

            Console.WriteLine("Your Result: {0}", result.Value);
            Console.ReadLine();
        }
    }
}
