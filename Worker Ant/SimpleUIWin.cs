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
    public partial class SimpleUIWin : Form
    {
        #region Fields
        // for Moving the form
        internal int MouseXAxis;
        internal int MouseYAxis;
        internal bool MouseDrag;
        // saving data for previwe
        internal (int, int, int) TimeDataWBR;
        #endregion

        #region Initialization
        // Initialization
        public SimpleUIWin()
        {
            InitializeComponent();
        }
        // form Opens
        private void SimpleViewWin_Load(object sender, EventArgs e)
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
                var errorHandler = new ErrorHandlerWin();
                errorHandler.ErrorHandeler("Radio Button not found", "SVW", "02", true);
                errorHandler.ShowDialog();
            }
        }
        #endregion

        #region FormBorderStyle
        //------------------------------------------------------------------------- Win Move
        // form Mouse down
        private void Win_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDrag = true;
            MouseXAxis = Cursor.Position.X - this.Left;
            MouseYAxis = Cursor.Position.Y - this.Top;
        }
        // form mouse move
        private void Win_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseDrag)
            {
                this.Left = Cursor.Position.X - MouseXAxis;
                this.Top = Cursor.Position.Y - MouseYAxis;
            }
        }
        // form mouse up
        private void Win_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDrag = false;
        }

        //------------------------------------------------------------------------- pic close
        // click
        private void PicBoxClose_Click(object sender, EventArgs e)
        {
            Visible = false;
            //Notify("Worker Ant", "Worker Ant is Minimized");
        }
        // double click
        private void PicBoxClose_DoubleClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // mouse leave
        private void PicBoxClose_MouseLeave(object sender, EventArgs e)
        {
            picBoxClose.BackColor = SystemColors.Control;
        }
        // mouse enter
        private void PicBoxClose_MouseEnter(object sender, EventArgs e)
        {
            picBoxClose.BackColor = SystemColors.ControlDark;
        }
        //------------------------------------------------------------------------- pic change info
        // info enter
        private void PicBoxInfo_MouseEnter(object sender, EventArgs e)
        {
            picBoxInfo.Image = Worker_Ant.Properties.Resources.Info;
        }
        // info leave
        private void PicBoxInfo_MouseLeave(object sender, EventArgs e)
        {
            picBoxInfo.Image = Worker_Ant.Properties.Resources.Info_L;
        }
        // info click
        private void PicBoxInfo_Click(object sender, EventArgs e)
        {
            var winCouter = new WindowBehavior();
            winCouter.WindowsOpenCheck(WindowNames.Info);
        }
        //------------------------------------------------------------------------- pic change settings
        // settings enter
        private void PicBoxSettings_MouseEnter(object sender, EventArgs e)
        {
            picBoxSettings.Image = Worker_Ant.Properties.Resources.Settings;
        }
        // settings leave
        private void PicBoxSettings_MouseLeave(object sender, EventArgs e)
        {
            picBoxSettings.Image = Worker_Ant.Properties.Resources.Settings_L;
        }
        // settings click
        private void PicBoxSettings_Click(object sender, EventArgs e)
        {
            var winCouter = new WindowBehavior();
            winCouter.WindowsOpenCheck(WindowNames.Settings);
        }
        #endregion

        #region Methods
        // Start/Stop button clicked
        private void BtnStartStop_Click(object sender, EventArgs e)
        {
            if (btnStartStop.Text == "Start")
            {
                winRefresh.Start();
            }
            else if (btnStartStop.Text == "Stop" && Countdown.TimeTickSegment == SegmentNames.Break)
            {
                winRefresh.Stop();
            }
            btnStartStop.Text = btnStartStop.Text.StartStop();

        }
        // radio button Change
        private void RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnRecovery.Checked == true)
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
                errorHandler.ErrorHandeler("Radio Button not found", "SVW", "01", true);
                errorHandler.ShowDialog();
            }

            labelWorkTimeCountdown.Text = (TimeDataWBR.Item1 / 60 + ":" + (TimeDataWBR.Item1 % 60).ToString("D2"));
            labelBreakTimeCountdown.Text = (TimeDataWBR.Item2 / 60 + ":" + (TimeDataWBR.Item2 % 60).ToString("D2"));
            labelRoundNumCountdown.Text = TimeDataWBR.Item3.ToString();

            progressBarCountdown.Maximum = 1;
            progressBarCountdown.Value = 0;

            Countdown.LastUserInput = TimeDataWBR;

            Countdown.Set();
        }
        // radio button Enable
        private void RadioBtnEnabel(bool trueFalse)
        {
            radioBtnRecovery.Enabled = trueFalse;
            radioBtnSmart.Enabled = trueFalse;
            radioBtnProgress.Enabled = trueFalse;
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
        private void NotifyIconSVW_Click(object sender, EventArgs e)
        {
            if (Visible == false)
            {
                Visible = true;
            }
        }
        // notify icon notifing
        public void Notify(string titel, string message)
        {
            //notifyIconSVW.BalloonTipIcon = ToolTipIcon.Info;
            notifyIconSVW.BalloonTipTitle = titel;
            notifyIconSVW.BalloonTipText = message;
            notifyIconSVW.ShowBalloonTip(1000);
        }
        #endregion
    }
}
