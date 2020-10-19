using ContractsLib.Models;
using ContractsLib.Models.MatchModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ContractsLib.Contracts.MatchDtos
{
    [DataContract]
    public class TeamStatsDto
    {
        // class properties
        [DataMember]
        public List<TeamBansDto> Bans { get; set; }

        // team general properties
        [DataMember]
        public int TeamId { get; set; }         // team 100 = blue; team 200 = red/purple

        [DataMember]
        public string Win { get; set; }

        [DataMember]
        public bool FirstBlood { get; set; }

        // tower properties
        [DataMember]
        public bool FirstTower { get; set; }

        [DataMember]
        public int TowerKills { get; set; }

        // inhib properties
        [DataMember]
        public bool FirstInhibitor { get; set; }

        [DataMember]
        public int InhibitorKills { get; set; }

        // baron properties
        [DataMember]
        public bool FirstBaron { get; set; }

        [DataMember]
        public int BaronKills { get; set; }

        // dragon properties
        [DataMember]
        public bool FirstDragon { get; set; }

        [DataMember]
        public int DragonKills { get; set; }

        // herald properties
        [DataMember]
        public bool FirstRiftHerald { get; set; }

        [DataMember]
        public int RiftHeraldKills { get; set; }
    }

    public static class TeamExtensions
    {
        public static TeamModel ToTeamModel(this TeamStatsDto @this)
        {
            if (@this is null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            List<BanModel> bans = @this.Bans
                .Select<TeamBansDto, BanModel>(ban => ban.ToBanModel())
                .ToList();

            return new TeamModel(bans, @this.TeamId, @this.Win, @this.FirstBlood, @this.FirstTower,
                @this.TowerKills, @this.FirstInhibitor, @this.InhibitorKills, @this.FirstBaron,
                @this.BaronKills, @this.FirstDragon, @this.DragonKills, @this.FirstRiftHerald, @this.RiftHeraldKills);
        }
    }
}
