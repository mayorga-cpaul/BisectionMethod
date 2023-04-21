using NumericMethod.Services.Interfaces;
using NumericMethod.Services.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using View.Utils;

namespace View.Components;

public partial class FrmBisection : Form
{
    private readonly IAproximateMethods aproximateMethods;
    public FrmBisection(IAproximateMethods aproximateMethods)
    {
        InitializeComponent();
        this.aproximateMethods = aproximateMethods;
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        this.Close();
        InitForm.GetView().Show();
    }

    private void btnTest_Click(object sender, EventArgs e)
    {
        dtgData.DataSource = null;

        var data = aproximateMethods.BisectionMethod
                                      (
                                      txtFunction.Text,
                                      Double.Parse(txtXa.Text),
                                      Double.Parse(txtXb.Text),
                                      Double.Parse(txtError.Text),
                                      int.Parse(txtIterations.Text)
                                      );

        dtgData.DataSource = data;
    }

    private void btnView_Click(object sender, EventArgs e)
    {
        new FrmFunc(txtFunction.Text).Show();

    }
}
