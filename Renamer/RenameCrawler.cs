namespace Renamer
{
    public class RenameCrawler
    {
        private Crawler c;

        private DirectoryInfo dir;

        public RenameCrawler(DirectoryInfo dir)
        {
            c = new Crawler();
            this.dir = dir;
        }


        void RenameFile(FileInfo f)
        {
            Console.WriteLine($"Behandler {f.FullName}");

            if (f.FullName.EndsWith(".txt")) return;

            if (f.Name.StartsWith('.')) return;

            

            var ending = f.FullName.EndsWith(".") ? "txt" : ".txt";

            File.Move(f.FullName, f.FullName + ending, true);

            CountFiles++;
        }

        public void Crawl() {
            c.Crawl(dir, RenameFile);
        }

        public int CountFiles { get; private set; }

        public int CountFolders => c.CountFolders;


    }
}

