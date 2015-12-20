using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aufgabe2._3_Client.Service_References.HttpSerializerService;

namespace Aufgabe2._3_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your Calculation: 1-2");
            var client = new ServiceClient("BasicHttpEndpoint");
            var result = client.diff(new Arguments { Arg1 = 1, Arg2 = 2 });

            Console.WriteLine("Your Result: {0}", result.Value);
            Console.ReadLine();
        }
    }
}
