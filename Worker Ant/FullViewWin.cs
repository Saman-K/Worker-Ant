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
        int mouseXAxis;
        int mouseYAxis;
        bool mouseDrag;

        public FullViewWin()
        {
            InitializeComponent();
        }
        //-------------------------------------------------------------------------win move
        //form mouse down
        private void Win_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDrag = true;
            mouseXAxis = Cursor.Position.X - this.Left;
            mouseYAxis = Cursor.Position.Y - this.Top;
        }
        //form mouse move
        private void Win_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDrag)
            {
                this.Left = Cursor.Position.X - mouseXAxis;
                this.Top = Cursor.Position.Y - mouseYAxis;
            }
        }
        //form mouse up
        private void Win_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDrag = false;
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
            winCouter.winName = "InfoWin";
            winCouter.ChackWins();
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
            winCouter.winName = "SettingsWin";
            winCouter.ChackWins();
        }
        //-------------------------------------------------------------------------button click
        //button set/reset click
        private void btnSetReset_Click(object sender, EventArgs e)
        {
            var countDown = new CountDown();
            //btnSetReset.Text = "Reset";
            ////add a void in countdoun class to grabe the data from the preset and send it to the timer

            //labelRoundNumCountdown.Text = Properties.Settings.Default.roundCountdown.ToString();
            
            if (radioBtnManual.Checked == true)
            {
                countDown.SavePresetTimeToSettings("set");
            }

            countDown.InsertSettingsData("FullViweWin");
        }
    }
}
