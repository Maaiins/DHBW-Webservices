using System;
using ConsoleCurrencyConverter.Commands.Abstracts;

namespace ConsoleCurrencyConverter.Commands
{
    public class Invalid : AbstractCommand
    {
        public override void showText()
        {
            Console.Clear();

            Console.WriteLine("Not a Valid input");
            Console.WriteLine("Type ? or help for help");
            Console.ReadLine();
        }
    }
}