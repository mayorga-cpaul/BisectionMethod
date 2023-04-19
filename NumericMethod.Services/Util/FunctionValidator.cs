using System.CodeDom.Compiler;
using Microsoft.CSharp;

namespace NumericMethod.Services.Util;

public class FunctionValidator
{
    public static bool Validate(string function)
    {
        try
        {
            // Compile the function as a lambda expression
            var provider = new CSharpCodeProvider();
            var parameters = new CompilerParameters { GenerateInMemory = true };
            var source = "Func<double, double> func = (x) => " + function + ";";
            var results = provider.CompileAssemblyFromSource(parameters, source);
            var method = results.CompiledAssembly.GetType().GetMethod("func");

            // Check that the function is valid by evaluating it at x=0
            var result = (double)method.Invoke(null, new object[] { 0.0 });
            if (double.IsNaN(result) || double.IsInfinity(result))
            {
                return false; // Function is not valid
            }

            // Check that the function is continuous on the x axis by evaluating it at a range of values
            var step = 0.001;
            var start = -100.0;
            var end = 100.0;
            var values = Enumerable.Range(0, (int)((end - start) / step))
                                    .Select(i => start + i * step);
            foreach (var value in values)
            {
                try
                {
                    result = (double)method.Invoke(null, new object[] { value });
                    if (double.IsNaN(result) || double.IsInfinity(result))
                    {
                        return false; // Function is not continuous on x axis
                    }
                }
                catch
                {
                    // Treat exceptions as infinity
                    result = double.PositiveInfinity;
                }
            }

            // Function is valid and continuous on the x axis
            return true;
        }
        catch
        {
            return false; // Function is not valid
        }
    }


    public static bool ValidateTwoVariables(string function)
    {
        try
        {
            // Compile the function as a lambda expression
            var provider = new CSharpCodeProvider();
            var parameters = new CompilerParameters { GenerateInMemory = true };
            var source = "Func<double, double, double> func = (x, y) => " + function + ";";
            var results = provider.CompileAssemblyFromSource(parameters, source);
            var method = results.CompiledAssembly.GetType().GetMethod("func");

            // Check that the function is valid by evaluating it at x=0 and y=0
            var result = (double)method.Invoke(null, new object[] { 0.0, 0.0 });
            if (double.IsNaN(result) || double.IsInfinity(result))
            {
                return false; // Function is not valid
            }

            // Check that the function is continuous on both x and y axes by evaluating it at a grid of values
            var step = 0.001;
            var startX = -100.0;
            var endX = 100.0;
            var startY = -100.0;
            var endY = 100.0;
            var xValues = Enumerable.Range(0, (int)((endX - startX) / step))
                                     .Select(i => startX + i * step);
            var yValues = Enumerable.Range(0, (int)((endY - startY) / step))
                                     .Select(i => startY + i * step);
            foreach (var x in xValues)
            {
                foreach (var y in yValues)
                {
                    result = (double)method.Invoke(null, new object[] { x, y });
                    if (double.IsNaN(result) || double.IsInfinity(result))
                    {
                        return false; // Function is not continuous on both x and y axes
                    }
                }
            }

            // Function is valid and continuous on both x and y axes
            return true;
        }
        catch
        {
            return false; // Function is not valid
        }
    }
}