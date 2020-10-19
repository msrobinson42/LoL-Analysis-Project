using System;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using ClientsLib;
using ViewModelsLib;

namespace ConsoleView
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var apiKey = "XXXXX-XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX";
            var uri = new Uri("https://na1.api.riotgames.com");


            #region Clients code, creates HttpClient client

            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            #endregion


            #region Get User Input

            Console.WriteLine("Please enter summoner name:");
            var summonerName =  Console.ReadLine(); 

            #endregion


            #region Get/Deserialize Json to Models

            var uriFactory = new UriFactory(uri.AbsoluteUri, apiKey);

            var summonerClient = new SummonerClient(summonerName, uriFactory, client);
            var summonerModel = await summonerClient.GetSummonerModelAsync().ConfigureAwait(false);

            var leagueEntryClient = new LeagueEntryClient(summonerModel.Id, uriFactory, client);
            var matchClient = new MatchClient(summonerModel.AccountId, uriFactory, client);

            var matchListTask = matchClient.GetMatchListModelAsync();
            var leagueEntryTask = leagueEntryClient.GetLeagueEntryModelsAsync();

            await Task.WhenAll(matchListTask, leagueEntryTask).ConfigureAwait(false);

            var matchListModel = await matchListTask.ConfigureAwait(false);

            var matchId = matchListModel.MostRecentMatchId;

            var timelineClient = new TimelineClient(matchId, client, uriFactory);


            var timelineModel = await timelineClient.GetMatchTimelineModelAsync();
            var leagueEntryModels = await leagueEntryTask.ConfigureAwait(false);
            var matchModel = await matchClient.GetMatchModelAsync(matchListModel.MostRecentMatchId).ConfigureAwait(false);
            var allMatchModels = await matchClient.GetAllMatchModelsAsync().ConfigureAwait(false);

            #endregion


            #region get datadragon information

            var dataDragonClient = new DataDragonClient(client);
            var championsDictionary = await dataDragonClient.GetChampionsAsync().ConfigureAwait(false);

            #endregion

            #region MatchHistoryViewModel test

            var matchListViewModel = new MatchHistoryViewModel(matchListModel);

            Console.WriteLine("Please enter number of matches you'd like to review.");
            var matchQty = Console.ReadLine();

            if(int.TryParse(matchQty, out int matches))
                Console.WriteLine(matchListViewModel.DisplayMatches(matches, championsDictionary));

            #endregion


            #region Display Output

            //Console.WriteLine();
            //Console.WriteLine(summonerModel.Name);
            //Console.WriteLine(matchListModel.MostRecentMatchId.ToString());
            //Console.WriteLine(matchModel.GameMode);
            //Console.WriteLine(leagueEntryModels[0].Tier);

            //Console.ReadLine(); 

            #endregion
        }
    }
}
