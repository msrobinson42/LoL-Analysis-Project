using ContractsLib.Models;
using ContractsLib.Models.MatchListModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ContractsLib.Contracts.MatchListDtos
{
    [DataContract]
    public class MatchListDto
    {
        [DataMember]
        public List<MatchReferenceDto> Matches { get; set; }

        [DataMember]
        public int TotalGames { get; set; }

        [DataMember]
        public int StartIndex { get; set; }

        [DataMember]
        public int EndIndex { get; set; }
    }

    public static class MatchListExtensions
    {
        public static MatchListModel ToMatchListModel(this MatchListDto @this)
        {
            if (@this is null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            List<MatchReferenceModel> matchModels = @this.Matches
                .Select<MatchReferenceDto, MatchReferenceModel>(m => m.ToMatchReferenceModel())
                .ToList();

            return new MatchListModel(matchModels, @this.TotalGames, @this.StartIndex, @this.EndIndex);
        }
    }
}
