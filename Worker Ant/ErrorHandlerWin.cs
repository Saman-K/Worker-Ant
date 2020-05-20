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
    public partial class ErrorHandlerWin : Form
    {
        #region Fields
        internal static int MouseXAxis;
        internal static int MouseYAxis;
        internal static bool MouseDrag;
        #endregion

        #region Initialization
        public ErrorHandlerWin()
        {
            InitializeComponent();
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
        // click
        private void PicBoxClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        // mouse leave
        private void PicBoxClose_MouseLeave(object sender, EventArgs e)
        {
            picBoxClose.BackColor = SystemColors.Control;
        }
        // mouse enter
        private void PicBoxClose_MouseEnter(object sender, EventArgs e)
        {
            picBoxClose.BackColor = SystemColors.ControlDark;

        }
        #endregion

        #region Methods
        // okey btn
        private void BtnOkBreakBasic_Click(object sender, EventArgs e)
        {
            Close();
        }
        // error handling method
        public void ErrorHandeler(string Message, string location, string errorNum, bool tF)
        {
            if (Message != "")
            {
                labelReportToDev.Text = Message;
            }

            labelLocationNumber.Text = (location + "/" + errorNum + " .").ToString();
            if (tF == true)
            {
                labelError.Visible = true;
                labelLocationNumber.Visible = true;
            }
            else
            {
                labelError.Visible = false;
                labelLocationNumber.Visible = false;
            }
        }
        #endregion
    }
}
