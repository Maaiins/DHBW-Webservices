using System.ServiceModel;
using ConsoleDatagrammsContracts.Models;

namespace ConsoleDatagrammsContracts.Interfaces
{
    [ServiceContract]
    public interface ICalculatorCallback
    {
        [OperationContract(IsOneWay = true)]
        void SetResult(Result result);
    }
}