namespace Worker_Ant
{
    partial class BreakBasic
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
            this.btnOkBreakBasic = new System.Windows.Forms.Button();
            this.labelTheBreakWEI = new System.Windows.Forms.Label();
            this.labelLiveBreakTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picBoxIcon = new System.Windows.Forms.PictureBox();
            this.picBoxClose = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWinName
            // 
            this.labelWinName.AutoSize = true;
            this.labelWinName.Location = new System.Drawing.Point(31, 9);
            this.labelWinName.Name = "labelWinName";
            this.labelWinName.Size = new System.Drawing.Size(61, 13);
            this.labelWinName.TabIndex = 4;
            this.labelWinName.Text = "Worker Ant";
            // 
            // btnOkBreakBasic
            // 
            this.btnOkBreakBasic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOkBreakBasic.Location = new System.Drawing.Point(263, 115);
            this.btnOkBreakBasic.Name = "btnOkBreakBasic";
            this.btnOkBreakBasic.Size = new System.Drawing.Size(75, 23);
            this.btnOkBreakBasic.TabIndex = 5;
            this.btnOkBreakBasic.Text = "Okey";
            this.btnOkBreakBasic.UseVisualStyleBackColor = true;
            // 
            // labelTheBreakWEI
            // 
            this.labelTheBreakWEI.AutoSize = true;
            this.labelTheBreakWEI.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTheBreakWEI.Location = new System.Drawing.Point(73, 67);
            this.labelTheBreakWEI.Name = "labelTheBreakWEI";
            this.labelTheBreakWEI.Size = new System.Drawing.Size(108, 13);
            this.labelTheBreakWEI.TabIndex = 7;
            this.labelTheBreakWEI.Text = "The break will end in ";
            // 
            // labelLiveBreakTime
            // 
            this.labelLiveBreakTime.AutoSize = true;
            this.labelLiveBreakTime.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelLiveBreakTime.Location = new System.Drawing.Point(175, 67);
            this.labelLiveBreakTime.Name = "labelLiveBreakTime";
            this.labelLiveBreakTime.Size = new System.Drawing.Size(78, 13);
            this.labelLiveBreakTime.TabIndex = 8;
            this.labelLiveBreakTime.Text = "LiveBreakTime";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = global::Worker_Ant.Properties.Resources.Whorker_AntBWH128;
            this.pictureBox1.Location = new System.Drawing.Point(12, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // picBoxIcon
            // 
            this.picBoxIcon.Image = global::Worker_Ant.Properties.Resources.Whorker_AntBW25;
            this.picBoxIcon.Location = new System.Drawing.Point(0, 0);
            this.picBoxIcon.Name = "picBoxIcon";
            this.picBoxIcon.Size = new System.Drawing.Size(25, 25);
            this.picBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxIcon.TabIndex = 3;
            this.picBoxIcon.TabStop = false;
            // 
            // picBoxClose
            // 
            this.picBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxClose.Image = global::Worker_Ant.Properties.Resources.X_Close;
            this.picBoxClose.Location = new System.Drawing.Point(305, 0);
            this.picBoxClose.Name = "picBoxClose";
            this.picBoxClose.Size = new System.Drawing.Size(45, 25);
            this.picBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBoxClose.TabIndex = 1;
            this.picBoxClose.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox2.Location = new System.Drawing.Point(0, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(350, 125);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // BreakBasic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 150);
            this.Controls.Add(this.labelLiveBreakTime);
            this.Controls.Add(this.labelTheBreakWEI);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOkBreakBasic);
            this.Controls.Add(this.labelWinName);
            this.Controls.Add(this.picBoxIcon);
            this.Controls.Add(this.picBoxClose);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BreakBasic";
            this.Load += new System.EventHandler(this.BreakBasic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxClose;
        private System.Windows.Forms.Label labelWinName;
        private System.Windows.Forms.PictureBox picBoxIcon;
        private System.Windows.Forms.Button btnOkBreakBasic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTheBreakWEI;
        private System.Windows.Forms.Label labelLiveBreakTime;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}