namespace project;

public class MeterPr
{
    public double M { get; set; }
    private const double mi = 39.37008;
    private const double im = 0.0254;
    public MeterPr(double m)
    {
        M = m;
    }
// +
    public static MeterPr operator+(MeterPr m1, MeterPr m2) // test1
    {
        return new MeterPr(m1.M + m2.M);
    }
    public static MeterPr operator+(MeterPr m1, Inch m2) // test2
    {
        return new MeterPr(m1.M + m2.I*im);
    }
    public static MeterPr operator+(Inch m1, MeterPr m2) // test3
    {
        return new MeterPr(m1.I*im + m2.M);
    }
    public static MeterPr operator+(MeterPr m1, double m2) // test4
    {
        return new MeterPr(m1.M + m2);
    }
    public static MeterPr operator+(double m1, MeterPr m2) // test4
    {
        return new MeterPr(m1 + m2.M);
    }
}
