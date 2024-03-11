using System;
namespace Shared
{
    public class SearchFactory
    {

        public static ISearchLogic GetSearchLogic()
        {
            return new SearchLogic(new Database());
        }
    }
}

