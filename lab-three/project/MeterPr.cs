namespace project;

public class MeterPr
{
    public double M { get; set; }
    private const double im = 39.37008;  // дюймов в метре
    private const double mi = 0.0254;  // метров в дюйме
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
        return new MeterPr(m1.M + m2.I*mi);
    }
    public static MeterPr operator+(Inch m1, MeterPr m2) // test3
    {
        return new MeterPr(m1.I*mi + m2.M);
    }
    public static MeterPr operator+(MeterPr m1, double m2) // test4
    {
        return new MeterPr(m1.M + m2);
    }
    public static MeterPr operator+(double m1, MeterPr m2) // test4
    {
        return new MeterPr(m1 + m2.M);
    }
// -
    public static MeterPr operator-(MeterPr m1, MeterPr m2) // test5
    {
        return new MeterPr(m1.M - m2.M);
    }
    public static MeterPr operator-(MeterPr m1, Inch m2) // test6
    {
        return new MeterPr(m1.M - m2.I*mi);
    }
    public static MeterPr operator-(Inch m1, MeterPr m2) // test6
    {
        return new MeterPr(m1.I*mi - m2.M);
    }
    public static MeterPr operator-(MeterPr m1, double m2) // test7
    {
        return new MeterPr(m1.M - m2);
    }
    public static MeterPr operator-(double m1, MeterPr m2) // test7
    {
        return new MeterPr(m1 - m2.M);
    }
// *
    public static MeterPr operator*(MeterPr m1, MeterPr m2) // test8
    {
        return new MeterPr(m1.M * m2.M);
    }
    public static MeterPr operator*(MeterPr m1, Inch m2) // test9
    {
        return new MeterPr(m1.M * m2.I*mi);
    }
    public static MeterPr operator*(Inch m1, MeterPr m2) // test9
    {
        return new MeterPr(m1.I*mi * m2.M);
    }
    public static MeterPr operator*(MeterPr m1, double m2) // test10
    {
        return new MeterPr(m1.M * m2);
    }
    public static MeterPr operator*(double m1, MeterPr m2) // test10
    {
        return new MeterPr(m1 * m2.M);
    }
// /
    public static MeterPr operator/(MeterPr m1, MeterPr m2) // test11
    {
        if(m2.M == 0) throw new ArgumentException("Div by zero");
        else return new MeterPr(m1.M / m2.M);
    }
    public static MeterPr operator/(MeterPr m1, Inch m2) // test12
    {
        if(m2.I*mi == 0) throw new ArgumentException("Div by zero");
        else return new MeterPr(m1.M / m2.I*mi);
    }
    public static MeterPr operator/(Inch m1, MeterPr m2) // test12
    {
        if(m2.M == 0) throw new ArgumentException("Div by zero");
        else return new MeterPr(m1.I*mi / m2.M);
    }
    public static MeterPr operator/(MeterPr m1, double m2) // test13
    {
        if(m2 == 0) throw new ArgumentException("Div by zero");
        else return new MeterPr(m1.M / m2);
    }
    public static MeterPr operator/(double m1, MeterPr m2) // test13
    {
        if(m2.M == 0) throw new ArgumentException("Div by zero");
        else return new MeterPr(m1 / m2.M);
    }
// ++
    public static MeterPr operator++(MeterPr m1) // test 14
    {
        return new MeterPr (m1.M + 1.0);
    }
// --
    public static MeterPr operator--(MeterPr m1) // test 15
    {
        return new MeterPr (m1.M - 1.0);
    }
// ==
    public static bool operator==(MeterPr m1, MeterPr m2) // test 16
    {
        return m1.M == m2.M;
    }
// "!="
    public static bool operator!=(MeterPr m1, MeterPr m2) // test 17
    {
        return m1.M != m2.M;
    }
// <
    public static bool operator<(MeterPr m1, MeterPr m2) // test 18
    {
        return m1.M < m2.M;
    }
// >
    public static bool operator>(MeterPr m1, MeterPr m2) // test 19
    {
        return m1.M > m2.M;
    }
// <=
    public static bool operator<=(MeterPr m1, MeterPr m2) // test 20
    {
        return m1.M <= m2.M;
    }
// >=
    public static bool operator>=(MeterPr m1, MeterPr m2) // test 21
    {
        return m1.M >= m2.M;
    }
// explicit
    public static explicit operator MeterPr(double m1) // test 22
    {
        return new MeterPr (m1);
    }
    public static explicit operator MeterPr(Inch m1) // test 22
    {
        return new MeterPr (m1.I*mi);
    }
// implicit
// Для одних и тех же исходных и целевых типов данных нельзя указывать оператор преобразования одновременно в явной и неявной форме.
    public static implicit operator MeterPr(int m1) // test 23
    {
        return new MeterPr (m1);
    }
// equals
    public override bool Equals(object? obj) // test 24
    {
        if (obj is MeterPr objectType) // если true автоматическое преобразование типа
        {
            return this.M == objectType.M;
        }
        return false;
    }
// gethashcode
    public override int GetHashCode() // test 25
    {
        return (M).GetHashCode();
    }
// toString
    public override string ToString() // test 26
    {
        return "Всего метров: " + M;
    } 

}
