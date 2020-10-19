using System;
using System.Collections.Generic;
using System.Text;

namespace ContractsLib.Models.LeagueEntryModels
{
    public class LeagueEntryModel
    {
        // fields

        // constructor
        public LeagueEntryModel(string leagueId, string queueType, string tier,
            string rank, string summonerId, string summonerName, int leaguePoints,
            int wins, int losses, bool veteran, bool inactive, bool freshBlood,
            bool hotStreak, MiniSeriesModel msModel)
        {
            LeagueId = leagueId;
            QueueType = queueType;
            Tier = tier;
            Rank = rank;
            SummonerId = summonerId;
            SummonerName = summonerName;
            LeaguePoints = leaguePoints;
            TotalWins = wins;
            TotalLosses = losses;
            Veteran = veteran;
            Inactive = inactive;
            FreshBlood = freshBlood;
            HotStreak = hotStreak;
            MiniSeries = msModel;
        }

        // properties
        public string LeagueId { get; set; }
        public string QueueType { get; set; }
        public string Tier { get; set; }
        public string Rank { get; set; }
        public string SummonerId { get; set; }
        public string SummonerName { get; set; }
        public int LeaguePoints { get; set; }
        public int TotalWins { get; set; }
        public int TotalLosses { get; set; }
        public bool Veteran { get; set; }
        public bool Inactive { get; set; }
        public bool FreshBlood { get; set; }
        public bool HotStreak { get; set; }
        public MiniSeriesModel MiniSeries { get; set; }

        // methods
        public double WinRateAsPercentage()
        {
            return TotalWins / (TotalWins + TotalLosses);
        }
    }
}
