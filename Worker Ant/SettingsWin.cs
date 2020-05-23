using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Worker_Ant
{
    public partial class SettingsWin : Form
    {
        #region Fields
        internal int MouseXAxis;
        internal int MouseYAxis;
        internal bool MouseDrag;
        #endregion

        #region Initialization
        public SettingsWin()
        {
            InitializeComponent();
        }
        // sethings win load
        private void SettingsWin_Load(object sender, EventArgs e)
        {
            // loading data for the UI
            numUDWorkRecovery.Value = Properties.Settings.Default.recoveryWorkTime / 60;
            numUDBreakRecovery.Value = Properties.Settings.Default.recoveryBreakTime / 60;
            numUDWorkSmart.Value = Properties.Settings.Default.smartWorkTime / 60;
            numUDBreakSmart.Value = Properties.Settings.Default.smartBreakTime / 60;
            numUDWorkProgress.Value = Properties.Settings.Default.progressWorkTime / 60;
            numUDBreakProgress.Value = Properties.Settings.Default.progressBreakTime / 60;

            checkBoxAudioAlert.Checked = Properties.Settings.Default.audioAlert;
            checkBoxSafetyInfo.Checked = Properties.Settings.Default.saftyInfo;
            checkBoxSimpleView.Checked = Properties.Settings.Default.simpleView;

            // using registry 
            RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            // run once to set Worker Ant to autostart 
            if (Properties.Settings.Default.autoStartRunOnce == false)
            {
                registry.SetValue("Worker Ant", Application.ExecutablePath.ToString());
                Properties.Settings.Default.autoStartRunOnce = true;
                Properties.Settings.Default.Save();
            }
            // loading registry data for auto start
            if (registry.GetValue("Worker Ant") == null)
            { 
                checkBoxAutoStart.Checked = false;
            }
            else
            {
                checkBoxAutoStart.Checked = true;
            }
        }
        #endregion

        #region FormBorderStyle
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
        private void PicBoxClose_Click(object sender, EventArgs e)
        {
            Visible = false;
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

        //------------------------------------------------------------------------- pic info
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
            var winCouter = new WinBehavior();
            winCouter.ChackWins("Info");
        }
        #endregion

        #region Methods
        //------------------------------------------------------------------------- btn
        //default btn
        private void BtnDefault_Click(object sender, EventArgs e)
        {
            var countdown = new Countdown();
            countdown.CountdownInputControl("Default");
            SettingsWin_Load(null, null);
            checkBoxAutoStart.Checked = true;
        }
        //save btn
        private void BtnSave_Click(object sender, EventArgs e)
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

                Properties.Settings.Default.audioAlert = checkBoxAudioAlert.Checked;
                Properties.Settings.Default.saftyInfo = checkBoxSafetyInfo.Checked;

                if (Properties.Settings.Default.simpleView != checkBoxSimpleView.Checked)
                {
                    Properties.Settings.Default.simpleView = checkBoxSimpleView.Checked;
                    var errorHandler1 = new ErrorHandlerWin();
                    errorHandler1.ErrorHandeler("Relunch the page to see the change", "SW", "03", false);
                    errorHandler1.Show();
                    //notify balloon can be used
                }
                // save autostart in registry 

                RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                if (checkBoxAutoStart.Checked == true && registry.GetValue("Worker Ant") == null)
                {
                    registry.SetValue("Worker Ant", Application.ExecutablePath.ToString());
                }
                else if (checkBoxAutoStart.Checked == false && registry.GetValue("Worker Ant") != null)
                {
                    registry.DeleteValue("Worker Ant");
                }

                Properties.Settings.Default.Save();
                var errorHandler = new ErrorHandlerWin();
                errorHandler.ErrorHandeler("Sattings has been saved!", "SW", "02", false);
                errorHandler.Show();

                Close();
            }
            catch
            {
                var errorHandler = new ErrorHandlerWin();
                errorHandler.ErrorHandeler("Could not save the new settings", "SW", "01", true);
                errorHandler.ShowDialog();
            }
        }
        #endregion
    }
}
