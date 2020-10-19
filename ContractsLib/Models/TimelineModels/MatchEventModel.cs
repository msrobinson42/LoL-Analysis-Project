using System.Collections.Generic;

namespace ContractsLib.Models.TimelineModels
{
    public class MatchEventModel
    {
        public MatchEventModel
            (string laneType,
             int skillSlot,
             int creatorId,
             int afterId,
             string eventType,
             string type,
             string levelUptype,
             string wardType,
             int participantId,
             string towerType,
             int itemId,
             int beforeId,
             string monsterType,
             int teamId,
             MatchPositionModel position,
             int killerId,
             long timestamp,
             List<int> assistingParticipantIds,
             string buildingType,
             int victimId)
        {
            #region string null checks (currently inactive)
            //if (string.IsNullOrEmpty(laneType))
            //{
            //    throw new System.ArgumentException("message", nameof(laneType));
            //}

            //if (string.IsNullOrEmpty(eventType))
            //{
            //    throw new System.ArgumentException("message", nameof(eventType));
            //}

            //if (string.IsNullOrEmpty(type))
            //{
            //    throw new System.ArgumentException("message", nameof(type));
            //}

            //if (string.IsNullOrEmpty(levelUptype))
            //{
            //    throw new System.ArgumentException("message", nameof(levelUptype));
            //}

            //if (string.IsNullOrEmpty(wardType))
            //{
            //    throw new System.ArgumentException("message", nameof(wardType));
            //}

            //if (string.IsNullOrEmpty(towerType))
            //{
            //    throw new System.ArgumentException("message", nameof(towerType));
            //}

            //if (string.IsNullOrEmpty(monsterType))
            //{
            //    throw new System.ArgumentException("message", nameof(monsterType));
            //}

            //if (string.IsNullOrEmpty(buildingType))
            //{
            //    throw new System.ArgumentException("message", nameof(buildingType));
            //} 
            #endregion

            LaneType = laneType;
            SkillSlot = skillSlot;
            CreatorId = creatorId;
            AfterId = afterId;
            EventType = eventType;
            Type = type;
            LevelUptype = levelUptype;
            WardType = wardType;
            ParticipantId = participantId;
            TowerType = towerType;
            ItemId = itemId;
            BeforeId = beforeId;
            MonsterType = monsterType;
            TeamId = teamId;
            Position = position;
            KillerId = killerId;
            Timestamp = timestamp;
            AssistingParticipantIds = assistingParticipantIds;
            BuildingType = buildingType;
            VictimId = victimId;
        }

        public string LaneType { get; }
        public int SkillSlot { get; }
        public int CreatorId { get; }
        public int AfterId { get; }
        public string EventType { get; }
        public string Type { get; }
        public string LevelUptype { get; }
        public string WardType { get; }
        public int ParticipantId { get; }
        public string TowerType { get; }
        public int ItemId { get; }
        public int BeforeId { get; }
        public string MonsterType { get; }
        public int TeamId { get; }
        public MatchPositionModel Position { get; }
        public int KillerId { get; }
        public long Timestamp { get; }
        public List<int> AssistingParticipantIds { get; }
        public string BuildingType { get; }
        public int VictimId { get; }
    }
}