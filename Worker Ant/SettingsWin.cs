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
        // Settings window load
        private void SettingsWin_Load(object sender, EventArgs e)
        {
            // load lap packages
            ((numUDWorkRecovery.Value, numUDBreakRecovery.Value),( numUDWorkSmart.Value, numUDBreakSmart.Value),( numUDWorkProgress.Value,
                numUDBreakProgress.Value), numUDRound.Value) = GetSetSettingsData.GetSattingsLapPackages();
            
            // load user preferred
            (checkBoxAudioAlert.Checked, checkBoxSimpleView.Checked, checkBoxAutoStart.Checked) = GetSetSettingsData.GetSettingsUserPreferences();
        }
        #endregion

        #region FormBorderStyle
        //------------------------------------------------------------------------- Win move
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
        #endregion

        #region Methods
        //------------------------------------------------------------------------- Button
        // Default Button
        private void BtnDefault_Click(object sender, EventArgs e)
        {

            GetSetSettingsData.SetSettingsToDefault();
            SettingsWin_Load(null, null);
            checkBoxAutoStart.Checked = true;
        }
        // Save Button
        private void BtnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            GetSetSettingsData.SaveSettings(numUDWorkRecovery.Value, numUDBreakRecovery.Value, numUDWorkSmart.Value, numUDBreakSmart.Value,
                numUDWorkProgress.Value, numUDBreakProgress.Value, numUDRound.Value, checkBoxAudioAlert.Checked, checkBoxSimpleView.Checked, checkBoxAutoStart.Checked), "Settings", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
        #endregion
    }
}
