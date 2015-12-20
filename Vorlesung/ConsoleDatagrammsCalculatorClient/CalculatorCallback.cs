using System;
using ConsoleDatagrammsContracts.Interfaces;
using ConsoleDatagrammsContracts.Models;

namespace ConsoleDatagrammsCalculatorClient
{
    public class CalculatorCallback:ICalculatorCallback
    {
        public void SetResult(Result result)
        {
           Console.WriteLine("{0}", result.Value);
        }
    }
}