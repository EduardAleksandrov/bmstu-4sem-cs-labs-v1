using lab_four;
internal class Program
{
    private static void Main(string[] args)
    {

        // var directoryInfo = new DirectoryInfo(@"./files");

        // foreach(FileInfo fileInfo in directoryInfo.EnumerateFiles("*", SearchOption.AllDirectories))
        // {
        //     Console.WriteLine($"{fileInfo.CreationTime} {fileInfo.FullName} ({fileInfo.Length} bytes)");
        //     // DateTime startedAt = fileInfo.CreationTime;
        //     // Console.WriteLine(startedAt);
        // }

        // IEnumerable<string> allfolders = Directory.EnumerateDirectories(directoryInfo.Name, "*", SearchOption.AllDirectories);
        // foreach (string folder in allfolders)
        // {
        //     Console.WriteLine(folder);
        // }

        string path = @"./files";
        lab_four.FileSystemWatcher file_watcher = new lab_four.FileSystemWatcher(path);
        for(;;)
        {
            Console.WriteLine("Введите цифру: 1. Добавить подписчика, 2. Удалить подписчика");
            string? x = Console.ReadLine();
            if(x == null) continue;
            int xx = 0;
            try
            {
                xx = int.Parse(x);
            } catch {
                Console.WriteLine("Ошибка в знаке");
                continue;
            }
            if(xx == 1) 
            {
                file_watcher.Notify+= PrintStruct;
            } else if(xx == 2) 
            {
                file_watcher.Notify-= PrintStruct;
            } else {
                continue;
            }
        }
        
    }

    public static void Print(string message)
    {
        Console.WriteLine(message);
    }
    public static void PrintStruct(TimeOnly tm, List<SearchedFiles> sf)
    {
        if(sf.Count == 0) Console.WriteLine("Searching...");
        for(int i = 0; i < sf.Count; i++)
        {
            Console.WriteLine($"{tm} {sf[i]._path} {sf[i]._natureOfChange}");
        }
        
    }
}
