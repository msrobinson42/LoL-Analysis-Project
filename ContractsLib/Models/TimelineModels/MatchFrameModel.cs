using System;
using System.Collections.Generic;
using System.Text;

namespace ContractsLib.Models.TimelineModels
{
    public class MatchFrameModel
    {
        public MatchFrameModel
            (Dictionary<string, MatchParticipantFrameModel> participantFrames,
            List<MatchEventModel> events, long timestamp)
        {
            ParticipantFrames = participantFrames ?? throw new ArgumentNullException(nameof(participantFrames));
            Events = events ?? throw new ArgumentNullException(nameof(events));
            Timestamp = timestamp;
        }

        public Dictionary<string, MatchParticipantFrameModel> ParticipantFrames { get; }
        public List<MatchEventModel> Events { get; }
        public long Timestamp { get; }
    }
}
