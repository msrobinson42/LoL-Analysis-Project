using System.Runtime.Serialization;

namespace ContractsLib.Contracts.DataDragon
{
    [DataContract]
    public class Champion
    {
        [DataMember(Name = "")]
        public string Version { get; set; }

        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "key")]
        public string Key { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "blurb")]
        public string Blurb { get; set; }

        [DataMember(Name = "info")]
        public Info Info { get; set; }

        [DataMember(Name = "image")]
        public Image Image { get; set; }

        [DataMember(Name = "tags")]
        public string[] Tags { get; set; }

        [DataMember(Name = "partype")]
        public string Partype { get; set; }

        [DataMember(Name = "stats")]
        public Stats Stats { get; set; }
    }
}

