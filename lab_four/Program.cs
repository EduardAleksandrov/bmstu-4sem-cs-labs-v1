using lab_four;
internal class Program
{
    private static void Main(string[] args)
    {

        // var directoryInfo = new DirectoryInfo(@"./files/");

        // foreach(FileInfo fileInfo in directoryInfo.EnumerateFiles("*", SearchOption.AllDirectories))
        // {
        //     Console.WriteLine($"{fileInfo.CreationTime} {fileInfo.FullName} ({fileInfo.Length} bytes)");
        // }

        // IEnumerable<string> allfolders = Directory.EnumerateDirectories(directoryInfo.Name, "*", SearchOption.AllDirectories);
        // foreach (string folder in allfolders)
        // {
        //     Console.WriteLine(folder);
        // }

        lab_four.FileSystemWatcher file_watcher = new lab_four.FileSystemWatcher();
        for(;;)
        {
            Console.WriteLine("1. Добавить, 2. Удалить");
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
                file_watcher.Notify+= Print;
            } else if(xx == 2) 
            {
                file_watcher.Notify-= Print;
            } else {
                continue;
            }
        }
        
    }

    public static void Print(string message)
    {
        Console.WriteLine(message);
    }
}
