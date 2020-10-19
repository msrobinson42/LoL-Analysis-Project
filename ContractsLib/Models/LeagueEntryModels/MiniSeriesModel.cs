using System;
using System.Collections.Generic;
using System.Text;

namespace ContractsLib.Models.LeagueEntryModels
{
    public class MiniSeriesModel
    {
        public static MiniSeriesModel Empty { get; } = new MiniSeriesModel();

        public MiniSeriesModel(int target, int wins, int losses, string progress)
        {
            Target = target;
            Wins = wins;
            Losses = losses;
            Progress = progress;
        }

        private MiniSeriesModel()
            : this(-1, 0, 0, "Not currently in a promotional series.")
        {

        }

        public int Target { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public string Progress { get; set; }
    }
}
