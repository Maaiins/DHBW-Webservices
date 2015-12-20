using System.Runtime.Serialization;

namespace Aufgabe2._3_Service.Model
{
    [DataContract]
    public class Result
    {
        [DataMember]
        public double Value { get; set; }
    }
}