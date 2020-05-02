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
    public partial class SettingsWin : Form
    {
        internal int MouseXAxis;
        internal int MouseYAxis;
        internal bool MouseDrag;

        public SettingsWin()
        {
            InitializeComponent();
        }
        //-------------------------------------------------------------------------win move
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
        //-------------------------------------------------------------------------pic close
        //click
        private void picBoxClose_Click(object sender, EventArgs e)
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
        //------------------------------------------------------------------------- pic info
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
        //------------------------------------------------------------------------- btn
        //default btn
        private void btnDefault_Click(object sender, EventArgs e)
        {
            var countdown = new Countdown();
            countdown.SetSettingsToDefault();
            SettingsWin_Load(null, null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                Properties.Settings.Default.recoveryWorkTime = numUDWorkRecovery.Value * 60;
                Properties.Settings.Default.recoveryBreakTime = numUDBreakRecovery.Value * 60;
                Properties.Settings.Default.smartWorkTime = numUDWorkSmart.Value * 60;
                Properties.Settings.Default.smartBreakTime = numUDBreakSmart.Value * 60;
                Properties.Settings.Default.progressWorkTime = numUDWorkProgress.Value * 60;
                Properties.Settings.Default.progressBreakTime = numUDBreakProgress.Value * 60;
                Properties.Settings.Default.roundCountdown = numUDRound.Value;

                if (checkBoxSimpleView.Checked != Properties.Settings.Default.simpleView)
                {
                    //MessageBox.Show("kuhf");
                    //var winBehavior = new WinBehavior();
                    //switch (checkBoxSimpleView.Checked)
                    //{
                    //    case true:
                    //        winBehavior.ChackWins("SimpleView");
                    //        break;
                    //    case false:
                    //        winBehavior.ChackWins("FullView");
                    //        break;
                    //}
                }

                Properties.Settings.Default.audioAlert = checkBoxAudioAlert.Checked;
                Properties.Settings.Default.saftyInfo = checkBoxSafetyInfo.Checked;
                Properties.Settings.Default.simpleView = checkBoxSimpleView.Checked;


                Properties.Settings.Default.Save();
                
                MessageBox.Show("Settings saved.");

                Close();
                
            }
            catch
            {
                var errorHandler = new ErrorHandlerWin();
                errorHandler.ErrorHandeler("Could not save the new settings", "SW", "01", false);
                errorHandler.Show();
            }


        }

        private void SettingsWin_Load(object sender, EventArgs e)
        {
            numUDWorkRecovery.Value = Properties.Settings.Default.recoveryWorkTime / 60;
            numUDBreakRecovery.Value = Properties.Settings.Default.recoveryBreakTime / 60;
            numUDWorkSmart.Value = Properties.Settings.Default.smartWorkTime / 60;
            numUDBreakSmart.Value = Properties.Settings.Default.smartBreakTime / 60;
            numUDWorkProgress.Value = Properties.Settings.Default.progressWorkTime / 60;
            numUDBreakProgress.Value = Properties.Settings.Default.progressBreakTime / 60;

            checkBoxAudioAlert.Checked = Properties.Settings.Default.audioAlert;
            checkBoxSafetyInfo.Checked = Properties.Settings.Default.saftyInfo;
            checkBoxSimpleView.Checked = Properties.Settings.Default.simpleView;
        }
    }
}
