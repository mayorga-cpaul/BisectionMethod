namespace SimpsonMethod;

using SimpsonMethod.Common;

//https://www.youtube.com/watch?v=ns3k-Lz7qWU
using System;

public class AproximateMethods
{
    private double Function(double x)
    {
        // Math.Pow(Math.E, x) / x;
        return 
            + 0.2d +(25) * (x)
            - 200 * (Math.Pow(x, 2)) 
            + 675 * (Math.Pow(x,3)) 
            - 900 * (Math.Pow(x, 4)) 
            + 400 * (Math.Pow(x, 5));
    }

    public double Compute(double a, double b, int n)
    {
        double[] x = new double[n + 1];

        double h = (b - a) / n;

        x[0] = a;

        for (int j = 1; j <= n; j++)
        {
            x[j] = a + h * j;
        }

        double sum = Function(x[0]);

        for (int j = 1; j < n; j++)
        {
            if (j % 2 != 0)
            {
                sum += 4 * Function(x[j]);
            }
            else
            {
                sum += 2 * Function(x[j]);
            }
        }

        sum += Function(x[n]);

        double integration = sum * h / 3;

        return integration;
    }

    public static double TrapezRule(Func<double, double> func, double a, double b, int n)
    {
        double area = 0;
        double h = (b - a) / n;
        area += (func(a) + func(b)) / 2;
        for (int i = 1; i < n; ++i)
            area += func(a + h * i);
        return h * area;
    }
}

public static class AproximateMethodsTest
{
    public static void ExecuteSimpson()
    {
        AproximateMethods simpson = new AproximateMethods();
        double a = 0d;
        double b = 0.8d;

        for (int i = 1; i < 100; ++i)
        {
            if (i % 2 == 0)
            {
                Util.PrintRow(
                    $"{i.ToString()}",
                    $"{simpson.Compute(a, b, i)}");

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("n should be an even number");
            }
        }
    }

    public static void ExecuteTrapeze()
    {
        //Show results for different numbers of trapezoids
        for (int i = 1; i < 100; ++i)
            Util.PrintRow(
                $"{i.ToString()}",
                $"{ AproximateMethods.TrapezRule(x => Math.Pow(Math.E, x) / x, 2, 4, i)}");
    }
}




