namespace View.Components
{
    partial class FrmNewtonRaphson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewtonRaphson));
            this.airForm1 = new ReaLTaiizor.Forms.AirForm();
            this.lblIt = new ReaLTaiizor.Controls.BigLabel();
            this.txtError = new ReaLTaiizor.Controls.BigTextBox();
            this.bigLabel4 = new ReaLTaiizor.Controls.BigLabel();
            this.txtIterations = new ReaLTaiizor.Controls.BigTextBox();
            this.bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            this.txtXa = new ReaLTaiizor.Controls.BigTextBox();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.btnTest = new ReaLTaiizor.Controls.AloneButton();
            this.txtFunction = new ReaLTaiizor.Controls.BigTextBox();
            this.dtgData = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.airForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // airForm1
            // 
            this.airForm1.BackColor = System.Drawing.Color.White;
            this.airForm1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.airForm1.Controls.Add(this.btnExit);
            this.airForm1.Controls.Add(this.lblIt);
            this.airForm1.Controls.Add(this.txtError);
            this.airForm1.Controls.Add(this.bigLabel4);
            this.airForm1.Controls.Add(this.txtIterations);
            this.airForm1.Controls.Add(this.bigLabel2);
            this.airForm1.Controls.Add(this.txtXa);
            this.airForm1.Controls.Add(this.bigLabel1);
            this.airForm1.Controls.Add(this.btnTest);
            this.airForm1.Controls.Add(this.txtFunction);
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
            this.airForm1.Text = "Newton Raphson Method";
            this.airForm1.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.airForm1.Transparent = false;
            // 
            // lblIt
            // 
            this.lblIt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblIt.AutoSize = true;
            this.lblIt.BackColor = System.Drawing.Color.Transparent;
            this.lblIt.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblIt.Location = new System.Drawing.Point(281, 561);
            this.lblIt.Name = "lblIt";
            this.lblIt.Size = new System.Drawing.Size(75, 35);
            this.lblIt.TabIndex = 61;
            this.lblIt.Text = "Error:";
            // 
            // txtError
            // 
            this.txtError.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtError.BackColor = System.Drawing.Color.Transparent;
            this.txtError.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtError.ForeColor = System.Drawing.Color.DimGray;
            this.txtError.Image = null;
            this.txtError.Location = new System.Drawing.Point(363, 554);
            this.txtError.MaxLength = 32767;
            this.txtError.Multiline = false;
            this.txtError.Name = "txtError";
            this.txtError.ReadOnly = false;
            this.txtError.Size = new System.Drawing.Size(363, 46);
            this.txtError.TabIndex = 60;
            this.txtError.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtError.UseSystemPasswordChar = false;
            // 
            // bigLabel4
            // 
            this.bigLabel4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bigLabel4.AutoSize = true;
            this.bigLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bigLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel4.Location = new System.Drawing.Point(479, 507);
            this.bigLabel4.Name = "bigLabel4";
            this.bigLabel4.Size = new System.Drawing.Size(141, 35);
            this.bigLabel4.TabIndex = 59;
            this.bigLabel4.Text = "Iteraciones:";
            // 
            // txtIterations
            // 
            this.txtIterations.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtIterations.BackColor = System.Drawing.Color.Transparent;
            this.txtIterations.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIterations.ForeColor = System.Drawing.Color.DimGray;
            this.txtIterations.Image = null;
            this.txtIterations.Location = new System.Drawing.Point(626, 500);
            this.txtIterations.MaxLength = 32767;
            this.txtIterations.Multiline = false;
            this.txtIterations.Name = "txtIterations";
            this.txtIterations.ReadOnly = false;
            this.txtIterations.Size = new System.Drawing.Size(100, 46);
            this.txtIterations.TabIndex = 58;
            this.txtIterations.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIterations.UseSystemPasswordChar = false;
            // 
            // bigLabel2
            // 
            this.bigLabel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bigLabel2.AutoSize = true;
            this.bigLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bigLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel2.Location = new System.Drawing.Point(283, 507);
            this.bigLabel2.Name = "bigLabel2";
            this.bigLabel2.Size = new System.Drawing.Size(74, 35);
            this.bigLabel2.TabIndex = 57;
            this.bigLabel2.Text = "Xa = ";
            // 
            // txtXa
            // 
            this.txtXa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtXa.BackColor = System.Drawing.Color.Transparent;
            this.txtXa.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtXa.ForeColor = System.Drawing.Color.DimGray;
            this.txtXa.Image = null;
            this.txtXa.Location = new System.Drawing.Point(363, 500);
            this.txtXa.MaxLength = 32767;
            this.txtXa.Multiline = false;
            this.txtXa.Name = "txtXa";
            this.txtXa.ReadOnly = false;
            this.txtXa.Size = new System.Drawing.Size(100, 46);
            this.txtXa.TabIndex = 56;
            this.txtXa.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtXa.UseSystemPasswordChar = false;
            // 
            // bigLabel1
            // 
            this.bigLabel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.Location = new System.Drawing.Point(283, 429);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(74, 35);
            this.bigLabel1.TabIndex = 55;
            this.bigLabel1.Text = "f(x) =";
            // 
            // btnTest
            // 
            this.btnTest.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTest.BackColor = System.Drawing.Color.White;
            this.btnTest.EnabledCalc = true;
            this.btnTest.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.btnTest.Location = new System.Drawing.Point(363, 606);
            this.btnTest.MaximumSize = new System.Drawing.Size(363, 46);
            this.btnTest.MinimumSize = new System.Drawing.Size(363, 46);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(363, 46);
            this.btnTest.TabIndex = 54;
            this.btnTest.Text = "Calcular";
            this.btnTest.Click += new ReaLTaiizor.Controls.AloneButton.ClickEventHandler(this.btnTest_Click);
            // 
            // txtFunction
            // 
            this.txtFunction.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtFunction.BackColor = System.Drawing.Color.Transparent;
            this.txtFunction.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFunction.ForeColor = System.Drawing.Color.DimGray;
            this.txtFunction.Image = null;
            this.txtFunction.Location = new System.Drawing.Point(363, 429);
            this.txtFunction.MaxLength = 32767;
            this.txtFunction.Multiline = false;
            this.txtFunction.Name = "txtFunction";
            this.txtFunction.ReadOnly = false;
            this.txtFunction.Size = new System.Drawing.Size(363, 46);
            this.txtFunction.TabIndex = 53;
            this.txtFunction.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFunction.UseSystemPasswordChar = false;
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
            this.dtgData.Location = new System.Drawing.Point(39, 49);
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
            this.dtgData.Size = new System.Drawing.Size(984, 362);
            this.dtgData.TabIndex = 52;
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(996, 606);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(39, 46);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 62;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmNewtonRaphson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 700);
            this.Controls.Add(this.airForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNewtonRaphson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNewtonRaphson";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.airForm1.ResumeLayout(false);
            this.airForm1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.AirForm airForm1;
        private ReaLTaiizor.Controls.BigLabel lblIt;
        private ReaLTaiizor.Controls.BigTextBox txtError;
        private ReaLTaiizor.Controls.BigLabel bigLabel4;
        private ReaLTaiizor.Controls.BigTextBox txtIterations;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.BigTextBox txtXa;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.AloneButton btnTest;
        private ReaLTaiizor.Controls.BigTextBox txtFunction;
        private ReaLTaiizor.Controls.PoisonDataGridView dtgData;
        private PictureBox btnExit;
    }
}