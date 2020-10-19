using ContractsLib.Models.TimelineModels;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace ContractsLib.Contracts.TimelineDtos
{
    [DataContract]
    public class MatchFrameDto
    {
        [DataMember]
        public Dictionary<string, MatchParticipantFrameDto> ParticipantFrames { get; set; }

        [DataMember]
        public List<MatchEventDto> Events { get; set; }

        [DataMember]
        public long TimeStamp { get; set; }
    }

    public static class MatchFrameDtoExtensions
    {
        public static MatchFrameModel ToMatchFrameModel(this MatchFrameDto @this)
        {
            if (@this is null)
            {
                throw new System.ArgumentNullException(nameof(@this));
            }

            var matchEventModels = @this.Events
                .Select(m => m.ToMatchEventModel())
                .ToList();

            var participantFrameModels = @this.ParticipantFrames
                .ToDictionary(p => p.Key, p => p.Value.ToMatchParticipantFrameModel());


            return new MatchFrameModel(participantFrameModels, matchEventModels, @this.TimeStamp);
        }
    }
}