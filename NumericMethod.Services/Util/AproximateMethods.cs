using MathNet.Numerics.Distributions;
using MathNet.Numerics;
using MathNet.Numerics.RootFinding;
using NumericMethod.Services.Interfaces;
using NumericMethod.Services.Models;
using org.mariuszgromada.math.mxparser;
using System.Runtime.ConstrainedExecution;
using org.mariuszgromada.math.mxparser.mathcollection;

namespace NumericMethod.Services.Util;

public class AproximateMethods : IAproximateMethods
{
    #region Bisection
    /// <summary>
    /// El método de bisección es una opción conveniente cuando 
    /// se busca encontrar raíces de una función en un intervalo dado. 
    /// Es fácil de implementar, garantiza la convergencia hacia una solución, 
    /// es robusto ante irregularidades en la función, permite controlar 
    /// el error y es adecuado para intervalos iniciales amplios. 
    /// Sin embargo, puede ser más lento en comparación con otros métodos más sofisticados, 
    /// por lo que su elección depende del equilibrio entre simplicidad 
    /// y eficiencia requeridos en cada situación.
    /// </summary>
    /// <param name="Bisection"></param>
    /// <param name="xa"> Limite inferior del eje x</param>
    /// <param name="xb"></param>
    /// <param name="tolerance"></param>
    /// <param name="maxIterations"></param>
    /// <returns></returns>
    public IList<BisectionAproximate> BisectionMethod(string function, double xa, double xb, double tolerance, int maxIterations)
    {
        List<BisectionAproximate> result = new List<BisectionAproximate>();

        // Se crea el objeto BisectionAproximate de la primera iteración
        BisectionAproximate currentResult = new BisectionAproximate();
        currentResult.I = 0;
        currentResult.Xa = xa;
        currentResult.Xb = xb;
        currentResult.Fxa = ValidateFunctions.GetFunction(function, xa);
        currentResult.Fxr = ValidateFunctions.GetFunction(function, currentResult.Xr);
        currentResult.Ea = 100.0;

        // Se agrega el objeto BisectionAproximate a la lista de resultados
        result.Add(currentResult);

        // Se entra en el bucle de iteraciones
        while (currentResult.Ea > tolerance && currentResult.I < maxIterations)
        {
            // Se crea un nuevo objeto BisectionAproximate con los valores de la iteración anterior
            currentResult = new BisectionAproximate();
            currentResult.I = result.Count;
            currentResult.Xa = result[result.Count - 1].Xa;
            currentResult.Xb = result[result.Count - 1].Xb;
            currentResult.Fxa = result[result.Count - 1].Fxa;
            currentResult.Fxr = ValidateFunctions.GetFunction(function, currentResult.Xr);

            // Se verifica el signo de la función en xa y xr
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

            // Se calcula el error relativo y se agrega el objeto BisectionAproximate a la lista de resultados
            currentResult.Ea = Math.Abs((currentResult.Xr - result[result.Count - 1].Xr) / currentResult.Xr) * 100.0;
            result.Add(currentResult);
        }

        return result;
    }

    #endregion

