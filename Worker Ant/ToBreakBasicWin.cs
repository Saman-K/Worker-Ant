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
    public partial class ToBreakBasicWin : Form
    {
        internal int MouseXAxis;
        internal int MouseYAxis;
        internal bool MouseDrag;

        public ToBreakBasicWin()
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
        //-------------------------------------------------------------------------button click
        private void btnNoToBreakBasic_Click(object sender, EventArgs e)
        {

        }

        private void btnYesToBreakBasic_Click(object sender, EventArgs e)
        {

        }
    }
}
