using System;
using Client.Service_References.HttpAuthServiceReference;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 for HTTP BASIC, 2 for HTTP AUTH");

            //Input von User -> Parsen!
            var input = int.Parse(Console.ReadLine());

            int result;
            if (input == 2)
            {
                //Erstellt Client
                //("Name in App.Config unter Bindings")
                var client = new ServiceClient("BasicHttpEndpoint1");
                //Methode, die Client von Service nutzt
                result = client.AddOne(1);
            }
            else
            {
                var client = new Service_References.HttpServiceReference.ServiceClient("BasicHttpEndpoint");
                result = client.AddOne(1);
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
