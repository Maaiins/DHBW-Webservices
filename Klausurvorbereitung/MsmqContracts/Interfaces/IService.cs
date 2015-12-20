using System.ServiceModel;
using MsmqContracts.Models;

namespace MsmqContracts.Interfaces
{
    [ServiceContract]
    public interface IService
    {
        //IsOneWay bei MSMQ wichtig -> geht nur in eine Richtung
        [OperationContract(IsOneWay = true)]

        //Methode, die ich nennen muss. Bei MSMQ sind immer void-Rückgabewerte
        void AddOne(Parameter parameter);
    }
}