using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ContractsLib.Contracts.DataDragon
{
    [DataContract]
    public partial class Stats
    {
        [DataMember(Name = "hp")]
        public float Hp { get; set; }

        [DataMember(Name = "hpperlevel")]
        public float HpPerLevel { get; set; }

        [DataMember(Name = "mp")]
        public float Mp { get; set; }

        [DataMember(Name = "mpperlevel")]
        public float MpPerLevel { get; set; }

        [DataMember(Name = "movespeed")]
        public int MoveSpeed { get; set; }

        [DataMember(Name = "armor")]
        public float Armor { get; set; }

        [DataMember(Name = "armorperlevel")]
        public float ArmorPerLevel { get; set; }

        [DataMember(Name = "spellblock")]
        public float SpellBlock { get; set; }

        [DataMember(Name = "spellblockperlevel")]
        public float SpellBlockPerLevel { get; set; }

        [DataMember(Name = "attackrange")]
        public int AttackRange { get; set; }

        [DataMember(Name = "hpregen")]
        public float HpRegen { get; set; }

        [DataMember(Name = "hpregenperlevel")]
        public float HpRegenPerLevel { get; set; }

        [DataMember(Name = "mpregen")]
        public float MpRegen { get; set; }

        [DataMember(Name = "mpregenperlevel")]
        public float MpRegenPerLevel { get; set; }

        [DataMember(Name = "crit")]
        public int Crit { get; set; }

        [DataMember(Name = "critperlevel")]
        public int CritPerLevel { get; set; }

        [DataMember(Name = "attackdamage")]
        public float AttackDamage { get; set; }

        [DataMember(Name = "attackdamageperlevel")]
        public float AttackDamagePerLevel { get; set; }

        [DataMember(Name = "attackspeedperlevel")]
        public float AttackSpeedPerLevel { get; set; }

        [DataMember(Name = "attackspeed")]
        public float AttackSpeed { get; set; }
    }
}

