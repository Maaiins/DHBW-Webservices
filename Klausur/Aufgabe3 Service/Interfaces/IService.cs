using System.ServiceModel;

namespace Aufgabe3_Service.Interfaces
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        string WhoAmI();
    }
}