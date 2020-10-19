using ContractsLib.Models;
using ContractsLib.Models.MatchModels;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ContractsLib.Contracts.MatchDtos
{
    [DataContract]
    public class ParticipantDto
    {
        [DataMember]
        public int ParticipantId { get; set; }

        [DataMember]
        public int ChampionId { get; set; }

        [DataMember]
        public ParticipantStatsDto Stats { get; set; }

        [DataMember]
        public int TeamId { get; set; }

        [DataMember]
        public ParticipantTimelineDto Timeline { get; set; }

        [DataMember]
        public int Spell1Id { get; set; }

        [DataMember]
        public int Spell2Id { get; set; }

        [DataMember]
        public string HighestAchievedSeasonTier { get; set; }
    }

    public static class ParticipantExtensions
    {
        public static ParticipantModel ToParticipantModel(this ParticipantDto @this)
        {
            if (@this is null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            ParticipantStatsModel statsModel = @this.Stats.ToStatsModel();

            return new ParticipantModel(statsModel, @this.ParticipantId, @this.TeamId, @this.ChampionId,
                @this.Spell1Id, @this.Spell2Id);
        }
    }
}
