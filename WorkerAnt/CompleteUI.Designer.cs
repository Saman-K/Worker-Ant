﻿namespace WorkerAnt
{
    partial class CompleteUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompleteUI));
            this.groupBoxManual = new System.Windows.Forms.GroupBox();
            this.numUDBreakManual = new System.Windows.Forms.NumericUpDown();
            this.numUDWorkManual = new System.Windows.Forms.NumericUpDown();
            this.labelBreakManual = new System.Windows.Forms.Label();
            this.labelWorkManual = new System.Windows.Forms.Label();
            this.groupBoxCountdown = new System.Windows.Forms.GroupBox();
            this.labelLapCounterLive = new System.Windows.Forms.Label();
            this.labelBreakTimeCountdown = new System.Windows.Forms.Label();
            this.labelWorkTimeCountdown = new System.Windows.Forms.Label();
            this.labellabelLapLive = new System.Windows.Forms.Label();
            this.labelBreakCountdown = new System.Windows.Forms.Label();
            this.labelWorkCountdown = new System.Windows.Forms.Label();
            this.progressBarCountdown = new System.Windows.Forms.ProgressBar();
            this.radioBtnSmart = new System.Windows.Forms.RadioButton();
            this.radioBtnProgress = new System.Windows.Forms.RadioButton();
            this.radioBtnRecovery = new System.Windows.Forms.RadioButton();
            this.btnSetReset = new System.Windows.Forms.Button();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.groupBoxPreview = new System.Windows.Forms.GroupBox();
            this.labelLapCounterPreview = new System.Windows.Forms.Label();
            this.labelBreakTimePreview = new System.Windows.Forms.Label();
            this.labelWorkTimePreview = new System.Windows.Forms.Label();
            this.labelLapPreview = new System.Windows.Forms.Label();
            this.labelBreakPreview = new System.Windows.Forms.Label();
            this.labelWorkPreview = new System.Windows.Forms.Label();
            this.rightClickMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioBtnManual = new System.Windows.Forms.RadioButton();
            this.liveDataUpdate = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStripNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.picBoxSettings = new System.Windows.Forms.PictureBox();
            this.picBoxInfo = new System.Windows.Forms.PictureBox();
            this.picBoxClose = new System.Windows.Forms.PictureBox();
            this.picBoxIcon = new System.Windows.Forms.PictureBox();
            this.labelWinName = new System.Windows.Forms.Label();
            this.notifyIconCUI = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBoxManual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDBreakManual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDWorkManual)).BeginInit();
            this.groupBoxCountdown.SuspendLayout();
            this.groupBoxPreview.SuspendLayout();
            this.rightClickMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStripNotifyIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxManual
            // 
            this.groupBoxManual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxManual.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxManual.Controls.Add(this.numUDBreakManual);
            this.groupBoxManual.Controls.Add(this.numUDWorkManual);
            this.groupBoxManual.Controls.Add(this.labelBreakManual);
            this.groupBoxManual.Controls.Add(this.labelWorkManual);
            this.groupBoxManual.Enabled = false;
            this.groupBoxManual.Location = new System.Drawing.Point(174, 45);
            this.groupBoxManual.Name = "groupBoxManual";
            this.groupBoxManual.Size = new System.Drawing.Size(156, 69);
            this.groupBoxManual.TabIndex = 0;
            this.groupBoxManual.TabStop = false;
            this.groupBoxManual.Text = "Manual";
            // 
            // numUDBreakManual
            // 
            this.numUDBreakManual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numUDBreakManual.Location = new System.Drawing.Point(79, 40);
            this.numUDBreakManual.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDBreakManual.Name = "numUDBreakManual";
            this.numUDBreakManual.Size = new System.Drawing.Size(70, 20);
            this.numUDBreakManual.TabIndex = 2;
            this.numUDBreakManual.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numUDBreakManual.ValueChanged += new System.EventHandler(this.NumUDManualValueChanged);
            // 
            // numUDWorkManual
            // 
            this.numUDWorkManual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numUDWorkManual.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUDWorkManual.Location = new System.Drawing.Point(79, 14);
            this.numUDWorkManual.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUDWorkManual.Name = "numUDWorkManual";
            this.numUDWorkManual.Size = new System.Drawing.Size(71, 20);
            this.numUDWorkManual.TabIndex = 1;
            this.numUDWorkManual.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numUDWorkManual.ValueChanged += new System.EventHandler(this.NumUDManualValueChanged);
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
            this.groupBoxCountdown.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxCountdown.Controls.Add(this.labelLapCounterLive);
            this.groupBoxCountdown.Controls.Add(this.labelBreakTimeCountdown);
            this.groupBoxCountdown.Controls.Add(this.labelWorkTimeCountdown);
            this.groupBoxCountdown.Controls.Add(this.labellabelLapLive);
            this.groupBoxCountdown.Controls.Add(this.labelBreakCountdown);
            this.groupBoxCountdown.Controls.Add(this.labelWorkCountdown);
            this.groupBoxCountdown.Location = new System.Drawing.Point(12, 115);
            this.groupBoxCountdown.Name = "groupBoxCountdown";
            this.groupBoxCountdown.Size = new System.Drawing.Size(156, 80);
            this.groupBoxCountdown.TabIndex = 1;
            this.groupBoxCountdown.TabStop = false;
            this.groupBoxCountdown.Text = "Countdown";
            // 
            // labelLapCounterLive
            // 
            this.labelLapCounterLive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLapCounterLive.AutoSize = true;
            this.labelLapCounterLive.Location = new System.Drawing.Point(79, 56);
            this.labelLapCounterLive.Name = "labelLapCounterLive";
            this.labelLapCounterLive.Size = new System.Drawing.Size(51, 13);
            this.labelLapCounterLive.TabIndex = 5;
            this.labelLapCounterLive.Text = "Laps Left";
            this.labelLapCounterLive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // labellabelLapLive
            // 
            this.labellabelLapLive.AutoSize = true;
            this.labellabelLapLive.Location = new System.Drawing.Point(6, 56);
            this.labellabelLapLive.Name = "labellabelLapLive";
            this.labellabelLapLive.Size = new System.Drawing.Size(25, 13);
            this.labellabelLapLive.TabIndex = 2;
            this.labellabelLapLive.Text = "Lap";
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
            this.progressBarCountdown.Location = new System.Drawing.Point(12, 201);
            this.progressBarCountdown.Name = "progressBarCountdown";
            this.progressBarCountdown.RightToLeftLayout = true;
            this.progressBarCountdown.Size = new System.Drawing.Size(156, 23);
            this.progressBarCountdown.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarCountdown.TabIndex = 3;
            // 
            // radioBtnSmart
            // 
            this.radioBtnSmart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioBtnSmart.AutoSize = true;
            this.radioBtnSmart.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioBtnSmart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioBtnSmart.Location = new System.Drawing.Point(12, 68);
            this.radioBtnSmart.Name = "radioBtnSmart";
            this.radioBtnSmart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioBtnSmart.Size = new System.Drawing.Size(52, 17);
            this.radioBtnSmart.TabIndex = 0;
            this.radioBtnSmart.Text = "Smart";
            this.radioBtnSmart.UseVisualStyleBackColor = false;
            this.radioBtnSmart.CheckedChanged += new System.EventHandler(this.RadioBtnChineged);
            // 
            // radioBtnProgress
            // 
            this.radioBtnProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioBtnProgress.AutoSize = true;
            this.radioBtnProgress.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioBtnProgress.Location = new System.Drawing.Point(12, 91);
            this.radioBtnProgress.Name = "radioBtnProgress";
            this.radioBtnProgress.Size = new System.Drawing.Size(66, 17);
            this.radioBtnProgress.TabIndex = 0;
            this.radioBtnProgress.Text = "Progress";
            this.radioBtnProgress.UseVisualStyleBackColor = false;
            this.radioBtnProgress.CheckedChanged += new System.EventHandler(this.RadioBtnChineged);
            // 
            // radioBtnRecovery
            // 
            this.radioBtnRecovery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioBtnRecovery.AutoSize = true;
            this.radioBtnRecovery.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioBtnRecovery.Location = new System.Drawing.Point(12, 45);
            this.radioBtnRecovery.Name = "radioBtnRecovery";
            this.radioBtnRecovery.Size = new System.Drawing.Size(71, 17);
            this.radioBtnRecovery.TabIndex = 0;
            this.radioBtnRecovery.Text = "Recovery";
            this.radioBtnRecovery.UseVisualStyleBackColor = false;
            this.radioBtnRecovery.CheckedChanged += new System.EventHandler(this.RadioBtnChineged);
            // 
            // btnSetReset
            // 
            this.btnSetReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetReset.Location = new System.Drawing.Point(174, 201);
            this.btnSetReset.Name = "btnSetReset";
            this.btnSetReset.Size = new System.Drawing.Size(75, 23);
            this.btnSetReset.TabIndex = 2;
            this.btnSetReset.Text = "Set";
            this.btnSetReset.UseVisualStyleBackColor = true;
            this.btnSetReset.Click += new System.EventHandler(this.SetBtn);
            // 
            // btnStartStop
            // 
            this.btnStartStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartStop.Location = new System.Drawing.Point(255, 201);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(75, 23);
            this.btnStartStop.TabIndex = 1;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.StartStopBtn);
            // 
            // groupBoxPreview
            // 
            this.groupBoxPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPreview.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxPreview.Controls.Add(this.labelLapCounterPreview);
            this.groupBoxPreview.Controls.Add(this.labelBreakTimePreview);
            this.groupBoxPreview.Controls.Add(this.labelWorkTimePreview);
            this.groupBoxPreview.Controls.Add(this.labelLapPreview);
            this.groupBoxPreview.Controls.Add(this.labelBreakPreview);
            this.groupBoxPreview.Controls.Add(this.labelWorkPreview);
            this.groupBoxPreview.Location = new System.Drawing.Point(174, 115);
            this.groupBoxPreview.Name = "groupBoxPreview";
            this.groupBoxPreview.Size = new System.Drawing.Size(156, 80);
            this.groupBoxPreview.TabIndex = 9;
            this.groupBoxPreview.TabStop = false;
            this.groupBoxPreview.Text = "Preview";
            // 
            // labelLapCounterPreview
            // 
            this.labelLapCounterPreview.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelLapCounterPreview.AutoSize = true;
            this.labelLapCounterPreview.Location = new System.Drawing.Point(89, 56);
            this.labelLapCounterPreview.Name = "labelLapCounterPreview";
            this.labelLapCounterPreview.Size = new System.Drawing.Size(30, 13);
            this.labelLapCounterPreview.TabIndex = 5;
            this.labelLapCounterPreview.Text = "Laps";
            this.labelLapCounterPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBreakTimePreview
            // 
            this.labelBreakTimePreview.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelBreakTimePreview.AutoSize = true;
            this.labelBreakTimePreview.Location = new System.Drawing.Point(89, 36);
            this.labelBreakTimePreview.Name = "labelBreakTimePreview";
            this.labelBreakTimePreview.Size = new System.Drawing.Size(61, 13);
            this.labelBreakTimePreview.TabIndex = 4;
            this.labelBreakTimePreview.Text = "Break Time";
            this.labelBreakTimePreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWorkTimePreview
            // 
            this.labelWorkTimePreview.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelWorkTimePreview.AutoSize = true;
            this.labelWorkTimePreview.Location = new System.Drawing.Point(89, 16);
            this.labelWorkTimePreview.Name = "labelWorkTimePreview";
            this.labelWorkTimePreview.Size = new System.Drawing.Size(59, 13);
            this.labelWorkTimePreview.TabIndex = 3;
            this.labelWorkTimePreview.Text = "Work Time";
            this.labelWorkTimePreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLapPreview
            // 
            this.labelLapPreview.AutoSize = true;
            this.labelLapPreview.Location = new System.Drawing.Point(6, 56);
            this.labelLapPreview.Name = "labelLapPreview";
            this.labelLapPreview.Size = new System.Drawing.Size(25, 13);
            this.labelLapPreview.TabIndex = 2;
            this.labelLapPreview.Text = "Lap";
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
            this.settingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("settingsToolStripMenuItem.Image")));
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.OpenSettings);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OpenAbout);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(113, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.CloseApplication);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 205);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // radioBtnManual
            // 
            this.radioBtnManual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radioBtnManual.AutoSize = true;
            this.radioBtnManual.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioBtnManual.Location = new System.Drawing.Point(168, 41);
            this.radioBtnManual.Name = "radioBtnManual";
            this.radioBtnManual.Size = new System.Drawing.Size(60, 17);
            this.radioBtnManual.TabIndex = 0;
            this.radioBtnManual.Text = "Manual";
            this.radioBtnManual.UseVisualStyleBackColor = false;
            this.radioBtnManual.CheckedChanged += new System.EventHandler(this.RadioBtnChineged);
            // 
            // liveDataUpdate
            // 
            this.liveDataUpdate.Tick += new System.EventHandler(this.LiveDataUpdate);
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
            this.openToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.NotifyIconClick);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem1.Image")));
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.OpenAbout);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(104, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem1.Image")));
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.CloseApplication);
            // 
            // picBoxSettings
            // 
            this.picBoxSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxSettings.Image = ((System.Drawing.Image)(resources.GetObject("picBoxSettings.Image")));
            this.picBoxSettings.Location = new System.Drawing.Point(241, 6);
            this.picBoxSettings.Name = "picBoxSettings";
            this.picBoxSettings.Size = new System.Drawing.Size(15, 15);
            this.picBoxSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxSettings.TabIndex = 31;
            this.picBoxSettings.TabStop = false;
            this.picBoxSettings.Click += new System.EventHandler(this.OpenSettings);
            this.picBoxSettings.MouseEnter += new System.EventHandler(this.SettingsPicBoxMouseEnter);
            this.picBoxSettings.MouseLeave += new System.EventHandler(this.SettingsPicBoxMouseLeave);
            // 
            // picBoxInfo
            // 
            this.picBoxInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxInfo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxInfo.Image")));
            this.picBoxInfo.Location = new System.Drawing.Point(262, 6);
            this.picBoxInfo.Name = "picBoxInfo";
            this.picBoxInfo.Size = new System.Drawing.Size(15, 15);
            this.picBoxInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxInfo.TabIndex = 30;
            this.picBoxInfo.TabStop = false;
            this.picBoxInfo.Click += new System.EventHandler(this.OpenAbout);
            this.picBoxInfo.MouseEnter += new System.EventHandler(this.AboutPicBoxMouseEnter);
            this.picBoxInfo.MouseLeave += new System.EventHandler(this.AboutPicBoxMouseLeave);
            // 
            // picBoxClose
            // 
            this.picBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxClose.BackColor = System.Drawing.SystemColors.Control;
            this.picBoxClose.ContextMenuStrip = this.rightClickMenuStrip;
            this.picBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("picBoxClose.Image")));
            this.picBoxClose.Location = new System.Drawing.Point(297, 0);
            this.picBoxClose.Name = "picBoxClose";
            this.picBoxClose.Size = new System.Drawing.Size(45, 25);
            this.picBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBoxClose.TabIndex = 29;
            this.picBoxClose.TabStop = false;
            this.picBoxClose.Click += new System.EventHandler(this.CloseWindow);
            this.picBoxClose.DoubleClick += new System.EventHandler(this.CloseApplication);
            this.picBoxClose.MouseEnter += new System.EventHandler(this.ClosePicBoxMouseEnter);
            this.picBoxClose.MouseLeave += new System.EventHandler(this.ClosePicBoxMouseLeave);
            // 
            // picBoxIcon
            // 
            this.picBoxIcon.ContextMenuStrip = this.rightClickMenuStrip;
            this.picBoxIcon.Image = ((System.Drawing.Image)(resources.GetObject("picBoxIcon.Image")));
            this.picBoxIcon.Location = new System.Drawing.Point(2, 2);
            this.picBoxIcon.Name = "picBoxIcon";
            this.picBoxIcon.Size = new System.Drawing.Size(25, 25);
            this.picBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxIcon.TabIndex = 28;
            this.picBoxIcon.TabStop = false;
            this.picBoxIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowMouseDown);
            this.picBoxIcon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WindowMouseMove);
            this.picBoxIcon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WindowMouseUp);
            // 
            // labelWinName
            // 
            this.labelWinName.AutoSize = true;
            this.labelWinName.ContextMenuStrip = this.rightClickMenuStrip;
            this.labelWinName.Location = new System.Drawing.Point(33, 9);
            this.labelWinName.Name = "labelWinName";
            this.labelWinName.Size = new System.Drawing.Size(61, 13);
            this.labelWinName.TabIndex = 27;
            this.labelWinName.Text = "Worker Ant";
            this.labelWinName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowMouseDown);
            this.labelWinName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WindowMouseMove);
            this.labelWinName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WindowMouseUp);
            // 
            // notifyIconCUI
            // 
            this.notifyIconCUI.ContextMenuStrip = this.contextMenuStripNotifyIcon;
            this.notifyIconCUI.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconCUI.Icon")));
            this.notifyIconCUI.Text = "Worker Ant";
            this.notifyIconCUI.Visible = true;
            this.notifyIconCUI.Click += new System.EventHandler(this.NotifyIconClick);
            // 
            // CompleteUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 236);
            this.ContextMenuStrip = this.rightClickMenuStrip;
            this.Controls.Add(this.picBoxSettings);
            this.Controls.Add(this.picBoxInfo);
            this.Controls.Add(this.picBoxClose);
            this.Controls.Add(this.picBoxIcon);
            this.Controls.Add(this.labelWinName);
            this.Controls.Add(this.radioBtnManual);
            this.Controls.Add(this.groupBoxPreview);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.btnSetReset);
            this.Controls.Add(this.radioBtnRecovery);
            this.Controls.Add(this.radioBtnProgress);
            this.Controls.Add(this.radioBtnSmart);
            this.Controls.Add(this.progressBarCountdown);
            this.Controls.Add(this.groupBoxCountdown);
            this.Controls.Add(this.groupBoxManual);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CompleteUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Worker Ant";
            this.Load += new System.EventHandler(this.CompleteUILoad);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowMouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WindowMouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WindowMouseUp);
            this.groupBoxManual.ResumeLayout(false);
            this.groupBoxManual.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDBreakManual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDWorkManual)).EndInit();
            this.groupBoxCountdown.ResumeLayout(false);
            this.groupBoxCountdown.PerformLayout();
            this.groupBoxPreview.ResumeLayout(false);
            this.groupBoxPreview.PerformLayout();
            this.rightClickMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStripNotifyIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxManual;
        private System.Windows.Forms.Label labelBreakManual;
        private System.Windows.Forms.Label labelWorkManual;
        private System.Windows.Forms.GroupBox groupBoxCountdown;
        private System.Windows.Forms.Label labellabelLapLive;
        private System.Windows.Forms.Label labelBreakCountdown;
        private System.Windows.Forms.Label labelWorkCountdown;
        private System.Windows.Forms.ProgressBar progressBarCountdown;
        private System.Windows.Forms.GroupBox groupBoxPreview;
        private System.Windows.Forms.Label labelLapPreview;
        private System.Windows.Forms.Label labelBreakPreview;
        private System.Windows.Forms.Label labelWorkPreview;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.NumericUpDown numUDWorkManual;
        public System.Windows.Forms.NumericUpDown numUDBreakManual;
        public System.Windows.Forms.RadioButton radioBtnSmart;
        public System.Windows.Forms.RadioButton radioBtnProgress;
        public System.Windows.Forms.RadioButton radioBtnRecovery;
        public System.Windows.Forms.RadioButton radioBtnManual;
        public System.Windows.Forms.Label labelLapCounterLive;
        public System.Windows.Forms.Label labelBreakTimeCountdown;
        public System.Windows.Forms.Label labelWorkTimeCountdown;
        public System.Windows.Forms.Button btnSetReset;
        public System.Windows.Forms.Button btnStartStop;
        public System.Windows.Forms.Label labelLapCounterPreview;
        public System.Windows.Forms.Label labelBreakTimePreview;
        public System.Windows.Forms.Label labelWorkTimePreview;
        private System.Windows.Forms.Timer liveDataUpdate;
        private System.Windows.Forms.ContextMenuStrip rightClickMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        public System.Windows.Forms.ContextMenuStrip contextMenuStripNotifyIcon;
        private System.Windows.Forms.PictureBox picBoxSettings;
        private System.Windows.Forms.PictureBox picBoxInfo;
        private System.Windows.Forms.PictureBox picBoxClose;
        private System.Windows.Forms.PictureBox picBoxIcon;
        private System.Windows.Forms.Label labelWinName;
        private System.Windows.Forms.NotifyIcon notifyIconCUI;
    }
}

