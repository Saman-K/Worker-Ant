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
    public partial class DueBreakUI : Form
    {
        #region Fields
        private int _mouseXAxis;
        private int _mouseYAxis;
        private bool _mouseDrag;
        #endregion

        #region Initialization
        public DueBreakUI()
        {
            InitializeComponent();
        }
        private void DueBreakUILoad(object sender, EventArgs e)
        {
            winRefresh.Start();
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
        #endregion

        #region Methods
        // No button
        private void NoBtn(object sender, EventArgs e)
        {
            Close();
        }
        // Yes button
        private void YesBtn(object sender, EventArgs e)
        {
            Countdown.SkipToBreak();
            Close();
        }
        // refresh window data (timer)
        private void LiveDataUpdate(object sender, EventArgs e)
        {
            if (Countdown.TimerTick == true && Countdown.TimeTickSegment == SegmentNames.Work)
            {
                labelLiveWorkTime.Text = Countdown.WorkTimerLive.IntToTimerFormat();
                if (Countdown.WorkTimerLive <= 295)
                {
                    this.Close();
                }
            }
            else
            {
                Close();
            }
        }
        #endregion
    }
}
