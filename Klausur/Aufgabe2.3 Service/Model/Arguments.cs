﻿using System.Runtime.Serialization;

namespace Aufgabe2._3_Service.Model
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