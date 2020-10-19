using System.Runtime.Serialization;

namespace ContractsLib.Contracts.DataDragon
{
    [DataContract]
    public class Image
    {
        [DataMember(Name = "full")]
        public string Full { get; set; }

        [DataMember(Name = "sprite")]
        public string Sprite { get; set; }

        [DataMember(Name = "group")]
        public string Group { get; set; }

        [DataMember(Name = "x")]
        public int X { get; set; }

        [DataMember(Name = "y")]
        public int Y { get; set; }

        [DataMember(Name = "w")]
        public int W { get; set; }

        [DataMember(Name = "h")]
        public int H { get; set; }
    }
}

