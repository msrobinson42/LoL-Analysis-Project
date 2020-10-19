using System;
using System.Collections.Generic;
using System.Text;

namespace ContractsLib.Models.MatchModels
{
    public class ParticipantModel
    {
        public ParticipantModel(ParticipantStatsModel stats, int participantId, int teamId,
            int championId, int spell1Id, int spell2Id)
        {
            Stats = stats;
            ParticipantId = participantId;
            TeamId = teamId;
            ChampionId = championId;
            Spell1Id = spell1Id;
            Spell2Id = spell2Id;
        }
        public ParticipantStatsModel Stats { get; set; }
        public int ParticipantId { get; set; }
        public int TeamId { get; set; }
        public int ChampionId { get; set; }
        public int Spell1Id { get; set; }
        public int Spell2Id { get; set; }
        //public Timeline timeline { get; set; }

    }
}
