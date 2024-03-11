namespace Shared
{
    public interface ISearchLogic
    {
        SearchResult Search(string[] query, int maxAmount);
    }
}