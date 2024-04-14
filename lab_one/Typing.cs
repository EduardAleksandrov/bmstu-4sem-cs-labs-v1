namespace lab_one;

public class Typing
{
    private int _arrayNumber;
    private DateTime _startTime;
    private DateTime _endTime;

    public int ArrayNumber { get => _arrayNumber; set => _arrayNumber = value; }

    public DateTime StartTime
    {
        get
        {
            return _startTime;
        }
        set
        {
            _startTime = value;
        }
    }
    public DateTime EndTime
    {
        get
        {
            return _endTime;
        }
        set
        {
            _endTime = value;
        }
    }
    public int NumMistakes { get; set;}

    public Typing(int arrayNumber, DateTime startTime, DateTime endTime, int numMistakes)
    {
        ArrayNumber = arrayNumber;
        StartTime = startTime;
        EndTime = endTime;
        NumMistakes = numMistakes;
    }
}
