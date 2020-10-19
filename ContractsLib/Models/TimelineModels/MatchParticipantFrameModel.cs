namespace ContractsLib.Models.TimelineModels
{
    public class MatchParticipantFrameModel
    {
        public MatchParticipantFrameModel
            (int participantId, int minionsKilled, int teamScore,
            int totalGold, int level, int xp, int currentGold,
            MatchPositionModel position, int jungleMinionsKilled)
        {
            ParticipantId = participantId;
            MinionsKilled = minionsKilled;
            TeamScore = teamScore;
            TotalGold = totalGold;
            Level = level;
            Xp = xp;
            CurrentGold = currentGold;
            Position = position;
            JungleMinionsKilled = jungleMinionsKilled;
        }

        public int ParticipantId { get; }
        public int MinionsKilled { get; }
        public int TeamScore { get; }
        public int TotalGold { get; }
        public int Level { get; }
        public int Xp { get; }
        public int CurrentGold { get; }
        public MatchPositionModel Position { get; }
        public int JungleMinionsKilled { get; }
    }
}