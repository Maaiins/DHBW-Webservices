using System;
using System.Linq;
using System.ServiceModel;

namespace HttpAuthService
{
    class Program
    {
        static void Main()
        {
            var host = new ServiceHost(typeof (Service));
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
