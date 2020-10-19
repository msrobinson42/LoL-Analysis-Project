using System;
using System.Collections.Generic;
using System.Text;

namespace ContractsLib.Models.MatchModels
{
    public class MatchModel
    {
        // fields

        // constructor
        public MatchModel(List<TeamModel> teams, List<ParticipantModel> particModels,
            List<ParticipantIdentityModel> parIdModels, long gameId, string platformId,
            string gameType, int queueId, int mapId, int seasonId, string gameVersion,
            string gameMode, long gameCreation, int gameDuration)
        {
            Teams = teams;
            Participants = particModels;
            ParticipantIds = parIdModels;

            GameId = gameId;
            PlatformId = platformId;
            GameType = gameType;
            QueueId = queueId;
            MapId = mapId;
            SeasonId = seasonId;
            GameVersion = gameVersion;
            GameMode = gameMode;

            GameCreation = gameCreation;
            GameDuration = gameDuration;
        }

        // properties
        public List<TeamModel> Teams { get; set; }
        public List<ParticipantModel> Participants { get; set; }
        public List<ParticipantIdentityModel> ParticipantIds { get; set; }

        // game type properties
        public long GameId { get; set; }
        public string PlatformId { get; set; }
        public string GameType { get; set; }
        public int QueueId { get; set; }
        public int MapId { get; set; }
        public int SeasonId { get; set; }
        public string GameVersion { get; set; }
        public string GameMode { get; set; }

        // game time properties
        public long GameCreation { get; set; }
        public int GameDuration { get; set; }

        // methods
    }
}
