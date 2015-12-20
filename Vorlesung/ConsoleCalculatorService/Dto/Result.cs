using System.Runtime.Serialization;

namespace CalculatorService.Dto
{
    [DataContract]
    public class Result
    {
        [DataMember]
        public double Value { get; set; }
    }
}