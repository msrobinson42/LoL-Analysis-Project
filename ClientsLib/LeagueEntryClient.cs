using ContractsLib.Contracts.LeagueEntryDtos;
using ContractsLib.Models.LeagueEntryModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClientsLib
{
    /// <summary>
    /// The client used to retrieve a LeagueEntry object from Riot's API.
    /// </summary>
    public class LeagueEntryClient
    {
        // fields
        private readonly IUriFactory _uriFactory;
        private readonly HttpClient _httpClient;
        private readonly string _encryptedSummonerId;

        // constructors
        public LeagueEntryClient(string encryptedSummonerId, IUriFactory uriFactory, HttpClient httpClient)
        {
            if (string.IsNullOrEmpty(encryptedSummonerId))
            {
                throw new ArgumentException("message", nameof(encryptedSummonerId));
            }

            _encryptedSummonerId = encryptedSummonerId;
            _uriFactory = uriFactory ?? throw new ArgumentNullException(nameof(uriFactory));
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        /// <summary>
        /// GETs a List of LeagueEntry objects from Riot's API and then deserializes it into a List of LeagueEntryModel objects.
        /// </summary>
        /// <returns>Returns a List of LeagueEntryModel objects.</returns>
        public async Task<List<LeagueEntryModel>> GetLeagueEntryModelsAsync()
        {
            var uri = GetUriFromEncryptedSummonerId();

            var json = await _httpClient.GetStringAsync(uri).ConfigureAwait(false);
            var contracts = JsonConvert.DeserializeObject<List<LeagueEntryDto>>(json);
            var entryModels = new List<LeagueEntryModel>();

            foreach (var contract in contracts)
                entryModels.Add(contract.ToLeagueEntryModel());

            return entryModels;

            #region Local Methods
            Uri GetUriFromEncryptedSummonerId()
            {
                // If API Path changes, modify string below.

                return _uriFactory
                                .AddSegments($"/lol/league/v4/entries/by-summoner/{_encryptedSummonerId}")
                                .Create();
            } 
            #endregion
        }


    }
}
