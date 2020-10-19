using ContractsLib.Contracts.DataDragon;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClientsLib
{
    public class DataDragonClient
    {
        private readonly Task<string> _versionNumber;
        private readonly Uri _versionUri;
        private readonly HttpClient _client;

        public DataDragonClient(HttpClient client)
        {
            _client = client;
            _versionUri = new Uri("https://ddragon.leagueoflegends.com/api/versions.json");

            _versionNumber = GetCurrentVersionAsync();
        }

        private async Task<string> GetCurrentVersionAsync()
        {
            var json = await _client.GetStringAsync(_versionUri).ConfigureAwait(false);
            var versions = JsonConvert.DeserializeObject<string[]>(json);

            return versions.First();
        }

        public async Task<Data> GetChampionsAsync()
        {
            var versionNumber = await _versionNumber.ConfigureAwait(false);

            var championsUri = new Uri($"https://ddragon.leagueoflegends.com/cdn/{versionNumber}/data/en_US/champion.json");

            var json = await _client.GetStringAsync(championsUri).ConfigureAwait(false);
            var champions = JsonConvert.DeserializeObject<Data>(json);

            return champions;
        }
    }
}
