﻿namespace Worker_Ant
{
    partial class SimpleViewWin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimpleViewWin));
            this.picBoxSettings = new System.Windows.Forms.PictureBox();
            this.picBoxInfo = new System.Windows.Forms.PictureBox();
            this.picBoxClose = new System.Windows.Forms.PictureBox();
            this.picBoxIcon = new System.Windows.Forms.PictureBox();
            this.labelWinName = new System.Windows.Forms.Label();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.radioBtnRecovery = new System.Windows.Forms.RadioButton();
            this.radioBtnProgress = new System.Windows.Forms.RadioButton();
            this.radioBtnSmart = new System.Windows.Forms.RadioButton();
            this.progressBarCountdown = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.winRefresh = new System.Windows.Forms.Timer(this.components);
            this.groupBoxCountdown = new System.Windows.Forms.GroupBox();
            this.labelRoundNumCountdown = new System.Windows.Forms.Label();
            this.labelBreakTimeCountdown = new System.Windows.Forms.Label();
            this.labelWorkTimeCountdown = new System.Windows.Forms.Label();
            this.labelRoundCountdown = new System.Windows.Forms.Label();
            this.labelBreakCountdown = new System.Windows.Forms.Label();
            this.labelWorkCountdown = new System.Windows.Forms.Label();
            this.rightClickMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIconSVW = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxCountdown.SuspendLayout();
            this.rightClickMenuStrip.SuspendLayout();
            this.contextMenuStripNotifyIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBoxSettings
            // 
            this.picBoxSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxSettings.Image = global::Worker_Ant.Properties.Resources.Settings_L;
            this.picBoxSettings.Location = new System.Drawing.Point(204, 5);
            this.picBoxSettings.Name = "picBoxSettings";
            this.picBoxSettings.Size = new System.Drawing.Size(15, 15);
            this.picBoxSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxSettings.TabIndex = 26;
            this.picBoxSettings.TabStop = false;
            this.picBoxSettings.Click += new System.EventHandler(this.PicBoxSettings_Click);
            this.picBoxSettings.MouseEnter += new System.EventHandler(this.PicBoxSettings_MouseEnter);
            this.picBoxSettings.MouseLeave += new System.EventHandler(this.PicBoxSettings_MouseLeave);
            // 
            // picBoxInfo
            // 
            this.picBoxInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxInfo.Image = global::Worker_Ant.Properties.Resources.Info_L;
            this.picBoxInfo.Location = new System.Drawing.Point(225, 5);
            this.picBoxInfo.Name = "picBoxInfo";
            this.picBoxInfo.Size = new System.Drawing.Size(15, 15);
            this.picBoxInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxInfo.TabIndex = 25;
            this.picBoxInfo.TabStop = false;
            this.picBoxInfo.Click += new System.EventHandler(this.PicBoxInfo_Click);
            this.picBoxInfo.MouseEnter += new System.EventHandler(this.PicBoxInfo_MouseEnter);
            this.picBoxInfo.MouseLeave += new System.EventHandler(this.PicBoxInfo_MouseLeave);
            // 
            // picBoxClose
            // 
            this.picBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxClose.BackColor = System.Drawing.SystemColors.Control;
            this.picBoxClose.Image = global::Worker_Ant.Properties.Resources.X_Close;
            this.picBoxClose.Location = new System.Drawing.Point(260, -1);
            this.picBoxClose.Name = "picBoxClose";
            this.picBoxClose.Size = new System.Drawing.Size(45, 25);
            this.picBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBoxClose.TabIndex = 24;
            this.picBoxClose.TabStop = false;
            this.picBoxClose.Click += new System.EventHandler(this.PicBoxClose_Click);
            this.picBoxClose.DoubleClick += new System.EventHandler(this.PicBoxClose_DoubleClick);
            this.picBoxClose.MouseEnter += new System.EventHandler(this.PicBoxClose_MouseEnter);
            this.picBoxClose.MouseLeave += new System.EventHandler(this.PicBoxClose_MouseLeave);
            // 
            // picBoxIcon
            // 
            this.picBoxIcon.Image = global::Worker_Ant.Properties.Resources.Whorker_AntBW25;
            this.picBoxIcon.Location = new System.Drawing.Point(3, 1);
            this.picBoxIcon.Name = "picBoxIcon";
            this.picBoxIcon.Size = new System.Drawing.Size(25, 25);
            this.picBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxIcon.TabIndex = 23;
            this.picBoxIcon.TabStop = false;
            this.picBoxIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Win_MouseDown);
            this.picBoxIcon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Win_MouseMove);
            this.picBoxIcon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Win_MouseUp);
            // 
            // labelWinName
            // 
            this.labelWinName.AutoSize = true;
            this.labelWinName.Location = new System.Drawing.Point(34, 8);
            this.labelWinName.Name = "labelWinName";
            this.labelWinName.Size = new System.Drawing.Size(61, 13);
            this.labelWinName.TabIndex = 22;
            this.labelWinName.Text = "Worker Ant";
            this.labelWinName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Win_MouseDown);
            this.labelWinName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Win_MouseMove);
            this.labelWinName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Win_MouseUp);
            // 
            // btnStartStop
            // 
            this.btnStartStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartStop.Location = new System.Drawing.Point(218, 123);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(75, 23);
            this.btnStartStop.TabIndex = 1;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.BtnStartStop_Click);
            // 
            // radioBtnRecovery
            // 
            this.radioBtnRecovery.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radioBtnRecovery.AutoSize = true;
            this.radioBtnRecovery.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioBtnRecovery.Location = new System.Drawing.Point(12, 44);
            this.radioBtnRecovery.Name = "radioBtnRecovery";
            this.radioBtnRecovery.Size = new System.Drawing.Size(71, 17);
            this.radioBtnRecovery.TabIndex = 0;
            this.radioBtnRecovery.Text = "Recovery";
            this.radioBtnRecovery.UseVisualStyleBackColor = false;
            this.radioBtnRecovery.CheckedChanged += new System.EventHandler(this.RadioBtn_CheckedChanged);
            // 
            // radioBtnProgress
            // 
            this.radioBtnProgress.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radioBtnProgress.AutoSize = true;
            this.radioBtnProgress.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioBtnProgress.Location = new System.Drawing.Point(12, 90);
            this.radioBtnProgress.Name = "radioBtnProgress";
            this.radioBtnProgress.Size = new System.Drawing.Size(66, 17);
            this.radioBtnProgress.TabIndex = 0;
            this.radioBtnProgress.Text = "Progress";
            this.radioBtnProgress.UseVisualStyleBackColor = false;
            this.radioBtnProgress.CheckedChanged += new System.EventHandler(this.RadioBtn_CheckedChanged);
            // 
            // radioBtnSmart
            // 
            this.radioBtnSmart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radioBtnSmart.AutoSize = true;
            this.radioBtnSmart.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioBtnSmart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioBtnSmart.Location = new System.Drawing.Point(12, 67);
            this.radioBtnSmart.Name = "radioBtnSmart";
            this.radioBtnSmart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioBtnSmart.Size = new System.Drawing.Size(52, 17);
            this.radioBtnSmart.TabIndex = 0;
            this.radioBtnSmart.Text = "Smart";
            this.radioBtnSmart.UseVisualStyleBackColor = false;
            this.radioBtnSmart.CheckedChanged += new System.EventHandler(this.RadioBtn_CheckedChanged);
            // 
            // progressBarCountdown
            // 
            this.progressBarCountdown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarCountdown.Location = new System.Drawing.Point(12, 123);
            this.progressBarCountdown.Name = "progressBarCountdown";
            this.progressBarCountdown.Size = new System.Drawing.Size(200, 22);
            this.progressBarCountdown.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(0, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 128);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // winRefresh
            // 
            this.winRefresh.Tick += new System.EventHandler(this.WinRefresh_Tick);
            // 
            // groupBoxCountdown
            // 
            this.groupBoxCountdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxCountdown.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxCountdown.Controls.Add(this.labelRoundNumCountdown);
            this.groupBoxCountdown.Controls.Add(this.labelBreakTimeCountdown);
            this.groupBoxCountdown.Controls.Add(this.labelWorkTimeCountdown);
            this.groupBoxCountdown.Controls.Add(this.labelRoundCountdown);
            this.groupBoxCountdown.Controls.Add(this.labelBreakCountdown);
            this.groupBoxCountdown.Controls.Add(this.labelWorkCountdown);
            this.groupBoxCountdown.Location = new System.Drawing.Point(137, 36);
            this.groupBoxCountdown.Name = "groupBoxCountdown";
            this.groupBoxCountdown.Size = new System.Drawing.Size(156, 80);
            this.groupBoxCountdown.TabIndex = 29;
            this.groupBoxCountdown.TabStop = false;
            this.groupBoxCountdown.Text = "Countdown";
            // 
            // labelRoundNumCountdown
            // 
            this.labelRoundNumCountdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRoundNumCountdown.AutoSize = true;
            this.labelRoundNumCountdown.Location = new System.Drawing.Point(79, 56);
            this.labelRoundNumCountdown.Name = "labelRoundNumCountdown";
            this.labelRoundNumCountdown.Size = new System.Drawing.Size(71, 13);
            this.labelRoundNumCountdown.TabIndex = 5;
            this.labelRoundNumCountdown.Text = "Round(s) Left";
            this.labelRoundNumCountdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBreakTimeCountdown
            // 
            this.labelBreakTimeCountdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBreakTimeCountdown.AutoSize = true;
            this.labelBreakTimeCountdown.Location = new System.Drawing.Point(79, 36);
            this.labelBreakTimeCountdown.Name = "labelBreakTimeCountdown";
            this.labelBreakTimeCountdown.Size = new System.Drawing.Size(61, 13);
            this.labelBreakTimeCountdown.TabIndex = 4;
            this.labelBreakTimeCountdown.Text = "Break Time";
            this.labelBreakTimeCountdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWorkTimeCountdown
            // 
            this.labelWorkTimeCountdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWorkTimeCountdown.AutoSize = true;
            this.labelWorkTimeCountdown.Location = new System.Drawing.Point(79, 16);
            this.labelWorkTimeCountdown.Name = "labelWorkTimeCountdown";
            this.labelWorkTimeCountdown.Size = new System.Drawing.Size(59, 13);
            this.labelWorkTimeCountdown.TabIndex = 3;
            this.labelWorkTimeCountdown.Text = "Work Time";
            this.labelWorkTimeCountdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // rightClickMenuStrip
            // 
            this.rightClickMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.rightClickMenuStrip.Name = "rightClickMenuStrip";
            this.rightClickMenuStrip.Size = new System.Drawing.Size(117, 76);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.PicBoxSettings_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.PicBoxInfo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(113, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.PicBoxClose_DoubleClick);
            // 
            // notifyIconSVW
            // 
            this.notifyIconSVW.ContextMenuStrip = this.contextMenuStripNotifyIcon;
            this.notifyIconSVW.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconSVW.Icon")));
            this.notifyIconSVW.Text = "notifyIcon1";
            this.notifyIconSVW.Visible = true;
            this.notifyIconSVW.Click += new System.EventHandler(this.NotifyIconSVW_Click);
            // 
            // contextMenuStripNotifyIcon
            // 
            this.contextMenuStripNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.aboutToolStripMenuItem1,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem1});
            this.contextMenuStripNotifyIcon.Name = "contextMenuStripNotifyIcon";
            this.contextMenuStripNotifyIcon.Size = new System.Drawing.Size(108, 76);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.NotifyIconSVW_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.PicBoxInfo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(104, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.PicBoxClose_DoubleClick);
            // 
            // SimpleViewWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 158);
            this.Controls.Add(this.groupBoxCountdown);
            this.Controls.Add(this.picBoxSettings);
            this.Controls.Add(this.picBoxInfo);
            this.Controls.Add(this.picBoxClose);
            this.Controls.Add(this.picBoxIcon);
            this.Controls.Add(this.labelWinName);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.progressBarCountdown);
            this.Controls.Add(this.radioBtnRecovery);
            this.Controls.Add(this.radioBtnProgress);
            this.Controls.Add(this.radioBtnSmart);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SimpleViewWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Worker Ant";
            this.Load += new System.EventHandler(this.SimpleViewWin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Win_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Win_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Win_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxCountdown.ResumeLayout(false);
            this.groupBoxCountdown.PerformLayout();
            this.rightClickMenuStrip.ResumeLayout(false);
            this.contextMenuStripNotifyIcon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxSettings;
        private System.Windows.Forms.PictureBox picBoxInfo;
        private System.Windows.Forms.PictureBox picBoxClose;
        private System.Windows.Forms.PictureBox picBoxIcon;
        private System.Windows.Forms.Label labelWinName;
        public System.Windows.Forms.Button btnStartStop;
        public System.Windows.Forms.RadioButton radioBtnRecovery;
        public System.Windows.Forms.RadioButton radioBtnProgress;
        public System.Windows.Forms.RadioButton radioBtnSmart;
        private System.Windows.Forms.ProgressBar progressBarCountdown;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer winRefresh;
        private System.Windows.Forms.GroupBox groupBoxCountdown;
        public System.Windows.Forms.Label labelRoundNumCountdown;
        public System.Windows.Forms.Label labelBreakTimeCountdown;
        public System.Windows.Forms.Label labelWorkTimeCountdown;
        private System.Windows.Forms.Label labelRoundCountdown;
        private System.Windows.Forms.Label labelBreakCountdown;
        private System.Windows.Forms.Label labelWorkCountdown;
        private System.Windows.Forms.ContextMenuStrip rightClickMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIconSVW;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
    }
}