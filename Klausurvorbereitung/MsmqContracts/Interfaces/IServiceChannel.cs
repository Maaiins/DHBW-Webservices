using System.ServiceModel;

namespace MsmqContracts.Interfaces
{
    public interface IServiceChannel : IService, IClientChannel
    {
         
    }
}