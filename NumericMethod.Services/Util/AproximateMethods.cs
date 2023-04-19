using NumericMethod.Services.Interfaces;
using NumericMethod.Services.Models;
using org.mariuszgromada.math.mxparser;

namespace NumericMethod.Services.Util;

public class AproximateMethods : IAproximateMethods
{
    #region Bisection
    public IList<BisectionAproximate> BisectionMethod(string function, double xa, double xb, double tolerance, int maxIterations)
    {
        List<BisectionAproximate> result = new List<BisectionAproximate>();

        BisectionAproximate currentResult = new BisectionAproximate();
        currentResult.I = 0;
        currentResult.Xa = xa;
        currentResult.Xb = xb;
        currentResult.Fxa = ValidateFunctions.GetFunction(function, xa);
        currentResult.Fxr = ValidateFunctions.GetFunction(function, currentResult.Xr);
        currentResult.Ea = 100.0;

        result.Add(currentResult);

        while (currentResult.Ea > tolerance && currentResult.I < maxIterations)
        {
            currentResult = new BisectionAproximate();
            currentResult.I = result.Count;
            currentResult.Xa = result[result.Count - 1].Xa;
            currentResult.Xb = result[result.Count - 1].Xb;
            currentResult.Fxa = result[result.Count - 1].Fxa;
            currentResult.Fxr = ValidateFunctions.GetFunction(function, currentResult.Xr);

            if (currentResult.FxaFr < 0)
            {
                currentResult.Xb = result[result.Count - 1].Xr;
                currentResult.Fxr = ValidateFunctions.GetFunction(function, currentResult.Xr);
            }
            else if (currentResult.FxaFr > 0)
            {
                currentResult.Xa = result[result.Count - 1].Xr;
                currentResult.Fxa = result[result.Count - 1].Fxr;
                currentResult.Fxr = ValidateFunctions.GetFunction(function, currentResult.Xr);
            }
            else
            {
                break;
            }

            currentResult.Ea = Math.Abs((currentResult.Xr - result[result.Count - 1].Xr) / currentResult.Xr) * 100.0;

            result.Add(currentResult);
        }

        return result;
    }
    #endregion

    #region FalseRule
    public IList<FalseRuleAproximate> FalseRuleMethod(string function, double xa, double xb, double tolerance, int maxIterations)
    {
        List<FalseRuleAproximate> result = new List<FalseRuleAproximate>();

        FalseRuleAproximate currentResult = new FalseRuleAproximate();
        currentResult.Id = 0;
        currentResult.Xa = xa;
        currentResult.Xb = xb;
        currentResult.Fxa = ValidateFunctions.GetFunction(function, xa);
        currentResult.Fxb = ValidateFunctions.GetFunction(function, xb);
        currentResult.ThereIsSolution = currentResult.FxaFxb < 0;

        result.Add(currentResult);

        while (currentResult.ThereIsSolution && currentResult.Id < maxIterations)
        {
            currentResult = new FalseRuleAproximate();
            currentResult.Id = result.Count;
            currentResult.Xa = result[result.Count - 1].Xa;
            currentResult.Xb = result[result.Count - 1].Xb;
            currentResult.Fxa = result[result.Count - 1].Fxa;
            currentResult.Fxb = result[result.Count - 1].Fxb;

            double xr = currentResult.Xb - (currentResult.Fxb * (currentResult.Xb - currentResult.Xa)) / (currentResult.Fxb - currentResult.Fxa);
            double fxr = ValidateFunctions.GetFunction(function, xr);

            currentResult.ThereIsSolution = fxr * currentResult.FxaFxb < 0;

            if (currentResult.ThereIsSolution)
            {
                currentResult.Xb = xr;
                currentResult.Fxb = fxr;
            }

            result.Add(currentResult);

            double ea = Math.Abs((xr - result[result.Count - 2].Xb) / xr) * 100.0;

            if (ea <= tolerance)
            {
                break;
            }
        }

        return result;
    }
    #endregion

