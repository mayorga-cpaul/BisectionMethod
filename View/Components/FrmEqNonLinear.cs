using NumericMethod.Services.Interfaces;
using NumericMethod.Services.Util;
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
    public partial class FrmEqNonLinear : Form
    {
        private readonly IAproximateMethods aproximateMethods;
        public FrmEqNonLinear(IAproximateMethods aproximateMethods)
        {
            InitializeComponent();
            this.aproximateMethods = aproximateMethods;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            dtgData.DataSource = null;

            var data = aproximateMethods.MetodoNewtonRaphsonParaSENoLineales
                                          (txtFunctionOne.Text, txtFunctionTwo.Text, Double.Parse(txtX0.Text), Double.Parse(txtX1.Text),
                                          Double.Parse(txtTolerancia.Text)
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

        }
    }
}
