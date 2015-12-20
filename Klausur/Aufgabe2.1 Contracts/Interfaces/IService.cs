using System.ServiceModel;

namespace Aufgabe2._1_Contracts.Interfaces
{
    [ServiceContract]
    public interface IService
    {
        Result diff(MessageParameterAttribute parameter);
    }
}