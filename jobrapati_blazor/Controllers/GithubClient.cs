using jobrapati_blazor.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace jobrapati_blazor.Controllers
{
    public class GithubClient
    {
        public async Task<User> GetUser()
        {
            HttpClient client = new HttpClient();
            var responseJson = await client.GetStringAsync("https://api.github.com/users/Duxez");
            return JsonConvert.DeserializeObject<User>(responseJson);
        }

        public async Task<Repository[]> GetRepositories()
        {
            HttpClient client = new HttpClient();
            var responseJson = await client.GetStringAsync("https://api.github.com/users/Duxez/repos");
            return JsonConvert.DeserializeObject<Repository[]>(responseJson);
        }

        public async Task<List<Repository>> GetReposWithoutForks()
        {
            var repos = await GetRepositories();
            List<Repository> reposWithoutForks = new List<Repository>();

            foreach(var repo in repos)
            {
                if (!repo.Fork)
                    reposWithoutForks.Add(repo);
            }

            return reposWithoutForks;
        }
    }
}
