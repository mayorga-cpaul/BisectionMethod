using NumericMethod.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Utils;

namespace View.Components
{
    public partial class FrmMullerMethod : Form
    {
        private readonly IAproximateMethods aproximateMethods;
        public FrmMullerMethod(IAproximateMethods aproximateMethods)
        {
            InitializeComponent();
            this.aproximateMethods = aproximateMethods;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            dtgData.DataSource = null;

            var data = aproximateMethods.MullerMethod
                                          (
                                          txtFunction.Text,
                                          Double.Parse(txtX0.Text),
                                          Double.Parse(txtX1.Text),
                                          Double.Parse(txtX2.Text),
                                          Double.Parse(txtError.Text),
                                          int.Parse(txtIterations.Text)
                                          );

            dtgData.DataSource = data;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            InitForm.GetView().Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            new FrmFunc(txtFunction.Text).Show();
        }
    }
}
