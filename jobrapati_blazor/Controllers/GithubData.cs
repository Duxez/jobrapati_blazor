using jobrapati_blazor.Models;
using jobrapati_blazor.Pages;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jobrapati_blazor.Controllers
{
    public class GithubData
    {
        public List<Repository> repositories;
        public async Task GetRepositoriesAsync()
        {
            GithubClient client = new GithubClient();
            repositories = await client.GetReposWithoutForks();
        }
    }
}
