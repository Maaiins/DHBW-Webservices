using System;
using System.ServiceModel;
using ConsoleDatagrammsContracts.Interfaces;
using ConsoleDatagrammsContracts.Models;

namespace ConsoleDatagrammsCalculatorService
{
    public interface ICalculatorCallbackChannel : ICalculatorCallback, IClientChannel
    {
    }

    public class CalculatorService : ICalculator
    {
        public void Add(Arguments args, string callbackAddress)
        {
            var result = new Result { Value = args.Arg1 + args.Arg2 };

            var calculatorBinding = new NetMsmqBinding(NetMsmqSecurityMode.None);
            var calculatorAddress = new EndpointAddress(callbackAddress);
            var factory = new ChannelFactory<ICalculatorCallbackChannel>(calculatorBinding, calculatorAddress);

            var channel = factory.CreateChannel();

            //Kein Using da, wenn Socket in faulted Zustand kein exception handling

            try
            {
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
