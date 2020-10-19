using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ContractsLib.Contracts.DataDragon
{
    [DataContract]
    public class Data
    {
        [DataMember(Name = "data")]
        public Dictionary<string, Champion> Champions { get; set; }
    }
}
