using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using Shared;
using static System.Net.WebRequestMethods;

namespace Core
{
    public class SearchProxy : ISearchLogic
    {
        private string serverEndPoint = "https://localhost:7271/api/search/";

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

