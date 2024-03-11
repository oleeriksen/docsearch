using System;
using System.Text.Json;
using Shared;
using static System.Net.WebRequestMethods;

namespace WebAppServer.Service
{
    public class SearchProxy : ISearchLogic
    {
        private string serverEndPoint = "https://localhost:7132/api/search/";

        private HttpClient mHttp;

        public SearchProxy()
        {
            mHttp = new System.Net.Http.HttpClient();
        }

        public SearchResult Search(string[] query, int maxAmount)
        {
            var task = mHttp.GetFromJsonAsync<SearchResult>($"{serverEndPoint}{String.Join(",", query)}/{maxAmount}");
            //var resultStr = response.Content.ReadAsStringAsync().Result;
            var res = task.Result;
            //result = JsonSerializer.Deserialize<SearchResult>(resultStr);
            return res;
        }
    }
}

