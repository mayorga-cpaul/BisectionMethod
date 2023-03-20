using StringMath;
using View.Models;

namespace View.Util;

public static class AproximateMethods
{
    public static List<Bisection> BisectionMethod(string fx, double xa, double xb, double ea = 0.03d)
    {
        var bisectionList = new List<Bisection>();
        int n = 0;
        double valueFa = fx.Replace("X", $"{xa}").Eval();
        double xr = (xa + xb) / 2;
        double valueFxr = fx.Replace("X", $"{xr}").Eval();
        double error = 101d;
        double xrtemp = 0d;

        // Add the firt so n = 1 => bisectionList[0]
        bisectionList.Add(new Bisection()
        {
            I = 1,
            Xa = xa,
            Xb = xb,
            Fxa = valueFa,
            Fxr = valueFxr,
            Ea = 0,
        });

        // bisectionList[0]
        while (ea < error)
        {
            Bisection bisection = bisectionList[n];

            xa = ValidateXa(bisectionList, bisection.Xa);
            xb = ValidateXb(bisectionList, bisection.Xb);
            xrtemp = (xa + xb) / 2;
            valueFa = fx.Replace("X", $"{xa}").Eval();
            valueFxr = fx.Replace("X", $"{xrtemp}").Eval();

            bisectionList.Add(new Bisection()
            {
                I = bisectionList.Count + 1,
                Xa = xa,
                Xb = xb,
                Fxa = valueFa,
                Fxr = valueFxr,
                Ea = Math.Abs((xrtemp - bisection.Xr)/ xrtemp)*100
            });

            error = bisectionList[bisectionList.Count - 1].Ea;
            n++;
        }

        return bisectionList;
    }

    private static double ValidateXb(List<Bisection> bisections, double xb)
    {
        int index = bisections.Count - 1;

        return (bisections[index].FxaFr > 0) ? bisections[index].Xb : bisections[index].Xr;
    }

    private static double ValidateXa(List<Bisection> bisections, double xb)
    {
        int index = bisections.Count - 1;

        return (bisections[index].FxaFr < 0) ? bisections[index].Xa : bisections[index].Xr;
    }
}
