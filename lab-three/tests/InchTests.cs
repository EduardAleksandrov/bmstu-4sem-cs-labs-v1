namespace tests;
using project;

public class InchTests
{
    // дюймов в метре
    private const double im = 39.37008;
    // метров в дюйме
    private const double mi = 0.0254;

// "+"
    [Fact]
    public void Test1()
    {
        // arrange
        Inch el1 = new Inch(5.0);
        Inch el2 = new Inch(4.0);
        
        // act
        Inch el = el1+el2;

        // assert
        Assert.Equal(9, el.I);
    }
    [Fact]
    public void Test2()
    {
        // arrange
        double x = 5.0;
        double y = 1.0;
        MeterPr el1 = new MeterPr(x);
        Inch el2 = new Inch(y);
        
        // act
        Inch el = el2 + el1;

        // assert
        Assert.Equal(x*im+y, el.I);
        // Assert.Equal(x+y*mi, e.M);
    }
    [Fact]
    public void Test4()
    {
        // arrange
        double x = 5.0;
        double y = 1.0;
        Inch el1 = new Inch(x);
        
        // act
        Inch el = el1+y;
        Inch e = y+el1;

        // assert
        Assert.Equal(x+y, el.I);
        Assert.Equal(y+x, e.I);
    }
// "-" 
    [Fact]
    public void Test5()
    {
        // arrange
        Inch el1 = new Inch(5.0);
        Inch el2 = new Inch(4.0);
        
        // act
        Inch el = el1-el2;

        // assert
        Assert.Equal(1, el.I);
    }
    [Fact]
    public void Test6()
    {
        // arrange
        double x = 5.0;
        double y = 1.0;
        MeterPr el1 = new MeterPr(x);
        Inch el2 = new Inch(y);
        
        // act
        Inch e = el2-el1;

        // assert
        Assert.Equal(y-x*im, e.I);
    }
    [Fact]
    public void Test7()
    {
        // arrange
        double x = 5.0;
        double y = 1.0;
        Inch el1 = new Inch(x);
        
        // act
        Inch el = el1-y;
        Inch e = y-el1;

        // assert
        Assert.Equal(x-y, el.I);
        Assert.Equal(y-x, e.I);
    }
// "*"  
    [Fact]
    public void Test8()
    {
        // arrange
        Inch el1 = new Inch(5.0);
        Inch el2 = new Inch(4.0);
        
        // act
        Inch el = el1 * el2;

        // assert
        Assert.Equal(20.0, el.I);
    }
    [Fact]
    public void Test9()
    {
        // arrange
        double x = 5.0;
        double y = 1.0;
        MeterPr el1 = new MeterPr(x);
        Inch el2 = new Inch(y);
        
        // act
        Inch e = el2 * el1;

        // assert
        Assert.Equal(y * x*im, e.I);
    }
    [Fact]
    public void Test10()
    {
        // arrange
        double x = 5.0;
        double y = 1.0;
        Inch el1 = new Inch(x);
        
        // act
        Inch el = el1 * y;
        Inch e = y * el1;

        // assert
        Assert.Equal(x*y, el.I);
        Assert.Equal(y*x, e.I);
    }
// "/"
    [Fact]
    public void Test11()
    {
        // arrange
        Inch el1 = new Inch(5.0);
        Inch el2 = new Inch(4.0);
        
        // act
        Inch el = el1 / el2;

        // assert
        Assert.Equal(5.0/4.0, el.I);
    }
    [Fact]
    public void Test12()
    {
        // arrange
        double x = 5.0;
        double y = 1.0;
        MeterPr el1 = new MeterPr(x);
        Inch el2 = new Inch(y);
        
        // act
        Inch e = el2 / el1;

        // assert
        Assert.Equal(y / (x*im), e.I);
    }
    [Fact]
    public void Test13()
    {
        // arrange
        double x = 5.0;
        double y = 1.0;
        Inch el1 = new Inch(x);
        
        // act
        Inch el = el1 / y;
        Inch e = y / el1;

        // assert
        Assert.Equal(x / y, el.I);
        Assert.Equal(y / x, e.I);
    }
// "++"
    [Fact]
    public void Test14()
    {
        // arrange
        Inch el = new Inch(5.0);
        
        // act
        el++;

        // assert
        Assert.Equal(6.0, el.I);
    }
// "--"
    [Fact]
    public void Test15()
    {
        // arrange
        Inch el = new Inch(5.0);
        
        // act
        el--;

        // assert
        Assert.Equal(4.0, el.I);
    }
// "==" 
    [Fact]
    public void Test16()
    {
        // arrange
        Inch el1 = new Inch(5.0);
        Inch el2 = new Inch(5.0);
        
        // act
        bool act = el1 == el2;

        // assert
        Assert.True(act);
    }
// "!="
    [Fact]
    public void Test17()
    {
        // arrange
        Inch el1 = new Inch(5.0);
        Inch el2 = new Inch(5.0);
        
        // act
        bool act = el1 != el2;

        // assert
        Assert.True(!act);
    }
// "<"
    [Fact]
    public void Test18()
    {
        // arrange
        Inch el1 = new Inch(5.0);
        Inch el2 = new Inch(6.0);
        
        // act
        bool act = el1 < el2;

        // assert
        Assert.True(act);
    }
// ">"
    [Fact]
    public void Test19()
    {
        // arrange
        Inch el1 = new Inch(5.0);
        Inch el2 = new Inch(6.0);
        
        // act
        bool act = el1 > el2;

        // assert
        Assert.True(!act);
    }
// "<="
    [Fact]
    public void Test20()
    {
        // arrange
        Inch el1 = new Inch(5.0);
        Inch el2 = new Inch(5.0);
        
        // act
        bool act = el1 <= el2;

        // assert
        Assert.True(act);
    }
// ">="
    [Fact]
    public void Test21()
    {
        // arrange
        Inch el1 = new Inch(5.0);
        Inch el2 = new Inch(5.0);
        
        // act
        bool act = el1 >= el2;

        // assert
        Assert.True(act);
    }
// "explicit"
    [Fact]
    public void Test22()
    {
        // arrange
        double el1 = 5.0;
        MeterPr el2 = new MeterPr(7.0);
        
        // act
        Inch el = (Inch)el1;
        Inch ell = (Inch)el2;

        // assert
        Assert.Equal(5.0, el.I);
        Assert.Equal(7.0*im, ell.I);
    }
// "implicit"
    [Fact]
    public void Test23()
    {
        // arrange
        int e = 8;
        
        // act
        Inch el = e;

        // assert
        Assert.Equal(8, el.I);
    }
// "Equals"
    [Fact]
    public void Test24()
    {
        // arrange
        Inch el1 = new Inch(5.0);
        Inch el2 = new Inch(5.0);
        
        // act
        bool e = el1.Equals(el2);

        // assert
        Assert.True(e);
    }
// "GetHashCode"
    [Fact]
    public void Test25()
    {
        // arrange
        Inch el1 = new Inch(5.0);
        
        // act
        bool e = el1.GetHashCode() == 5.0.GetHashCode();

        // assert
        Assert.True(e);
    }
// "toString"
    [Fact]
    public void Test26()
    {
        // arrange
        Inch el = new Inch(5.0);
        
        // act
        bool e = el.ToString() == "Всего дюймов: 5";

        // assert
        Assert.True(e);
    }
}
