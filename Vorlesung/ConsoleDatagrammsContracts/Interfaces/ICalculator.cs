using System.ServiceModel;
using ConsoleDatagrammsContracts.Models;

namespace ConsoleDatagrammsContracts.Interfaces
{
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract(IsOneWay = true)]
        void Add(Arguments args, string callbackAddress);
    }
}