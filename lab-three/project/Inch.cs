namespace project;

public class Inch
{
    public double I { get; set; }
    private const double im = 39.37008; // дюймов в метре
    private const double mi = 0.0254; // метров в дюйме
    public Inch(double i)
    {
        I = i;
    }
// +
    public static Inch operator+(Inch m1, Inch m2) // test1
    {
        return new Inch(m1.I + m2.I);
    }
    public static Inch operator+(Inch m1, MeterPr m2) // test2
    {
        return new Inch(m1.I + m2.M*im);
    }
    public static Inch operator+(Inch m1, double m2) // test4
    {
        return new Inch(m1.I + m2);
    }
    public static Inch operator+(double m1, Inch m2) // test4
    {
        return new Inch(m1 + m2.I);
    }
// -
    public static Inch operator-(Inch m1, Inch m2) // test5
    {
        return new Inch(m1.I - m2.I);
    }
    public static Inch operator-(Inch m1, MeterPr m2) // test6
    {
        return new Inch(m1.I - m2.M*im);
    }
    public static Inch operator-(Inch m1, double m2) // test7
    {
        return new Inch(m1.I - m2);
    }
    public static Inch operator-(double m1, Inch m2) // test7
    {
        return new Inch(m1 - m2.I);
    }
// *
    public static Inch operator*(Inch m1, Inch m2) // test8
    {
        return new Inch(m1.I * m2.I);
    }
    public static Inch operator*(Inch m1, MeterPr m2) // test9
    {
        return new Inch(m1.I * m2.M*im);
    }
    public static Inch operator*(Inch m1, double m2) // test10
    {
        return new Inch(m1.I * m2);
    }
    public static Inch operator*(double m1, Inch m2) // test10
    {
        return new Inch(m1 * m2.I);
    }
// /
    public static Inch operator/(Inch m1, Inch m2) // test11
    {
        if(m2.I == 0) throw new ArgumentException("Div by zero");
        else return new Inch(m1.I / m2.I);
    }
    public static Inch operator/(Inch m1, MeterPr m2) // test12
    {
        if(m2.M == 0) throw new ArgumentException("Div by zero");
        else return new Inch(m1.I / (m2.M*im));
    }
    public static Inch operator/(Inch m1, double m2) // test13
    {
        if(m2 == 0) throw new ArgumentException("Div by zero");
        else return new Inch(m1.I / m2);
    }
    public static Inch operator/(double m1, Inch m2) // test13
    {
        if(m2.I == 0) throw new ArgumentException("Div by zero");
        else return new Inch(m1 / m2.I);
    }
// ++
    public static Inch operator++(Inch m1) // test 14
    {
        return new Inch (m1.I + 1.0);
    }
// --
    public static Inch operator--(Inch m1) // test 15
    {
        return new Inch (m1.I - 1.0);
    }
// ==
    public static bool operator==(Inch m1, Inch m2) // test 16
    {
        return m1.I == m2.I;
    }
// "!="
    public static bool operator!=(Inch m1, Inch m2) // test 17
    {
        return m1.I != m2.I;
    }
// <
    public static bool operator<(Inch m1, Inch m2) // test 18
    {
        return m1.I < m2.I;
    }
// >
    public static bool operator>(Inch m1, Inch m2) // test 19
    {
        return m1.I > m2.I;
    }
// <=
    public static bool operator<=(Inch m1, Inch m2) // test 20
    {
        return m1.I <= m2.I;
    }
// >=
    public static bool operator>=(Inch m1, Inch m2) // test 21
    {
        return m1.I>= m2.I;
    }
// explicit
    public static explicit operator Inch(double m1) // test 22
    {
        return new Inch (m1);
    }
    public static explicit operator Inch(MeterPr m1) // test 22
    {
        return new Inch (m1.M*im);
    }
// implicit
// Для одних и тех же исходных и целевых типов данных нельзя указывать оператор преобразования одновременно в явной и неявной форме.
    public static implicit operator Inch(int m1) // test 23
    {
        return new Inch (m1);
    }
// equals
    public override bool Equals(object? obj) // test 24
    {
        if (obj is Inch objectType) // если true автоматическое преобразование типа
        {
            return this.I == objectType.I;
        }
        return false;
    }
// gethashcode
    public override int GetHashCode() // test 25
    {
        return (I).GetHashCode();
    }
// toString
    public override string ToString() // test 26
    {
        return "Всего дюймов: " + I;
    } 
}
