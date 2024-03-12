using System;
using Shared;
namespace Shared
{
    public class SearchFactory
    {
        public static ISearchLogic GetProxy() {
            return new SearchProxy();
        }
    }
}

