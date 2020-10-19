using System;
using System.Collections.Generic;
using System.Text;

namespace ContractsLib.Models.TimelineModels
{
    public class MatchTimelineModel
    {
        public MatchTimelineModel(IEnumerable<MatchFrameModel> frames, long frameInterval)
        {
            Frames = frames ?? throw new ArgumentNullException(nameof(frames));
            FrameInterval = frameInterval;
        }

        public IEnumerable<MatchFrameModel> Frames { get; }
        public long FrameInterval { get; }
    }
}
