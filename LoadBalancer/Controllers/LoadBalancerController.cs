using System;
using Microsoft.AspNetCore.Mvc;

namespace LoadBalancer.Controllers
{
    [ApiController]
    [Route("api/search")]
    public class LoadBalancerController : ControllerBase
    {
        private static readonly string[] _servers = {
                                             "https://localhost:7132/api/search",
                                             "https://localhost:7133/api/search" };

        private static int next = 0;

        [HttpGet]
        [Route("{query}/{maxAmount}")]
        public string Get(string query, int maxAmount)
        {

            string server = $"{_servers[next]}/{query}/{maxAmount}";
            next = (next + 1) % _servers.Length;

            Response.Redirect(server);
            return "";
        }

        [HttpGet]
        [Route("ping")]
        public string? Ping()
        {
            return Environment.GetEnvironmentVariable("id");
        }
    }
}

