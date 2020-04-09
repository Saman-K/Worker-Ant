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
    public partial class FullViewWin : Form
    {
        internal int _mouseXAxis;
        internal int _mouseYAxis;
        internal bool _mouseDrag;
        internal (int,int,int) _getTimeData;
        public FullViewWin()
        {
            InitializeComponent();
        }
        //-------------------------------------------------------------------------win move
        private void Win_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDrag = true;
            _mouseXAxis = Cursor.Position.X - this.Left;
            _mouseYAxis = Cursor.Position.Y - this.Top;
        }
        //form mouse move
        private void Win_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDrag)
            {
                this.Left = Cursor.Position.X - _mouseXAxis;
                this.Top = Cursor.Position.Y - _mouseYAxis;
            }
        }
        //form mouse up
        private void Win_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDrag = false;
        }
        //-------------------------------------------------------------------------pic close
        //click
        private void picBoxClose_Click(object sender, EventArgs e)
        {
            
        }
        //double click
        private void picBoxClose_MouseDoubleClick(object sender, MouseEventArgs e)
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
            winCouter.ChackWins("InfoWin");
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
            winCouter.ChackWins("SettingsWin");
        }
        //------------------------------------------------------------------------- button click
        //button set/reset click
        private void btnSetReset_Click(object sender, EventArgs e)
        {
            btnSetReset.Text = "Reset";

            getTimeData();

            labelWorkTimeCountdown.Text = _getTimeData.Item1.ToString() + " Mins";
            labelBreakTimeCountdown.Text = _getTimeData.Item2.ToString() + " Mins";
            labelRoundNumCountdown.Text = _getTimeData.Item3.ToString();
        }

        //start button clicked
        private void btnStartStop_Click(object sender, EventArgs e)
        {
            getTimeData();

            if (btnStartStop.Text == "Start")
            {
                btnStartStop.Text = "Stop";
            }
            else if(btnStartStop.Text == "Stop")
            {
                btnStartStop.Text = "Start";
            }
        }
        //------------------------------------------------------------------------- radio button
        // manual
        private void radioBtnChineged_CheckedChanged(object sender, EventArgs e)
        {
            getTimeData();

            labelWorkTimePreview.Text = _getTimeData.Item1.ToString() + " Mins";
            labelBreakTimePreview.Text = _getTimeData.Item2.ToString() + " Mins";
            labelRoundNumPreview.Text = _getTimeData.Item3.ToString() ;

        }
        //------------------------------------------------------------------------- get data
        // get time data frome settings
        private void getTimeData()
        {
            if (radioBtnManual.Checked == false)
            {
                groupBoxManual.Enabled = false;
            }

            if (radioBtnManual.Checked == true)
            {
                _getTimeData = Countdown.InsertDataToPreview("Manual");
                groupBoxManual.Enabled = true;
            }
            else if (radioBtnRecovery.Checked == true)
            {
                _getTimeData = Countdown.InsertDataToPreview("Recovery");
            }
            else if (radioBtnSmart.Checked == true)
            {
                _getTimeData = Countdown.InsertDataToPreview("Smart");
            }
            else if (radioBtnProgress.Checked == true)
            {
                _getTimeData = Countdown.InsertDataToPreview("Progress");
            }
        }
    }
}
