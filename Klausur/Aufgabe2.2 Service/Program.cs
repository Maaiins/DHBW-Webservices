using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe2._2_Service
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new ServiceHost(typeof(Service.Service));
            Console.WriteLine();
            host.Open();

            var baseAddress = host.BaseAddresses.FirstOrDefault();
            Console.WriteLine("The service is ready at {0}", baseAddress);
            Console.WriteLine("Press <Enter> to stop the service.");
            Console.ReadLine();

            host.Close();
        }
    }
}
