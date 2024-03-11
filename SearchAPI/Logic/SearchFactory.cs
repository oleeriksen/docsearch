using System;
using Shared;
namespace SearchAPI.Logic
{
    public class SearchFactory
    {

        public static ISearchLogic GetSearchLogic()
        {
            return new SearchLogic(new Database());
        }
    }
}

