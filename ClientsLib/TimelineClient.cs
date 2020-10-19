using ContractsLib.Contracts.TimelineDtos;
using ContractsLib.Models.TimelineModels;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClientsLib
{
    public class TimelineClient //: IClient<MatchTimelineModel>
    {
        private readonly long _matchId;
        private readonly HttpClient _httpClient;
        private readonly IUriFactory _uriFactory;

        public TimelineClient(long matchId, HttpClient httpClient, IUriFactory uriFactory)
        {
            _matchId = matchId;
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            _uriFactory = uriFactory ?? throw new ArgumentNullException(nameof(uriFactory));
        }

        private async Task<MatchTimelineDto> GetMatchTimelineDtoAsync()
        {
            Uri uri = GetUriFromMatchId();

            var json = await _httpClient.GetStringAsync(uri).ConfigureAwait(false);

            return JsonConvert.DeserializeObject<MatchTimelineDto>(json);

            Uri GetUriFromMatchId()
            {
                return _uriFactory
                    .AddSegments($"/lol/match/v4/timelines/by-match/{_matchId}")
                    .Create();
            }
        }

        public async Task<MatchTimelineModel> GetMatchTimelineModelAsync()
        {
            var contract = await GetMatchTimelineDtoAsync();

            return contract.ToMatchTimelineModel();
        }

        //public async Task<MatchTimelineModel> GetModel()
        //{
        //    var contract = await GetMatchTimelineDtoAsync();

        //    return contract.ToMatchTimelineModel();
        //}
    }
}
