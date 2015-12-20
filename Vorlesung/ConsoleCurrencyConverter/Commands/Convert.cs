using System;
using ConsoleCurrencyConverter.Commands.Abstracts;
using ConsoleCurrencyConverter.Service_References.CurrencyConverterSoap;

namespace ConsoleCurrencyConverter.Commands
{
    public class Convert : AbstractCommand
    {
        private Currency mFromCurrency;

        private Currency mToCurrency;

        private double mValue;

        public Convert(string fromCurrency, string toCurrency, string value)
        {
            Enum.TryParse(fromCurrency, true, out mFromCurrency);
            Enum.TryParse(toCurrency, true, out mToCurrency);

            Double.TryParse(value, out mValue);
        }

        public override void showText()
        {
            var conversion = getConversion();

            Console.Clear();

            Console.WriteLine("Your input:");
            Console.WriteLine("Value: " + mValue);
            Console.WriteLine("From: " + mFromCurrency);
            Console.WriteLine("To: " + mToCurrency);
            Console.WriteLine();
            Console.WriteLine(mValue + " " + mFromCurrency + " is equivalent to " + conversion + " " + mToCurrency);
        }

        private double getConversion()
        {
            var client = new CurrencyConvertorSoapClient("CurrencyConvertorSoap");
            var rate = client.ConversionRate(mFromCurrency, mToCurrency);

            return mValue*rate;
        }
    }
}