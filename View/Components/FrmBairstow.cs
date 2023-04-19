using NumericMethod.Services.Interfaces;
using View.Utils;

namespace View.Components
{
    public partial class FrmBairstow : Form
    {
        private readonly IAproximateMethods aproximateMethods;
        public FrmBairstow(IAproximateMethods aproximateMethods)
        {
            InitializeComponent();
            this.aproximateMethods = aproximateMethods;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            int.TryParse(txtIteration.Text,out int degree);
            BairstowCache.Degree = degree + 1;
            this.Close();
            new FrmCoeficientes(aproximateMethods).Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            InitForm.GetView().Show();
        }
    }
}
