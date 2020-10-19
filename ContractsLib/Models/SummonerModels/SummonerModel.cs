using System;
using System.Collections.Generic;
using System.Text;

namespace ContractsLib.Models.SummonerModels
{
    public class SummonerModel
    {
        // fields

        // constructors
        public SummonerModel(string name, int profileIconId, int summonerLevel,
            long revisionDate, string id, string accountId, string puuid)
        {
            Name = name;
            ProfileIconId = profileIconId;
            Level = summonerLevel;
            RevisionDate = revisionDate;
            Id = id;
            AccountId = accountId;
            Puuid = puuid;

            // make new class with these attached
            //Matches = matchlist.matches;
            //RankedInfo = entries;
            //Matches = GetMatches(matchlist).ToList();
        }

        // properties
        // summoner general properties
        public string Name { get; set; }
        public int ProfileIconId { get; set; }
        public int Level { get; set; }
        public long RevisionDate { get; set; }
        // summoner unique identifiers
        public string Id { get; set; }
        public string AccountId { get; set; }
        public string Puuid { get; set; }

        // make new class with these attached
        //public List<LeagueEntry> RankedInfo { get; set; }
        //public List<Match> Matches { get; }

        //// methods
        //IEnumerable<Match> GetMatches(MatchList matchlist)
        //{
        //    foreach (Match match in matchlist.matches)
        //    {
        //        yield return match;
        //    }
        //}
    }
}
