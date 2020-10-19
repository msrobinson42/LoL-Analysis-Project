using ContractsLib.Models.MatchModels;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ContractsLib.Contracts.MatchDtos
{
    [DataContract]
    public class ParticipantTimelineDto
    {
        [DataMember]
        public int ParticipantId { get; set; }

        [DataMember]
        public Dictionary<string, double> CsDiffPerMinDeltas { get; set; }

        [DataMember]
        public Dictionary<string, double> DamageTakenPerMinDeltas { get; set; }

        [DataMember]
        public string Role { get; set; }

        [DataMember]
        public Dictionary<string, double> DamageTakenDiffPerMinDeltas { get; set; }

        [DataMember]
        public Dictionary<string, double> XpPerMinDeltas { get; set; }

        [DataMember]
        public Dictionary<string, double> XpDiffPerMinDeltas { get; set; }

        [DataMember]
        public string Lane { get; set; }

        [DataMember]
        public Dictionary<string, double> CreepsPerMinDeltas { get; set; }

        [DataMember]
        public Dictionary<string, double> GoldPerMinDeltas { get; set; }
    }

    public static class ParticipantTimelineDtoExtensions
    {
        public static ParticipantTimelineModel ToParticipantTimelineModel(this ParticipantTimelineDto @this)
        {
            if (@this is null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            return new ParticipantTimelineModel
                (@this.ParticipantId, @this.CsDiffPerMinDeltas, @this.DamageTakenPerMinDeltas,
                @this.Role, @this.DamageTakenDiffPerMinDeltas, @this.XpPerMinDeltas,
                @this.XpDiffPerMinDeltas, @this.Lane, @this.CreepsPerMinDeltas, @this.GoldPerMinDeltas);

        }
    }
}