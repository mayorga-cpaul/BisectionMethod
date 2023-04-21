using MathNet.Numerics;

using System.Linq.Dynamic.Core;
using System.Linq.Expressions;

namespace NumericMethod.Services.Util;

public class ValidateFunctions
{
    public static double GetFunction(string function, double value)
    {
        LambdaExpression lambda = DynamicExpressionParser.ParseLambda(new[] { Expression.Parameter(typeof(double), "x") }, null, function); // analiza la expresión
        Delegate compiled = lambda.Compile(); // compile the expression
        Func<double, double> data = (Func<double, double>)Convert.ChangeType(compiled, typeof(Func<double, double>)); // convierte el objeto Delegate en Func<double, double>
        double test = data(value);
        return test;
    }

    public static double Derivada(string func, double x, int n)
    {
        double h = 0.0001; // step size
        if (n == 0) return GetFunction(func,x); // base
        else return (Derivada(func, x + h, n - 1) - Derivada(func, x, n - 1)) / h; // derivative
    }

    public static double CalcularDerivadaParcial(string funcion, double valorX, double valorY, int indiceVariable)
    {
        //indice variable 0 es x y 1 es y
        org.mariuszgromada.math.mxparser.Function f = new org.mariuszgromada.math.mxparser.Function($"f(x,y) = {funcion}");
        double[] valores = { valorX, valorY };
        if (f.checkSyntax())
        {
            Func<double[], double> funcionConvertida = (double[] values) =>
            {
                org.mariuszgromada.math.mxparser.Argument valorx = new org.mariuszgromada.math.mxparser.Argument($"x = {values[0]}");
                org.mariuszgromada.math.mxparser.Argument valory = new org.mariuszgromada.math.mxparser.Argument($"y = {values[1]}");
                org.mariuszgromada.math.mxparser.Expression expression = new org.mariuszgromada.math.mxparser.Expression("f(x,y)", f, valorx, valory);
                return expression.calculate();
            };
            return Differentiate.FirstPartialDerivative(funcionConvertida, valores, indiceVariable);
        }
        else
        {
            throw new ArgumentException("El formato de la funcion es incorrecto");
        }
    }
}
