using System.ServiceModel;
using Aufgabe2._1_Service.Model;

namespace Aufgabe2._1_Service.Interfaces
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        Result diff(Arguments arguments);
    }
}