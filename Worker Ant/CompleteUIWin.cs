using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Worker_Ant
{
    public partial class CompleteUIWin : Form
    {
        #region Fields
        internal int MouseXAxis;
        internal int MouseYAxis;
        internal bool MouseDrag;
        internal (int, int, int) TimeDataWBR;
        #endregion

        #region Initialization
        public CompleteUIWin()
        {
            InitializeComponent();
        }
        private void FullViewWin_Load(object sender, EventArgs e)
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
                var errorHandler = new ErrorHandlerWin();
                errorHandler.ErrorHandeler("Radio Button not found", "FVW", "02", true);
                errorHandler.ShowDialog();
            }

        }
        #endregion

        #region FormBorderStyle
        //------------------------------------------------------------------------- win move
        //form mouse down
        private void Win_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDrag = true;
            MouseXAxis = Cursor.Position.X - this.Left;
            MouseYAxis = Cursor.Position.Y - this.Top;
        }
        //form mouse move
        private void Win_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseDrag)
            {
                this.Left = Cursor.Position.X - MouseXAxis;
                this.Top = Cursor.Position.Y - MouseYAxis;
            }
        }
        //form mouse up
        private void Win_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDrag = false;
        }

        //------------------------------------------------------------------------- Picture box close
        //click
        private void PicBoxClose_Click(object sender, EventArgs e)
        {
            Visible = false;
            //Notify("Worker Ant", "Worker Ant is Minimized");
        }
        //double click
        private void PicBoxClose_DoubleClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //mouse leave
        private void PicBoxClose_MouseLeave(object sender, EventArgs e)
        {
            picBoxClose.BackColor = SystemColors.Control;
        }
        //mouse enter
        private void PicBoxClose_MouseEnter(object sender, EventArgs e)
        {
            picBoxClose.BackColor = SystemColors.ControlDark;
        }

        //------------------------------------------------------------------------- Picture box info
        //info enter
        private void PicBoxInfo_MouseEnter(object sender, EventArgs e)
        {
            picBoxInfo.Image = Worker_Ant.Properties.Resources.Info;
        }
        //info leave
        private void PicBoxInfo_MouseLeave(object sender, EventArgs e)
        {
            picBoxInfo.Image = Worker_Ant.Properties.Resources.Info_L;
        }
        //info click
        private void PicBoxInfo_Click(object sender, EventArgs e)
        {
            var winCouter = new WindowBehavior();
            winCouter.WindowsOpenCheck(WindowNames.Info);
        }
        //------------------------------------------------------------------------- Picture box settings
        //settings enter
        private void PicBoxSettings_MouseEnter(object sender, EventArgs e)
        {
            picBoxSettings.Image = Worker_Ant.Properties.Resources.Settings;
        }
        //settings leave
        private void PicBoxSettings_MouseLeave(object sender, EventArgs e)
        {
            picBoxSettings.Image = Worker_Ant.Properties.Resources.Settings_L;
        }
        //settings click
        private void PicBoxSettings_Click(object sender, EventArgs e)
        {
            var winCouter = new WindowBehavior();
            winCouter.WindowsOpenCheck(WindowNames.Settings);
        }
        #endregion

        #region Methods
        // button set/reset click
        private void BtnSetReset_Click(object sender, EventArgs e)
        {
            if (radioBtnManual.Checked == true)
            {
                Properties.Settings.Default.manualWorkTime = numUDWorkManual.Value * 60;
                Properties.Settings.Default.manualBreakTime = numUDBreakManual.Value * 60;
                Properties.Settings.Default.Save();
            }

            GetTimeData();

            labelWorkTimeCountdown.Text = (TimeDataWBR.Item1 / 60 + ":" + (TimeDataWBR.Item1 % 60).ToString("D2"));
            labelBreakTimeCountdown.Text = (TimeDataWBR.Item2 / 60 + ":" + (TimeDataWBR.Item2 % 60).ToString("D2"));
            labelRoundNumCountdown.Text = TimeDataWBR.Item3.ToString();

            progressBarCountdown.Maximum = 1;
            progressBarCountdown.Value = 0;

            Countdown.LastUserInput = TimeDataWBR;
            btnSetReset.Text = "Reset";
            Countdown.Set();

            SaveLastUsedRadioBtn();
        }
        // Start/Stop button clicked
        private void BtnStartStop_Click(object sender, EventArgs e)
        {
            if (btnStartStop.Text == "Start")
            {
                if (labelWorkTimeCountdown.Text == "Work Time" || labelBreakCountdown.Text == "Break Time")
                {
                    BtnSetReset_Click(null, null);
                }
                winRefresh.Start();
            }
            else if (btnStartStop.Text == "Stop" && Countdown.TimeTickSegment == SegmentNames.Break)
            {
                //winRefresh.Stop();
            }
            btnStartStop.Text = btnStartStop.Text.StartStop();

        }
        // radio button changed
        private void RadioBtnChineged_CheckedChanged(object sender, EventArgs e)
        {
            GetTimeData();

            labelWorkTimePreview.Text = (TimeDataWBR.Item1 / 60 + ":" + (TimeDataWBR.Item1 % 60).ToString("D2"));
            labelBreakTimePreview.Text = (TimeDataWBR.Item2 / 60 + ":" + (TimeDataWBR.Item2 % 60).ToString("D2"));
            labelRoundNumPreview.Text = TimeDataWBR.Item3.ToString() ;
        }
        // number up down manual 
        private void NumUDManual_ValueChanged(object sender, EventArgs e)
        {
            if (radioBtnManual.Checked == true)
            {
                Properties.Settings.Default.manualWorkTime = numUDWorkManual.Value * 60;
                Properties.Settings.Default.manualBreakTime = numUDBreakManual.Value * 60;
                RadioBtnChineged_CheckedChanged(null, null);
            }
        }
        // refresh window data (timer)
        private void WinRefresh_Tick(object sender, EventArgs e)
        {
            labelWorkTimeCountdown.Text = Countdown.WorkTimerFormatedLive;

            if (Countdown.TimeTickSegment == SegmentNames.EndBreak)
            {
                labelBreakTimeCountdown.Text = Countdown.BreakTimerFormattedLive;
                labelBreakTimeCountdown.ForeColor = Color.Red;
            }
            else
            {
                labelBreakTimeCountdown.Text = Countdown.BreakTimerFormattedLive;
                labelBreakTimeCountdown.ForeColor = SystemColors.ControlText;
            }

            labelRoundNumCountdown.Text = Countdown.LapCounterLive.ToString();

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
        // get data
        private void GetTimeData()
        {
            if (radioBtnManual.Checked == false)
            {
                groupBoxManual.Enabled = false;
            }

            if (radioBtnManual.Checked == true)
            {
                TimeDataWBR = LapPackageNames.Manual.GetLapPackageValue();
                groupBoxManual.Enabled = true;
            }
            else if (radioBtnRecovery.Checked == true)
            {
                TimeDataWBR = LapPackageNames.Recovery.GetLapPackageValue();
            }
            else if (radioBtnSmart.Checked == true)
            {
                TimeDataWBR = LapPackageNames.Smart.GetLapPackageValue();
            }
            else if (radioBtnProgress.Checked == true)
            {
                TimeDataWBR = LapPackageNames.Progress.GetLapPackageValue();
            }
            else
            {
                var errorHandler = new ErrorHandlerWin();
                errorHandler.ErrorHandeler("Radio Button not found", "FVW", "01", true);
                errorHandler.ShowDialog();
                Application.Exit();
            }
            
        }
        // save RadioBtn 
        private void SaveLastUsedRadioBtn()
        {
            if (radioBtnManual.Checked == true) LapPackageNames.Manual.SaveLastUsedLapPackage();
            else if (radioBtnRecovery.Checked == true) LapPackageNames.Recovery.SaveLastUsedLapPackage();
            else if (radioBtnSmart.Checked == true) LapPackageNames.Smart.SaveLastUsedLapPackage();
            else if (radioBtnProgress.Checked == true) LapPackageNames.Progress.SaveLastUsedLapPackage();
        }
        //  icon double click
        private void NotifyIconFVW_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Visible == false)
            {
                Visible = true;
            }
        }
        // notify Strip Menu open button
        private void NotifyIco(object sender, EventArgs e)
        {
            if (Visible == false)
            {
                Visible = true;
            }
        }
        // notify icon notifying
        public void Notify(string titel, string message)
        {
            //notifyIconFVW.BalloonTipIcon = ToolTipIcon.Info;
            notifyIconFVW.BalloonTipTitle = titel;
            notifyIconFVW.BalloonTipText = message;
            notifyIconFVW.ShowBalloonTip(1000);
        }
        #endregion
    }
}
