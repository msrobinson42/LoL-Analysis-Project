using ContractsLib.Models;
using ContractsLib.Models.MatchModels;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ContractsLib.Contracts.MatchDtos
{
    [DataContract]
    public class TeamBansDto
    {
        [DataMember]
        public int PickTurn { get; set; }

        [DataMember]
        public int ChampionId { get; set; }
    }

    public static class BanDtoExtensions
    {
        public static BanModel ToBanModel(this TeamBansDto @this)
        {
            if (@this is null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            return new BanModel(@this.PickTurn, @this.ChampionId);
        }
    }
}
