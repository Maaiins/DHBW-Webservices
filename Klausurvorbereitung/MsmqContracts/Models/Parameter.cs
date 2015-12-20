using System.Runtime.Serialization;
using MsmqContracts.Abstracts;

namespace MsmqContracts.Models
{
    /*
     * Vorsicht: Erbt Callback Address
     */
    [DataContract]
    public class Parameter : BaseParameter
    {
        /*
         * Membervariablen hinzufügen
         */
        [DataMember]
        public int Value { get; set; }
        //ggfls. neue Variable mit DataMember drüber
    }
}