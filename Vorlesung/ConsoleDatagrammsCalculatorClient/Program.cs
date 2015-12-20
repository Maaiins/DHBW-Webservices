using System;
using System.Globalization;
using System.ServiceModel;
using ConsoleDatagrammsContracts.Interfaces;
using ConsoleDatagrammsContracts.Models;

namespace ConsoleDatagrammsCalculatorClient
{
    class Program
    {
        public interface ICalculatorChannel: ICalculator, IClientChannel
        {
        }

        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Usage CalculatorClient <callbackAddress>");
                return;
            }

            var host = StartCallbackHost();

            var calculatorBinding = new NetMsmqBinding(NetMsmqSecurityMode.None);
            var calculatorAddress = new EndpointAddress("net.msmq://localhost/private/calculator");
            var factory = new ChannelFactory<ICalculatorChannel>(calculatorBinding, calculatorAddress);

            var channel = factory.CreateChannel();

            try
            {
                var input1 = FirstUserInput();
                var input2 = SecondUserInput();

                channel.Add(new Arguments { Arg1 = input1, Arg2 = input2 }, args[0]);

                Console.Write("{0} + {1} = ", input1, input2);
                Console.ReadLine();
                channel.Dispose();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            Console.ReadLine();
            host.Close();
        }

        private static ServiceHost StartCallbackHost()
        {
            var callbackBinding = new NetMsmqBinding(NetMsmqSecurityMode.None);

            var host = new ServiceHost(typeof(CalculatorCallback));
            host.AddServiceEndpoint(typeof (ICalculatorCallback), callbackBinding,
                "net.msmq://localhost/private/calculatorcallback");
            host.Open();

            return host;
        }

        private static double FirstUserInput()
        {
            Console.WriteLine("Insert first number!");
            var input = Console.ReadLine();

            double result;
            if (!double.TryParse(input, out result))
            {
                FirstUserInput();
            }

            return result;
        }

        private static double SecondUserInput()
        {
            Console.WriteLine("Insert second number!");
            var input = Console.ReadLine();

            double result;
            if (!double.TryParse(input, out result))
            {
                SecondUserInput();
            }

            return result;
        }

        private static void Programm()
        {
            
        }
    }
}
