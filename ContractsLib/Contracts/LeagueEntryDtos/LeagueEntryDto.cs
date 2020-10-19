using ContractsLib.Models;
using ContractsLib.Models.LeagueEntryModels;
using System;
using System.Runtime.Serialization;

namespace ContractsLib.Contracts.LeagueEntryDtos
{
    [DataContract]
    public class LeagueEntryDto
    {
        [DataMember]
        public string LeagueId { get; set; }

        [DataMember]
        public string QueueType { get; set; }

        [DataMember]
        public string Tier { get; set; }

        [DataMember]
        public string Rank { get; set; }

        [DataMember]
        public string SummonerId { get; set; }

        [DataMember]
        public string SummonerName { get; set; }

        [DataMember]
        public int LeaguePoints { get; set; }

        [DataMember]
        public int Wins { get; set; }

        [DataMember]
        public int Losses { get; set; }

        [DataMember]
        public bool Veteran { get; set; }

        [DataMember]
        public bool Inactive { get; set; }

        [DataMember]
        public bool FreshBlood { get; set; }

        [DataMember]
        public bool HotStreak { get; set; }

        [DataMember]
        public MiniSeriesDto MiniSeries { get; set; }
    }

    public static class LeagueEntryExtensions
    {
        public static LeagueEntryModel ToLeagueEntryModel(this LeagueEntryDto @this)
        {
            if (@this is null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            MiniSeriesModel msModel = @this.MiniSeries.ToMiniseriesModel();

            return new LeagueEntryModel(@this.LeagueId, @this.QueueType, @this.Tier, @this.Rank,
                @this.SummonerId, @this.SummonerName, @this.LeaguePoints, @this.Wins, @this.Losses,
                @this.Veteran, @this.Inactive, @this.FreshBlood, @this.HotStreak, msModel);
        }
    }
}