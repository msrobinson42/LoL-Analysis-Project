using ContractsLib.Contracts.MatchDtos;
using ContractsLib.Contracts.MatchListDtos;
using ContractsLib.Models;
using ContractsLib.Models.MatchListModels;
using ContractsLib.Models.MatchModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClientsLib
{
    /// <summary>
    /// The client used to retrieve a Match object from Riot's API.
    /// </summary>
    public class MatchClient
    {
        // fields
        private readonly string _encryptedAccountId;
        private readonly HttpClient _httpClient;
        private readonly IUriFactory _uriFactory;
        private MatchListDto _matchListContract;

        // constructors
        public MatchClient(string encryptedAccountId, IUriFactory uriFactory, HttpClient client)
        {
            if (string.IsNullOrEmpty(encryptedAccountId))
            {
                throw new ArgumentException("encryptedAccoundId cannot be null or empty.", nameof(encryptedAccountId));
            }

            _encryptedAccountId = encryptedAccountId;
            _uriFactory = uriFactory ?? throw new ArgumentNullException(nameof(uriFactory));
            _httpClient = client ?? throw new ArgumentNullException(nameof(client));
        }

        /// <summary>
        /// GETs a Match object from Riot's API and then deserializes it into a MatchModel object.
        /// </summary>
        /// <param name="matchId">A long that references the particular match id.</param>
        /// <returns>Returns a Task for a MatchModel object.</returns>
        public async Task<MatchModel> GetMatchModelAsync(long matchId)
        {
            var uri = GetUriFromMatchId(matchId);

            var json = await _httpClient.GetStringAsync(uri).ConfigureAwait(false);
            var contract = JsonConvert.DeserializeObject<MatchDto>(json);

            return contract.ToMatchModel();

            Uri GetUriFromMatchId(long matchId)
            {
                // If API Path changes, modify string below.

                return _uriFactory
                                .AddSegments($"/lol/match/v4/matches/{matchId}")
                                .Create();
            }
        }

        /// <summary>
        /// GETs a List of Match objects from Riot's API and then deserializes it into a List of MatchModel objects.
        /// </summary>
        /// <returns>Returns a Task for a List of MatchModel objects.</returns>
        public async Task<List<MatchModel>> GetAllMatchModelsAsync()
        {
            if (_matchListContract is null)
                throw new ArgumentNullException("_matchListContract cannot be null", nameof(_matchListContract));

            var matchModels = new List<MatchModel>();
            var tasks = _matchListContract.Matches.Select(m => GetMatchModelAsync(m.GameId));

            var result = await Task.WhenAll(tasks).ConfigureAwait(false);

            return result.ToList();
        }

        /// <summary>
        /// GETs a MatchList object from Riot's API and then deserializes it into a MatchListModel object.
        /// </summary>
        /// <param name="endIndex">Optional parameter determining how many games back to end the request. 
        /// Default is 5. Cannot be less than beginIndex parameter. 
        /// Difference between endIndex and beginIndex cannot be greater than 100.</param>
        /// <param name="beginIndex">Optional parameter determining how many games back to begin the request.
        /// Default is 0 (most recent game). Cannot be higher than endIndex parameter.
        /// Difference between beginIndex and endIndex cannot be greater than 100.</param>
        /// <param name="queueId">Optional parameter that filters games to a specific queue type.</param>
        /// <returns>Returns a Task for a MatchListModel object.</returns>
        public async Task<MatchListModel> GetMatchListModelAsync
            (int endIndex = 5, int beginIndex = 0, int? queueId = null)
        {
            var parameters = GetQueryParameters(endIndex, beginIndex, queueId);

            var uri = GetUriFromAccountIdAndParameters(parameters);

            var json = await _httpClient.GetStringAsync(uri).ConfigureAwait(false);
            var contract = JsonConvert.DeserializeObject<MatchListDto>(json);
            _matchListContract = contract;

            return contract.ToMatchListModel();

            #region Local Methods
            static KeyValuePair<string, string>[] GetQueryParameters(int endIndex, int beginIndex, int? queueId)
            {
                return new (string key, string value)[]{
                (nameof(endIndex)  , endIndex.ToString()),
                (nameof(beginIndex), beginIndex.ToString()),
                (nameof(queueId)   , queueId?.ToString())}
                            .Where(t => t.value != null)
                            .Select(t => new KeyValuePair<string, string>(t.key, t.value))
                            .ToArray();
            }

            Uri GetUriFromAccountIdAndParameters(KeyValuePair<string, string>[] parameters)
            {
                // If API Path changes, modify the string below.

                return _uriFactory
                                .AddSegments($"/lol/match/v4/matchlists/by-account/{_encryptedAccountId}")
                                .AddParameters(parameters)
                                .Create();
            } 
            #endregion
        }
    }
}
