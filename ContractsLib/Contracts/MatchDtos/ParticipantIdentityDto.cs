using ContractsLib.Models;
using ContractsLib.Models.MatchModels;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ContractsLib.Contracts.MatchDtos
{
    [DataContract]
    public class ParticipantIdentityDto
    {
        [DataMember]
        public PlayerDto Player { get; set; }

        [DataMember]
        public int ParticipantId { get; set; }
    }

    public static class ParticipantIdentityExtensions
    {
        public static ParticipantIdentityModel ToParticipantIdentityModel(this ParticipantIdentityDto @this)
        {
            if (@this is null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            PlayerModel playerModel = @this.Player.ToPlayerModel();

            return new ParticipantIdentityModel(playerModel, @this.ParticipantId);
        }
    }
}
