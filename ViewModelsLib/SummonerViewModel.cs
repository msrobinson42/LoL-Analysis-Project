using ContractsLib.Contracts;
using ContractsLib.Contracts.LeagueEntryDtos;
using ContractsLib.Contracts.MatchDtos;
using ContractsLib.Models;
using ContractsLib.Models.LeagueEntryModels;
using ContractsLib.Models.SummonerModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ViewModelsLib
{
    public class SummonerViewModel
    {
        // fields


        // properties
        public string Name { get; }
        public int ProfileIconId { get; }
        public int Level { get; }
        public List<MatchDto> Matches { get; set; }
        public List<LeagueEntryDto> RankedInfo { get; }

        //constructor
        public SummonerViewModel(SummonerModel model)
        {
            Name = model.Name;
            ProfileIconId = model.ProfileIconId;
            Level = model.Level;
            //this.Matches = model.Matches;
            //RankedInfo = model.RankedInfo;
        }

        // methods
        public string GetBasicInfo()
        {
            return $"Summoner Name - {Name}" +
                $"\nProfile Icon Id - {ProfileIconId}" +
                $"\nSummoner Level - {Level}";
        }

        public IEnumerable<long> GetFiveMatchNames()
        {
            for (int i = 0; i < 5; i++)
            {
                yield return Matches[i].GameId;
            }
        }

        public IEnumerable<LeagueEntryDto> GetRankedInformation()
        {
            foreach (LeagueEntryDto entry in RankedInfo)
            {
                yield return entry;
            }
        }

        public void DisplayRankedInfo(IEnumerable<LeagueEntryModel> entries)
        {
            entries.ToList()
                .ForEach(e =>
                {
                    Console.WriteLine($"{e.QueueType}" +
                    $"\n{e.Rank} {e.Tier}" +
                    $"\n{e.LeaguePoints} LP" +
                    $"\n{e.WinRateAsPercentage()}");
                });
        }

    }
}
