using NumericMethod.Services.Interfaces;
using View.Utils;

namespace View.Components;

public partial class FrmCoeficientes : Form
{
    private List<double> doubles = new List<double>();

    private readonly IAproximateMethods aproximateMethods;
    public FrmCoeficientes(IAproximateMethods aproximateMethods)
    {
        InitializeComponent();
        this.aproximateMethods = aproximateMethods;
    }
    private void aloneButton2_Click(object sender, EventArgs e)
    {
        new FrmBairstowMethod(aproximateMethods).Show();
    }

    private void btnTest_Click(object sender, EventArgs e)
    {
        Double.TryParse(txtFunction.Text, out double coeficient);

        doubles.Add(coeficient);

        if (doubles.Count == BairstowCache.Degree)
        {
            BairstowCache.Coeficients = doubles;
            aloneButton2.Visible = true;
        }
    }

    private void aloneButton1_Click(object sender, EventArgs e)
    {
        doubles.Remove(doubles.Last());
    }
}