    #region NewthonRhapson
    public List<NewthonRhapsonAproximate> NewtonRaphson(string func, double x0, int n, double eps)
    {
        List<NewthonRhapsonAproximate> iterations = new List<NewthonRhapsonAproximate>();
        double xi = x0;
        int iterationCount = 0;
        double error = double.MaxValue;
        while (iterationCount < n && error > eps)
        {
            NewthonRhapsonAproximate iteration = new NewthonRhapsonAproximate();
            iteration.Iteration = iterationCount;
            iteration.Xi = xi;
            iteration.Fxi = ValidateFunctions.GetFunction(func, xi);
            iteration.DerivateFxi = ValidateFunctions.Derivada(func, xi, 1);
            xi = iteration.Xi_1;
            error = Math.Abs(xi - iteration.Xi);
            iterationCount++;
            iterations.Add(iteration);
        }
        return iterations;
    }
    #endregion

    #region SecantAproximate
    public IList<SecantAproximate> SecantMethod(string func, double xa, double xb, double error, int maxIterations)
    {
        List<SecantAproximate> iterations = new List<SecantAproximate>();
        double fxa = ValidateFunctions.GetFunction(func, xa);
        double fxb = ValidateFunctions.GetFunction(func, xb);
        double xi_1 = xa;
        int iteration = 0;
        double currentError = error + 1;

        while (currentError > error && iteration < maxIterations)
        {
            double xi = xb - (fxb * (xa - xb)) / (fxa - fxb);
            currentError = Math.Abs((xi - xi_1) / xi);
            xi_1 = xi;
            xa = xb;
            fxa = fxb;
            xb = xi_1;
            fxb = ValidateFunctions.GetFunction(func, xb);
            iteration++;

            iterations.Add(new SecantAproximate
            {
                iteration = iteration,
                Xa = xa,
                Xb = xb,
                Fxa = fxa,
                Fxb = fxb,
                Xi_1 = xi_1,
                Error = currentError
            });
        }

        return iterations;
    }
    #endregion

    #region FixedAproximate
    public IList<FixedPointProperties> FixedPointMethod(string func, double x0, double error, int maxIterations)
    {
        List<FixedPointProperties> iterations = new List<FixedPointProperties>();
        double gx = ValidateFunctions.GetFunction(func, x0);
        int iteration = 0;
        double currentError = error + 1;

        while (currentError > error && iteration < maxIterations)
        {
            double x = gx;
            gx = ValidateFunctions.GetFunction(func, x);
            currentError = Math.Abs((gx - x) / gx);
            iteration++;

            iterations.Add(new FixedPointProperties
            {
                Iteration = iteration,
                X = x,
                Gx = gx,
                Error = currentError
            });
        }

        return iterations;
    }
    #endregion

    #region MullerIteration
    public IList<MullerIteration> MullerMethod(string function, double x0, double x1, double x2, double tol, int maxIter)
    {
        List<MullerIteration> iterations = new List<MullerIteration>(); // lista para almacenar las iteraciones

        double h1 = x1 - x0;
        double h2 = x2 - x1;

        double d1 = (ValidateFunctions.GetFunction(function, x1) - ValidateFunctions.GetFunction(function, x0)) / h1;
        double d2 = (ValidateFunctions.GetFunction(function, x2) - ValidateFunctions.GetFunction(function, x1)) / h2;

        double a = (d2 - d1) / (h2 + h1);
        double b = a * h2 + d2;
        double c = ValidateFunctions.GetFunction(function, x2);

        int iter = 0;
        while (iter < maxIter)
        {
            iter++;

            double bSquaredMinus4ac = b * b - 4 * a * c;
            if (Math.Abs(bSquaredMinus4ac) < double.Epsilon)
            {
                bSquaredMinus4ac = 0;
            }

            double x3 = x2 + (-2 * c) / (b + Math.Sign(b) * Math.Sqrt(bSquaredMinus4ac));
            double h = x3 - x2;

            iterations.Add(new MullerIteration { IterationNumber = iter, X3Value = x3, FunctionValue = ValidateFunctions.GetFunction(function, x3) });

            if (Math.Abs(h) < tol)
            {
                return iterations;
            }

            x0 = x1;
            x1 = x2;
            x2 = x3;

            h1 = x1 - x0;
            h2 = x2 - x1;

            d1 = (ValidateFunctions.GetFunction(function, x1) - ValidateFunctions.GetFunction(function, x0)) / h1;
            d2 = (ValidateFunctions.GetFunction(function, x2) - ValidateFunctions.GetFunction(function, x1)) / h2;

            double aPrev = a;
            a = (d2 - d1) / (h2 + h1);
            b = a * h2 + d2;
            c = ValidateFunctions.GetFunction(function, x2);

            if (Math.Abs(a - aPrev) < double.Epsilon)
            {
                break;
            }
        }

        return iterations;
    }
    #endregion