    #region FalseRule
    /// <summary>
    /// La regla falsa, también conocida como método de interpolación lineal, 
    /// es un método de aproximación utilizado para encontrar raíces de una 
    /// función en un intervalo dado.Al igual que el método de bisección,
    /// se basa en el Teorema de Bolzano y garantiza la convergencia hacia 
    /// una solución. Sin embargo, a diferencia de la bisección, la regla
    /// falsa utiliza una interpolación lineal para estimar la posición de
    /// la raíz, lo que permite un ajuste más rápido hacia la solución.
    /// Es especialmente útil cuando el intervalo inicial es estrecho y
    /// se desea una convergencia más rápida. Sin embargo, la regla falsa
    /// puede ser más sensible a oscilaciones y discontinuidades en la
    /// función, lo que puede afectar su estabilidad y convergencia en
    /// ciertos casos.Por lo tanto, se recomienda considerar las 
    /// características de la función y el intervalo antes de elegir 
    /// entre el método de bisección y la regla falsa.
    /// </summary>
    /// <param name="function"></param>
    /// <param name="xa"></param>
    /// <param name="xb"></param>
    /// <param name="tolerance"></param>
    /// <param name="maxIterations"></param>
    /// <returns></returns>
    public IList<FalseRuleAproximate> FalseRuleMethod(string function, double xa, double xb, double tolerance, int maxIterations)
    {
        // Lista para almacenar los resultados de las aproximaciones
        List<FalseRuleAproximate> result = new List<FalseRuleAproximate>();

        // Crear el objeto para almacenar el primer resultado
        FalseRuleAproximate currentResult = new FalseRuleAproximate();

        // Asignar los valores iniciales al primer resultado
        currentResult.Id = 0;
        currentResult.Xa = xa;
        currentResult.Xb = xb;
        currentResult.Fxa = ValidateFunctions.GetFunction(function, xa);
        currentResult.Fxb = ValidateFunctions.GetFunction(function, xb);

        // Verificar si hay solución en el intervalo inicial
        currentResult.ThereIsSolution = currentResult.FxaFxb < 0;

        // Agregar el primer resultado a la lista
        result.Add(currentResult);

        // Realizar iteraciones hasta encontrar una aproximación o alcanzar el número máximo de iteraciones
        while (currentResult.ThereIsSolution && currentResult.Id < maxIterations)
        {
            // Crear un nuevo objeto para almacenar el resultado actual
            currentResult = new FalseRuleAproximate();

            // Copiar los valores del resultado anterior al resultado actual
            currentResult.Id = result.Count;
            currentResult.Xa = result[result.Count - 1].Xa;
            currentResult.Xb = result[result.Count - 1].Xb;
            currentResult.Fxa = result[result.Count - 1].Fxa;
            currentResult.Fxb = result[result.Count - 1].Fxb;

            // Calcular el nuevo valor de xr utilizando el método de la regla falsa
            double xr = currentResult.Xb - (currentResult.Fxb * (currentResult.Xb - currentResult.Xa)) / (currentResult.Fxb - currentResult.Fxa);
            double fxr = ValidateFunctions.GetFunction(function, xr);

            // Verificar si hay solución en el nuevo intervalo
            currentResult.ThereIsSolution = fxr * currentResult.FxaFxb < 0;

            if (currentResult.ThereIsSolution)
            {
                // Actualizar el intervalo y los valores de la función en el nuevo intervalo
                currentResult.Xb = xr;
                currentResult.Fxb = fxr;
            }

            // Agregar el resultado actual a la lista
            result.Add(currentResult);

            // Calcular el error aproximado (ea) en cada iteración
            double ea = Math.Abs((xr - result[result.Count - 2].Xb) / xr) * 100.0;

            // Verificar si se alcanzó la tolerancia deseada y salir del bucle si es el caso
            if (ea <= tolerance)
            {
                break;
            }
        }

        // Devolver la lista de resultados
        return result;
    }

