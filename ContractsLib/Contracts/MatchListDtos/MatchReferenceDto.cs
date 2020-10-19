using ContractsLib.Models;
using ContractsLib.Models.MatchListModels;
using System;
using System.Runtime.Serialization;

namespace ContractsLib.Contracts.MatchListDtos
{
    [DataContract]
    public class MatchReferenceDto
    {
        [DataMember]
        public string Lane { get; set; }

        [DataMember]
        public long GameId { get; set; }

        [DataMember]
        public int Champion { get; set; }

        [DataMember]
        public string PlatformId { get; set; }

        [DataMember]
        public long Timestamp { get; set; }

        [DataMember]
        public int Queue { get; set; }

        [DataMember]
        public string Role { get; set; }

        [DataMember]
        public int Season { get; set; }
    }

    public static class MatchReferenceExtensions
    {
        public static MatchReferenceModel ToMatchReferenceModel(this MatchReferenceDto @this)
        {
            if (@this is null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            return new MatchReferenceModel(@this.Lane, @this.GameId, @this.Champion, @this.PlatformId,
                @this.Timestamp, @this.Queue, @this.Role, @this.Season);
        }
    }
}
