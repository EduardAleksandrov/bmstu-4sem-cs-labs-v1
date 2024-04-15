namespace lab_four;

public struct SearchedFiles
{
    public SearchedFiles(string path, DateTime changeDate, string natureOfChange)
    {
        _path = path;
        _changeDate = changeDate;
        _natureOfChange = natureOfChange;
    }

    public string _path { get; set; }
    public DateTime _changeDate { get; set; }
    public string _natureOfChange { get; set; }

    
}