using Shared;
namespace Renamer;

class Program
{
    static void Main(string[] args)
    {
        RenameCrawler renamer = new RenameCrawler();
        renamer.Crawl(new DirectoryInfo(Paths.FOLDER));
        Console.WriteLine("Done with");
        Console.WriteLine("Folders: " + renamer.CountFolders);
        Console.WriteLine("Files:   " + renamer.CountFiles);
    }
}


