using ContractsLib.Models;
using ContractsLib.Models.MatchModels;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ContractsLib.Contracts.MatchDtos
{
    [DataContract]
    public class PlayerDto
    {
        // summoner general properties
        [DataMember]
        public string SummonerName { get; set; }

        [DataMember]
        public int ProfileIcon { get; set; }

        [DataMember]
        public string PlatformId { get; set; }

        [DataMember]
        public string CurrentPlatformId { get; set; }

        // unique player properties
        [DataMember]
        public string AccountId { get; set; }

        [DataMember]
        public string SummonerId { get; set; }

        [DataMember]
        public string CurrentAccountId { get; set; }

        [DataMember]
        public string MatchHistoryUri { get; set; }
    }

    public static class PlayerExtensions
    {
        public static PlayerModel ToPlayerModel(this PlayerDto @this)
        {
            if (@this is null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            return new PlayerModel(@this.SummonerName, @this.ProfileIcon, @this.PlatformId, @this.CurrentPlatformId,
                @this.AccountId, @this.SummonerId, @this.CurrentAccountId, @this.MatchHistoryUri);
        }
    }
}
