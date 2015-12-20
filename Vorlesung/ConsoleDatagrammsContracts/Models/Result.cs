using System.Runtime.Serialization;

namespace ConsoleDatagrammsContracts.Models
{
    [DataContract]
    public class Result
    {
        [DataMember]
        public double Value { get; set; }
    }
}