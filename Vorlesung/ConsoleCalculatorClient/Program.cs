using System;
using CalculatorClient.Service_References.Calculator;

namespace CalculatorClient
{
    public class Program
    {
        static void Main()
        {
            var client = new Service_References.Calculator.CalculatorClient("BasicHttpEndpoint");
            while (true)
            {
                MethodChooser(client);
            }
        }

        private static void MethodChooser(Service_References.Calculator.CalculatorClient client)
        {
            Console.WriteLine("Type <A> for Method ADD.");
            Console.WriteLine("Type <ESC> for exit.");
            var keys = Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine();
            switch (keys.Key)
            {
                case ConsoleKey.A:
                    Add(client);
                    break;
                case ConsoleKey.Escape:
                    client.Close();
                    Environment.Exit(0);
                    break;
            }
        }

        private static void Add(ICalculator client)
        {
            var arguments = new Arguments();

            Console.WriteLine("First number:");
            arguments.Arg1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second number:");
            arguments.Arg2 = Convert.ToInt32(Console.ReadLine());

            var result =  client.Add(arguments);
            Console.WriteLine("The result of Adding the number {0} to number {1} is {2}", arguments.Arg1, arguments.Arg2, result.Value);
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}