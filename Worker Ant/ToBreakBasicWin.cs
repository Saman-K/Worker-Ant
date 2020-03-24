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
        int mouseXAxis;
        int mouseYAxis;
        bool mouseDrag;

        public ToBreakBasicWin()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------win move
        //form mouse down
        private void Win_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDrag = true;
            mouseXAxis = Cursor.Position.X - this.Left;
            mouseYAxis = Cursor.Position.Y - this.Top;
        }
        //form mouse move
        private void Win_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDrag)
            {
                this.Left = Cursor.Position.X - mouseXAxis;
                this.Top = Cursor.Position.Y - mouseYAxis;
            }
        }
        //form mouse up
        private void Win_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDrag = false;
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
    }
}
