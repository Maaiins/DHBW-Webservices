using System.Runtime.Serialization;

namespace MsmqContracts.Models
{
    /*
     * DataContract ist erfordelich bei jedem Model z.B. Argumente oder Results
     */
    [DataContract]
    public class Sample
    {
        /*
         * Data Member muss für jede Membervariable deklariert werden
         */
        [DataMember]
        public int Variable { get; set; }
    }
}