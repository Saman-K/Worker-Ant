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
        // For moving the form
        private int _mouseXAxis;
        private int _mouseYAxis;
        private bool _mouseDrag;
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

                radioBtnSmart.Checked = true;
            }
        }
        #endregion

        #region Form Border Style
        #region ------------------------------------------------------------------------- Move Window
        // Window mouse down
        private void WindowMouseDown(object sender, MouseEventArgs e)
        {
            _mouseDrag = true;
            _mouseXAxis = Cursor.Position.X - this.Left;
            _mouseYAxis = Cursor.Position.Y - this.Top;
        }
        // Window mouse move
        private void WindowMouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDrag)
            {
                this.Left = Cursor.Position.X - _mouseXAxis;
                this.Top = Cursor.Position.Y - _mouseYAxis;
            }
        }
        // Window mouse up
        private void WindowMouseUp(object sender, MouseEventArgs e)
        {
            _mouseDrag = false;
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
            if (Countdown.TimerTick == true)
            {
                if (MessageBox.Show("Are you sure you want to close Worker Ant while the timer is running?", "Worker Ant", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            else
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
            SaveLapPackageUsed();

            btnStartStop.Text = btnStartStop.Text.StartStop();
        }

        // radio button Change
        private void RadioBtnChineged(object sender, EventArgs e)
        {
            GetLapPackage();

            labelWorkTimeCountdown.Text = PreviewLapPackage.Work.IntToTimerFormat();
            labelBreakTimeCountdown.Text = PreviewLapPackage.Break.IntToTimerFormat();
            labelLapCounterLive.Text = PreviewLapPackage.Laps.ToString();

            progressBarCountdown.Value = 0;

            Countdown.LastUserInput = PreviewLapPackage;

            Countdown.Set();
        }

        // Get radio button selected lap package
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
                MessageBox.Show("Radio Button not found!", "WorkerAnt", MessageBoxButtons.OK, MessageBoxIcon.Error);

                PreviewLapPackage = LapPackageNames.Smart.GetLapPackageValue();
            }
        }

        // Radio button Enable
        private void RadioBtnEnabel(bool trueFalse)
        {
            radioBtnRecovery.Enabled = trueFalse;
            radioBtnSmart.Enabled = trueFalse;
            radioBtnProgress.Enabled = trueFalse;
        }

        // Refresh window data (timer)
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

            labelLapCounterLive.Text = Countdown.LapCounterLive.ToString();

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
                progressBarCountdown.Maximum = 100;
                progressBarCountdown.SetState(1);
                progressBarCountdown.Value = Countdown.GetProgressInPercentage(SegmentNames.Work);
            }
            else if (Countdown.TimeTickSegment == SegmentNames.Break)
            {
                progressBarCountdown.Maximum = 100;
                progressBarCountdown.SetState(3);
                progressBarCountdown.Value = Countdown.GetProgressInPercentage(SegmentNames.Break);
            }
            else if (Countdown.TimeTickSegment == SegmentNames.EndBreak)
            {
                progressBarCountdown.SetState(2);
                progressBarCountdown.Maximum = 1;
                progressBarCountdown.Value = 1;

                if (Visible == false)
                {
                    Visible = true;
                }
            }
            else
            {
                if (progressBarCountdown.Maximum == 1)
                {
                    progressBarCountdown.Maximum = 100;
                    progressBarCountdown.SetState(1);
                    progressBarCountdown.Value = Countdown.GetProgressInPercentage(SegmentNames.Paused);
                }
            }
        }

        // Save lap package used
        private void SaveLapPackageUsed()
        {
            if (radioBtnRecovery.Checked == true) LapPackageNames.Recovery.SaveLastUsedLapPackage();
            else if (radioBtnSmart.Checked == true) LapPackageNames.Smart.SaveLastUsedLapPackage();
            else if (radioBtnProgress.Checked == true) LapPackageNames.Progress.SaveLastUsedLapPackage();
        }

        // Notify icon click
        private void NotifyIconSUIClick(object sender, EventArgs e)
        {
            if (Visible == false)
            {
                Visible = true;
            }
        }

        #endregion
    }
}
