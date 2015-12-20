using System.Runtime.Serialization;

namespace Aufgabe2._1_Contracts.Model
{
    [DataContract]
    public class Arguments
    {
        [DataMember]
        public double Arg1 { get; set; }

        [DataMember]
        public double Arg2 { get; set; }
    }
}