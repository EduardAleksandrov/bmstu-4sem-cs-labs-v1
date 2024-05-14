namespace tests;

using System.Linq.Expressions;

using project;

public class UnitTest1
{
    // дюймов в метре
    private const double im = 39.37008;
    // метров в дюйме
    private const double mi = 0.0254;

// "+" MeterPr 
    [Fact(DisplayName = "Lab 3")]
    public void Test1()
    {
        // arrange
        MeterPr el1 = new MeterPr(5.0);
        MeterPr el2 = new MeterPr(4.0);
        
        // act
        MeterPr el = el1+el2;

        // assert
        Assert.Equal(9, el.M);
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
        MeterPr el = el1+el2;
        MeterPr e = el2+el1;

        // assert
        Assert.Equal(x+y*mi, el.M);
        Assert.Equal(x+y*mi, e.M);
    }
    [Fact]
    public void Test3()
    {
        // arrange
        double x = 5.0;
        double y = 1.0;
        MeterPr el1 = new MeterPr(x);
        Inch el2 = new Inch(y);
        
        // act
        MeterPr el = el2+el1;

        // assert
        Assert.Equal(x+y*mi, el.M);
    }
    [Fact]
    public void Test4()
    {
        // arrange
        double x = 5.0;
        double y = 1.0;
        MeterPr el1 = new MeterPr(x);
        
        // act
        MeterPr el = el1+y;
        MeterPr e = y+el1;

        // assert
        Assert.Equal(x+y, el.M);
        Assert.Equal(y+x, e.M);
    }
// "-" MeterPr 
    [Fact]
    public void Test5()
    {
        // arrange
        MeterPr el1 = new MeterPr(5.0);
        MeterPr el2 = new MeterPr(4.0);
        
        // act
        MeterPr el = el1-el2;

        // assert
        Assert.Equal(1, el.M);
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
        MeterPr el = el1-el2;
        MeterPr e = el2-el1;

        // assert
        Assert.Equal(x-y*mi, el.M);
        Assert.Equal(y*mi - x, e.M);
    }
    [Fact]
    public void Test7()
    {
        // arrange
        double x = 5.0;
        double y = 1.0;
        MeterPr el1 = new MeterPr(x);
        
        // act
        MeterPr el = el1-y;
        MeterPr e = y-el1;

        // assert
        Assert.Equal(x-y, el.M);
        Assert.Equal(y-x, e.M);
    }
// "*" MeterPr 
    [Fact]
    public void Test8()
    {
        // arrange
        MeterPr el1 = new MeterPr(5.0);
        MeterPr el2 = new MeterPr(4.0);
        
        // act
        MeterPr el = el1 * el2;

        // assert
        Assert.Equal(20, el.M);
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
        MeterPr el = el1 * el2;
        MeterPr e = el2 * el1;

        // assert
        Assert.Equal(x * y*mi, el.M);
        Assert.Equal(y*mi * x, e.M);
    }
    [Fact]
    public void Test10()
    {
        // arrange
        double x = 5.0;
        double y = 1.0;
        MeterPr el1 = new MeterPr(x);
        
        // act
        MeterPr el = el1 * y;
        MeterPr e = y * el1;

        // assert
        Assert.Equal(x*y, el.M);
        Assert.Equal(y*x, e.M);
    }
// "/" MeterPr 
    [Fact]
    public void Test11()
    {
        // arrange
        MeterPr el1 = new MeterPr(5.0);
        MeterPr el2 = new MeterPr(4.0);
        
        // act
        MeterPr el = el1 / el2;

        // assert
        Assert.Equal(5.0/4.0, el.M);
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
        MeterPr el = el1 / el2;
        MeterPr e = el2 / el1;

        // assert
        Assert.Equal(x / y*mi, el.M);
        Assert.Equal(y*mi / x, e.M);
    }
    [Fact]
    public void Test13()
    {
        // arrange
        double x = 5.0;
        double y = 1.0;
        MeterPr el1 = new MeterPr(x);
        
        // act
        MeterPr el = el1 / y;
        MeterPr e = y / el1;

        // assert
        Assert.Equal(x / y, el.M);
        Assert.Equal(y / x, e.M);
    }
// "++" MeterPr 
    [Fact]
    public void Test14()
    {
        // arrange
        MeterPr el = new MeterPr(5.0);
        
        // act
        el++;

        // assert
        Assert.Equal(6.0, el.M);
    }
// "--" MeterPr 
    [Fact]
    public void Test15()
    {
        // arrange
        MeterPr el = new MeterPr(5.0);
        
        // act
        el--;

        // assert
        Assert.Equal(4.0, el.M);
    }
// "==" MeterPr 
    [Fact]
    public void Test16()
    {
        // arrange
        MeterPr el1 = new MeterPr(5.0);
        MeterPr el2 = new MeterPr(5.0);
        
        // act
        bool act = el1 == el2;

        // assert
        Assert.True(act);
    }
// "!=" MeterPr 
    [Fact]
    public void Test17()
    {
        // arrange
        MeterPr el1 = new MeterPr(5.0);
        MeterPr el2 = new MeterPr(5.0);
        
        // act
        bool act = el1 != el2;

        // assert
        Assert.True(!act);
    }
// "<" MeterPr 
    [Fact]
    public void Test18()
    {
        // arrange
        MeterPr el1 = new MeterPr(5.0);
        MeterPr el2 = new MeterPr(6.0);
        
        // act
        bool act = el1 < el2;

        // assert
        Assert.True(act);
    }
// ">" MeterPr 
    [Fact]
    public void Test19()
    {
        // arrange
        MeterPr el1 = new MeterPr(5.0);
        MeterPr el2 = new MeterPr(6.0);
        
        // act
        bool act = el1 > el2;

        // assert
        Assert.True(!act);
    }
// "<=" MeterPr 
    [Fact]
    public void Test20()
    {
        // arrange
        MeterPr el1 = new MeterPr(5.0);
        MeterPr el2 = new MeterPr(5.0);
        
        // act
        bool act = el1 <= el2;

        // assert
        Assert.True(act);
    }
// ">=" MeterPr 
    [Fact]
    public void Test21()
    {
        // arrange
        MeterPr el1 = new MeterPr(5.0);
        MeterPr el2 = new MeterPr(5.0);
        
        // act
        bool act = el1 >= el2;

        // assert
        Assert.True(act);
    }
// "explicit" MeterPr 
    [Fact]
    public void Test22()
    {
        // arrange
        double el1 = 5.0;
        Inch el2 = new Inch(7.0);
        
        // act
        MeterPr el = (MeterPr)el1;
        MeterPr ell = (MeterPr)el2;

        // assert
        Assert.Equal(5.0, el.M);
        Assert.Equal(7.0*mi, ell.M);
    }
// "implicit" MeterPr 
    [Fact]
    public void Test23()
    {
        // arrange
        int e = 8;
        
        // act
        MeterPr el = e;

        // assert
        Assert.Equal(8, el.M);
    }
}
