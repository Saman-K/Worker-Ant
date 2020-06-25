using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkerAnt
{
    public partial class SimpleUI : Form
    {
        #region Fields and Properties
        // for Moving the form
        private int mouseXAxis;
        private int mouseYAxis;
        private bool mouseDrag;
        // saving data for preview
        private (int Work, int Break, int Laps) PreviewLapPackage { get; set; }
        #endregion

        #region Initialization
        // Initialization
        public SimpleUI()
        {
            InitializeComponent();
        }
        // Window Opens
        private void SimpleUILoad(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.lastUsedLapPackage == (int)LapPackageNames.Recovery)
            {
                radioBtnRecovery.Checked = true;
            }
            else if (Properties.Settings.Default.lastUsedLapPackage == (int)LapPackageNames.Smart || Properties.Settings.Default.lastUsedLapPackage == (int)LapPackageNames.Manual)
            {
                radioBtnSmart.Checked = true;
            }
            else if (Properties.Settings.Default.lastUsedLapPackage == (int)LapPackageNames.Progress)
            {
                radioBtnProgress.Checked = true;
            }
            else
            {
                MessageBox.Show("Radio Button not found!", "WorkerAnt", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Application.Exit();
            }
        }
        #endregion

        #region Form Border Style
        #region ------------------------------------------------------------------------- Move Window
        // Window mouse down
        private void WindowMouseDown(object sender, MouseEventArgs e)
        {
            mouseDrag = true;
            mouseXAxis = Cursor.Position.X - this.Left;
            mouseYAxis = Cursor.Position.Y - this.Top;
        }
        // Window mouse move
        private void WindowMouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDrag)
            {
                this.Left = Cursor.Position.X - mouseXAxis;
                this.Top = Cursor.Position.Y - mouseYAxis;
            }
        }
        // Window mouse up
        private void WindowMouseUp(object sender, MouseEventArgs e)
        {
            mouseDrag = false;
        }
        #endregion
        #region ------------------------------------------------------------------------- Close picture box
        // Minimize Window
        private void CloseWindow(object sender, EventArgs e)
        {
            Visible = false;
            // notify
        }
        // Close Application
        private void CloseApplication(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close this Worker Ant?", "WorkerAnt", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        // Close mouse leave 
        private void ClosePicBoxMouseLeave(object sender, EventArgs e)
        {
            picBoxClose.BackColor = SystemColors.Control;
        }
        // Close mouse enter
        private void ClosePicBoxMouseEnter(object sender, EventArgs e)
        {
            picBoxClose.BackColor = SystemColors.ControlDark;
        }
        #endregion
        #region ------------------------------------------------------------------------- About picture box
        // About enter
        private void AboutPicBoxMouseEnter(object sender, EventArgs e)
        {
            picBoxInfo.Image = WorkerAnt.Properties.Resources.Info;
        }
        // About leave
        private void AboutPicBoxMouseLeave(object sender, EventArgs e)
        {
            picBoxInfo.Image = WorkerAnt.Properties.Resources.Info_L;
        }
        // About click
        private void OpenAbout(object sender, EventArgs e)
        {
            var winCouter = new WindowBehavior();
            winCouter.WindowsOpenCheck(WindowNames.Info);
        }
        #endregion
        #region ------------------------------------------------------------------------- Settings picture box
        // Settings mouse enter
        private void SettingsPicBoxMouseEnter(object sender, EventArgs e)
        {
            picBoxSettings.Image = WorkerAnt.Properties.Resources.Settings;
        }
        // settings mouse leave
        private void SettingsPicBoxMouseLeave(object sender, EventArgs e)
        {
            picBoxSettings.Image = WorkerAnt.Properties.Resources.Settings_L;
        }
        // Open settings
        private void OpenSettings(object sender, EventArgs e)
        {
            var winCouter = new WindowBehavior();
            winCouter.WindowsOpenCheck(WindowNames.Settings);
        }
        #endregion
        #endregion

        #region Methods

        // Start/Stop button clicked
        private void StartStopBtn(object sender, EventArgs e)
        {
            if (btnStartStop.Text == "Start")
            {
                winRefresh.Start();
                RadioBtnEnabel(false);
            }
            else if (btnStartStop.Text == "Stop" && Countdown.TimeTickSegment == SegmentNames.Break)
            {
                winRefresh.Stop();
                RadioBtnEnabel(true);
            }

            btnStartStop.Text = btnStartStop.Text.StartStop();
        }

        // radio button Change
        private void RadioBtnChineged(object sender, EventArgs e)
        {
            GetLapPackage();

            labelWorkTimeCountdown.Text = PreviewLapPackage.Work.IntToTimerFormat();
            labelBreakTimeCountdown.Text = PreviewLapPackage.Break.IntToTimerFormat();
            labelRoundNumCountdown.Text = PreviewLapPackage.Laps.ToString();

            progressBarCountdown.Value = 0;

            Countdown.LastUserInput = PreviewLapPackage;

            Countdown.Set();
        }

        // Get radio btn selected lap package
        private void GetLapPackage()
        {
            if (radioBtnRecovery.Checked == true)
            {
                PreviewLapPackage = LapPackageNames.Recovery.GetLapPackageValue();
            }
            else if (radioBtnSmart.Checked == true)
            {
                PreviewLapPackage = LapPackageNames.Smart.GetLapPackageValue();
            }
            else if (radioBtnProgress.Checked == true)
            {
                PreviewLapPackage = LapPackageNames.Progress.GetLapPackageValue();
            }
            else
            {
                PreviewLapPackage = LapPackageNames.Smart.GetLapPackageValue();
                // error "Radio Button not found"
            }
        }

        // radio button Enable
        private void RadioBtnEnabel(bool trueFalse)
        {
            radioBtnRecovery.Enabled = trueFalse;
            radioBtnSmart.Enabled = trueFalse;
            radioBtnProgress.Enabled = trueFalse;
        }

        // refresh window data (timer)
        private void LiveDataUpdate(object sender, EventArgs e)
        {
            labelWorkTimeCountdown.Text = Countdown.WorkTimerLive.IntToTimerFormat();

            if (Countdown.TimeTickSegment == SegmentNames.EndBreak)
            {
                labelBreakTimeCountdown.Text = "- " + Countdown.BreakTimerLive.IntToTimerFormat();
                labelBreakTimeCountdown.ForeColor = Color.Red;

            }
            else
            {
                labelBreakTimeCountdown.Text = Countdown.BreakTimerLive.IntToTimerFormat();
                labelBreakTimeCountdown.ForeColor = SystemColors.ControlText;
            }

            labelRoundNumCountdown.Text = Countdown.LapCounterLive.ToString();

            if (Countdown.TimerTick == true)
            {
                btnStartStop.Text = "Stop";
            }
            else if (Countdown.TimerTick == false)
            {
                btnStartStop.Text = "Start";
            }

            if (Countdown.TimeTickSegment == SegmentNames.Work)
            {
                progressBarCountdown.SetState(1);
                progressBarCountdown.Value = Countdown.GetProgressInPercentage(SegmentNames.Work);
                progressBarCountdown.Style = ProgressBarStyle.Continuous;
            }
            else if (Countdown.TimeTickSegment == SegmentNames.Break)
            {
                progressBarCountdown.SetState(3);
                progressBarCountdown.Value = Countdown.GetProgressInPercentage(SegmentNames.Break);
                progressBarCountdown.Style = ProgressBarStyle.Continuous;
            }
            else if (Countdown.TimeTickSegment == SegmentNames.EndBreak)
            {
                progressBarCountdown.SetState(2);
                progressBarCountdown.Value = Countdown.GetProgressInPercentage(SegmentNames.EndBreak);
            }
        }

        // notify icon click
        private void NotifyIconDoubleClick(object sender, EventArgs e)
        {
            if (Visible == false)
            {
                Visible = true;
            }
        }

        #endregion
    }
}
