using System;
using System.Collections.Generic;
using System.Text;

namespace ContractsLib.Models.MatchModels
{
    public class ParticipantTimelineModel
    {
        public int ParticipantId { get; set; }
        public Dictionary<string, double> CsDiffPerMinDeltas { get; set; }
        public Dictionary<string, double> DamageTakenPerMinDeltas { get; set; }
        public string Role { get; set; }
        public Dictionary<string, double> DamageTakenDiffPerMinDeltas { get; set; }
        public Dictionary<string, double> XpPerMinDeltas { get; set; }
        public Dictionary<string, double> XpDiffPerMinDeltas { get; set; }
        public string Lane { get; set; }
        public Dictionary<string, double> CreepsPerMinDeltas { get; set; }
        public Dictionary<string, double> GoldPerMinDeltas { get; set; }

        public ParticipantTimelineModel(
            int participantId, Dictionary<string, double> csDiffPerMinDeltas,
            Dictionary<string, double> damageTakenPerMinDeltas, string role,
            Dictionary<string, double> damageTakenDiffPerMinDeltas, Dictionary<string, double> xpPerMinDeltas,
            Dictionary<string, double> xpDiffPerMinDeltas, string lane, Dictionary<string, double> creepsPerMinDeltas,
            Dictionary<string, double> goldPerMinDeltas)
        {
            if (string.IsNullOrEmpty(role))
            {
                throw new ArgumentException("message", nameof(role));
            }

            if (string.IsNullOrEmpty(lane))
            {
                throw new ArgumentException("message", nameof(lane));
            }

            ParticipantId = participantId;
            CsDiffPerMinDeltas = csDiffPerMinDeltas ?? throw new ArgumentNullException(nameof(csDiffPerMinDeltas));
            DamageTakenPerMinDeltas = damageTakenPerMinDeltas ?? throw new ArgumentNullException(nameof(damageTakenPerMinDeltas));
            Role = role;
            DamageTakenDiffPerMinDeltas = damageTakenDiffPerMinDeltas ?? throw new ArgumentNullException(nameof(damageTakenDiffPerMinDeltas));
            XpPerMinDeltas = xpPerMinDeltas ?? throw new ArgumentNullException(nameof(xpPerMinDeltas));
            XpDiffPerMinDeltas = xpDiffPerMinDeltas ?? throw new ArgumentNullException(nameof(xpDiffPerMinDeltas));
            Lane = lane;
            CreepsPerMinDeltas = creepsPerMinDeltas ?? throw new ArgumentNullException(nameof(creepsPerMinDeltas));
            GoldPerMinDeltas = goldPerMinDeltas ?? throw new ArgumentNullException(nameof(goldPerMinDeltas));
        }
    }
}
