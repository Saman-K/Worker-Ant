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
    public partial class SimpleViewWin : Form
    {
        internal int MouseXAxis;
        internal int MouseYAxis;
        internal bool MouseDrag;
        internal (int, int, int) TimeDataWBR;
        public SimpleViewWin()
        {
            InitializeComponent();
        }
        //-------------------------------------------------------------------------win move
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
        //-------------------------------------------------------------------------pic close
        //click
        private void picBoxClose_Click(object sender, EventArgs e)
        {
        }
        //double click
        private void picBoxClose_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
        //mouse leave
        private void picBoxClose_MouseLeave(object sender, EventArgs e)
        {
            picBoxClose.BackColor = SystemColors.Control;
        }
        //mouse enter
        private void picBoxClose_MouseEnter(object sender, EventArgs e)
        {
            picBoxClose.BackColor = SystemColors.ControlDark;
        }
        //------------------------------------------------------------------------- pic change info
        //info enter
        private void picBoxInfo_MouseEnter(object sender, EventArgs e)
        {
            picBoxInfo.Image = Worker_Ant.Properties.Resources.Info;
        }
        //info leave
        private void picBoxInfo_MouseLeave(object sender, EventArgs e)
        {
            picBoxInfo.Image = Worker_Ant.Properties.Resources.Info_L;
        }
        //info click
        private void picBoxInfo_Click(object sender, EventArgs e)
        {
            var winCouter = new WinBehavior();
            winCouter.ChackWins("Info");
        }
        //------------------------------------------------------------------------- pic change settings
        //settings enter
        private void picBoxSettings_MouseEnter(object sender, EventArgs e)
        {
            picBoxSettings.Image = Worker_Ant.Properties.Resources.Settings;
        }
        //settings leave
        private void picBoxSettings_MouseLeave(object sender, EventArgs e)
        {
            picBoxSettings.Image = Worker_Ant.Properties.Resources.Settings_L;
        }
        //settings click
        private void picBoxSettings_Click(object sender, EventArgs e)
        {
            var winCouter = new WinBehavior();
            winCouter.ChackWins("Settings");
        }
        //-------------------------------------------------------------------------


        //------------------------------------------------------------------------- button click
        //start button clicked
        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (btnStartStop.Text == "Start")
            {
                RadioBtnEnabel(false);

                if (labelWorkTimeCountdown.Text == "Work Time" || labelBreakCountdown.Text == "Break Time")
                {
                    GetTimeData();
                }
                winRefresh.Start();
            }
            else if (btnStartStop.Text == "Stop")
            {
                if (Countdown.TimerRoundName == "Break")
                {
                    RadioBtnEnabel(false);
                }
                else
                {
                    RadioBtnEnabel(true);
                    winRefresh.Stop();
                }
            }
            var countdown = new Countdown();
            btnStartStop.Text = countdown.CountdownInputControl(btnStartStop.Text);
        }
        //------------------------------------------------------------------------- get data
        // get time data frome settings
        private void GetTimeData()
        {
            var countdown = new Countdown();
            if (radioBtnRecovery.Checked == true)
            {
                TimeDataWBR = countdown.GetTimerDataForUI("Recovery");
            }
            else if (radioBtnSmart.Checked == true)
            {
                TimeDataWBR = countdown.GetTimerDataForUI("Smart");
            }
            else if (radioBtnProgress.Checked == true)
            {
                TimeDataWBR = countdown.GetTimerDataForUI("Progress");
            }
            else
            {
                var errorHandler = new ErrorHandlerWin();
                errorHandler.ErrorHandeler("Radio Button not found", "SVW", "01", false);
                errorHandler.ShowDialog();
            }

            labelWorkTimeCountdown.Text = (TimeDataWBR.Item1 / 60 + ":" + (TimeDataWBR.Item1 % 60).ToString("D2"));
            labelBreakTimeCountdown.Text = (TimeDataWBR.Item2 / 60 + ":" + (TimeDataWBR.Item2 % 60).ToString("D2"));
            labelRoundNumCountdown.Text = TimeDataWBR.Item3.ToString();
        }

        private void RadioBtnEnabel(bool trueFalse)
        {
            radioBtnRecovery.Enabled = trueFalse;
            radioBtnSmart.Enabled = trueFalse;
            radioBtnProgress.Enabled = trueFalse;
        }

        private void radioBtnChineged_CheckedChanged(object sender, EventArgs e)
        {
            GetTimeData();
        }

        private void winRefresh_Tick(object sender, EventArgs e)
        {
            labelWorkTimeCountdown.Text = (Countdown.WorkValueLive / 60 + ":" + (Countdown.WorkValueLive % 60).ToString("D2"));

            if (Countdown.TimerRoundName == "End Break")
            {
                labelBreakTimeCountdown.Text = ("- " + Countdown.BreakValueLive / 60 + ":" + (Countdown.BreakValueLive % 60).ToString("D2"));
                if (Countdown.BreakValueLive == 0)
                {
                    labelBreakTimeCountdown.ForeColor = Color.Red;
                }
            }
            else
            {
                labelBreakTimeCountdown.Text = (Countdown.BreakValueLive / 60 + ":" + (Countdown.BreakValueLive % 60).ToString("D2"));
                labelBreakTimeCountdown.ForeColor = SystemColors.ControlText;
            }

            labelRoundNumCountdown.Text = Countdown.RoundValueLive.ToString();


            if (Countdown.TimerStatus == "Tick")
            {
                btnStartStop.Text = "Stop";
                RadioBtnEnabel(false);
            }
            else if (Countdown.TimerStatus == "Pause")
            {
                btnStartStop.Text = "Start";
                RadioBtnEnabel(true);
            }
        }
    }
}
