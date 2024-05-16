using System.Diagnostics.Metrics;

using project;

public class Program
{
    private static void Main(string[] args)
    {
        MeterPr elM = new MeterPr(5.0);
        MeterPr elM2 = new MeterPr(0.0);
        try{
            MeterPr el = elM/elM2;
        } catch (Exception ex)
        {
            Console.WriteLine($"{ex}");
        }
        
        // Console.WriteLine(el.M);

        // Console.WriteLine("Hello, World!");
    }
}