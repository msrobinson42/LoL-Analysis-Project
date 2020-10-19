using ContractsLib.Models;
using ContractsLib.Models.SummonerModels;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ContractsLib.Contracts.SummonerDtos
{
    [DataContract]
    public class SummonerDto
    {
        // summoner general properties
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int ProfileIconId { get; set; }

        [DataMember]
        public int SummonerLevel { get; set; }

        [DataMember]
        public long RevisionDate { get; set; }

        // summoner unique identifiers
        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public string AccountId { get; set; }

        [DataMember]
        public string Puuid { get; set; }
    }

    public static class SummonerExtensions
    {
        public static SummonerModel ToSummonerModel(this SummonerDto @this)
        {
            if (@this is null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            return new SummonerModel
                (@this.Name, @this.ProfileIconId, @this.SummonerLevel, @this.RevisionDate,
                @this.Id, @this.AccountId, @this.Puuid);
        }
    }
}
