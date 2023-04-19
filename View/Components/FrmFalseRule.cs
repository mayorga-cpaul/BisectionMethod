﻿using NumericMethod.Services.Interfaces;
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
    public partial class FrmFalseRule : Form
    {
        private readonly IAproximateMethods aproximateMethods;
        public FrmFalseRule(IAproximateMethods aproximateMethods)
        {
            InitializeComponent();
            this.aproximateMethods = aproximateMethods;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            dtgData.DataSource = null;

            var data = aproximateMethods.FalseRuleMethod
                                          (
                                          txtFunction.Text,
                                          Double.Parse(txtXa.Text),
                                          Double.Parse(txtXb.Text),
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
    }
}
