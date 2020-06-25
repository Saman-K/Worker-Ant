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
    public partial class BreakWin : Form
    {
        #region Fields
        internal static int MouseXAxis;
        internal static int MouseYAxis;
        internal static bool MouseDrag;
        #endregion

        #region Initialization
        public BreakWin()
        {
            InitializeComponent();
        }
        // win load
        private void BreakBasicWin_Load(object sender, EventArgs e)
        {
            winRefresh.Start();
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
            if (Countdown.TimeTickSegment == SegmentNames.EndBreak)
            {
                Countdown.EndLapPackage();
                Close();
            }
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
        // refresh window data (timer)
        private void winRefresh_Tick(object sender, EventArgs e)
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
        // okey btn
        private void btnYesOkay_Click(object sender, EventArgs e)
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
        // no btn
        private void btnNo_Click(object sender, EventArgs e)
        {
            Countdown.PauseBetweenLap();
            Close();
        }
        #endregion
    }
}
