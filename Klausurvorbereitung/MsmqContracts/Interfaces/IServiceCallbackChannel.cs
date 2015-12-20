using System.ServiceModel;

namespace MsmqContracts.Interfaces
{
    public interface IServiceCallbackChannel : IServiceCallback, IClientChannel
    {
         
    }
}