using Shared;
namespace Renamer;

class Program
{
    static void Main(string[] args)
    {
        RenameCrawler renamer = new RenameCrawler(new DirectoryInfo(Paths.FOLDER));
        renamer.Crawl();
        Console.WriteLine("Done with");
        Console.WriteLine("Folders: " + renamer.CountFolders);
        Console.WriteLine("Files:   " + renamer.CountFiles);
    }
}


