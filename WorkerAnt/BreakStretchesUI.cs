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
    public partial class BreakStretchesUI : Form
    {
        #region Fields
        private int _mouseXAxis;
        private int _mouseYAxis;
        private bool _mouseDrag;
        #endregion

        #region Initialization
        public BreakStretchesUI()
        {
            InitializeComponent();
        }
        // win load
        private void BreakInfoUILoad(object sender, EventArgs e)
        {
            liveDataUpdate.Start();
            if (Countdown.LapCounterLive > 0)
            {
                btnYesOkay.Text = "Yes";
            }
            else if (Countdown.LapCounterLive <= 0)
            {
                btnYesOkay.Text = "Okay";
                btnNo.Visible = false;
                btnNo.Enabled = false;
            }
        }
        #endregion

        #region FormBorderStyle

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
            if (Countdown.TimeTickSegment == SegmentNames.EndBreak)
            {
                Countdown.EndLapPackage();
                Close();
            }
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
        #endregion

        #region Methods
        // Live data Updater (timer)
        private void LiveDataUpdate(object sender, EventArgs e)
        {
            if (Countdown.TimerTick == true)
            {
                labelLiveBreakTime.Text = Countdown.BreakTimerLive.IntToTimerFormat();
                if (Countdown.TimeTickSegment == SegmentNames.Break)
                {
                    btnYesOkay.Enabled = false;
                    btnNo.Enabled = false;
                    labelAnotherRound.Visible = false;
                }
                else if (Countdown.TimeTickSegment == SegmentNames.EndBreak)
                {
                    if (Countdown.BreakTimerLive == 0)
                    {
                        labelLiveBreakTime.ForeColor = Color.Red;
                        labelTheBreakWEI.Text = "Break has ended";
                        labelTheBreakWEI.ForeColor = Color.Red;
                        btnYesOkay.Enabled = true;
                        if (Countdown.LapCounterLive > 0)
                        {
                            btnNo.Enabled = true;
                            labelAnotherRound.Visible = true;
                        }
                    }
                }
                else
                {
                    Close();
                }
            }
            else
            {
                Close();
            }
        }
        // yes and okay button
        private void YesOkayBtn(object sender, EventArgs e)
        {
            if (btnYesOkay.Text == "Yes")
            {
                Countdown.StartLap();
            }
            else if (btnYesOkay.Text == "Okay")
            {
                Countdown.EndLapPackage();
            }
            Close();
        }
        // No button
        private void NoBtn(object sender, EventArgs e)
        {
            Countdown.PauseBetweenLap();
            Close();
        }
        #endregion
    }
}
