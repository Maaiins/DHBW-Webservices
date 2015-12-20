using System.ServiceModel;
using Aufgabe2._3_Service.Model;

namespace Aufgabe2._3_Service.Interfaces
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        Result diff(Arguments arguments);
    }
}