using System.Runtime.Serialization;

namespace MsmqContracts.Abstracts
{
    [DataContract]
    public abstract class BaseParameter
    {
        [DataMember]
        public string CallbackAddress { get; set; }
    }
}