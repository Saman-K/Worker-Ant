﻿namespace WorkerAnt
{
    partial class BreakUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BreakUI));
            this.labelWinName = new System.Windows.Forms.Label();
            this.btnYesOkay = new System.Windows.Forms.Button();
            this.labelTheBreakWEI = new System.Windows.Forms.Label();
            this.labelLiveBreakTime = new System.Windows.Forms.Label();
            this.liveDataUpdate = new System.Windows.Forms.Timer(this.components);
            this.labelAnotherRound = new System.Windows.Forms.Label();
            this.btnNo = new System.Windows.Forms.Button();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.picBoxIcon = new System.Windows.Forms.PictureBox();
            this.picBoxClose = new System.Windows.Forms.PictureBox();
            this.picBoxBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWinName
            // 
            this.labelWinName.AutoSize = true;
            this.labelWinName.Location = new System.Drawing.Point(34, 8);
            this.labelWinName.Name = "labelWinName";
            this.labelWinName.Size = new System.Drawing.Size(61, 13);
            this.labelWinName.TabIndex = 4;
            this.labelWinName.Text = "Worker Ant";
            this.labelWinName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowMouseDown);
            this.labelWinName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WindowMouseMove);
            this.labelWinName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WindowMouseUp);
            // 
            // btnYesOkay
            // 
            this.btnYesOkay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYesOkay.Location = new System.Drawing.Point(263, 115);
            this.btnYesOkay.Name = "btnYesOkay";
            this.btnYesOkay.Size = new System.Drawing.Size(75, 23);
            this.btnYesOkay.TabIndex = 1;
            this.btnYesOkay.Text = "Yes";
            this.btnYesOkay.UseVisualStyleBackColor = true;
            this.btnYesOkay.Click += new System.EventHandler(this.YesOkayBtn);
            // 
            // labelTheBreakWEI
            // 
            this.labelTheBreakWEI.AutoSize = true;
            this.labelTheBreakWEI.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTheBreakWEI.Location = new System.Drawing.Point(73, 67);
            this.labelTheBreakWEI.Name = "labelTheBreakWEI";
            this.labelTheBreakWEI.Size = new System.Drawing.Size(84, 13);
            this.labelTheBreakWEI.TabIndex = 7;
            this.labelTheBreakWEI.Text = "Break will end in";
            // 
            // labelLiveBreakTime
            // 
            this.labelLiveBreakTime.AutoSize = true;
            this.labelLiveBreakTime.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelLiveBreakTime.Location = new System.Drawing.Point(156, 67);
            this.labelLiveBreakTime.Name = "labelLiveBreakTime";
            this.labelLiveBreakTime.Size = new System.Drawing.Size(78, 13);
            this.labelLiveBreakTime.TabIndex = 8;
            this.labelLiveBreakTime.Text = "LiveBreakTime";
            // 
            // liveDataUpdate
            // 
            this.liveDataUpdate.Tick += new System.EventHandler(this.LiveDataUpdate);
            // 
            // labelAnotherRound
            // 
            this.labelAnotherRound.AutoSize = true;
            this.labelAnotherRound.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelAnotherRound.Location = new System.Drawing.Point(89, 87);
            this.labelAnotherRound.Name = "labelAnotherRound";
            this.labelAnotherRound.Size = new System.Drawing.Size(177, 13);
            this.labelAnotherRound.TabIndex = 10;
            this.labelAnotherRound.Text = "Do you want to start another round?";
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(182, 115);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 23);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.NoBtn);
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picBoxLogo.Image = global::WorkerAnt.Properties.Resources.Worker_AntBWH128;
            this.picBoxLogo.Location = new System.Drawing.Point(12, 45);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(55, 55);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxLogo.TabIndex = 6;
            this.picBoxLogo.TabStop = false;
            // 
            // picBoxIcon
            // 
            this.picBoxIcon.Image = global::WorkerAnt.Properties.Resources.Worker_AntBW25;
            this.picBoxIcon.Location = new System.Drawing.Point(3, 1);
            this.picBoxIcon.Name = "picBoxIcon";
            this.picBoxIcon.Size = new System.Drawing.Size(25, 25);
            this.picBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxIcon.TabIndex = 3;
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
            this.picBoxClose.TabIndex = 1;
            this.picBoxClose.TabStop = false;
            this.picBoxClose.Click += new System.EventHandler(this.CloseWindow);
            this.picBoxClose.MouseEnter += new System.EventHandler(this.ClosePicBoxMouseEnter);
            this.picBoxClose.MouseLeave += new System.EventHandler(this.ClosePicBoxMouseLeave);
            // 
            // picBoxBackground
            // 
            this.picBoxBackground.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picBoxBackground.Location = new System.Drawing.Point(0, 31);
            this.picBoxBackground.Name = "picBoxBackground";
            this.picBoxBackground.Size = new System.Drawing.Size(350, 119);
            this.picBoxBackground.TabIndex = 9;
            this.picBoxBackground.TabStop = false;
            // 
            // BreakUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 150);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.labelAnotherRound);
            this.Controls.Add(this.labelLiveBreakTime);
            this.Controls.Add(this.labelTheBreakWEI);
            this.Controls.Add(this.picBoxLogo);
            this.Controls.Add(this.btnYesOkay);
            this.Controls.Add(this.labelWinName);
            this.Controls.Add(this.picBoxIcon);
            this.Controls.Add(this.picBoxClose);
            this.Controls.Add(this.picBoxBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BreakUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Break Time";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.BreakUILoad);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowMouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WindowMouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WindowMouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxClose;
        private System.Windows.Forms.Label labelWinName;
        private System.Windows.Forms.PictureBox picBoxIcon;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.Label labelTheBreakWEI;
        private System.Windows.Forms.Label labelLiveBreakTime;
        private System.Windows.Forms.PictureBox picBoxBackground;
        private System.Windows.Forms.Timer liveDataUpdate;
        private System.Windows.Forms.Label labelAnotherRound;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnYesOkay;
    }
}