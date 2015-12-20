using System;
using System.ServiceModel;
using MsmqContracts.Interfaces;
using MsmqContracts.Models;

namespace MsmqService
{
    public class Service : IService
    {
        //ganz einfache Klasse, die übergeben wird. Beinhaltet immer Callbackaddress und Variablen
        //ggfl. bearbeiten
        public void AddOne(Parameter parameter)
        {
            //Machen, was Methode machen soll
            var result = parameter.Value + 1;

            //Von hier bis Methodenende in jeder Methode erforderlich
            var binding = new NetMsmqBinding(NetMsmqSecurityMode.None);
            var address = new EndpointAddress(parameter.CallbackAddress);
            var factory = new ChannelFactory<IServiceCallbackChannel>(binding, address);

            var channel = factory.CreateChannel();

            //Kein Using da, wenn Socket in faulted Zustand kein exception handling

            try
            {
                //Variablenname der zu liefernden Variableanpassen (hier: result ändern)
                channel.SetResult(result);
                channel.Dispose();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }
    }
}