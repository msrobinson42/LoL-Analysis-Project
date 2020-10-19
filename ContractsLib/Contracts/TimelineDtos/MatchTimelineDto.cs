using ContractsLib.Models.TimelineModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ContractsLib.Contracts.TimelineDtos
{
    [DataContract]
    public class MatchTimelineDto
    {
        [DataMember]
        public IEnumerable<MatchFrameDto> Frames { get; set; }

        [DataMember]
        public long FrameInterval { get; set; }

    }

    public static class MatchTimelineDtoExtensions
    {
        public static MatchTimelineModel ToMatchTimelineModel(this MatchTimelineDto @this)
        {
            if (@this is null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            var frameModels = @this.Frames
                .Select(f => f.ToMatchFrameModel())
                .ToList();

            return new MatchTimelineModel(frameModels, @this.FrameInterval);
        }
    }
}
