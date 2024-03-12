using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shared;

namespace SearchAPI.Controllers
{
    [ApiController]
    [Route("api/search")]
    public class SearchController : ControllerBase
    {

        [HttpGet]
        [Route("{query}/{maxAmount}")]
        public SearchResult Search(string query, int maxAmount)
        {
            var logic = SearchAPI.Logic.SearchFactory.GetSearchLogic();
            return logic.Search(query.Split(","), maxAmount);
            
        }
    }
}

