using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleCurrencyConverter.Commands;
using ConsoleCurrencyConverter.Commands.Abstracts;
using Convert = ConsoleCurrencyConverter.Commands.Convert;

namespace ConsoleCurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Initialize();
        }

        private static void Initialize()
        {
            Console.WriteLine("Type ? for Help");

            var input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input))
            {
                var split = input.Split(' ');

                if (split[0].Equals("quit", StringComparison.CurrentCultureIgnoreCase))
                {
                    Environment.Exit(0);
                }

                AbstractCommand convert;

                if (split[0].Equals("convert", StringComparison.CurrentCultureIgnoreCase) &&
                    split[3].Equals("to", StringComparison.CurrentCultureIgnoreCase))
                {
                    convert = new Convert(split[2], split[4], split[1]);
                }
                else if (split[0].Equals("list", StringComparison.CurrentCultureIgnoreCase))
                {
                    convert = new List();
                }
                else if (split[0].Equals("?", StringComparison.CurrentCultureIgnoreCase) ||
                         split[0].Equals("help", StringComparison.CurrentCultureIgnoreCase))
                {
                    convert = new Help();
                }
                else
                {
                    convert = new Invalid();
                }

                convert.showText();
            }
            else
            {
                AbstractCommand convert = new Invalid();
                convert.showText();
            }

            Initialize();
        }
    }
}
