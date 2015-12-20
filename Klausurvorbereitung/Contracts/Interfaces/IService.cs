using System.ServiceModel;

namespace Contracts.Interfaces
{
    [ServiceContract]
    public interface IService
    {
        //Methoden, die der Service anbietet. F�r jede Methode ein OperationContract dr�ber
        [OperationContract]
        int AddOne(int value);
    }
}