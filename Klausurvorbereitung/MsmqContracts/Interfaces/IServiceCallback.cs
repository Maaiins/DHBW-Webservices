using System.ServiceModel;

namespace MsmqContracts.Interfaces
{
    [ServiceContract]
    public interface IServiceCallback
    {
        [OperationContract(IsOneWay = true)]
        /*
         * Datentyp von result anpassen
         */

        //Im Service wird SetResult aufgerufen
        void SetResult(int result);
    }
}