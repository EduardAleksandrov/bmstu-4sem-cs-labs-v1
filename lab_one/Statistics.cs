namespace lab_one;

public class Statistics
{
    public Statistics()
    {
        TryesSum = 0;
        tryesSumList = new List<double>(16);
    }
    public int TryesSum{ get; set; }
    protected List<double> tryesSumList;
    public void PutData(double timeV, int numSymbols)
    {
        TryesSum++;
        double result = numSymbols/(timeV/1000)*60;
        tryesSumList.Add(result);
    }
    public int GetMidTime()
    {
        double sum = 0;
        foreach (var item in tryesSumList)
        {
            sum+=item;
        }
        return (int)sum/TryesSum;
    }
    public int GetMinTime()
    {
        double min = tryesSumList[0];
        foreach (var item in tryesSumList)
        {
            if(item<min && item != 0) min=item;
        }
        return (int)min;
    }
    public int GetMaxTime()
    {
        double max = tryesSumList[0];
        foreach (var item in tryesSumList)
        {
            if(item>max && item != 0) max=item;
        }
        return (int)max;
    }
}
