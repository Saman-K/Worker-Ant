namespace Worker_Ant
{
    partial class FullViewWin
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
            this.groupBoxManual = new System.Windows.Forms.GroupBox();
            this.numUpDownBreakManual = new System.Windows.Forms.NumericUpDown();
            this.numUDWorkManual = new System.Windows.Forms.NumericUpDown();
            this.labelBreakManual = new System.Windows.Forms.Label();
            this.labelWorkManual = new System.Windows.Forms.Label();
            this.groupBoxCountdown = new System.Windows.Forms.GroupBox();
            this.labelRoundNumCountdown = new System.Windows.Forms.Label();
            this.labelBreakTimeCountdown = new System.Windows.Forms.Label();
            this.labelWorkTimeCountdown = new System.Windows.Forms.Label();
            this.labelRoundCountdown = new System.Windows.Forms.Label();
            this.labelBreakCountdown = new System.Windows.Forms.Label();
            this.labelWorkCountdown = new System.Windows.Forms.Label();
            this.progressBarCountdown = new System.Windows.Forms.ProgressBar();
            this.radioBtnSmart = new System.Windows.Forms.RadioButton();
            this.radioBtnProgress = new System.Windows.Forms.RadioButton();
            this.radioBtnRecovery = new System.Windows.Forms.RadioButton();
            this.radioBtnManual = new System.Windows.Forms.RadioButton();
            this.btnSetReset = new System.Windows.Forms.Button();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.groupBoxPreview = new System.Windows.Forms.GroupBox();
            this.labelRoundNumPreview = new System.Windows.Forms.Label();
            this.labelBreakTimePreview = new System.Windows.Forms.Label();
            this.labelWorkTimePreview = new System.Windows.Forms.Label();
            this.labelRoundPreview = new System.Windows.Forms.Label();
            this.labelBreakPreview = new System.Windows.Forms.Label();
            this.labelWorkPreview = new System.Windows.Forms.Label();
            this.labelWinName = new System.Windows.Forms.Label();
            this.picBoxSetting = new System.Windows.Forms.PictureBox();
            this.picBoxInfo = new System.Windows.Forms.PictureBox();
            this.picBoxClose = new System.Windows.Forms.PictureBox();
            this.picBoxIcon = new System.Windows.Forms.PictureBox();
            this.groupBoxManual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownBreakManual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDWorkManual)).BeginInit();
            this.groupBoxCountdown.SuspendLayout();
            this.groupBoxPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxManual
            // 
            this.groupBoxManual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxManual.Controls.Add(this.numUpDownBreakManual);
            this.groupBoxManual.Controls.Add(this.numUDWorkManual);
            this.groupBoxManual.Controls.Add(this.labelBreakManual);
            this.groupBoxManual.Controls.Add(this.labelWorkManual);
            this.groupBoxManual.Location = new System.Drawing.Point(178, 38);
            this.groupBoxManual.Name = "groupBoxManual";
            this.groupBoxManual.Size = new System.Drawing.Size(160, 69);
            this.groupBoxManual.TabIndex = 0;
            this.groupBoxManual.TabStop = false;
            this.groupBoxManual.Text = "Manual";
            // 
            // numUpDownBreakManual
            // 
            this.numUpDownBreakManual.Location = new System.Drawing.Point(83, 40);
            this.numUpDownBreakManual.Name = "numUpDownBreakManual";
            this.numUpDownBreakManual.Size = new System.Drawing.Size(70, 20);
            this.numUpDownBreakManual.TabIndex = 11;
            // 
            // numUDWorkManual
            // 
            this.numUDWorkManual.Location = new System.Drawing.Point(83, 14);
            this.numUDWorkManual.Name = "numUDWorkManual";
            this.numUDWorkManual.Size = new System.Drawing.Size(71, 20);
            this.numUDWorkManual.TabIndex = 10;
            // 
            // labelBreakManual
            // 
            this.labelBreakManual.AutoSize = true;
            this.labelBreakManual.Location = new System.Drawing.Point(6, 42);
            this.labelBreakManual.Name = "labelBreakManual";
            this.labelBreakManual.Size = new System.Drawing.Size(35, 13);
            this.labelBreakManual.TabIndex = 9;
            this.labelBreakManual.Text = "Break";
            // 
            // labelWorkManual
            // 
            this.labelWorkManual.AutoSize = true;
            this.labelWorkManual.Location = new System.Drawing.Point(6, 16);
            this.labelWorkManual.Name = "labelWorkManual";
            this.labelWorkManual.Size = new System.Drawing.Size(33, 13);
            this.labelWorkManual.TabIndex = 8;
            this.labelWorkManual.Text = "Work";
            // 
            // groupBoxCountdown
            // 
            this.groupBoxCountdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxCountdown.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxCountdown.Controls.Add(this.labelRoundNumCountdown);
            this.groupBoxCountdown.Controls.Add(this.labelBreakTimeCountdown);
            this.groupBoxCountdown.Controls.Add(this.labelWorkTimeCountdown);
            this.groupBoxCountdown.Controls.Add(this.labelRoundCountdown);
            this.groupBoxCountdown.Controls.Add(this.labelBreakCountdown);
            this.groupBoxCountdown.Controls.Add(this.labelWorkCountdown);
            this.groupBoxCountdown.Location = new System.Drawing.Point(12, 108);
            this.groupBoxCountdown.Name = "groupBoxCountdown";
            this.groupBoxCountdown.Size = new System.Drawing.Size(160, 80);
            this.groupBoxCountdown.TabIndex = 1;
            this.groupBoxCountdown.TabStop = false;
            this.groupBoxCountdown.Text = "Countdown";
            // 
            // labelRoundNumCountdown
            // 
            this.labelRoundNumCountdown.AutoSize = true;
            this.labelRoundNumCountdown.Location = new System.Drawing.Point(66, 56);
            this.labelRoundNumCountdown.Name = "labelRoundNumCountdown";
            this.labelRoundNumCountdown.Size = new System.Drawing.Size(87, 13);
            this.labelRoundNumCountdown.TabIndex = 5;
            this.labelRoundNumCountdown.Text = "Num of Round(s)";
            // 
            // labelBreakTimeCountdown
            // 
            this.labelBreakTimeCountdown.AutoSize = true;
            this.labelBreakTimeCountdown.Location = new System.Drawing.Point(66, 36);
            this.labelBreakTimeCountdown.Name = "labelBreakTimeCountdown";
            this.labelBreakTimeCountdown.Size = new System.Drawing.Size(92, 13);
            this.labelBreakTimeCountdown.TabIndex = 4;
            this.labelBreakTimeCountdown.Text = "Break Time in Min";
            // 
            // labelWorkTimeCountdown
            // 
            this.labelWorkTimeCountdown.AutoSize = true;
            this.labelWorkTimeCountdown.Location = new System.Drawing.Point(66, 16);
            this.labelWorkTimeCountdown.Name = "labelWorkTimeCountdown";
            this.labelWorkTimeCountdown.Size = new System.Drawing.Size(90, 13);
            this.labelWorkTimeCountdown.TabIndex = 3;
            this.labelWorkTimeCountdown.Text = "Work Time in Min";
            // 
            // labelRoundCountdown
            // 
            this.labelRoundCountdown.AutoSize = true;
            this.labelRoundCountdown.Location = new System.Drawing.Point(6, 56);
            this.labelRoundCountdown.Name = "labelRoundCountdown";
            this.labelRoundCountdown.Size = new System.Drawing.Size(39, 13);
            this.labelRoundCountdown.TabIndex = 2;
            this.labelRoundCountdown.Text = "Round";
            // 
            // labelBreakCountdown
            // 
            this.labelBreakCountdown.AutoSize = true;
            this.labelBreakCountdown.Location = new System.Drawing.Point(6, 36);
            this.labelBreakCountdown.Name = "labelBreakCountdown";
            this.labelBreakCountdown.Size = new System.Drawing.Size(35, 13);
            this.labelBreakCountdown.TabIndex = 1;
            this.labelBreakCountdown.Text = "Break";
            // 
            // labelWorkCountdown
            // 
            this.labelWorkCountdown.AutoSize = true;
            this.labelWorkCountdown.Location = new System.Drawing.Point(6, 16);
            this.labelWorkCountdown.Name = "labelWorkCountdown";
            this.labelWorkCountdown.Size = new System.Drawing.Size(33, 13);
            this.labelWorkCountdown.TabIndex = 0;
            this.labelWorkCountdown.Text = "Work";
            // 
            // progressBarCountdown
            // 
            this.progressBarCountdown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarCountdown.Location = new System.Drawing.Point(12, 194);
            this.progressBarCountdown.Name = "progressBarCountdown";
            this.progressBarCountdown.Size = new System.Drawing.Size(164, 23);
            this.progressBarCountdown.TabIndex = 3;
            // 
            // radioBtnSmart
            // 
            this.radioBtnSmart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioBtnSmart.AutoSize = true;
            this.radioBtnSmart.BackColor = System.Drawing.SystemColors.Control;
            this.radioBtnSmart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioBtnSmart.Location = new System.Drawing.Point(12, 61);
            this.radioBtnSmart.Name = "radioBtnSmart";
            this.radioBtnSmart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioBtnSmart.Size = new System.Drawing.Size(52, 17);
            this.radioBtnSmart.TabIndex = 4;
            this.radioBtnSmart.Text = "Smart";
            this.radioBtnSmart.UseVisualStyleBackColor = false;
            // 
            // radioBtnProgress
            // 
            this.radioBtnProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioBtnProgress.AutoSize = true;
            this.radioBtnProgress.Location = new System.Drawing.Point(12, 84);
            this.radioBtnProgress.Name = "radioBtnProgress";
            this.radioBtnProgress.Size = new System.Drawing.Size(66, 17);
            this.radioBtnProgress.TabIndex = 5;
            this.radioBtnProgress.TabStop = true;
            this.radioBtnProgress.Text = "Progress";
            this.radioBtnProgress.UseVisualStyleBackColor = true;
            // 
            // radioBtnRecovery
            // 
            this.radioBtnRecovery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioBtnRecovery.AutoSize = true;
            this.radioBtnRecovery.Location = new System.Drawing.Point(12, 38);
            this.radioBtnRecovery.Name = "radioBtnRecovery";
            this.radioBtnRecovery.Size = new System.Drawing.Size(71, 17);
            this.radioBtnRecovery.TabIndex = 6;
            this.radioBtnRecovery.TabStop = true;
            this.radioBtnRecovery.Text = "Recovery";
            this.radioBtnRecovery.UseVisualStyleBackColor = true;
            // 
            // radioBtnManual
            // 
            this.radioBtnManual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radioBtnManual.AutoSize = true;
            this.radioBtnManual.Location = new System.Drawing.Point(172, 34);
            this.radioBtnManual.Name = "radioBtnManual";
            this.radioBtnManual.Size = new System.Drawing.Size(60, 17);
            this.radioBtnManual.TabIndex = 7;
            this.radioBtnManual.TabStop = true;
            this.radioBtnManual.Text = "Manual";
            this.radioBtnManual.UseVisualStyleBackColor = true;
            // 
            // btnSetReset
            // 
            this.btnSetReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetReset.Location = new System.Drawing.Point(182, 194);
            this.btnSetReset.Name = "btnSetReset";
            this.btnSetReset.Size = new System.Drawing.Size(75, 23);
            this.btnSetReset.TabIndex = 7;
            this.btnSetReset.Text = "Set";
            this.btnSetReset.UseVisualStyleBackColor = true;
            // 
            // btnStartStop
            // 
            this.btnStartStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartStop.Location = new System.Drawing.Point(263, 194);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(75, 23);
            this.btnStartStop.TabIndex = 8;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            // 
            // groupBoxPreview
            // 
            this.groupBoxPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPreview.Controls.Add(this.labelRoundNumPreview);
            this.groupBoxPreview.Controls.Add(this.labelBreakTimePreview);
            this.groupBoxPreview.Controls.Add(this.labelWorkTimePreview);
            this.groupBoxPreview.Controls.Add(this.labelRoundPreview);
            this.groupBoxPreview.Controls.Add(this.labelBreakPreview);
            this.groupBoxPreview.Controls.Add(this.labelWorkPreview);
            this.groupBoxPreview.Location = new System.Drawing.Point(178, 108);
            this.groupBoxPreview.Name = "groupBoxPreview";
            this.groupBoxPreview.Size = new System.Drawing.Size(160, 80);
            this.groupBoxPreview.TabIndex = 9;
            this.groupBoxPreview.TabStop = false;
            this.groupBoxPreview.Text = "Preview";
            // 
            // labelRoundNumPreview
            // 
            this.labelRoundNumPreview.AutoSize = true;
            this.labelRoundNumPreview.Location = new System.Drawing.Point(66, 56);
            this.labelRoundNumPreview.Name = "labelRoundNumPreview";
            this.labelRoundNumPreview.Size = new System.Drawing.Size(87, 13);
            this.labelRoundNumPreview.TabIndex = 5;
            this.labelRoundNumPreview.Text = "Num of Round(s)";
            // 
            // labelBreakTimePreview
            // 
            this.labelBreakTimePreview.AutoSize = true;
            this.labelBreakTimePreview.Location = new System.Drawing.Point(66, 36);
            this.labelBreakTimePreview.Name = "labelBreakTimePreview";
            this.labelBreakTimePreview.Size = new System.Drawing.Size(92, 13);
            this.labelBreakTimePreview.TabIndex = 4;
            this.labelBreakTimePreview.Text = "Break Time in Min";
            // 
            // labelWorkTimePreview
            // 
            this.labelWorkTimePreview.AutoSize = true;
            this.labelWorkTimePreview.Location = new System.Drawing.Point(66, 16);
            this.labelWorkTimePreview.Name = "labelWorkTimePreview";
            this.labelWorkTimePreview.Size = new System.Drawing.Size(90, 13);
            this.labelWorkTimePreview.TabIndex = 3;
            this.labelWorkTimePreview.Text = "Work Time in Min";
            // 
            // labelRoundPreview
            // 
            this.labelRoundPreview.AutoSize = true;
            this.labelRoundPreview.Location = new System.Drawing.Point(6, 56);
            this.labelRoundPreview.Name = "labelRoundPreview";
            this.labelRoundPreview.Size = new System.Drawing.Size(39, 13);
            this.labelRoundPreview.TabIndex = 2;
            this.labelRoundPreview.Text = "Round";
            // 
            // labelBreakPreview
            // 
            this.labelBreakPreview.AutoSize = true;
            this.labelBreakPreview.Location = new System.Drawing.Point(6, 36);
            this.labelBreakPreview.Name = "labelBreakPreview";
            this.labelBreakPreview.Size = new System.Drawing.Size(35, 13);
            this.labelBreakPreview.TabIndex = 1;
            this.labelBreakPreview.Text = "Break";
            // 
            // labelWorkPreview
            // 
            this.labelWorkPreview.AutoSize = true;
            this.labelWorkPreview.Location = new System.Drawing.Point(6, 16);
            this.labelWorkPreview.Name = "labelWorkPreview";
            this.labelWorkPreview.Size = new System.Drawing.Size(33, 13);
            this.labelWorkPreview.TabIndex = 0;
            this.labelWorkPreview.Text = "Work";
            // 
            // labelWinName
            // 
            this.labelWinName.AutoSize = true;
            this.labelWinName.Location = new System.Drawing.Point(36, 9);
            this.labelWinName.Name = "labelWinName";
            this.labelWinName.Size = new System.Drawing.Size(61, 13);
            this.labelWinName.TabIndex = 10;
            this.labelWinName.Text = "Worker Ant";
            // 
            // picBoxSetting
            // 
            this.picBoxSetting.Image = global::Worker_Ant.Properties.Resources.Setting_L;
            this.picBoxSetting.Location = new System.Drawing.Point(247, 5);
            this.picBoxSetting.Name = "picBoxSetting";
            this.picBoxSetting.Size = new System.Drawing.Size(15, 15);
            this.picBoxSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxSetting.TabIndex = 14;
            this.picBoxSetting.TabStop = false;
            // 
            // picBoxInfo
            // 
            this.picBoxInfo.Image = global::Worker_Ant.Properties.Resources.Info_L;
            this.picBoxInfo.Location = new System.Drawing.Point(268, 5);
            this.picBoxInfo.Name = "picBoxInfo";
            this.picBoxInfo.Size = new System.Drawing.Size(15, 15);
            this.picBoxInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxInfo.TabIndex = 13;
            this.picBoxInfo.TabStop = false;
            // 
            // picBoxClose
            // 
            this.picBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxClose.BackColor = System.Drawing.SystemColors.Control;
            this.picBoxClose.Image = global::Worker_Ant.Properties.Resources.X_Close;
            this.picBoxClose.Location = new System.Drawing.Point(305, 0);
            this.picBoxClose.Name = "picBoxClose";
            this.picBoxClose.Size = new System.Drawing.Size(45, 25);
            this.picBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBoxClose.TabIndex = 12;
            this.picBoxClose.TabStop = false;
            // 
            // picBoxIcon
            // 
            this.picBoxIcon.Image = global::Worker_Ant.Properties.Resources.X_Close;
            this.picBoxIcon.Location = new System.Drawing.Point(0, 0);
            this.picBoxIcon.Name = "picBoxIcon";
            this.picBoxIcon.Size = new System.Drawing.Size(25, 25);
            this.picBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxIcon.TabIndex = 11;
            this.picBoxIcon.TabStop = false;
            // 
            // FullViewWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 229);
            this.Controls.Add(this.picBoxSetting);
            this.Controls.Add(this.picBoxInfo);
            this.Controls.Add(this.picBoxClose);
            this.Controls.Add(this.picBoxIcon);
            this.Controls.Add(this.labelWinName);
            this.Controls.Add(this.groupBoxPreview);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.btnSetReset);
            this.Controls.Add(this.radioBtnRecovery);
            this.Controls.Add(this.radioBtnManual);
            this.Controls.Add(this.radioBtnProgress);
            this.Controls.Add(this.radioBtnSmart);
            this.Controls.Add(this.progressBarCountdown);
            this.Controls.Add(this.groupBoxCountdown);
            this.Controls.Add(this.groupBoxManual);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FullViewWin";
            this.Text = "Worker Ant";
            this.groupBoxManual.ResumeLayout(false);
            this.groupBoxManual.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownBreakManual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDWorkManual)).EndInit();
            this.groupBoxCountdown.ResumeLayout(false);
            this.groupBoxCountdown.PerformLayout();
            this.groupBoxPreview.ResumeLayout(false);
            this.groupBoxPreview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxManual;
        private System.Windows.Forms.NumericUpDown numUDWorkManual;
        private System.Windows.Forms.Label labelBreakManual;
        private System.Windows.Forms.Label labelWorkManual;
        private System.Windows.Forms.GroupBox groupBoxCountdown;
        private System.Windows.Forms.Label labelRoundNumCountdown;
        private System.Windows.Forms.Label labelBreakTimeCountdown;
        private System.Windows.Forms.Label labelWorkTimeCountdown;
        private System.Windows.Forms.Label labelRoundCountdown;
        private System.Windows.Forms.Label labelBreakCountdown;
        private System.Windows.Forms.Label labelWorkCountdown;
        private System.Windows.Forms.ProgressBar progressBarCountdown;
        private System.Windows.Forms.RadioButton radioBtnSmart;
        private System.Windows.Forms.RadioButton radioBtnProgress;
        private System.Windows.Forms.RadioButton radioBtnRecovery;
        private System.Windows.Forms.RadioButton radioBtnManual;
        private System.Windows.Forms.Button btnSetReset;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.GroupBox groupBoxPreview;
        private System.Windows.Forms.Label labelRoundNumPreview;
        private System.Windows.Forms.Label labelBreakTimePreview;
        private System.Windows.Forms.Label labelWorkTimePreview;
        private System.Windows.Forms.Label labelRoundPreview;
        private System.Windows.Forms.Label labelBreakPreview;
        private System.Windows.Forms.Label labelWorkPreview;
        private System.Windows.Forms.Label labelWinName;
        private System.Windows.Forms.PictureBox picBoxIcon;
        private System.Windows.Forms.PictureBox picBoxClose;
        private System.Windows.Forms.PictureBox picBoxInfo;
        private System.Windows.Forms.PictureBox picBoxSetting;
        private System.Windows.Forms.NumericUpDown numUpDownBreakManual;
    }
}

