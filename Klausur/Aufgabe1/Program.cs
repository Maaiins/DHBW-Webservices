using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aufgabe1.Service_References.EchoService;

namespace Aufgabe1
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new EchoServiceClient("EchoService");
            Console.WriteLine("Please Insert something");
            var input = Console.ReadLine();

            var result = client.Echo(input);

            Console.WriteLine("Your Input was: {0}", result);
            Console.ReadLine();
        }
    }
}
