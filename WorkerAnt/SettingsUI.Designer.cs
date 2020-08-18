namespace WorkerAnt
{
    partial class SettingsUI
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
            WorkerAnt.Properties.Settings settings1 = new WorkerAnt.Properties.Settings();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsUI));
            this.labelWinName = new System.Windows.Forms.Label();
            this.groupBoxSetSmart = new System.Windows.Forms.GroupBox();
            this.numUDBreakSmart = new System.Windows.Forms.NumericUpDown();
            this.numUDWorkSmart = new System.Windows.Forms.NumericUpDown();
            this.labelBreakSmart = new System.Windows.Forms.Label();
            this.labelWorkSmart = new System.Windows.Forms.Label();
            this.groupBoxSetProgress = new System.Windows.Forms.GroupBox();
            this.numUDBreakProgress = new System.Windows.Forms.NumericUpDown();
            this.numUDWorkProgress = new System.Windows.Forms.NumericUpDown();
            this.labelBreakProgress = new System.Windows.Forms.Label();
            this.labelWorkProgress = new System.Windows.Forms.Label();
            this.groupBoxSetRecovery = new System.Windows.Forms.GroupBox();
            this.numUDBreakRecovery = new System.Windows.Forms.NumericUpDown();
            this.numUDWorkRecovery = new System.Windows.Forms.NumericUpDown();
            this.labelBreakRecovery = new System.Windows.Forms.Label();
            this.labelWorkRecovery = new System.Windows.Forms.Label();
            this.labelRoundSet = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDefault = new System.Windows.Forms.Button();
            this.labelAudioAlert = new System.Windows.Forms.Label();
            this.labelSimpleView = new System.Windows.Forms.Label();
            this.picBoxInfo = new System.Windows.Forms.PictureBox();
            this.picBoxIcon = new System.Windows.Forms.PictureBox();
            this.picBoxClose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBoxSimpleView = new System.Windows.Forms.CheckBox();
            this.labelAutoStart = new System.Windows.Forms.Label();
            this.checkBoxAutoStart = new System.Windows.Forms.CheckBox();
            this.checkBoxAudioAlert = new System.Windows.Forms.CheckBox();
            this.numUDRound = new System.Windows.Forms.NumericUpDown();
            this.labelBreakInfo = new System.Windows.Forms.Label();
            this.checkBoxBreakInfo = new System.Windows.Forms.CheckBox();
            this.groupBoxSetSmart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDBreakSmart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDWorkSmart)).BeginInit();
            this.groupBoxSetProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDBreakProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDWorkProgress)).BeginInit();
            this.groupBoxSetRecovery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDBreakRecovery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDWorkRecovery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDRound)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWinName
            // 
            this.labelWinName.AutoSize = true;
            this.labelWinName.Location = new System.Drawing.Point(34, 8);
            this.labelWinName.Name = "labelWinName";
            this.labelWinName.Size = new System.Drawing.Size(45, 13);
            this.labelWinName.TabIndex = 2;
            this.labelWinName.Text = "Settings";
            this.labelWinName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowMouseDown);
            this.labelWinName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WindowMouseMove);
            this.labelWinName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WindowMouseUp);
            // 
            // groupBoxSetSmart
            // 
            this.groupBoxSetSmart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxSetSmart.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxSetSmart.Controls.Add(this.numUDBreakSmart);
            this.groupBoxSetSmart.Controls.Add(this.numUDWorkSmart);
            this.groupBoxSetSmart.Controls.Add(this.labelBreakSmart);
            this.groupBoxSetSmart.Controls.Add(this.labelWorkSmart);
            this.groupBoxSetSmart.Location = new System.Drawing.Point(178, 37);
            this.groupBoxSetSmart.Name = "groupBoxSetSmart";
            this.groupBoxSetSmart.Size = new System.Drawing.Size(160, 69);
            this.groupBoxSetSmart.TabIndex = 3;
            this.groupBoxSetSmart.TabStop = false;
            this.groupBoxSetSmart.Text = "Smart";
            // 
            // numUDBreakSmart
            // 
            this.numUDBreakSmart.Location = new System.Drawing.Point(84, 40);
            this.numUDBreakSmart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDBreakSmart.Name = "numUDBreakSmart";
            this.numUDBreakSmart.Size = new System.Drawing.Size(70, 20);
            this.numUDBreakSmart.TabIndex = 6;
            this.numUDBreakSmart.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numUDWorkSmart
            // 
            this.numUDWorkSmart.Location = new System.Drawing.Point(83, 14);
            this.numUDWorkSmart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDWorkSmart.Name = "numUDWorkSmart";
            this.numUDWorkSmart.Size = new System.Drawing.Size(71, 20);
            this.numUDWorkSmart.TabIndex = 5;
            this.numUDWorkSmart.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelBreakSmart
            // 
            this.labelBreakSmart.AutoSize = true;
            this.labelBreakSmart.Location = new System.Drawing.Point(6, 42);
            this.labelBreakSmart.Name = "labelBreakSmart";
            this.labelBreakSmart.Size = new System.Drawing.Size(35, 13);
            this.labelBreakSmart.TabIndex = 9;
            this.labelBreakSmart.Text = "Break";
            // 
            // labelWorkSmart
            // 
            this.labelWorkSmart.AutoSize = true;
            this.labelWorkSmart.Location = new System.Drawing.Point(6, 16);
            this.labelWorkSmart.Name = "labelWorkSmart";
            this.labelWorkSmart.Size = new System.Drawing.Size(33, 13);
            this.labelWorkSmart.TabIndex = 8;
            this.labelWorkSmart.Text = "Work";
            // 
            // groupBoxSetProgress
            // 
            this.groupBoxSetProgress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxSetProgress.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxSetProgress.Controls.Add(this.numUDBreakProgress);
            this.groupBoxSetProgress.Controls.Add(this.numUDWorkProgress);
            this.groupBoxSetProgress.Controls.Add(this.labelBreakProgress);
            this.groupBoxSetProgress.Controls.Add(this.labelWorkProgress);
            this.groupBoxSetProgress.Location = new System.Drawing.Point(12, 112);
            this.groupBoxSetProgress.Name = "groupBoxSetProgress";
            this.groupBoxSetProgress.Size = new System.Drawing.Size(160, 69);
            this.groupBoxSetProgress.TabIndex = 2;
            this.groupBoxSetProgress.TabStop = false;
            this.groupBoxSetProgress.Text = "Progress";
            // 
            // numUDBreakProgress
            // 
            this.numUDBreakProgress.Location = new System.Drawing.Point(84, 40);
            this.numUDBreakProgress.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDBreakProgress.Name = "numUDBreakProgress";
            this.numUDBreakProgress.Size = new System.Drawing.Size(70, 20);
            this.numUDBreakProgress.TabIndex = 4;
            this.numUDBreakProgress.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numUDWorkProgress
            // 
            this.numUDWorkProgress.Location = new System.Drawing.Point(83, 14);
            this.numUDWorkProgress.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDWorkProgress.Name = "numUDWorkProgress";
            this.numUDWorkProgress.Size = new System.Drawing.Size(71, 20);
            this.numUDWorkProgress.TabIndex = 3;
            this.numUDWorkProgress.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelBreakProgress
            // 
            this.labelBreakProgress.AutoSize = true;
            this.labelBreakProgress.Location = new System.Drawing.Point(6, 42);
            this.labelBreakProgress.Name = "labelBreakProgress";
            this.labelBreakProgress.Size = new System.Drawing.Size(35, 13);
            this.labelBreakProgress.TabIndex = 9;
            this.labelBreakProgress.Text = "Break";
            // 
            // labelWorkProgress
            // 
            this.labelWorkProgress.AutoSize = true;
            this.labelWorkProgress.Location = new System.Drawing.Point(6, 16);
            this.labelWorkProgress.Name = "labelWorkProgress";
            this.labelWorkProgress.Size = new System.Drawing.Size(33, 13);
            this.labelWorkProgress.TabIndex = 8;
            this.labelWorkProgress.Text = "Work";
            // 
            // groupBoxSetRecovery
            // 
            this.groupBoxSetRecovery.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxSetRecovery.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxSetRecovery.Controls.Add(this.numUDBreakRecovery);
            this.groupBoxSetRecovery.Controls.Add(this.numUDWorkRecovery);
            this.groupBoxSetRecovery.Controls.Add(this.labelBreakRecovery);
            this.groupBoxSetRecovery.Controls.Add(this.labelWorkRecovery);
            this.groupBoxSetRecovery.Location = new System.Drawing.Point(12, 37);
            this.groupBoxSetRecovery.Name = "groupBoxSetRecovery";
            this.groupBoxSetRecovery.Size = new System.Drawing.Size(160, 69);
            this.groupBoxSetRecovery.TabIndex = 1;
            this.groupBoxSetRecovery.TabStop = false;
            this.groupBoxSetRecovery.Text = "Recovery";
            // 
            // numUDBreakRecovery
            // 
            this.numUDBreakRecovery.Location = new System.Drawing.Point(84, 40);
            this.numUDBreakRecovery.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDBreakRecovery.Name = "numUDBreakRecovery";
            this.numUDBreakRecovery.Size = new System.Drawing.Size(70, 20);
            this.numUDBreakRecovery.TabIndex = 2;
            this.numUDBreakRecovery.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numUDWorkRecovery
            // 
            this.numUDWorkRecovery.Location = new System.Drawing.Point(83, 14);
            this.numUDWorkRecovery.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDWorkRecovery.Name = "numUDWorkRecovery";
            this.numUDWorkRecovery.Size = new System.Drawing.Size(71, 20);
            this.numUDWorkRecovery.TabIndex = 1;
            this.numUDWorkRecovery.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // labelBreakRecovery
            // 
            this.labelBreakRecovery.AutoSize = true;
            this.labelBreakRecovery.Location = new System.Drawing.Point(6, 42);
            this.labelBreakRecovery.Name = "labelBreakRecovery";
            this.labelBreakRecovery.Size = new System.Drawing.Size(35, 13);
            this.labelBreakRecovery.TabIndex = 9;
            this.labelBreakRecovery.Text = "Break";
            // 
            // labelWorkRecovery
            // 
            this.labelWorkRecovery.AutoSize = true;
            this.labelWorkRecovery.Location = new System.Drawing.Point(6, 16);
            this.labelWorkRecovery.Name = "labelWorkRecovery";
            this.labelWorkRecovery.Size = new System.Drawing.Size(33, 13);
            this.labelWorkRecovery.TabIndex = 8;
            this.labelWorkRecovery.Text = "Work";
            // 
            // labelRoundSet
            // 
            this.labelRoundSet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelRoundSet.AutoSize = true;
            this.labelRoundSet.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelRoundSet.Location = new System.Drawing.Point(184, 117);
            this.labelRoundSet.Name = "labelRoundSet";
            this.labelRoundSet.Size = new System.Drawing.Size(50, 13);
            this.labelRoundSet.TabIndex = 7;
            this.labelRoundSet.Text = "Round(s)";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.Location = new System.Drawing.Point(263, 205);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.SaveBtn);
            // 
            // btnDefault
            // 
            this.btnDefault.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDefault.Location = new System.Drawing.Point(182, 205);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(75, 23);
            this.btnDefault.TabIndex = 11;
            this.btnDefault.Text = "Default";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.DefaultBtn);
            // 
            // labelAudioAlert
            // 
            this.labelAudioAlert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAudioAlert.AutoSize = true;
            this.labelAudioAlert.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelAudioAlert.Location = new System.Drawing.Point(184, 142);
            this.labelAudioAlert.Name = "labelAudioAlert";
            this.labelAudioAlert.Size = new System.Drawing.Size(57, 13);
            this.labelAudioAlert.TabIndex = 13;
            this.labelAudioAlert.Text = "Audio alert";
            // 
            // labelSimpleView
            // 
            this.labelSimpleView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSimpleView.AutoSize = true;
            this.labelSimpleView.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSimpleView.Location = new System.Drawing.Point(184, 162);
            this.labelSimpleView.Name = "labelSimpleView";
            this.labelSimpleView.Size = new System.Drawing.Size(63, 13);
            this.labelSimpleView.TabIndex = 16;
            this.labelSimpleView.Text = "Simple view";
            // 
            // picBoxInfo
            // 
            this.picBoxInfo.Image = global::WorkerAnt.Properties.Resources.Info_L;
            this.picBoxInfo.Location = new System.Drawing.Point(270, 5);
            this.picBoxInfo.Name = "picBoxInfo";
            this.picBoxInfo.Size = new System.Drawing.Size(15, 15);
            this.picBoxInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxInfo.TabIndex = 18;
            this.picBoxInfo.TabStop = false;
            this.picBoxInfo.Click += new System.EventHandler(this.OpenAbout);
            this.picBoxInfo.MouseEnter += new System.EventHandler(this.AboutPicBoxMouseEnter);
            this.picBoxInfo.MouseLeave += new System.EventHandler(this.AboutPicBoxMouseLeave);
            // 
            // picBoxIcon
            // 
            this.picBoxIcon.Image = global::WorkerAnt.Properties.Resources.Worker_AntBW25;
            this.picBoxIcon.Location = new System.Drawing.Point(3, 1);
            this.picBoxIcon.Name = "picBoxIcon";
            this.picBoxIcon.Size = new System.Drawing.Size(25, 25);
            this.picBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxIcon.TabIndex = 1;
            this.picBoxIcon.TabStop = false;
            this.picBoxIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowMouseDown);
            this.picBoxIcon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WindowMouseMove);
            this.picBoxIcon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WindowMouseUp);
            // 
            // picBoxClose
            // 
            this.picBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxClose.Image = global::WorkerAnt.Properties.Resources.X_Close;
            this.picBoxClose.Location = new System.Drawing.Point(305, 0);
            this.picBoxClose.Name = "picBoxClose";
            this.picBoxClose.Size = new System.Drawing.Size(45, 25);
            this.picBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBoxClose.TabIndex = 0;
            this.picBoxClose.TabStop = false;
            this.picBoxClose.Click += new System.EventHandler(this.CloseWindow);
            this.picBoxClose.MouseEnter += new System.EventHandler(this.ClosePicBoxMouseEnter);
            this.picBoxClose.MouseLeave += new System.EventHandler(this.ClosePicBoxMouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 209);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // checkBoxSimpleView
            // 
            this.checkBoxSimpleView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBoxSimpleView.AutoSize = true;
            this.checkBoxSimpleView.Location = new System.Drawing.Point(317, 162);
            this.checkBoxSimpleView.Name = "checkBoxSimpleView";
            this.checkBoxSimpleView.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSimpleView.TabIndex = 10;
            this.checkBoxSimpleView.UseVisualStyleBackColor = true;
            // 
            // labelAutoStart
            // 
            this.labelAutoStart.AutoSize = true;
            this.labelAutoStart.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelAutoStart.Location = new System.Drawing.Point(184, 182);
            this.labelAutoStart.Name = "labelAutoStart";
            this.labelAutoStart.Size = new System.Drawing.Size(54, 13);
            this.labelAutoStart.TabIndex = 20;
            this.labelAutoStart.Text = "Auto-Start";
            // 
            // checkBoxAutoStart
            // 
            this.checkBoxAutoStart.AutoSize = true;
            this.checkBoxAutoStart.Location = new System.Drawing.Point(317, 182);
            this.checkBoxAutoStart.Name = "checkBoxAutoStart";
            this.checkBoxAutoStart.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAutoStart.TabIndex = 21;
            this.checkBoxAutoStart.UseVisualStyleBackColor = true;
            // 
            // checkBoxAudioAlert
            // 
            this.checkBoxAudioAlert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBoxAudioAlert.AutoSize = true;
            settings1.audioAlert = true;
            settings1.breakInfo = true;
            settings1.lapCounter = new decimal(new int[] {
            4,
            0,
            0,
            0});
            settings1.lastUsedLapPackage = 0;
            settings1.manualBreakTime = new decimal(new int[] {
            240,
            0,
            0,
            0});
            settings1.manualWorkTime = new decimal(new int[] {
            2700,
            0,
            0,
            0});
            settings1.progressBreakTime = new decimal(new int[] {
            300,
            0,
            0,
            0});
            settings1.progressWorkTime = new decimal(new int[] {
            3300,
            0,
            0,
            0});
            settings1.recoveryBreakTime = new decimal(new int[] {
            120,
            0,
            0,
            0});
            settings1.recoveryWorkTime = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            settings1.SettingsKey = "";
            settings1.simpleUI = false;
            settings1.smartBreakTime = new decimal(new int[] {
            240,
            0,
            0,
            0});
            settings1.smartWorkTime = new decimal(new int[] {
            2400,
            0,
            0,
            0});
            this.checkBoxAudioAlert.Checked = settings1.audioAlert;
            this.checkBoxAudioAlert.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAudioAlert.DataBindings.Add(new System.Windows.Forms.Binding("Checked", settings1, "audioAlert", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxAudioAlert.Location = new System.Drawing.Point(317, 141);
            this.checkBoxAudioAlert.Name = "checkBoxAudioAlert";
            this.checkBoxAudioAlert.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAudioAlert.TabIndex = 9;
            this.checkBoxAudioAlert.UseVisualStyleBackColor = true;
            // 
            // numUDRound
            // 
            this.numUDRound.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numUDRound.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::WorkerAnt.Properties.Settings.Default, "lapCounter", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numUDRound.Location = new System.Drawing.Point(261, 115);
            this.numUDRound.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUDRound.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDRound.Name = "numUDRound";
            this.numUDRound.Size = new System.Drawing.Size(71, 20);
            this.numUDRound.TabIndex = 7;
            this.numUDRound.Value = global::WorkerAnt.Properties.Settings.Default.lapCounter;
            // 
            // labelBreakInfo
            // 
            this.labelBreakInfo.AutoSize = true;
            this.labelBreakInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelBreakInfo.Location = new System.Drawing.Point(18, 187);
            this.labelBreakInfo.Name = "labelBreakInfo";
            this.labelBreakInfo.Size = new System.Drawing.Size(56, 13);
            this.labelBreakInfo.TabIndex = 20;
            this.labelBreakInfo.Text = "Break Info";
            // 
            // checkBoxBreakInfo
            // 
            this.checkBoxBreakInfo.AutoSize = true;
            this.checkBoxBreakInfo.Checked = true;
            this.checkBoxBreakInfo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBreakInfo.Location = new System.Drawing.Point(151, 187);
            this.checkBoxBreakInfo.Name = "checkBoxBreakInfo";
            this.checkBoxBreakInfo.Size = new System.Drawing.Size(15, 14);
            this.checkBoxBreakInfo.TabIndex = 21;
            this.checkBoxBreakInfo.UseVisualStyleBackColor = true;
            // 
            // SettingsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 240);
            this.Controls.Add(this.checkBoxBreakInfo);
            this.Controls.Add(this.labelBreakInfo);
            this.Controls.Add(this.checkBoxAutoStart);
            this.Controls.Add(this.labelAutoStart);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.picBoxInfo);
            this.Controls.Add(this.labelSimpleView);
            this.Controls.Add(this.checkBoxSimpleView);
            this.Controls.Add(this.checkBoxAudioAlert);
            this.Controls.Add(this.labelAudioAlert);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.numUDRound);
            this.Controls.Add(this.labelRoundSet);
            this.Controls.Add(this.groupBoxSetRecovery);
            this.Controls.Add(this.groupBoxSetProgress);
            this.Controls.Add(this.groupBoxSetSmart);
            this.Controls.Add(this.labelWinName);
            this.Controls.Add(this.picBoxIcon);
            this.Controls.Add(this.picBoxClose);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsUILoad);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowMouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WindowMouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WindowMouseUp);
            this.groupBoxSetSmart.ResumeLayout(false);
            this.groupBoxSetSmart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDBreakSmart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDWorkSmart)).EndInit();
            this.groupBoxSetProgress.ResumeLayout(false);
            this.groupBoxSetProgress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDBreakProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDWorkProgress)).EndInit();
            this.groupBoxSetRecovery.ResumeLayout(false);
            this.groupBoxSetRecovery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDBreakRecovery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDWorkRecovery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDRound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxClose;
        private System.Windows.Forms.PictureBox picBoxIcon;
        private System.Windows.Forms.Label labelWinName;
        private System.Windows.Forms.GroupBox groupBoxSetSmart;
        private System.Windows.Forms.Label labelBreakSmart;
        private System.Windows.Forms.Label labelWorkSmart;
        private System.Windows.Forms.GroupBox groupBoxSetProgress;
        private System.Windows.Forms.Label labelBreakProgress;
        private System.Windows.Forms.Label labelWorkProgress;
        private System.Windows.Forms.GroupBox groupBoxSetRecovery;
        private System.Windows.Forms.Label labelBreakRecovery;
        private System.Windows.Forms.Label labelWorkRecovery;
        private System.Windows.Forms.Label labelRoundSet;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.Label labelAudioAlert;
        private System.Windows.Forms.Label labelSimpleView;
        private System.Windows.Forms.PictureBox picBoxInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.NumericUpDown numUDBreakSmart;
        public System.Windows.Forms.NumericUpDown numUDWorkSmart;
        public System.Windows.Forms.NumericUpDown numUDBreakProgress;
        public System.Windows.Forms.NumericUpDown numUDWorkProgress;
        public System.Windows.Forms.NumericUpDown numUDBreakRecovery;
        public System.Windows.Forms.NumericUpDown numUDWorkRecovery;
        public System.Windows.Forms.NumericUpDown numUDRound;
        public System.Windows.Forms.CheckBox checkBoxAudioAlert;
        public System.Windows.Forms.CheckBox checkBoxSimpleView;
        private System.Windows.Forms.Label labelAutoStart;
        private System.Windows.Forms.CheckBox checkBoxAutoStart;
        private System.Windows.Forms.Label labelBreakInfo;
        private System.Windows.Forms.CheckBox checkBoxBreakInfo;
    }
}