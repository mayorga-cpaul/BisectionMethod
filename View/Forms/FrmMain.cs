using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Util;

namespace View.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            dtgData.DataSource = null;

            var data = AproximateMethods.BisectionMethod
                                          (
                                          txtFunction.Text, 
                                          Double.Parse(txtXa.Text), 
                                          Double.Parse(txtXb.Text), 
                                          0.003d
                                          );

            dtgData.DataSource = data;
        }
    }
}
