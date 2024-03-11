using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shared;
using SearchAPI.Logic;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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
            var logic = SearchFactory.GetSearchLogic();
            return logic.Search(query.Split(","), maxAmount);
            
        }
    }
}

