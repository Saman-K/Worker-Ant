namespace Worker_Ant
{
    partial class ErrorHandlerWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorHandlerWin));
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnOkBreakBasic = new System.Windows.Forms.Button();
            this.labelWinName = new System.Windows.Forms.Label();
            this.picBoxIcon = new System.Windows.Forms.PictureBox();
            this.picBoxClose = new System.Windows.Forms.PictureBox();
            this.picBoxBackground = new System.Windows.Forms.PictureBox();
            this.labelError = new System.Windows.Forms.Label();
            this.labelReportToDev = new System.Windows.Forms.Label();
            this.labelLocationNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picBoxLogo.Image = global::Worker_Ant.Properties.Resources.Worker_AntBWH128;
            this.picBoxLogo.Location = new System.Drawing.Point(12, 45);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(55, 55);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxLogo.TabIndex = 14;
            this.picBoxLogo.TabStop = false;
            // 
            // btnOkBreakBasic
            // 
            this.btnOkBreakBasic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOkBreakBasic.Location = new System.Drawing.Point(263, 115);
            this.btnOkBreakBasic.Name = "btnOkBreakBasic";
            this.btnOkBreakBasic.Size = new System.Drawing.Size(75, 23);
            this.btnOkBreakBasic.TabIndex = 1;
            this.btnOkBreakBasic.Text = "Okey";
            this.btnOkBreakBasic.UseVisualStyleBackColor = true;
            this.btnOkBreakBasic.Click += new System.EventHandler(this.BtnOkBreakBasic_Click);
            // 
            // labelWinName
            // 
            this.labelWinName.AutoSize = true;
            this.labelWinName.Location = new System.Drawing.Point(34, 8);
            this.labelWinName.Name = "labelWinName";
            this.labelWinName.Size = new System.Drawing.Size(61, 13);
            this.labelWinName.TabIndex = 12;
            this.labelWinName.Text = "Worker Ant";
            this.labelWinName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Win_MouseDown);
            this.labelWinName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Win_MouseMove);
            this.labelWinName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Win_MouseUp);
            // 
            // picBoxIcon
            // 
            this.picBoxIcon.Image = global::Worker_Ant.Properties.Resources.Worker_AntBW25;
            this.picBoxIcon.Location = new System.Drawing.Point(3, 1);
            this.picBoxIcon.Name = "picBoxIcon";
            this.picBoxIcon.Size = new System.Drawing.Size(25, 25);
            this.picBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxIcon.TabIndex = 11;
            this.picBoxIcon.TabStop = false;
            this.picBoxIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Win_MouseDown);
            this.picBoxIcon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Win_MouseMove);
            this.picBoxIcon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Win_MouseUp);
            // 
            // picBoxClose
            // 
            this.picBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxClose.Image = global::Worker_Ant.Properties.Resources.X_Close;
            this.picBoxClose.Location = new System.Drawing.Point(305, 0);
            this.picBoxClose.Name = "picBoxClose";
            this.picBoxClose.Size = new System.Drawing.Size(45, 25);
            this.picBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBoxClose.TabIndex = 10;
            this.picBoxClose.TabStop = false;
            this.picBoxClose.Click += new System.EventHandler(this.PicBoxClose_Click);
            this.picBoxClose.MouseEnter += new System.EventHandler(this.PicBoxClose_MouseEnter);
            this.picBoxClose.MouseLeave += new System.EventHandler(this.PicBoxClose_MouseEnter);
            // 
            // picBoxBackground
            // 
            this.picBoxBackground.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picBoxBackground.Location = new System.Drawing.Point(0, 31);
            this.picBoxBackground.Name = "picBoxBackground";
            this.picBoxBackground.Size = new System.Drawing.Size(350, 119);
            this.picBoxBackground.TabIndex = 16;
            this.picBoxBackground.TabStop = false;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelError.Location = new System.Drawing.Point(73, 45);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(32, 13);
            this.labelError.TabIndex = 17;
            this.labelError.Text = "Error!";
            // 
            // labelReportToDev
            // 
            this.labelReportToDev.AutoSize = true;
            this.labelReportToDev.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelReportToDev.Location = new System.Drawing.Point(94, 66);
            this.labelReportToDev.Name = "labelReportToDev";
            this.labelReportToDev.Size = new System.Drawing.Size(187, 13);
            this.labelReportToDev.TabIndex = 15;
            this.labelReportToDev.Text = "Please report to Work Ant developers.";
            // 
            // labelLocationNumber
            // 
            this.labelLocationNumber.AutoSize = true;
            this.labelLocationNumber.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelLocationNumber.Location = new System.Drawing.Point(94, 87);
            this.labelLocationNumber.Name = "labelLocationNumber";
            this.labelLocationNumber.Size = new System.Drawing.Size(56, 13);
            this.labelLocationNumber.TabIndex = 15;
            this.labelLocationNumber.Text = "(null/ null).";
            // 
            // ErrorHandlerWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 150);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelLocationNumber);
            this.Controls.Add(this.labelReportToDev);
            this.Controls.Add(this.picBoxLogo);
            this.Controls.Add(this.btnOkBreakBasic);
            this.Controls.Add(this.labelWinName);
            this.Controls.Add(this.picBoxIcon);
            this.Controls.Add(this.picBoxClose);
            this.Controls.Add(this.picBoxBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ErrorHandlerWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ErrorHandlerWin";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Win_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Win_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Win_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picBoxLogo;
        public System.Windows.Forms.Button btnOkBreakBasic;
        private System.Windows.Forms.Label labelWinName;
        private System.Windows.Forms.PictureBox picBoxIcon;
        private System.Windows.Forms.PictureBox picBoxClose;
        private System.Windows.Forms.PictureBox picBoxBackground;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelReportToDev;
        private System.Windows.Forms.Label labelLocationNumber;
    }
}