using ContractsLib.Models.TimelineModels;
using System.Runtime.Serialization;

namespace ContractsLib.Contracts.TimelineDtos
{
    [DataContract]
    public class MatchParticipantFrameDto
    {
        [DataMember]
        public int ParticipantId { get; set; }

        [DataMember]
        public int MinionsKilled { get; set; }

        [DataMember]
        public int TeamScore { get; set; }

        [DataMember]
        public int TotalGold { get; set; }

        [DataMember]
        public int Level { get; set; }

        [DataMember]
        public int Xp { get; set; }

        [DataMember]
        public int CurrentGold { get; set; }

        [DataMember]
        public MatchPositionDto Position{ get; set; }

        [DataMember]
        public int JungleMinionsKilled { get; set; }
    }

    public static class MatchParticipantFrameDtoExtensions
    {
        public static MatchParticipantFrameModel ToMatchParticipantFrameModel(this MatchParticipantFrameDto @this)
        {
            if (@this is null)
            {
                throw new System.ArgumentNullException(nameof(@this));
            }

            var position = @this.Position.ToMatchPositionModel();

            return new MatchParticipantFrameModel(@this.ParticipantId, @this.MinionsKilled, @this.TeamScore,
                @this.TotalGold, @this.Level, @this.Xp, @this.CurrentGold, position, @this.JungleMinionsKilled);
        }
    }
}