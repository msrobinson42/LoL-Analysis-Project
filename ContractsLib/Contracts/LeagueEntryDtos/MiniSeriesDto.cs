using ContractsLib.Models;
using ContractsLib.Models.LeagueEntryModels;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ContractsLib.Contracts.LeagueEntryDtos
{
    [DataContract]
    public class MiniSeriesDto
    {
        [DataMember]
        public int Target { get; set; }

        [DataMember]
        public int Wins { get; set; }

        [DataMember]
        public int Losses { get; set; }

        [DataMember]
        public string Progress { get; set; }
    }

    public static class MiniseriesExtensions
    {
        public static MiniSeriesModel ToMiniseriesModel(this MiniSeriesDto @this)
        {
            if (@this is null)
            {
                return MiniSeriesModel.Empty;
            }

            return new MiniSeriesModel(@this.Target, @this.Wins, @this.Losses, @this.Progress);
        }
    }
}
