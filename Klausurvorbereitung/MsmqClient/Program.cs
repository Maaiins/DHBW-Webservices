using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using MsmqContracts.Interfaces;
using MsmqContracts.Models;

namespace MsmqClient
{
    class Program
    {
        static void Main()
        {
            //Adresse Anpassen, wenn Queue umbenannt
            string[] args = { "net.msmq://localhost/private/serviceCallback" };

            //Ruft Methode unten auf
            //Wartet darauf, dass was in Callback-Queue reinkommt
            var host = StartCallbackHost();
            // net.msmq://localhost/private/<Servicename> (private da PRIVATE MSMQ Warteschlange)
            var address = new EndpointAddress("net.msmq://localhost/private/service");
            var binding = new NetMsmqBinding(NetMsmqSecurityMode.None);
            var factory = new ChannelFactory<MsmqContracts.Interfaces.IServiceChannel>(binding, address);
            var channel = factory.CreateChannel();
            try
            {
                Console.WriteLine("Message sent.");
                //Methodenaufruf beim "richtigen" Service -> In Service umbenennen und Parameter anpassen. CallbackAddress lassen!!
                channel.AddOne(new Parameter { Value = 1, CallbackAddress = args[0] });
                channel.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.ReadLine();
            host.Close();
        }

        private static ServiceHost StartCallbackHost()
        {
            //Adresse Anpassen, wenn Queue umbenannt
            // net.msmq://localhost/private/<Servicename> (private da PRIVATE MSMQ Warteschlange)
            const string address = "net.msmq://localhost/private/serviceCallback";
            var binding = new NetMsmqBinding(NetMsmqSecurityMode.None);

            //Startet Service und greift zu
            var host = new ServiceHost(typeof(ServiceCallback));

            host.AddServiceEndpoint(typeof(IServiceCallback), binding, address);

            host.Open();

            //Gibt Service an obere Methode
            return host;
        }
    }
}
