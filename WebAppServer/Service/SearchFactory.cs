using System;
using Shared;
namespace WebAppServer.Service
{
    public class SearchFactory
    {
        public static ISearchLogic GetSearchLogic() {
            return new SearchProxy();
        }
    }
}

