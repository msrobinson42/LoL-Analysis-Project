using ContractsLib.Contracts.SummonerDtos;
using ContractsLib.Models;
using ContractsLib.Models.SummonerModels;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClientsLib
{
    /// <summary>
    /// The client used to retrieve a Summoner object from Riot's API.
    /// </summary>
    public class SummonerClient
    {
        // fields
        private readonly HttpClient _httpClient;
        private readonly string _name = "";
        private readonly IUriFactory _uriFactory;

        // constructors
        public SummonerClient(string name, IUriFactory uriFactory, HttpClient httpClient)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Summoner name cannot be null, empty, or white space.", nameof(name));
            }

            _name = name;
            _uriFactory = uriFactory ?? throw new ArgumentNullException(nameof(_uriFactory));
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        /// <summary>
        /// GETs a Summoner object from Riot's API and deserializes it into a SummonerModel object.
        /// </summary>
        /// <returns>Returns a SummonerModel object.</returns>
        public async Task<SummonerModel> GetSummonerModelAsync()
        {
            var uri = GetUriFromSummonerName();

            var json = await _httpClient.GetStringAsync(uri).ConfigureAwait(false);
            var contract = JsonConvert.DeserializeObject<SummonerDto>(json);

            return contract.ToSummonerModel();

            #region Local Methods
            Uri GetUriFromSummonerName()
            {
                // If API Path changes, modify string below.

                return _uriFactory
                                .AddSegments($"/lol/summoner/v4/summoners/by-name/{_name}")
                                .Create();
            }
            #endregion        }
        }
    }
}
