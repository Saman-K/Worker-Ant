namespace Worker_Ant
{
    partial class SettingsWin
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
            this.numUDRound = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDefault = new System.Windows.Forms.Button();
            this.labelSafetyInfo = new System.Windows.Forms.Label();
            this.checkBoxSafetyInfo = new System.Windows.Forms.CheckBox();
            this.labelAudioAlert = new System.Windows.Forms.Label();
            this.checkBoxAudioAlert = new System.Windows.Forms.CheckBox();
            this.checkBoxSimpleView = new System.Windows.Forms.CheckBox();
            this.labelSimpleView = new System.Windows.Forms.Label();
            this.buttonAdminSet = new System.Windows.Forms.Button();
            this.picBoxInfo = new System.Windows.Forms.PictureBox();
            this.picBoxIcon = new System.Windows.Forms.PictureBox();
            this.picBoxClose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxSetSmart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDBreakSmart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDWorkSmart)).BeginInit();
            this.groupBoxSetProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDBreakProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDWorkProgress)).BeginInit();
            this.groupBoxSetRecovery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDBreakRecovery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDWorkRecovery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDRound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWinName
            // 
            this.labelWinName.AutoSize = true;
            this.labelWinName.Location = new System.Drawing.Point(31, 7);
            this.labelWinName.Name = "labelWinName";
            this.labelWinName.Size = new System.Drawing.Size(45, 13);
            this.labelWinName.TabIndex = 2;
            this.labelWinName.Text = "Settings";
            this.labelWinName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Win_MouseDown);
            this.labelWinName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Win_MouseMove);
            this.labelWinName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Win_MouseUp);
            // 
            // groupBoxSetSmart
            // 
            this.groupBoxSetSmart.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxSetSmart.Controls.Add(this.numUDBreakSmart);
            this.groupBoxSetSmart.Controls.Add(this.numUDWorkSmart);
            this.groupBoxSetSmart.Controls.Add(this.labelBreakSmart);
            this.groupBoxSetSmart.Controls.Add(this.labelWorkSmart);
            this.groupBoxSetSmart.Location = new System.Drawing.Point(178, 31);
            this.groupBoxSetSmart.Name = "groupBoxSetSmart";
            this.groupBoxSetSmart.Size = new System.Drawing.Size(160, 69);
            this.groupBoxSetSmart.TabIndex = 3;
            this.groupBoxSetSmart.TabStop = false;
            this.groupBoxSetSmart.Text = "Smart";
            // 
            // numUDBreakSmart
            // 
            this.numUDBreakSmart.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Worker_Ant.Properties.Settings.Default, "smartBreakTime", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numUDBreakSmart.Location = new System.Drawing.Point(84, 40);
            this.numUDBreakSmart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDBreakSmart.Name = "numUDBreakSmart";
            this.numUDBreakSmart.Size = new System.Drawing.Size(70, 20);
            this.numUDBreakSmart.TabIndex = 6;
            this.numUDBreakSmart.Value = global::Worker_Ant.Properties.Settings.Default.smartBreakTime;
            // 
            // numUDWorkSmart
            // 
            this.numUDWorkSmart.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Worker_Ant.Properties.Settings.Default, "smartWorkTime", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numUDWorkSmart.Location = new System.Drawing.Point(83, 14);
            this.numUDWorkSmart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDWorkSmart.Name = "numUDWorkSmart";
            this.numUDWorkSmart.Size = new System.Drawing.Size(71, 20);
            this.numUDWorkSmart.TabIndex = 5;
            this.numUDWorkSmart.Value = global::Worker_Ant.Properties.Settings.Default.smartWorkTime;
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
            this.groupBoxSetProgress.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxSetProgress.Controls.Add(this.numUDBreakProgress);
            this.groupBoxSetProgress.Controls.Add(this.numUDWorkProgress);
            this.groupBoxSetProgress.Controls.Add(this.labelBreakProgress);
            this.groupBoxSetProgress.Controls.Add(this.labelWorkProgress);
            this.groupBoxSetProgress.Location = new System.Drawing.Point(12, 106);
            this.groupBoxSetProgress.Name = "groupBoxSetProgress";
            this.groupBoxSetProgress.Size = new System.Drawing.Size(160, 69);
            this.groupBoxSetProgress.TabIndex = 2;
            this.groupBoxSetProgress.TabStop = false;
            this.groupBoxSetProgress.Text = "Progress";
            // 
            // numUDBreakProgress
            // 
            this.numUDBreakProgress.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Worker_Ant.Properties.Settings.Default, "progressBreakTime", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numUDBreakProgress.Location = new System.Drawing.Point(84, 40);
            this.numUDBreakProgress.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDBreakProgress.Name = "numUDBreakProgress";
            this.numUDBreakProgress.Size = new System.Drawing.Size(70, 20);
            this.numUDBreakProgress.TabIndex = 4;
            this.numUDBreakProgress.Value = global::Worker_Ant.Properties.Settings.Default.progressBreakTime;
            // 
            // numUDWorkProgress
            // 
            this.numUDWorkProgress.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Worker_Ant.Properties.Settings.Default, "progressWorkTime", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numUDWorkProgress.Location = new System.Drawing.Point(83, 14);
            this.numUDWorkProgress.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDWorkProgress.Name = "numUDWorkProgress";
            this.numUDWorkProgress.Size = new System.Drawing.Size(71, 20);
            this.numUDWorkProgress.TabIndex = 3;
            this.numUDWorkProgress.Value = global::Worker_Ant.Properties.Settings.Default.progressWorkTime;
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
            this.groupBoxSetRecovery.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxSetRecovery.Controls.Add(this.numUDBreakRecovery);
            this.groupBoxSetRecovery.Controls.Add(this.numUDWorkRecovery);
            this.groupBoxSetRecovery.Controls.Add(this.labelBreakRecovery);
            this.groupBoxSetRecovery.Controls.Add(this.labelWorkRecovery);
            this.groupBoxSetRecovery.Location = new System.Drawing.Point(12, 31);
            this.groupBoxSetRecovery.Name = "groupBoxSetRecovery";
            this.groupBoxSetRecovery.Size = new System.Drawing.Size(160, 69);
            this.groupBoxSetRecovery.TabIndex = 1;
            this.groupBoxSetRecovery.TabStop = false;
            this.groupBoxSetRecovery.Text = "Recovery";
            // 
            // numUDBreakRecovery
            // 
            this.numUDBreakRecovery.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Worker_Ant.Properties.Settings.Default, "recoveryBreakTime", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numUDBreakRecovery.Location = new System.Drawing.Point(84, 40);
            this.numUDBreakRecovery.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDBreakRecovery.Name = "numUDBreakRecovery";
            this.numUDBreakRecovery.Size = new System.Drawing.Size(70, 20);
            this.numUDBreakRecovery.TabIndex = 2;
            this.numUDBreakRecovery.Value = global::Worker_Ant.Properties.Settings.Default.recoveryBreakTime;
            // 
            // numUDWorkRecovery
            // 
            this.numUDWorkRecovery.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Worker_Ant.Properties.Settings.Default, "recoveryWorkTime", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numUDWorkRecovery.Location = new System.Drawing.Point(83, 14);
            this.numUDWorkRecovery.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDWorkRecovery.Name = "numUDWorkRecovery";
            this.numUDWorkRecovery.Size = new System.Drawing.Size(71, 20);
            this.numUDWorkRecovery.TabIndex = 1;
            this.numUDWorkRecovery.Value = global::Worker_Ant.Properties.Settings.Default.recoveryWorkTime;
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
            this.labelRoundSet.AutoSize = true;
            this.labelRoundSet.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelRoundSet.Location = new System.Drawing.Point(184, 111);
            this.labelRoundSet.Name = "labelRoundSet";
            this.labelRoundSet.Size = new System.Drawing.Size(50, 13);
            this.labelRoundSet.TabIndex = 7;
            this.labelRoundSet.Text = "Round(s)";
            // 
            // numUDRound
            // 
            this.numUDRound.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Worker_Ant.Properties.Settings.Default, "roundCountdown", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numUDRound.Location = new System.Drawing.Point(261, 109);
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
            this.numUDRound.Value = global::Worker_Ant.Properties.Settings.Default.roundCountdown;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(101, 200);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDefault
            // 
            this.btnDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDefault.Location = new System.Drawing.Point(263, 200);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(75, 23);
            this.btnDefault.TabIndex = 11;
            this.btnDefault.Text = "Default";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // labelSafetyInfo
            // 
            this.labelSafetyInfo.AutoSize = true;
            this.labelSafetyInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSafetyInfo.Location = new System.Drawing.Point(184, 136);
            this.labelSafetyInfo.Name = "labelSafetyInfo";
            this.labelSafetyInfo.Size = new System.Drawing.Size(57, 13);
            this.labelSafetyInfo.TabIndex = 11;
            this.labelSafetyInfo.Text = "Safety info";
            // 
            // checkBoxSafetyInfo
            // 
            this.checkBoxSafetyInfo.AutoSize = true;
            this.checkBoxSafetyInfo.Checked = global::Worker_Ant.Properties.Settings.Default.saftyInfo;
            this.checkBoxSafetyInfo.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Worker_Ant.Properties.Settings.Default, "saftyInfo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxSafetyInfo.Enabled = false;
            this.checkBoxSafetyInfo.Location = new System.Drawing.Point(317, 136);
            this.checkBoxSafetyInfo.Name = "checkBoxSafetyInfo";
            this.checkBoxSafetyInfo.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSafetyInfo.TabIndex = 8;
            this.checkBoxSafetyInfo.UseVisualStyleBackColor = true;
            // 
            // labelAudioAlert
            // 
            this.labelAudioAlert.AutoSize = true;
            this.labelAudioAlert.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelAudioAlert.Location = new System.Drawing.Point(184, 156);
            this.labelAudioAlert.Name = "labelAudioAlert";
            this.labelAudioAlert.Size = new System.Drawing.Size(57, 13);
            this.labelAudioAlert.TabIndex = 13;
            this.labelAudioAlert.Text = "Audio alert";
            // 
            // checkBoxAudioAlert
            // 
            this.checkBoxAudioAlert.AutoSize = true;
            this.checkBoxAudioAlert.Checked = global::Worker_Ant.Properties.Settings.Default.audioAlert;
            this.checkBoxAudioAlert.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Worker_Ant.Properties.Settings.Default, "audioAlert", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxAudioAlert.Enabled = false;
            this.checkBoxAudioAlert.Location = new System.Drawing.Point(317, 156);
            this.checkBoxAudioAlert.Name = "checkBoxAudioAlert";
            this.checkBoxAudioAlert.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAudioAlert.TabIndex = 9;
            this.checkBoxAudioAlert.UseVisualStyleBackColor = true;
            // 
            // checkBoxSimpleView
            // 
            this.checkBoxSimpleView.AutoSize = true;
            this.checkBoxSimpleView.Checked = global::Worker_Ant.Properties.Settings.Default.simpleView;
            this.checkBoxSimpleView.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Worker_Ant.Properties.Settings.Default, "simpleView", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxSimpleView.Enabled = false;
            this.checkBoxSimpleView.Location = new System.Drawing.Point(317, 176);
            this.checkBoxSimpleView.Name = "checkBoxSimpleView";
            this.checkBoxSimpleView.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSimpleView.TabIndex = 10;
            this.checkBoxSimpleView.UseVisualStyleBackColor = true;
            // 
            // labelSimpleView
            // 
            this.labelSimpleView.AutoSize = true;
            this.labelSimpleView.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSimpleView.Location = new System.Drawing.Point(184, 176);
            this.labelSimpleView.Name = "labelSimpleView";
            this.labelSimpleView.Size = new System.Drawing.Size(63, 13);
            this.labelSimpleView.TabIndex = 16;
            this.labelSimpleView.Text = "Simple view";
            // 
            // buttonAdminSet
            // 
            this.buttonAdminSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdminSet.Enabled = false;
            this.buttonAdminSet.Location = new System.Drawing.Point(12, 200);
            this.buttonAdminSet.Name = "buttonAdminSet";
            this.buttonAdminSet.Size = new System.Drawing.Size(75, 23);
            this.buttonAdminSet.TabIndex = 17;
            this.buttonAdminSet.Text = "Admin";
            this.buttonAdminSet.UseVisualStyleBackColor = true;
            // 
            // picBoxInfo
            // 
            this.picBoxInfo.Image = global::Worker_Ant.Properties.Resources.Info_L;
            this.picBoxInfo.Location = new System.Drawing.Point(270, 5);
            this.picBoxInfo.Name = "picBoxInfo";
            this.picBoxInfo.Size = new System.Drawing.Size(15, 15);
            this.picBoxInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxInfo.TabIndex = 18;
            this.picBoxInfo.TabStop = false;
            this.picBoxInfo.Click += new System.EventHandler(this.picBoxInfo_Click);
            this.picBoxInfo.MouseEnter += new System.EventHandler(this.picBoxInfo_MouseEnter);
            this.picBoxInfo.MouseLeave += new System.EventHandler(this.picBoxInfo_MouseLeave);
            // 
            // picBoxIcon
            // 
            this.picBoxIcon.Image = global::Worker_Ant.Properties.Resources.Whorker_AntBW25;
            this.picBoxIcon.Location = new System.Drawing.Point(0, 0);
            this.picBoxIcon.Name = "picBoxIcon";
            this.picBoxIcon.Size = new System.Drawing.Size(25, 25);
            this.picBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxIcon.TabIndex = 1;
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
            this.picBoxClose.TabIndex = 0;
            this.picBoxClose.TabStop = false;
            this.picBoxClose.Click += new System.EventHandler(this.picBoxClose_Click);
            this.picBoxClose.MouseEnter += new System.EventHandler(this.picBoxClose_MouseEnter);
            this.picBoxClose.MouseLeave += new System.EventHandler(this.picBoxClose_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(0, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 210);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // SettingsWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 235);
            this.Controls.Add(this.picBoxInfo);
            this.Controls.Add(this.buttonAdminSet);
            this.Controls.Add(this.labelSimpleView);
            this.Controls.Add(this.checkBoxSimpleView);
            this.Controls.Add(this.checkBoxAudioAlert);
            this.Controls.Add(this.labelAudioAlert);
            this.Controls.Add(this.checkBoxSafetyInfo);
            this.Controls.Add(this.labelSafetyInfo);
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
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsWin";
            this.Text = " ";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Win_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Win_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Win_MouseUp);
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
            ((System.ComponentModel.ISupportInitialize)(this.numUDRound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label labelSafetyInfo;
        private System.Windows.Forms.Label labelAudioAlert;
        private System.Windows.Forms.Label labelSimpleView;
        private System.Windows.Forms.Button buttonAdminSet;
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
        public System.Windows.Forms.CheckBox checkBoxSafetyInfo;
        public System.Windows.Forms.CheckBox checkBoxAudioAlert;
        public System.Windows.Forms.CheckBox checkBoxSimpleView;
    }
}