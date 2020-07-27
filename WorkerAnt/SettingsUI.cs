using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkerAnt
{
    public partial class SettingsUI : Form
    {
        #region Fields
        // For moving the form
        private int _mouseXAxis;
        private int _mouseYAxis;
        private bool _mouseDrag;
        #endregion

        #region Initialization
        public SettingsUI()
        {
            InitializeComponent();
        }
        // Settings window load
        private void SettingsUILoad(object sender, EventArgs e)
        {
            // load lap packages
            ((numUDWorkRecovery.Value, numUDBreakRecovery.Value),( numUDWorkSmart.Value, numUDBreakSmart.Value),( numUDWorkProgress.Value,
                numUDBreakProgress.Value), numUDRound.Value) = GetSetSettingsData.GetSattingsLapPackages();
            
            // load user preferred
            (checkBoxAudioAlert.Checked, checkBoxSimpleView.Checked, checkBoxAutoStart.Checked) = GetSetSettingsData.GetSettingsUserPreferences();
        }
        #endregion

        #region Form Border Style

        #region ------------------------------------------------------------------------- Move Window
        // Window mouse down
        private void WindowMouseDown(object sender, MouseEventArgs e)
        {
            _mouseDrag = true;
            _mouseXAxis = Cursor.Position.X - this.Left;
            _mouseYAxis = Cursor.Position.Y - this.Top;
        }
        // Window mouse move
        private void WindowMouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDrag)
            {
                this.Left = Cursor.Position.X - _mouseXAxis;
                this.Top = Cursor.Position.Y - _mouseYAxis;
            }
        }
        // Window mouse up
        private void WindowMouseUp(object sender, MouseEventArgs e)
        {
            _mouseDrag = false;
        }
        #endregion

        #region ------------------------------------------------------------------------- Picture box close
        // Close Window
        private void CloseWindow(object sender, EventArgs e)
        {
            Close();
        }
        // Close mouse leave 
        private void ClosePicBoxMouseLeave(object sender, EventArgs e)
        {
            picBoxClose.BackColor = SystemColors.Control;
        }
        // Close mouse enter
        private void ClosePicBoxMouseEnter(object sender, EventArgs e)
        {
            picBoxClose.BackColor = SystemColors.ControlDark;
        }

        #endregion

        #region ------------------------------------------------------------------------- About picture box
        // About enter
        private void AboutPicBoxMouseEnter(object sender, EventArgs e)
        {
            picBoxInfo.Image = WorkerAnt.Properties.Resources.Info;
        }
        // About leave
        private void AboutPicBoxMouseLeave(object sender, EventArgs e)
        {
            picBoxInfo.Image = WorkerAnt.Properties.Resources.Info_L;
        }
        // About click
        private void OpenAbout(object sender, EventArgs e)
        {
            var winCouter = new WindowBehavior();
            try
            {
                winCouter.WindowsOpenCheck(WindowNames.Info);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "WorkerAnt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #endregion

        #region Methods
        //------------------------------------------------------------------------- Button
        // Default Button
        private void DefaultBtn(object sender, EventArgs e)
        {
            GetSetSettingsData.SetSettingsToDefault();
            SettingsUILoad(null, null);
            checkBoxAutoStart.Checked = true;
        }
        // Save Button
        private void SaveBtn(object sender, EventArgs e)
        {
            MessageBox.Show(
            GetSetSettingsData.SaveSettings(numUDWorkRecovery.Value, numUDBreakRecovery.Value, numUDWorkSmart.Value, numUDBreakSmart.Value,
                numUDWorkProgress.Value, numUDBreakProgress.Value, numUDRound.Value, checkBoxAudioAlert.Checked, checkBoxSimpleView.Checked, checkBoxAutoStart.Checked), "Worker Ant Settings", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
        #endregion
    }
}
