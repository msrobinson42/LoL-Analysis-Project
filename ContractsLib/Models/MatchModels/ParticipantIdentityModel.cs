using System;
using System.Collections.Generic;
using System.Text;

namespace ContractsLib.Models.MatchModels
{
    public class ParticipantIdentityModel
    {
        public ParticipantIdentityModel(PlayerModel player, int participantId)
        {
            Player = player;
            ParticipantId = participantId;
        }

        public PlayerModel Player { get; set; }
        public int ParticipantId { get; set; }
    }
}
