using System.ServiceModel;
using MsmqContracts.Models;

namespace MsmqContracts.Interfaces
{
    [ServiceContract]
    public interface IService
    {
        //IsOneWay bei MSMQ wichtig -> geht nur in eine Richtung
        [OperationContract(IsOneWay = true)]

        //Methode, die ich nennen muss. Bei MSMQ sind immer void-R�ckgabewerte
        void AddOne(Parameter parameter);
    }
}