using ContractsLib.Models;
using ContractsLib.Models.MatchModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace ContractsLib.Contracts.MatchDtos
{
    [DataContract]
    public class MatchDto
    {
        // class properties
        [DataMember]
        public List<TeamStatsDto> Teams { get; set; }

        [DataMember]
        public List<ParticipantDto> Participants { get; set; }

        [DataMember]
        public List<ParticipantIdentityDto> ParticipantIdentities { get; set; }

        // game type properties
        [DataMember]
        public long GameId { get; set; }

        [DataMember]
        public string PlatformId { get; set; }

        [DataMember]
        public string GameType { get; set; }

        [DataMember]
        public int QueueId { get; set; }

        [DataMember]
        public int MapId { get; set; }

        [DataMember]
        public int SeasonId { get; set; }

        [DataMember]
        public string GameVersion { get; set; }

        [DataMember]
        public string GameMode { get; set; }

        // game time properties
        [DataMember]
        public long GameCreation { get; set; }

        [DataMember]
        public int GameDuration { get; set; }
    }

    public static class MatchExtensions
    {
        public static MatchModel ToMatchModel(this MatchDto @this)
        {
            if (@this is null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            List<TeamModel> teamModels = @this.Teams
                .Select<TeamStatsDto, TeamModel>(t => t.ToTeamModel())
                .ToList();

            List<ParticipantModel> particModels = @this.Participants
                .Select<ParticipantDto, ParticipantModel>(p => p.ToParticipantModel())
                .ToList();

            List<ParticipantIdentityModel> parIdModels = @this.ParticipantIdentities
                .Select<ParticipantIdentityDto, ParticipantIdentityModel>(p => p.ToParticipantIdentityModel())
                .ToList();

            return new MatchModel(teamModels, particModels, parIdModels, @this.GameId, @this.PlatformId, @this.GameType,
                @this.QueueId, @this.MapId, @this.SeasonId, @this.GameVersion, @this.GameMode, @this.GameCreation,
                @this.GameDuration);
        }
    }
}