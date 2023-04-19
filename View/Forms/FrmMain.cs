using Microsoft.Extensions.DependencyInjection;
using NumericMethod.Services.Interfaces;
using View.Components;
using View.Utils;

namespace View.Forms;

public partial class FrmMain : Form
{
    private readonly IAproximateMethods aproximateMethods;

    public FrmMain(IAproximateMethods aproximateMethods)
    {
        InitializeComponent();
        this.aproximateMethods = aproximateMethods;
    }

    private void FrmMain_Load(object sender, EventArgs e)
    {
        cmbData.Items.AddRange(Enum.GetValues(typeof(Methods)).Cast<object>().ToArray());
    }

    private void cmbData_SelectedIndexChanged(object sender, EventArgs e)
    {
        switch (cmbData.SelectedItem)
        {
            case Methods.Bisection_Method:
                this.Hide();
                new FrmBisection(aproximateMethods).Show();
                break;
            case Methods.False_Rule_Method:
                this.Hide();
                new FrmFalseRule(aproximateMethods).Show();
                break;
            case Methods.Newton_Raphson:
                this.Hide();
                new FrmNewtonRaphson(aproximateMethods).Show();
                break;
            case Methods.Secant_Method:
                this.Hide();
                new FrmSecantMethod(aproximateMethods).Show();
                break;
            case Methods.Fixed_Point_Method:
                this.Hide();
                new FrmFixedPoint(aproximateMethods).Show();
                break;
            case Methods.Muller_Method:
                this.Hide();
                new FrmMullerMethod(aproximateMethods).Show();
                break;
            case Methods.Bairstow_Method:
                this.Hide();
                new FrmBairstow(aproximateMethods).Show();
                break;
            case Methods.Nonlinear_System_Equations_Raphson:
                this.Hide();
                new FrmEqNonLinear(aproximateMethods).Show();
                break;
        }
    }
}