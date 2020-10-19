using ContractsLib.Models.LeagueEntryModels;
using ContractsLib.Models.MatchListModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContractsLib.Models.SummonerModels
{
    public class SummonerInfoModel
    {
        // constructors
        public SummonerInfoModel(SummonerModel summoner, List<LeagueEntryModel> entries, MatchListModel matchlist)
        {
            Summoner = summoner;
            Entries = entries;
            Matchlist = matchlist;
        }

        // properties
        public SummonerModel Summoner { get; }
        public List<LeagueEntryModel> Entries { get; }
        public MatchListModel Matchlist { get; }

        // methods
        public string DisplayGeneralInfo()
        {
            StringBuilder message = new StringBuilder();

            message.Append(Summoner.Name + Environment.NewLine);
            message.Append(Summoner.ProfileIconId.ToString() + Environment.NewLine);
            message.Append(GetEntryMessage());

            return message.ToString();

            string GetEntryMessage()
            {
                if (Entries.Count == 0)
                {
                    return "No ranked games this season.";
                }
                else
                {
                    StringBuilder baseString = new StringBuilder();

                    Entries.ForEach(e =>
                    {
                        baseString.Append($"{e.QueueType}-->");
                        baseString.Append($"{e.Tier} {e.Rank}{Environment.NewLine}");
                        baseString.Append($"{e.LeaguePoints} ");
                        baseString.Append($"{e.MiniSeries.Progress}{Environment.NewLine}");
                        baseString.Append($"{e.TotalWins} Wins, {e.TotalLosses} Losses, {e.WinRateAsPercentage():p}");
                    });

                    return baseString.ToString();
                }
            }
        }
    }
}
