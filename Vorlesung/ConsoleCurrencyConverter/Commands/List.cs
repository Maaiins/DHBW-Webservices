using System;
using ConsoleCurrencyConverter.Commands.Abstracts;
using ConsoleCurrencyConverter.Service_References.CurrencyConverterSoap;

namespace ConsoleCurrencyConverter.Commands
{
    public class List : AbstractCommand
    {
        public override void showText()
        {
            var values = Enum.GetValues(typeof (Currency));

            Console.Clear();
            Console.WriteLine("Available currencies");

            foreach (var value in values)
            {
                Console.WriteLine(value);
            }
        }
    }
}