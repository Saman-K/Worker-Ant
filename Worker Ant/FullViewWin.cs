﻿using System;
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
    public partial class FullViewWin : Form
    {
        internal int MouseXAxis;
        internal int MouseYAxis;
        internal bool MouseDrag;
        internal (int, int, int) TimeDataWBR;
        public FullViewWin()
        {
            InitializeComponent();
        }

        private void FullViewWin_Load(object sender, EventArgs e)
        {
            numUDWorkManual.Value = Properties.Settings.Default.manualWorkTime / 60;
            numUDBreakManual.Value = Properties.Settings.Default.manualBreakTime / 60;
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
        private void PicBoxSettings_MouseEnter(object sender, EventArgs e)
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
        //button set/reset click
        private void btnSetReset_Click(object sender, EventArgs e)
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

            Countdown.SavedCountdownValuesWBR = TimeDataWBR;
            var countdown = new Countdown();
            btnSetReset.Text = countdown.CountdownInputControl(btnSetReset.Text);
        }
        //start button clicked
        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (btnStartStop.Text == "Start")
            {
                btnSetReset.Enabled = false;

                if (labelWorkTimeCountdown.Text == "Work Time" || labelBreakCountdown.Text == "Break Time")
                {
                    btnSetReset_Click(null, null);
                    liveRefresh_Tick(null, null);
                }
                liveRefresh.Start();
            }
            else if (btnStartStop.Text == "Stop")
            {
                btnSetReset.Enabled = true;
                liveRefresh.Stop();
            }
            var countdown = new Countdown();
            btnStartStop.Text = countdown.CountdownInputControl(btnStartStop.Text);
        }
        //------------------------------------------------------------------------- radio button
        private void radioBtnChineged_CheckedChanged(object sender, EventArgs e)
        {
            GetTimeData();

            labelWorkTimePreview.Text = (TimeDataWBR.Item1 / 60 + ":" + (TimeDataWBR.Item1 % 60).ToString("D2"));
            labelBreakTimePreview.Text = (TimeDataWBR.Item2 / 60 + ":" + (TimeDataWBR.Item2 % 60).ToString("D2"));
            labelRoundNumPreview.Text = TimeDataWBR.Item3.ToString() ;
        }
        //------------------------------------------------------------------------- number up down menual 
        private void numUDManual_ValueChanged(object sender, EventArgs e)
        {
            if (radioBtnManual.Checked == true)
            {
                Properties.Settings.Default.manualWorkTime = numUDWorkManual.Value * 60;
                Properties.Settings.Default.manualBreakTime = numUDBreakManual.Value * 60;
                radioBtnChineged_CheckedChanged(null, null);
            }
        }
        //------------------------------------------------------------------------- get data
        private void GetTimeData()
        {
            var countdown = new Countdown();
            if (radioBtnManual.Checked == false)
            {
                groupBoxManual.Enabled = false;
            }

            if (radioBtnManual.Checked == true)
            {
                TimeDataWBR = countdown.GetTimerDataForUI("Manual");
                groupBoxManual.Enabled = true;
            }
            else if (radioBtnRecovery.Checked == true)
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
                errorHandler.ErrorHandeler("", "FVW", "01", true); 

                MessageBox.Show("Radio Button not found");
            }
            
        }
        //------------------------------------------------------------------------- timer
        private void liveRefresh_Tick(object sender, EventArgs e)
        {
            labelWorkTimeCountdown.Text = (Countdown.WorkValueLive / 60 + ":" + (Countdown.WorkValueLive % 60).ToString("D2"));
            labelBreakTimeCountdown.Text = (Countdown.BreakValueLive / 60 + ":" + (Countdown.BreakValueLive % 60).ToString("D2"));
            labelRoundNumCountdown.Text = Countdown.RoundValueLive.ToString();
        }
    }
}
