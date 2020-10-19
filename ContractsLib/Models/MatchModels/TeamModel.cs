using System;
using System.Collections.Generic;
using System.Text;

namespace ContractsLib.Models.MatchModels
{
    public class TeamModel
    {
        // class properties
        public List<BanModel> Bans { get; set; }

        // team general properties
        public string TeamName { get; }
        public string Win { get; }
        public bool FirstBlood { get; }

        // tower properties
        public bool FirstTower { get; }
        public int TowerKills { get; }

        // inhib properties
        public bool FirstInhibitor { get; }
        public int InhibitorKills { get; }

        // baron properties
        public bool FirstBaron { get; }
        public int BaronKills { get; }

        // dragon properties
        public bool FirstDragon { get; }
        public int DragonKills { get; }

        // herald properties
        public bool FirstRiftHerald { get; }
        public int RiftHeraldKills { get; }

        public TeamModel(List<BanModel> bans, int teamId, string win, bool firstBlood,
                bool firstTower, int towerKills, bool firstInhibitor, int inhibitorKills,
                bool firstBaron, int baronKills, bool firstDragon, int dragonKills,
                bool firstRiftHerald, int riftHeraldKills)
        {
            this.TeamName = teamId == 100 ? "Blue Team" : "Red Team";
            this.Bans = bans;
            //this.teamId = teamId;
            Win = win;
            FirstBlood = firstBlood;
            FirstTower = firstTower;
            TowerKills = towerKills;
            FirstInhibitor = firstInhibitor;
            InhibitorKills = inhibitorKills;
            FirstBaron = firstBaron;
            BaronKills = baronKills;
            FirstDragon = firstDragon;
            DragonKills = dragonKills;
            FirstRiftHerald = firstRiftHerald;
            RiftHeraldKills = riftHeraldKills;
        }
    }
}
