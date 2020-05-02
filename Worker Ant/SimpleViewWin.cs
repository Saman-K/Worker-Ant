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
        internal (int, int, int) TimeData;
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
                btnStartStop.Text = "Stop";
                GetTimeData();


            }
            else if (btnStartStop.Text == "Stop")
            {
                btnStartStop.Text = "Start";
            }
        }
        //------------------------------------------------------------------------- get data
        // get time data frome settings
        private void GetTimeData()
        {
            var countdown = new Countdown();
            if (radioBtnRecovery.Checked == true)
            {
                TimeData = countdown.GetTimerDataForUI("Recovery");
            }
            else if (radioBtnSmart.Checked == true)
            {
                TimeData = countdown.GetTimerDataForUI("Smart");
            }
            else if (radioBtnProgress.Checked == true)
            {
                TimeData = countdown.GetTimerDataForUI("Progress");
            }
            labelWorkTimeCountdown.Text = TimeData.Item1.ToString() + " Mins";
            labelBreakTimeCountdown.Text = TimeData.Item2.ToString() + " Mins";
            labelRoundNumCountdown.Text = TimeData.Item3.ToString();
        }
    }
}