    #endregion
    /// <summary>
    /// El método de Newton-Raphson es un método de aproximación utilizado
    /// para encontrar raíces de una función. Se basa en la idea de utilizar 
    /// la derivada de la función para aproximar la posición de la raíz.
    /// El método comienza con una estimación inicial y, en cada iteración, 
    /// se calcula una nueva aproximación mediante una fórmula que involucra
    /// la evaluación de la función y su derivada en el punto actual. Esto
    /// permite una convergencia rápida hacia la raíz, especialmente cuando
    /// se tiene una buena estimación inicial y la función es suave y bien
    /// comportada. Sin embargo, el método puede presentar dificultades
    /// cuando se encuentran puntos de inflexión, raíces múltiples o la derivada
    /// se aproxima a cero, lo que puede llevar a la divergencia o la convergencia
    /// hacia raíces incorrectas. Por lo tanto, se recomienda evaluar cuidadosamente 
    /// la función y su comportamiento local antes de aplicar el método de Newton-Raphson.
    /// </summary>
    /// <param name="func"></param>
    /// <param name="x0"></param>
    /// <param name="n"></param>
    /// <param name="eps"></param>
    /// <returns></returns>
    #region NewthonRhapson
    public List<NewthonRhapsonAproximate> NewtonRaphson(string func, double x0, int n, double eps)
    {
        // Lista para almacenar los resultados de las aproximaciones
        List<NewthonRhapsonAproximate> iterations = new List<NewthonRhapsonAproximate>();

        // Inicializar la variable xi con el valor inicial x0
        double xi = x0;

        // Contador de iteraciones
        int iterationCount = 0;

        // Error inicial
        double error = double.MaxValue;

        // Realizar iteraciones hasta alcanzar el número máximo de iteraciones o el error sea menor que la tolerancia
        while (iterationCount < n && error > eps)
        {
            // Crear un objeto para almacenar el resultado de la iteración actual
            NewthonRhapsonAproximate iteration = new NewthonRhapsonAproximate();

            // Asignar los valores al objeto de la iteración
            iteration.Iteration = iterationCount;
            iteration.Xi = xi;
            iteration.Fxi = ValidateFunctions.GetFunction(func, xi);
            iteration.DerivateFxi = ValidateFunctions.Derivada(func, xi, 1);

            // Calcular el próximo valor de xi utilizando el método de Newton-Raphson
            xi = iteration.Xi_1;

            // Calcular el error absoluto entre el valor anterior de xi y el nuevo xi
            error = Math.Abs(xi - iteration.Xi);

            // Incrementar el contador de iteraciones
            iterationCount++;

            // Agregar el resultado de la iteración a la lista
            iterations.Add(iteration);
        }

        // Devolver la lista de resultados de las aproximaciones
        return iterations;
    }

    #endregion

