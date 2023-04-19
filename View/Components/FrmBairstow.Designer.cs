namespace View.Components
{
    partial class FrmBairstow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBairstow));
            this.Degree = new ReaLTaiizor.Forms.AirForm();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.btnTest = new ReaLTaiizor.Controls.AloneButton();
            this.txtIteration = new ReaLTaiizor.Controls.BigTextBox();
            this.Degree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // Degree
            // 
            this.Degree.BackColor = System.Drawing.Color.White;
            this.Degree.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Degree.Controls.Add(this.txtIteration);
            this.Degree.Controls.Add(this.btnExit);
            this.Degree.Controls.Add(this.bigLabel1);
            this.Degree.Controls.Add(this.btnTest);
            this.Degree.Customization = "AAAA/1paWv9ycnL/";
            this.Degree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Degree.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Degree.Image = null;
            this.Degree.Location = new System.Drawing.Point(0, 0);
            this.Degree.MinimumSize = new System.Drawing.Size(112, 35);
            this.Degree.Movable = true;
            this.Degree.Name = "Degree";
            this.Degree.NoRounding = false;
            this.Degree.Sizable = true;
            this.Degree.Size = new System.Drawing.Size(500, 300);
            this.Degree.SmartBounds = true;
            this.Degree.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Degree.TabIndex = 0;
            this.Degree.Text = "Degree";
            this.Degree.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Degree.Transparent = false;
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(449, 192);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(39, 46);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 59;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // bigLabel1
            // 
            this.bigLabel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.Location = new System.Drawing.Point(58, 66);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(299, 35);
            this.bigLabel1.TabIndex = 44;
            this.bigLabel1.Text = "Degree of the polynomial";
            // 
            // btnTest
            // 
            this.btnTest.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTest.BackColor = System.Drawing.Color.White;
            this.btnTest.EnabledCalc = true;
            this.btnTest.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.btnTest.Location = new System.Drawing.Point(58, 192);
            this.btnTest.MaximumSize = new System.Drawing.Size(363, 46);
            this.btnTest.MinimumSize = new System.Drawing.Size(363, 46);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(363, 46);
            this.btnTest.TabIndex = 43;
            this.btnTest.Text = "Next";
            this.btnTest.Click += new ReaLTaiizor.Controls.AloneButton.ClickEventHandler(this.btnTest_Click);
            // 
            // txtIteration
            // 
            this.txtIteration.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtIteration.BackColor = System.Drawing.Color.Transparent;
            this.txtIteration.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIteration.ForeColor = System.Drawing.Color.DimGray;
            this.txtIteration.Image = null;
            this.txtIteration.Location = new System.Drawing.Point(58, 124);
            this.txtIteration.MaxLength = 32767;
            this.txtIteration.Multiline = false;
            this.txtIteration.Name = "txtIteration";
            this.txtIteration.ReadOnly = false;
            this.txtIteration.Size = new System.Drawing.Size(363, 46);
            this.txtIteration.TabIndex = 60;
            this.txtIteration.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIteration.UseSystemPasswordChar = false;
            // 
            // FrmBairstow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.Degree);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(500, 300);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "FrmBairstow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBairstow";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Degree.ResumeLayout(false);
            this.Degree.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Forms.AirForm Degree;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.AloneButton btnTest;
        private PictureBox btnExit;
        private ReaLTaiizor.Controls.BigTextBox txtIteration;
    }
}