using System;
using Shared;
namespace ConsoleSearch.Service
{
    public class SearchFactory
    {
        public static ISearchLogic GetSearchLogic() {
            return new SearchProxy();
        }
    }
}

