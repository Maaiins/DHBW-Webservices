﻿using System;
using System.Linq;
using System.ServiceModel;
using CalculatorService.Services;

namespace CalculatorService
{
    public class Program
    {
        private static void Main()
        {
            var host = new ServiceHost(typeof(Calculator));
            Console.WriteLine();
            host.Open();

            var baseAddress = host.BaseAddresses.FirstOrDefault();
            Console.WriteLine("The service is ready at {0}", baseAddress);
            Console.WriteLine("Press <Enter> to stop the service.");
            Console.ReadLine();

            host.Close();
        }
    }
}