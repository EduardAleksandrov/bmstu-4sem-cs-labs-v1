using System.Globalization;

namespace lab_four;

public class FileSystemWatcher
{
    protected Timer? _timer;
    public FileSystemWatcher()
    {
        _timer = new Timer(Got, null, 0, 2000);
        _timer.Change(Timeout.Infinite,Timeout.Infinite);
    }
    public delegate void FileHandler(string message);
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
        _notify?.Invoke("hello");
    }
}
