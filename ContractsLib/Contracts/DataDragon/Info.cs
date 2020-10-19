using System.Runtime.Serialization;

namespace ContractsLib.Contracts.DataDragon
{
    [DataContract]
    public class Info
    {
        [DataMember(Name = "attack")]
        public int Attack { get; set; }

        [DataMember(Name = "defense")]
        public int Defense { get; set; }

        [DataMember(Name = "magic")]
        public int Magic { get; set; }

        [DataMember(Name = "difficulty")]
        public int Difficulty { get; set; }
    }
}

