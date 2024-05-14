namespace tests;
using project;

public class UnitTest1
{
    private const double mi = 39.37008;
    private const double im = 0.0254;

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
        Assert.Equal(x+y*im, el.M);
        Assert.Equal(x+y*im, e.M);
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
        Assert.Equal(x+y*im, el.M);
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
}