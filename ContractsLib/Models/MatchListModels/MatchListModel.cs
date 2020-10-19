using System;
using System.Collections.Generic;
using System.Text;

namespace ContractsLib.Models.MatchListModels
{
    public class MatchListModel
    {
        public MatchListModel(List<MatchReferenceModel> matches, int totalGames,
            int startIndex, int endIndex)
        {
            MatchReferences = matches;
            TotalGames = totalGames;
            StartIndex = startIndex;
            EndIndex = endIndex;
        }
        public List<MatchReferenceModel> MatchReferences { get; set; }
        public int TotalGames { get; set; }
        public int StartIndex { get; set; }
        public int EndIndex { get; set; }
        public long MostRecentMatchId => MatchReferences[0].GameId;
    }
}
