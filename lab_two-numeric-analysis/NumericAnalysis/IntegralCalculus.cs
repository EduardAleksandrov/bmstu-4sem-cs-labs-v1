using System;

namespace NumericAnalysis;

public class IntegralCalculus
{
    public static double Calculate(Func<double, double> func, double x1, double x2, double precision)
    {
        // double y1 = func(x1);
        // double y2 = func(x2);
        
        double x = 0, f = 0;
        double xmin = x1, xmax = x2, h = precision;
        double xnew = xmin;
        while(xnew < xmax)
        {
            x = xnew;
            if(xmax - xmin == h || xnew + h >= xmax)
            {
                xnew += h;
                break;
            }
            f += (func(x) + func(x + h))/2*((x + h) - x); // метод трапеций
            xnew+= h;
        }
        if(xnew >= xmax)
        {
            f += (func(x) + func(xmax))/2*(xmax - x);
        }

        return f;

        // throw new NotImplementedException();
    }
}