    #region SecantAproximate
    /// <summary>
    /// El método de la secante es un método numérico utilizado para encontrar
    /// raíces de una función. A diferencia del método de Newton-Raphson,
    /// el método de la secante no requiere el cálculo de la derivada de
    /// la función. En cambio, se aproxima la derivada mediante una línea 
    /// secante que pasa por dos puntos cercanos en la curva de la función.
    /// En cada iteración, se calcula un nuevo punto de intersección de la 
    /// línea secante con el eje x, y este nuevo punto se utiliza como
    /// aproximación para la raíz en la siguiente iteración. El método
    /// de la secante es efectivo cuando no se dispone de la derivada de 
    /// la función o cuando el cálculo de la derivada es costoso. Sin embargo,
    /// el método puede ser menos convergente que el método de Newton-Raphson y
    /// puede requerir un mayor número de iteraciones para alcanzar la precisión 
    /// deseada. Además, el método de la secante puede ser sensible a la elección
    /// de los puntos iniciales, y en algunos casos puede conducir a divergencia si 
    /// los puntos iniciales no se seleccionan adecuadamente. Por lo tanto, 
    /// es importante tener en cuenta estas consideraciones al utilizar el método de la secante.
    /// </summary>
    /// <param name="func"></param>
    /// <param name="xa"></param>
    /// <param name="xb"></param>
    /// <param name="error"></param>
    /// <param name="maxIterations"></param>
    /// <returns></returns>
    public IList<SecantAproximate> SecantMethod(string func, double xa, double xb, double error, int maxIterations)
    {
        // Lista para almacenar los resultados de las aproximaciones
        List<SecantAproximate> iterations = new List<SecantAproximate>();

        // Obtener los valores iniciales de las funciones evaluadas en xa y xb
        double fxa = ValidateFunctions.GetFunction(func, xa);
        double fxb = ValidateFunctions.GetFunction(func, xb);

        // Variables para almacenar los valores de las aproximaciones anteriores
        double xi_1 = xa;
        double currentError = error + 1;

        // Contador de iteraciones
        int iteration = 0;

        // Realizar iteraciones hasta que el error sea menor que la tolerancia o se alcance el número máximo de iteraciones
        while (currentError > error && iteration < maxIterations)
        {
            // Calcular el nuevo valor de xi utilizando el método de la secante
            double xi = xb - (fxb * (xa - xb)) / (fxa - fxb);

            // Calcular el error absoluto entre el valor anterior de xi y el nuevo xi
            currentError = Math.Abs((xi - xi_1) / xi);

            // Actualizar los valores de las aproximaciones anteriores
            xi_1 = xi;
            xa = xb;
            fxa = fxb;

            // Actualizar los valores de xb y fxb con los nuevos valores de xi
            xb = xi_1;
            fxb = ValidateFunctions.GetFunction(func, xb);

            // Incrementar el contador de iteraciones
            iteration++;

            // Agregar el resultado de la iteración a la lista
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

        // Devolver la lista de resultados de las aproximaciones
        return iterations;
    }

    #endregion

    /// <summary>
    /// El método del punto fijo es un método de aproximación utilizado 
    /// para encontrar soluciones de ecuaciones de la forma "x = g(x)". 
    /// Consiste en realizar iteraciones sucesivas utilizando una función
    /// "g(x)" para obtener nuevas aproximaciones de la solución.
    /// El método no requiere el cálculo de derivadas y su convergencia
    /// depende de la elección adecuada de la función "g(x)" y la estimación 
    /// inicial.Aunque puede ser más sencillo de implementar que otros métodos, 
    /// la convergencia puede ser lenta y la elección de la función y la estimación
    /// inicial es crucial para obtener resultados precisos y rápidos.
    /// </summary>
    /// <param name="func"></param>
    /// <param name="x0"></param>
    /// <param name="error"></param>
    /// <param name="maxIterations"></param>
    /// <returns></returns>
    #region FixedAproximate
    public IList<FixedPointProperties> FixedPointMethod(string func, double x0, double error, int maxIterations)
    {
        // Lista para almacenar los resultados de las aproximaciones
        List<FixedPointProperties> iterations = new List<FixedPointProperties>();

        // Obtener el valor inicial de g(x0)
        double gx = ValidateFunctions.GetFunction(func, x0);

        // Contador de iteraciones
        int iteration = 0;

        // Error inicial
        double currentError = error + 1;

        // Realizar iteraciones hasta que el error sea menor que la tolerancia o se alcance el número máximo de iteraciones
        while (currentError > error && iteration < maxIterations)
        {
            // Calcular el nuevo valor de x utilizando la función g(x)
            double x = gx;

            // Calcular el valor de g(x)
            gx = ValidateFunctions.GetFunction(func, x);

            // Calcular el error absoluto entre el valor anterior de g(x) y el nuevo g(x)
            currentError = Math.Abs((gx - x) / gx);

            // Incrementar el contador de iteraciones
            iteration++;

            // Agregar el resultado de la iteración a la lista
            iterations.Add(new FixedPointProperties
            {
                Iteration = iteration,
                X = x,
                Gx = gx,
                Error = currentError
            });
        }

        // Devolver la lista de resultados de las aproximaciones
        return iterations;
    }

    #endregion



    #region MullerIteration
    /// <summary>
    /// El método de Muller es un método numérico para encontrar 
    /// raíces de una función.Combina conceptos de la interpolación
    /// cuadrática inversa y el método de la secante. Utiliza tres 
    /// puntos iniciales y una fórmula de interpolación para calcular
    /// nuevas aproximaciones de la raíz en cada iteración.Es útil para
    /// raíces complejas y raíces cercanas. Sin embargo, puede presentar 
    /// dificultades como convergencia a raíces incorrectas o divergencia 
    /// si los puntos iniciales no son apropiados.Se requiere una cuidadosa 
    /// selección de los puntos iniciales y considerar el comportamiento 
    /// de la función antes de usar el método de Muller.
    /// </summary>
    /// <param name="function"></param>
    /// <param name="x0"></param>
    /// <param name="x1"></param>
    /// <param name="x2"></param>
    /// <param name="tol"></param>
    /// <param name="maxIter"></param>
    /// <returns></returns>
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
