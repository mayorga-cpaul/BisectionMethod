using OxyPlot.Series;
using OxyPlot;
using org.mariuszgromada.math.mxparser;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using OxyPlot.WindowsForms;

namespace View.Components;

public partial class FrmFunc : Form
{
    public FrmFunc(string Function)
    {
        InitializeComponent();
        this.plotView1.Model = GetPlotModel(Function);
    }

    public PlotModel GetPlotModel(string function)
    {
        // Crear un modelo de trazado
        var plotModel = new PlotModel();

        // Establecer los títulos de los ejes
        plotModel.Axes.Add(new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Bottom, Title = "X", Minimum = -50, Maximum = 50, IsZoomEnabled = true });
        plotModel.Axes.Add(new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Left, Title = "Y", Minimum = -50, Maximum = 50, IsZoomEnabled = true });

        // Crear una función a partir del string de entrada
        LambdaExpression lambda = DynamicExpressionParser.ParseLambda(new[] { System.Linq.Expressions.Expression.Parameter(typeof(double), "x") }, null, function); // analiza la expresión
        Delegate compiled = lambda.Compile(); // compile the expression
        Func<double, double> data = (Func<double, double>)Convert.ChangeType(compiled, typeof(Func<double, double>));

        // Crear una serie de función y agregarla al modelo de trazado
        plotModel.Series.Add(new FunctionSeries(data, -500000, 500000, 0.1, "Math.Pow(x,3)"));
        //Devolver el modelo de trazado
        return plotModel;
    }

    private void FrmFunc_Load(object sender, EventArgs e)
    {

    }

}

