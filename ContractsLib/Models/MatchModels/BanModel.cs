using System;
using System.Collections.Generic;
using System.Text;

namespace ContractsLib.Models.MatchModels
{
    public class BanModel
    {
        public int PickTurn { get; set; }
        public int ChampionId { get; set; }

        public BanModel(int pickTurn, int championId)
        {
            this.PickTurn = pickTurn;
            this.ChampionId = championId;
        }
    }
}
