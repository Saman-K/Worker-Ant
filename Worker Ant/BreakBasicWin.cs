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
    public partial class BreakBasicWin : Form
    {
        internal static int MouseXAxis;
        internal static int MouseYAxis;
        internal static bool MouseDrag;

        public BreakBasicWin()
        {
            InitializeComponent();
        }
        //------------------------------------------------------------------------- win load
        private void BreakBasicWin_Load(object sender, EventArgs e)
        {
            winRefresh.Start();
            if (Countdown.RoundValueLive > 0)
            {
                btnYesOkay.Text = "Yes";
            }
            else if (Countdown.RoundValueLive <= 0)
            {
                btnYesOkay.Text = "Okay";
                btnNo.Visible = false;
                btnNo.Enabled = false;
            }
        }
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
            var countdown = new Countdown();
            if (Countdown.TimerRoundName == "End Break")
            {
                countdown.CountdownInputControl("BreakWinOkay");
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
        // window load
        //-------------------------------------------------------------------------

        //------------------------------------------------------------------------- timer
        // refresh window data (timer)
        private void winRefresh_Tick(object sender, EventArgs e)
        {
            if (Countdown.TimerStatus == "Tick" )
            {
                if (Countdown.TimerRoundName == "Break")
                {
                    labelLiveBreakTime.Text = (Countdown.BreakValueLive / 60 + ":" + (Countdown.BreakValueLive % 60).ToString("D2"));
                    btnYesOkay.Enabled = false;
                    btnNo.Enabled = false;
                    labelAnotherRound.Visible = false;
                }
                else if (Countdown.TimerRoundName == "End Break")
                {
                    labelLiveBreakTime.Text = (" - " + Countdown.BreakValueLive / 60 + ":" + (Countdown.BreakValueLive % 60).ToString("D2"));
                    if (Countdown.BreakValueLive == 0)
                    {
                        labelLiveBreakTime.ForeColor = Color.Red;
                        labelTheBreakWEI.Text = "Break has ended";
                        labelTheBreakWEI.ForeColor = Color.Red;
                        btnYesOkay.Enabled = true;
                        if (Countdown.RoundValueLive > 0)
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
        //------------------------------------------------------------------------- Button
        // okey btn
        private void btnYesOkay_Click(object sender, EventArgs e)
        {
            var countdown = new Countdown();
            if (btnYesOkay.Text == "Yes")
            {
                countdown.CountdownInputControl("BreakWinYes");
            }
            else if (btnYesOkay.Text == "Okay")
            {
                countdown.CountdownInputControl("BreakWinOkay");
            }
            Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            var countdown = new Countdown();
            countdown.CountdownInputControl("BreakWinNo");
            Close();
        }
    }
}
