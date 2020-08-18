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
    public partial class CompleteUI : Form
    {
        #region Fields and Properties
        private int _mouseXAxis;
        private int _mouseYAxis;
        private bool _mouseDrag;
        // saving data for preview
        private (int Work, int Break, int Laps) PreviewLapPackage { get; set;}
        #endregion

        #region Initialization
        // Initialization
        public CompleteUI()
        {
            InitializeComponent();
        }
        // Window Opens
        private void CompleteUILoad(object sender, EventArgs e)
        {
            numUDWorkManual.Value = Properties.Settings.Default.manualWorkTime / 60;
            numUDBreakManual.Value = Properties.Settings.Default.manualBreakTime / 60;
            //--  Redo
            //
            if (Properties.Settings.Default.lastUsedLapPackage == (int)LapPackageNames.Manual)
            {
                radioBtnManual.Checked = true;
            }
            else if (Properties.Settings.Default.lastUsedLapPackage == (int)LapPackageNames.Recovery)
            {
                radioBtnRecovery.Checked = true;
            }
            else if (Properties.Settings.Default.lastUsedLapPackage == (int)LapPackageNames.Smart)
            {
                radioBtnSmart.Checked = true;
            }
            else if (Properties.Settings.Default.lastUsedLapPackage == (int)LapPackageNames.Progress)
            {
                radioBtnProgress.Checked = true;
            }
            else
            {
                // error "Radio Button not found!"
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
            try
            {
                winCouter.WindowsOpenCheck(WindowNames.Info);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "WorkerAnt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
            try
            {
                winCouter.WindowsOpenCheck(WindowNames.Settings);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message , "WorkerAnt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        #endregion
        #endregion

        #region Methods

        // Set button click
        private void SetBtn(object sender, EventArgs e)
        {
            if (radioBtnManual.Checked == true)
            {
                Properties.Settings.Default.manualWorkTime = numUDWorkManual.Value * 60;
                Properties.Settings.Default.manualBreakTime = numUDBreakManual.Value * 60;
                Properties.Settings.Default.Save();
            }

            GetLapPackage();

            labelWorkTimeCountdown.Text = PreviewLapPackage.Work.IntToTimerFormat();
            labelBreakTimeCountdown.Text = PreviewLapPackage.Break.IntToTimerFormat();
            labelLapCounterLive.Text = PreviewLapPackage.Laps.ToString();

            progressBarCountdown.Value = Countdown.GetProgressInPercentage(SegmentNames.Paused);

            Countdown.LastUserInput = PreviewLapPackage;
            btnSetReset.Text = "Reset";
            Countdown.Set();

            SaveLapPackageUsed();
        }

        // Start/Stop button click
        private void StartStopBtn(object sender, EventArgs e)
        {
            if (btnStartStop.Text == "Start")
            {
                if (labelWorkTimeCountdown.Text == "Work Time" || labelBreakCountdown.Text == "Break Time")
                {
                    SetBtn(null, null);
                }
                liveDataUpdate.Start();
            }
            else if (btnStartStop.Text == "Stop" && Countdown.TimeTickSegment == SegmentNames.Break)
            {
                liveDataUpdate.Stop();
            }
            try
            {
                btnStartStop.Text = btnStartStop.Text.StartStop();
            }
            catch (TimeoutException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "WorkerAnt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        /// <summary>
        /// Radio button check changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioBtnChineged(object sender, EventArgs e)
        {
            GetLapPackage();

            labelWorkTimePreview.Text = PreviewLapPackage.Work.IntToTimerFormat();
            labelBreakTimePreview.Text = PreviewLapPackage.Break.IntToTimerFormat();
            labelLapCounterPreview.Text = PreviewLapPackage.Laps.ToString() ;
        }

        // Manual number up down changed
        private void NumUDManualValueChanged(object sender, EventArgs e)
        {
            if (radioBtnManual.Checked == true)
            {
                Properties.Settings.Default.manualWorkTime = numUDWorkManual.Value * 60;
                Properties.Settings.Default.manualBreakTime = numUDBreakManual.Value * 60;
                RadioBtnChineged(null, null);
            }
        }
        
        // Live data Updater (timer)
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
                btnSetReset.Enabled = false;
            }
            else if (Countdown.TimerTick == false)
            {
                btnStartStop.Text = "Start";
                btnSetReset.Enabled = true;
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

        // Get radio btn selected lap package
        private void GetLapPackage()
        {
            if (radioBtnManual.Checked == false)
            {
                groupBoxManual.Enabled = false;
            }

            if (radioBtnManual.Checked == true)
            {
                PreviewLapPackage = LapPackageNames.Manual.GetLapPackageValue();
                groupBoxManual.Enabled = true;
            }
            else if (radioBtnRecovery.Checked == true)
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
                // error "Radio Button not found"
                PreviewLapPackage = LapPackageNames.Smart.GetLapPackageValue();
            }
            
        }

        // Save lap package used
        private void SaveLapPackageUsed()
        {
            if (radioBtnManual.Checked == true) LapPackageNames.Manual.SaveLastUsedLapPackage();
            else if (radioBtnRecovery.Checked == true) LapPackageNames.Recovery.SaveLastUsedLapPackage();
            else if (radioBtnSmart.Checked == true) LapPackageNames.Smart.SaveLastUsedLapPackage();
            else if (radioBtnProgress.Checked == true) LapPackageNames.Progress.SaveLastUsedLapPackage();
        }

        //  Notify Icon Double Click
        private void NotifyIconClick(object sender, EventArgs e)
        {
            if (Visible == false)
            {
                Visible = true;
            }
        }
        #endregion
    }
}
