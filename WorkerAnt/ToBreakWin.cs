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
    public partial class ToBreakWin : Form
    {
        #region Fields
        internal int MouseXAxis;
        internal int MouseYAxis;
        internal bool MouseDrag;
        #endregion

        #region Initialization
        public ToBreakWin()
        {
            InitializeComponent();
        }
        private void ToBreakBasicWin_Load(object sender, EventArgs e)
        {
            winRefresh.Start();
        }
        #endregion

        #region FormBorderStyle
        //------------------------------------------------------------------------- win move
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

        //------------------------------------------------------------------------- pic close
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
        #endregion

        #region Methods
        //button No
        private void btnNo_Click(object sender, EventArgs e)
        {
            Close();
        }
        //button Yes
        private void btnYes_Click(object sender, EventArgs e)
        {
            Countdown.SkipToBreak();
            Close();
        }
        // refresh window data (timer)
        private void winRefresh_Tick(object sender, EventArgs e)
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
