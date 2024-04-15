using System.Data;
using System.Globalization;
using System.IO.Compression;

namespace lab_four;

public class FileSystemWatcher
{
    protected Timer? _timer;
    protected List<SearchedFiles> _dbFilesToSearch;
    protected List<SearchedFiles> _filesChanged;
    protected DirectoryInfo _directoryInfo;
    public FileSystemWatcher()
    {
        _timer = new Timer(Got, null, 0, 2000);
        _timer.Change(Timeout.Infinite,Timeout.Infinite);

        _directoryInfo = new DirectoryInfo(@"./files");

        _dbFilesToSearch = new List<SearchedFiles>();
        _filesChanged = new List<SearchedFiles>();
    }
    public delegate void FileHandler(TimeOnly tm, List<SearchedFiles> sf);
    private FileHandler? _notify;
    public event FileHandler? Notify
    {
        add
        {
            _notify += value;
            if(_notify?.GetInvocationList().Length == 1) WatcherSet();
            Console.WriteLine("added");
        }
        remove
        {
            _notify -= value;
            if(_notify?.GetInvocationList().Length == 0) WatcherDel();
            Console.WriteLine("deleted");
        }
    }
    private void WatcherSet()
    {
        // _notify?.GetInvocationList().Length;
        // Console.WriteLine(_notify?.GetInvocationList().Length);  
        // создаем таймер
        _timer?.Change(0, 2000);
            }
    private void WatcherDel()
    {
        // timer?.Dispose();
        _timer?.Change(Timeout.Infinite,Timeout.Infinite);

        
    }
    public void Got(object? obj)
    {
        // _notify?.Invoke("hello");

        _filesChanged.Clear();
//---
        // int countOfFiles = 0;
        // foreach(FileInfo fileInfo in _directoryInfo.EnumerateFiles("*", SearchOption.AllDirectories))
        // {
        //     countOfFiles++;
        //     // Console.WriteLine($"{fileInfo.CreationTime} {fileInfo.FullName} ({fileInfo.Length} bytes)");
        //     // DateTime startedAt = fileInfo.CreationTime;
        //     // Console.WriteLine(startedAt);
        // }
        // var array = new int[countOfFiles];

        //если в базе ноль
        // if(_dbFilesToSearch.Count == 0 && countOfFiles != 0)
        // {
        //     foreach(FileInfo fileInfo in _directoryInfo.EnumerateFiles("*", SearchOption.AllDirectories))
        //     {
        //         DateTime st = fileInfo.CreationTime;
        //         _dbFilesToSearch.Add(new SearchedFiles(fileInfo.FullName, st, ""));
        //         _filesChanged.Add(new SearchedFiles(fileInfo.FullName, st, "Добавлен"));
        //     }
        // }
        // //если все удалили
        // if(_dbFilesToSearch.Count != 0 && countOfFiles == 0)
        // {
        //     for(int i = 0; i < _dbFilesToSearch.Count; i++)
        //     {
        //         _filesChanged.Add(new SearchedFiles(_dbFilesToSearch[i]._path, _dbFilesToSearch[i]._changeDate, "Удален"));
        //     }
        //     _dbFilesToSearch.Clear();
        // }
//---
        // if(_dbFilesToSearch.Count != 0 && countOfFiles != 0)
        // {
            for(int i = 0; i < _dbFilesToSearch.Count; i++)
            {
                int sum_one = 0;
                // int z = 0;
                foreach(FileInfo fileInfo in _directoryInfo.EnumerateFiles("*", SearchOption.AllDirectories))
                {
                    if(_dbFilesToSearch[i]._path == fileInfo.FullName && _dbFilesToSearch[i]._changeDate != fileInfo.CreationTime)
                    {
                        DateTime st = fileInfo.CreationTime;
                        _filesChanged.Add(new SearchedFiles(_dbFilesToSearch[i]._path, st, "Изменен"));
                    }
                    if(_dbFilesToSearch[i]._path == fileInfo.FullName)
                    {
                        sum_one++;
                        // array[z] = 1;
                    }
                    // z++;
                }
                if(sum_one == 0)
                {
                    _filesChanged.Add(new SearchedFiles(_dbFilesToSearch[i]._path, _dbFilesToSearch[i]._changeDate, "Удален"));
                }
            }
            foreach(FileInfo fileInfo in _directoryInfo.EnumerateFiles("*", SearchOption.AllDirectories))
            {
                int sum = 0;
                for(int i = 0; i < _dbFilesToSearch.Count; i++)
                {
                    if(_dbFilesToSearch[i]._path != fileInfo.FullName)
                    {
                        sum++;
                    }
                }
                if(sum == _dbFilesToSearch.Count)
                {
                    DateTime st = fileInfo.CreationTime;
                    _filesChanged.Add(new SearchedFiles(fileInfo.FullName, st, "Добавлен"));
                }
            }
            // for(int i = 0; i<_dbFilesToSearch.Count ; i++)
            // {
            //     Console.WriteLine(_dbFilesToSearch[i]._path);
            // }
            if(_filesChanged.Count > 0)
            {
                _dbFilesToSearch.Clear();
                foreach(FileInfo fileInfo in _directoryInfo.EnumerateFiles("*", SearchOption.AllDirectories))
                {
                    DateTime st = fileInfo.CreationTime;
                    _dbFilesToSearch.Add(new SearchedFiles(fileInfo.FullName, st, ""));
                }
            }
        // }

        _notify?.Invoke(TimeOnly.FromDateTime(DateTime.Now), _filesChanged);
    }
}
