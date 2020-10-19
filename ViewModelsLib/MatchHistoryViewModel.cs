using ContractsLib.Contracts.DataDragon;
using ContractsLib.Models;
using ContractsLib.Models.MatchListModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ViewModelsLib
{
    public class MatchHistoryViewModel
    {
        private readonly MatchListModel matchList;

        public MatchHistoryViewModel(MatchListModel matches)
        {
            matchList = matches;
        }

        public string DisplayMatches(int quantity, Data championInfo)
        {
            var output = string.Empty;

            for (int i = 0; i < quantity; i++)
                AddMatch(i);

            return output;

            string AddMatch(int i)
            {
                var matchRef = matchList.MatchReferences[i];

                output += matchRef.GameId + Environment.NewLine;
                output += matchRef.QueueName + Environment.NewLine;
                output += GetChampionName() + Environment.NewLine;
                output += matchRef.Role + Environment.NewLine;
                output += matchRef.Lane + Environment.NewLine;
                output += Environment.NewLine;
                return output;

                string GetChampionName() => 
                    championInfo.Champions
                       .Where(kvp => kvp.Value.Key == matchRef.Champion.ToString())
                       .Select(kvp => kvp.Value.Name)
                       .Single();
            }
        }
    }
}
