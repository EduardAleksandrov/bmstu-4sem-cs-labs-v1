namespace project;

public class Inch
{
    public double I { get; set; }
    private const double mi = 39.37008;
    private const double im = 0.0254;
    public Inch(double i)
    {
        I = i;
    }
    public static Inch operator+(Inch i1, Inch i2)
    {
        return new Inch(i1.I + i2.I);
    }
}
