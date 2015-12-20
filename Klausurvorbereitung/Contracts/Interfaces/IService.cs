using System.ServiceModel;

namespace Contracts.Interfaces
{
    [ServiceContract]
    public interface IService
    {
        //Methoden, die der Service anbietet. Für jede Methode ein OperationContract drüber
        [OperationContract]
        int AddOne(int value);
    }
}