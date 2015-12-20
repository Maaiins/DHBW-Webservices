using System.Runtime.Serialization;

namespace Aufgabe2._1_Service.Model
{
    [DataContract]
    public class Result
    {
        [DataMember]
        public double Value { get; set; }
    }
}