using System.Runtime.Serialization;

namespace ConsoleDatagrammsContracts.Models
{
    [DataContract]
    public class Arguments
    {
        [DataMember]
        public double Arg1 { get; set; }
        [DataMember]
        public double Arg2 { get; set; }
        [DataMember]
        public string CallbackAddress { get; set; }
    }
}
