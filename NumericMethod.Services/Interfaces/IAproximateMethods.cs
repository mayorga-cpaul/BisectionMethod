using NumericMethod.Services.Models;
using static NumericMethod.Services.Util.Bairstow;

namespace NumericMethod.Services.Interfaces;

public interface IAproximateMethods
{
    IList<BisectionAproximate> BisectionMethod(string function, double xa, double xb, double tolerance, int maxIterations);
    IList<FalseRuleAproximate> FalseRuleMethod(string function, double xa, double xb, double tolerance, int maxIterations);
    List<NewthonRhapsonAproximate> NewtonRaphson(string func, double x0, int n, double eps);
    IList<SecantAproximate> SecantMethod(string func, double xa, double xb, double error, int maxIterations);
    IList<FixedPointProperties> FixedPointMethod(string func, double x0, double error, int maxIterations);
    IList<MullerIteration> MullerMethod(string function, double x0, double x1, double x2, double tol, int maxIter);
    IList<IteracionNewtonSE> MetodoNewtonRaphsonParaSENoLineales(string primeraEc, string segundaEc, double x0, double y0, double tolerancia);
    List<List<IterationResult>> BairstowMethod(double[] polynomial, double error,
    int iterations, double sGuess, double rGuess);

}