using System;
namespace Renamer
{
    public class Crawler
    {
        private int countFolders;

        public delegate void FileHandler(FileInfo f);


        public void Crawl(DirectoryInfo dir, FileHandler f)
        {
            Console.WriteLine("Crawling " + dir.FullName);
            
            foreach (var file in dir.EnumerateFiles())
                f(file);

            foreach (var d in dir.EnumerateDirectories())
                Crawl(d, f);

            countFolders++;
        }

        public int CountFolders => countFolders;
    }
}

