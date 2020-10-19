using System;
using System.Collections.Generic;
using System.Text;

namespace ContractsLib.Models.MatchModels
{
    public class PlayerModel
    {
        // fields

        // constructors
        public PlayerModel(string summonerName, int profileIcon, string platformId,
            string currentPlatformId, string accountId, string summonerId,
            string currentAccountId, string matchHistoryUri)
        {
            SummonerName = summonerName;
            ProfileIcon = profileIcon;
            PlatformId = platformId;
            CurrentPlatformId1 = currentPlatformId;
            CurrentPlatformId = currentAccountId;

            AccountId = accountId;
            SummonerId = summonerId;
            CurrentAccountId = currentAccountId;
            MatchHistoryUri = matchHistoryUri;

        }

        // properties
        // summoner general properties
        public string SummonerName { get; set; }
        public int ProfileIcon { get; set; }
        public string PlatformId { get; set; }
        public string CurrentPlatformId1 { get; }
        public string CurrentPlatformId { get; set; }

        // unique player properties
        public string AccountId { get; set; }
        public string SummonerId { get; set; }
        public string CurrentAccountId { get; set; }
        public string MatchHistoryUri { get; set; }

        // methods
    }
}
