using System;
using System.Collections.Generic;
using System.Text;

namespace ContractsLib.Models.MatchListModels
{
    public class MatchReferenceModel
    {
        public MatchReferenceModel(string lane, long gameId, int champion, string platformId,
            long timestamp, int queue, string role, int season)
        {
            Lane = lane;
            GameId = gameId;
            Champion = champion;
            PlatformId = platformId;
            Timestamp = timestamp;
            Queue = queue;
            Role = role;
            Season = season;
        }

        public string Lane { get; set; }
        public long GameId { get; set; }
        public int Champion { get; set; }
        public string PlatformId { get; set; }
        public long Timestamp { get; set; }
        public int Queue { get; set; }
        public string QueueName => Enum.GetName(typeof(QueueTypes), Queue);
        public string Role { get; set; }
        public int Season { get; set; }

    }
}