    #region MetodoNewtonRaphsonParaSENL
    public IList<IteracionNewtonSE> MetodoNewtonRaphsonParaSENoLineales(string primeraEc, string segundaEc, double x0, double y0, double tolerancia)
    {
        List<IteracionNewtonSE> iteraciones = new List<IteracionNewtonSE>();
        Function f1 = new Function($"f(x,y) = {primeraEc}");
        if (!f1.checkSyntax())
        {
            throw new ArgumentException("La primera ecuacion no tiene el formato correcto o no es valida");
        }
        Function f2 = new Function($"f(x,y) = {segundaEc}");
        if (!f2.checkSyntax())
        {
            throw new ArgumentException("La segunda ecuacion no tiene el formato correcto o no es valida");
        }
        int contador = 1;
        double errorX = double.MaxValue;
        double errorY = double.MaxValue;
        double x1 = 0, y1 = 0;
        while (errorX > tolerancia && errorY > tolerancia)
        {
            double u = new Expression($"f({x0},{y0})", f1).calculate();
            double v = new Expression($"f({x0},{y0})", f2).calculate();
            double derivadaUx = ValidateFunctions.CalcularDerivadaParcial(primeraEc, x0, y0, 0);
            double derivadaUy = ValidateFunctions.CalcularDerivadaParcial(primeraEc, x0, y0, 1);
            double derivadaVx = ValidateFunctions.CalcularDerivadaParcial(segundaEc, x0, y0, 0);
            double derivadaVy = ValidateFunctions.CalcularDerivadaParcial(segundaEc, x0, y0, 1);
            double determinante = (derivadaUx * derivadaVy) - (derivadaUy * derivadaVx);
            x1 = x0 - (u * derivadaVy - v * derivadaUy) / determinante;
            y1 = y0 - (v * derivadaUx - u * derivadaVx) / determinante;
            errorX = Math.Abs((x1 - x0) / x1);
            errorY = Math.Abs((y1 - y0) / y1);
            x0 = x1;
            y0 = y1;
            iteraciones.Add(new IteracionNewtonSE()
            {
                NoIteracion = contador,
                U = u,
                V = v,
                DerivadaParcialUx = derivadaUx,
                DerivadaParcialVy = derivadaVy,
                DerivadaParcialUy = derivadaUy,
                DerivadaParcialVx = derivadaVx,
                Determinante = determinante,
                Eax = errorX * 100,
                Eay = errorY * 100,
                X = x0,
                Y = y0,
            });
            contador++;
        }
        return iteraciones;
    }
    #endregion

    #region Bairstow
    public List<List<Bairstow.IterationResult>> BairstowMethod(double[] polynomial, double error, 
        int iterations, double sGuess, double rGuess)
    {
        Bairstow b = new Bairstow(polynomial, error, iterations, sGuess, rGuess);
        Tuple<double, double>[] roots = b.calculateRoots();
        return b.getIterationResults();
    }
    #endregion
}
