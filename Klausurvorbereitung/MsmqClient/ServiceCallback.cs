using System;
using MsmqContracts.Interfaces;

namespace MsmqClient
{
    //Service, den ich in program.cs öffne
    public class ServiceCallback : IServiceCallback
    {
        public void SetResult(int result)
        {
            Console.WriteLine(result);
        }
    }
}