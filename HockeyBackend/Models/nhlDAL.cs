
using RestSharp;
namespace HockeyBackend.Models
{
    public class nhlDAL
    {
        public Team GetTeam(int id)
        {
            RestClient client = new RestClient($"https://statsapi.web.nhl.com/api/v1/teams/{id}/");
            RestRequest request = new RestRequest();
            Task<Team> response = client.GetAsync<Team>(request);

            return response.Result;
        }

        public List<Team> getAllTeams()
        {
            RestClient client = new RestClient($"https://statsapi.web.nhl.com/api/v1/teams/");
            RestRequest request = new RestRequest();
            Task<List<Team>> response = client.GetAsync<List<Team>>(request);

            return response.Result;
        }

        public Player GetPlayer(int id)
        {
            RestClient client = new RestClient($"https://statsapi.web.nhl.com/api/v1/people/{id}");
            RestRequest request = new RestRequest();
            Task<Player> response = client.GetAsync<Player>(request);
            return response.Result;
        }

        public Stat GetStatsBySeason(int id, int season)
        {
            RestClient client = new RestClient($"https://statsapi.web.nhl.com/api/v1/people/{id}/stats?stats=statsSingleSeason&season={season}");
            RestRequest request = new RestRequest();
            Task<Stat> response = client.GetAsync<Stat>(request);

            return response.Result;
        }
    }
}
