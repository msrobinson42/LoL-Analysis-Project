using ContractsLib.Models;
using ContractsLib.Models.MatchModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContractsLib.Contracts.MatchDtos
{
    public class ParticipantStatsDto
    {
        // Stats for a particular player

        // player identifier properties
        public int ParticipantId { get; set; }

        #region item prop
        // player item properties
        public int Item0 { get; set; }
        public int Item1 { get; set; }
        public int Item2 { get; set; }
        public int Item3 { get; set; }
        public int Item4 { get; set; }
        public int Item5 { get; set; }
        public int Item6 { get; set; }
        #endregion

        #region general
        // player general stats
        public bool Win { get; set; }
        public int Deaths { get; set; }
        public int Assists { get; set; }
        public int ChampLevel { get; set; }
        #endregion

        #region kills
        // player kill stats
        public int Kills { get; set; }
        public int DoubleKills { get; set; }
        public int TripleKills { get; set; }
        public int QuadraKills { get; set; }
        public int PentaKills { get; set; }
        public int UnrealKills { get; set; }
        public int LargestKillingSpree { get; set; }
        public int LargestMultiKill { get; set; }
        public int KillingSprees { get; set; }
        #endregion

        #region defensive
        // player defensive stats
        public int LongestTimeSpentLiving { get; set; }
        public int TotalDamageTaken { get; set; }
        public int PhysicalDamageTaken { get; set; }
        public int MagicalDamageTaken { get; set; }
        public int TrueDamageTaken { get; set; }
        #endregion

        #region damage
        // player damage stats
        public int TotalDamageDealt { get; set; }
        public int PhysicalDamageDealt { get; set; }
        public int MagicDamageDealt { get; set; }
        public int TrueDamageDealt { get; set; }
        public int LargestCriticalStrike { get; set; }
        public int TotalDamageDealtToChampions { get; set; }
        public int PhysicalDamageDealtToChampions { get; set; }
        public int MagicDamageDealtToChampions { get; set; }
        public int TrueDamageDealtToChampions { get; set; }
        #endregion

        #region healing/shielding
        // player healing/shield stats
        public int TotalHeal { get; set; }
        public int TotalUnitsHealed { get; set; }
        public int DamageSelfMitigated { get; set; }
        #endregion

        #region objectives
        // player objective stats
        public int DamageDealtToObjectives { get; set; }
        public int DamageDealtToTurrets { get; set; }
        public int TurretKills { get; set; }
        public int InhibitorKills { get; set; }
        #endregion

        #region vision score
        // player vision score
        public int VisionScore { get; set; }
        public int VisionWardsBoughtInGame { get; set; }
        public int SightWardsBoughtInGame { get; set; }
        public int WardsPlaced { get; set; }
        public int WardsKilled { get; set; }
        #endregion

        #region utility
        // player utility score
        public int TimeCCingOthers { get; set; }
        public int TotalTimeCrowdControlDealt { get; set; }
        #endregion

        #region economy
        // player economy score
        public int GoldEarned { get; set; }
        public int GoldSpent { get; set; }
        #endregion

        #region creep score
        // player creep score
        public int TotalMinionsKilled { get; set; }
        public int NeutralMinionsKilled { get; set; }
        public int NeutralMinionsKilledTeamJungle { get; set; }
        public int NeutralMinionsKilledEnemyJungle { get; set; }
        #endregion

        #region 'first of' properties
        // player first of properties
        public bool FirstBloodKill { get; set; }
        public bool FirstBloodAssist { get; set; }
        public bool FirstTowerKill { get; set; }
        public bool FirstTowerAssist { get; set; }
        public bool FirstInhibitorKill { get; set; }
        public bool FirstInhibitorAssist { get; set; }
        #endregion

        #region player scores
        // player score properties
        public int CombatPlayerScore { get; set; }
        public int ObjectivePlayerScore { get; set; }
        public int TotalPlayerScore { get; set; }
        public int TotalScoreRank { get; set; }
        public int PlayerScore0 { get; set; }
        public int PlayerScore1 { get; set; }
        public int PlayerScore2 { get; set; }
        public int PlayerScore3 { get; set; }
        public int PlayerScore4 { get; set; }
        public int PlayerScore5 { get; set; }
        public int PlayerScore6 { get; set; }
        public int PlayerScore7 { get; set; }
        public int PlayerScore8 { get; set; }
        public int PlayerScore9 { get; set; }
        #endregion

        #region player perks/runes
        // player perk properties
        public int Perk0 { get; set; }
        public int Perk0Var1 { get; set; }
        public int Perk0Var2 { get; set; }
        public int Perk0Var3 { get; set; }
        public int Perk1 { get; set; }
        public int Perk1Var1 { get; set; }
        public int Perk1Var2 { get; set; }
        public int Perk1Var3 { get; set; }
        public int Perk2 { get; set; }
        public int Perk2Var1 { get; set; }
        public int Perk2Var2 { get; set; }
        public int Perk2Var3 { get; set; }
        public int Perk3 { get; set; }
        public int Perk3Var1 { get; set; }
        public int Perk3Var2 { get; set; }
        public int Perk3Var3 { get; set; }
        public int Perk4 { get; set; }
        public int Perk4Var1 { get; set; }
        public int Perk4Var2 { get; set; }
        public int Perk4Var3 { get; set; }
        public int Perk5 { get; set; }
        public int Perk5Var1 { get; set; }
        public int Perk5Var2 { get; set; }
        public int Perk5Var3 { get; set; }
        public int PerkPrimaryStyle { get; set; }
        public int PerkSubStyle { get; set; }
        public int StatPerk0 { get; set; }
        public int StatPerk1 { get; set; }
        public int StatPerk2 { get; set; }
        #endregion
    }

    public static class StatsExtensions
    {
        public static ParticipantStatsModel ToStatsModel(this ParticipantStatsDto @this)
        {
            if (@this is null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            return new ParticipantStatsModel(@this.ParticipantId, @this.Item0, @this.Item1, @this.Item2, @this.Item3, @this.Item4,
                @this.Item5, @this.Item6, @this.Win, @this.Deaths, @this.Assists, @this.ChampLevel, @this.Kills,
                @this.DoubleKills, @this.TripleKills, @this.QuadraKills, @this.PentaKills, @this.UnrealKills, @this.LargestKillingSpree,
                @this.LargestMultiKill, @this.KillingSprees, @this.LongestTimeSpentLiving, @this.TotalDamageTaken, @this.PhysicalDamageTaken,
                @this.MagicalDamageTaken, @this.TrueDamageTaken, @this.TotalDamageDealt, @this.PhysicalDamageDealt, @this.MagicDamageDealt,
                @this.TrueDamageDealt, @this.LargestCriticalStrike, @this.TotalDamageDealtToChampions, @this.PhysicalDamageDealtToChampions,
                @this.MagicDamageDealtToChampions, @this.TrueDamageDealtToChampions, @this.TotalHeal, @this.TotalUnitsHealed, @this.DamageSelfMitigated,
                @this.DamageDealtToObjectives, @this.DamageDealtToTurrets, @this.TurretKills, @this.InhibitorKills, @this.VisionScore,
                @this.VisionWardsBoughtInGame, @this.SightWardsBoughtInGame, @this.WardsPlaced,
                @this.VisionWardsBoughtInGame, @this.SightWardsBoughtInGame, @this.WardsPlaced, @this.GoldEarned,
                @this.GoldSpent, @this.TotalMinionsKilled, @this.NeutralMinionsKilled, @this.NeutralMinionsKilledTeamJungle,
                @this.NeutralMinionsKilledEnemyJungle, @this.FirstBloodKill, @this.FirstBloodAssist, @this.FirstTowerKill,
                @this.FirstTowerAssist, @this.FirstInhibitorKill, @this.FirstInhibitorAssist, @this.CombatPlayerScore,
                @this.ObjectivePlayerScore, @this.TotalPlayerScore, @this.TotalScoreRank, @this.PlayerScore0, @this.PlayerScore1,
                @this.PlayerScore2, @this.PlayerScore3, @this.PlayerScore4, @this.PlayerScore5, @this.PlayerScore6,
                @this.PlayerScore7, @this.PlayerScore8, @this.PlayerScore9, @this.Perk0, @this.Perk0Var1, @this.Perk0Var2,
                @this.Perk0Var3, @this.Perk1, @this.Perk1Var1, @this.Perk1Var2, @this.Perk1Var3, @this.Perk2, @this.Perk2Var1,
                @this.Perk2Var2, @this.Perk2Var3, @this.Perk3, @this.Perk3Var1, @this.Perk3Var2, @this.Perk3Var3, @this.Perk4,
                @this.Perk4Var1, @this.Perk4Var2, @this.Perk4Var3, @this.Perk5, @this.Perk5Var1, @this.Perk5Var2, @this.Perk5Var3,
                @this.PerkPrimaryStyle, @this.PerkSubStyle, @this.StatPerk0, @this.StatPerk1, @this.StatPerk2);
        }
    }
}
