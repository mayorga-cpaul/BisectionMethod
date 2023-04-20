namespace View.Components
{
    partial class FrmBairstowMethod
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBairstowMethod));
            this.airForm1 = new ReaLTaiizor.Forms.AirForm();
            this.txtFunction = new ReaLTaiizor.Controls.FoxBigLabel();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.txtIteration = new ReaLTaiizor.Controls.BigTextBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.bigLabel5 = new ReaLTaiizor.Controls.BigLabel();
            this.txtError = new ReaLTaiizor.Controls.BigTextBox();
            this.bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            this.bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            this.txtSb = new ReaLTaiizor.Controls.BigTextBox();
            this.txtSa = new ReaLTaiizor.Controls.BigTextBox();
            this.btnTest = new ReaLTaiizor.Controls.AloneButton();
            this.dtgData = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.bigLabel6 = new ReaLTaiizor.Controls.BigLabel();
            this.btnView = new System.Windows.Forms.PictureBox();
            this.airForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnView)).BeginInit();
            this.SuspendLayout();
            // 
            // airForm1
            // 
            this.airForm1.BackColor = System.Drawing.Color.White;
            this.airForm1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.airForm1.Controls.Add(this.bigLabel6);
            this.airForm1.Controls.Add(this.btnView);
            this.airForm1.Controls.Add(this.txtFunction);
            this.airForm1.Controls.Add(this.bigLabel1);
            this.airForm1.Controls.Add(this.txtIteration);
            this.airForm1.Controls.Add(this.btnExit);
            this.airForm1.Controls.Add(this.bigLabel5);
            this.airForm1.Controls.Add(this.txtError);
            this.airForm1.Controls.Add(this.bigLabel3);
            this.airForm1.Controls.Add(this.bigLabel2);
            this.airForm1.Controls.Add(this.txtSb);
            this.airForm1.Controls.Add(this.txtSa);
            this.airForm1.Controls.Add(this.btnTest);
            this.airForm1.Controls.Add(this.dtgData);
            this.airForm1.Customization = "AAAA/1paWv9ycnL/";
            this.airForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.airForm1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.airForm1.Image = null;
            this.airForm1.Location = new System.Drawing.Point(0, 0);
            this.airForm1.MinimumSize = new System.Drawing.Size(112, 35);
            this.airForm1.Movable = true;
            this.airForm1.Name = "airForm1";
            this.airForm1.NoRounding = false;
            this.airForm1.Sizable = true;
            this.airForm1.Size = new System.Drawing.Size(1063, 700);
            this.airForm1.SmartBounds = true;
            this.airForm1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.airForm1.TabIndex = 0;
            this.airForm1.Text = "Bairstow";
            this.airForm1.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.airForm1.Transparent = false;
            // 
            // txtFunction
            // 
            this.txtFunction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFunction.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFunction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.txtFunction.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Bottom;
            this.txtFunction.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtFunction.Location = new System.Drawing.Point(155, 396);
            this.txtFunction.Name = "txtFunction";
            this.txtFunction.Size = new System.Drawing.Size(851, 64);
            this.txtFunction.TabIndex = 51;
            this.txtFunction.Text = "x^(5) - 3.5x^(4)+2.75x^(3) + 2.125x^(2) - 3.875x + 1.25";
            // 
            // bigLabel1
            // 
            this.bigLabel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.Location = new System.Drawing.Point(497, 518);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(124, 35);
            this.bigLabel1.TabIndex = 50;
            this.bigLabel1.Text = "Iterations:";
            // 
            // txtIteration
            // 
            this.txtIteration.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtIteration.BackColor = System.Drawing.Color.Transparent;
            this.txtIteration.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIteration.ForeColor = System.Drawing.Color.DimGray;
            this.txtIteration.Image = null;
            this.txtIteration.Location = new System.Drawing.Point(627, 518);
            this.txtIteration.MaxLength = 32767;
            this.txtIteration.Multiline = false;
            this.txtIteration.Name = "txtIteration";
            this.txtIteration.ReadOnly = false;
            this.txtIteration.Size = new System.Drawing.Size(100, 46);
            this.txtIteration.TabIndex = 49;
            this.txtIteration.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIteration.UseSystemPasswordChar = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(984, 569);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(39, 46);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 48;
            this.btnExit.TabStop = false;
            // 
            // bigLabel5
            // 
            this.bigLabel5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bigLabel5.AutoSize = true;
            this.bigLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bigLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel5.Location = new System.Drawing.Point(283, 518);
            this.bigLabel5.Name = "bigLabel5";
            this.bigLabel5.Size = new System.Drawing.Size(75, 35);
            this.bigLabel5.TabIndex = 47;
            this.bigLabel5.Text = "Error:";
            // 
            // txtError
            // 
            this.txtError.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtError.BackColor = System.Drawing.Color.Transparent;
            this.txtError.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtError.ForeColor = System.Drawing.Color.DimGray;
            this.txtError.Image = null;
            this.txtError.Location = new System.Drawing.Point(391, 517);
            this.txtError.MaxLength = 32767;
            this.txtError.Multiline = false;
            this.txtError.Name = "txtError";
            this.txtError.ReadOnly = false;
            this.txtError.Size = new System.Drawing.Size(100, 46);
            this.txtError.TabIndex = 46;
            this.txtError.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtError.UseSystemPasswordChar = false;
            // 
            // bigLabel3
            // 
            this.bigLabel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bigLabel3.AutoSize = true;
            this.bigLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bigLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel3.Location = new System.Drawing.Point(498, 466);
            this.bigLabel3.Name = "bigLabel3";
            this.bigLabel3.Size = new System.Drawing.Size(108, 35);
            this.bigLabel3.TabIndex = 45;
            this.bigLabel3.Text = "R Guess:";
            // 
            // bigLabel2
            // 
            this.bigLabel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bigLabel2.AutoSize = true;
            this.bigLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bigLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel2.Location = new System.Drawing.Point(284, 470);
            this.bigLabel2.Name = "bigLabel2";
            this.bigLabel2.Size = new System.Drawing.Size(104, 35);
            this.bigLabel2.TabIndex = 44;
            this.bigLabel2.Text = "S guess:";
            // 
            // txtSb
            // 
            this.txtSb.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtSb.BackColor = System.Drawing.Color.Transparent;
            this.txtSb.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSb.ForeColor = System.Drawing.Color.DimGray;
            this.txtSb.Image = null;
            this.txtSb.Location = new System.Drawing.Point(627, 466);
            this.txtSb.MaxLength = 32767;
            this.txtSb.Multiline = false;
            this.txtSb.Name = "txtSb";
            this.txtSb.ReadOnly = false;
            this.txtSb.Size = new System.Drawing.Size(100, 46);
            this.txtSb.TabIndex = 43;
            this.txtSb.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSb.UseSystemPasswordChar = false;
            // 
            // txtSa
            // 
            this.txtSa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtSa.BackColor = System.Drawing.Color.Transparent;
            this.txtSa.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSa.ForeColor = System.Drawing.Color.DimGray;
            this.txtSa.Image = null;
            this.txtSa.Location = new System.Drawing.Point(392, 466);
            this.txtSa.MaxLength = 32767;
            this.txtSa.Multiline = false;
            this.txtSa.Name = "txtSa";
            this.txtSa.ReadOnly = false;
            this.txtSa.Size = new System.Drawing.Size(100, 46);
            this.txtSa.TabIndex = 42;
            this.txtSa.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSa.UseSystemPasswordChar = false;
            // 
            // btnTest
            // 
            this.btnTest.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTest.BackColor = System.Drawing.Color.White;
            this.btnTest.EnabledCalc = true;
            this.btnTest.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.btnTest.Location = new System.Drawing.Point(392, 569);
            this.btnTest.MaximumSize = new System.Drawing.Size(363, 46);
            this.btnTest.MinimumSize = new System.Drawing.Size(100, 50);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(335, 50);
            this.btnTest.TabIndex = 41;
            this.btnTest.Text = "Calcular";
            this.btnTest.Click += new ReaLTaiizor.Controls.AloneButton.ClickEventHandler(this.btnTest_Click);
            // 
            // dtgData
            // 
            this.dtgData.AllowUserToResizeRows = false;
            this.dtgData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgData.BackgroundColor = System.Drawing.Color.White;
            this.dtgData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgData.EnableHeadersVisualStyles = false;
            this.dtgData.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtgData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgData.Location = new System.Drawing.Point(52, 50);
            this.dtgData.MultiSelect = false;
            this.dtgData.Name = "dtgData";
            this.dtgData.ReadOnly = true;
            this.dtgData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgData.RowHeadersWidth = 51;
            this.dtgData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgData.RowTemplate.Height = 29;
            this.dtgData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgData.Size = new System.Drawing.Size(984, 323);
            this.dtgData.TabIndex = 40;
            // 
            // bigLabel6
            // 
            this.bigLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bigLabel6.AutoSize = true;
            this.bigLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bigLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel6.Location = new System.Drawing.Point(773, 470);
            this.bigLabel6.Name = "bigLabel6";
            this.bigLabel6.Size = new System.Drawing.Size(56, 35);
            this.bigLabel6.TabIndex = 53;
            this.bigLabel6.Text = "Ver:";
            // 
            // btnView
            // 
            this.btnView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.Location = new System.Drawing.Point(835, 470);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(39, 46);
            this.btnView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnView.TabIndex = 52;
            this.btnView.TabStop = false;
            // 
            // FrmBairstowMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 700);
            this.Controls.Add(this.airForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1600, 1000);
            this.Name = "FrmBairstowMethod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBairstowMethod";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.airForm1.ResumeLayout(false);
            this.airForm1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.AirForm airForm1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.BigTextBox txtIteration;
        private PictureBox btnExit;
        private ReaLTaiizor.Controls.BigLabel bigLabel5;
        private ReaLTaiizor.Controls.BigTextBox txtError;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.BigTextBox txtSb;
        private ReaLTaiizor.Controls.BigTextBox txtSa;
        private ReaLTaiizor.Controls.AloneButton btnTest;
        private ReaLTaiizor.Controls.PoisonDataGridView dtgData;
        private ReaLTaiizor.Controls.FoxBigLabel txtFunction;
        private ReaLTaiizor.Controls.BigLabel bigLabel6;
        private PictureBox btnView;
    }
}