using ContractsLib.Models.TimelineModels;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ContractsLib.Contracts.TimelineDtos
{
    [DataContract]
    public class MatchEventDto
    {
        [DataMember]
        public string LaneType { get; set; }

        [DataMember]
        public int SkillSlot { get; set; }

        [DataMember]
        public int CreatorId { get; set; }

        [DataMember]
        public int AfterId { get; set; }

        [DataMember]
        public string EventType { get; set; }

        /*      (Legal values for Type: 
         *  	CHAMPION_KILL, WARD_PLACED, WARD_KILL, 
         *  	BUILDING_KILL, ELITE_MONSTER_KILL, ITEM_PURCHASED, 
         *  	ITEM_SOLD, ITEM_DESTROYED, ITEM_UNDO, SKILL_LEVEL_UP, 
         *  	ASCENDED_EVENT, CAPTURE_POINT, PORO_KING_SUMMON) 
         */
        [DataMember]
        public string Type { get; set; }

        [DataMember]
        public string LevelUpType { get; set; }

        [DataMember]
        public string WardType { get; set; }

        [DataMember]
        public int ParticipantId { get; set; }

        [DataMember]
        public string TowerType { get; set; }

        [DataMember]
        public int ItemId { get; set; }

        [DataMember]
        public int BeforeId { get; set; }

        [DataMember]
        public string MonsterType { get; set; }

        [DataMember]
        public string MonsterSubType { get; set; }

        [DataMember]
        public int TeamId { get; set; }

        [DataMember]
        public MatchPositionDto Position { get; set; }

        [DataMember]
        public int KillerId { get; set; }

        [DataMember]
        public long Timestamp { get; set; }

        [DataMember]
        public List<int> AssistingParticipantIds { get; set; }

        [DataMember]
        public string BuildingType { get; set; }

        [DataMember]
        public int VictimId { get; set; }

    }

    public static class MatchEventDtoExtensions
    {
        public static MatchEventModel ToMatchEventModel(this MatchEventDto @this)
        {
            if (@this is null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            var positionModel = @this.Position.ToMatchPositionModel();

            return new MatchEventModel(@this.LaneType,
                                       @this.SkillSlot,
                                       @this.CreatorId,
                                       @this.AfterId,
                                       @this.EventType,
                                       @this.Type,
                                       @this.LevelUpType,
                                       @this.WardType,
                                       @this.ParticipantId,
                                       @this.TowerType,
                                       @this.ItemId,
                                       @this.BeforeId,
                                       @this.MonsterType,
                                       @this.TeamId,
                                       positionModel,
                                       @this.KillerId,
                                       @this.Timestamp,
                                       @this.AssistingParticipantIds,
                                       @this.BuildingType,
                                       @this.VictimId);
        }
    }
}
 