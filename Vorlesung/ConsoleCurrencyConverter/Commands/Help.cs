using System;
using ConsoleCurrencyConverter.Commands.Abstracts;

namespace ConsoleCurrencyConverter.Commands
{
    public class Help : AbstractCommand
    {
        public override void showText()
        {
            Console.Clear();

            Console.WriteLine("Type ? or help for help");
            Console.WriteLine();
            Console.WriteLine("For Conversion do the following:");
            Console.WriteLine("CONVERT <VALUE> <CURRENCY> TO <CURRENCY>");
            Console.WriteLine();
            Console.WriteLine("Example:");
            Console.WriteLine("CONVERT 1 USD TO EUR");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("For a list of avvailable currencies type: LIST");
            Console.WriteLine();
            Console.WriteLine("Type QUIT to exit the program");
        }
    }
}