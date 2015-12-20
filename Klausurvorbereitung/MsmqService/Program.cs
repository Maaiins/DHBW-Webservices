using System;
using System.Linq;
using System.ServiceModel;

namespace MsmqService
{
    class Program
    {
        static void Main()
        {
            var host = new ServiceHost(typeof(Service));
            Console.WriteLine();
            host.Open();

            Console.WriteLine("The service is ready");
            Console.WriteLine("Press <Enter> to stop the service.");
            Console.ReadLine();

            host.Close();
        }
    }
}
