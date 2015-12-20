using System;
using System.Linq;
using System.ServiceModel;

namespace HttpService
{
    class Program
    {
        static void Main()
        {
            //Erzeugt ServiceHost
            var host = new ServiceHost(typeof (Service));
            Console.WriteLine();
            //Host öffnen
            host.Open();

            //Host bleibt offen
            var baseAddress = host.BaseAddresses.FirstOrDefault();
            Console.WriteLine("The service is ready at {0}", baseAddress);
            Console.WriteLine("Press <Enter> to stop the service.");
            Console.ReadLine();

            //Schließen von Host
            host.Close();
        }
    }
}
