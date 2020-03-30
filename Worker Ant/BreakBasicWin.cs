﻿using System;
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
        internal int _mouseXAxis;
        internal int _mouseYAxis;
        internal bool _mouseDrag;

        public BreakBasicWin()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------win move
        //form mouse down
        private void Win_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDrag = true;
            _mouseXAxis = Cursor.Position.X - this.Left;
            _mouseYAxis = Cursor.Position.Y - this.Top;
        }
        //form mouse move
        private void Win_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDrag)
            {
                this.Left = Cursor.Position.X - _mouseXAxis;
                this.Top = Cursor.Position.Y - _mouseYAxis;
            }
        }
        //form mouse up
        private void Win_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDrag = false;
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

        private void BreakBasic_Load(object sender, EventArgs e)
        {

        }

        private void btnOkBreakBasic_Click(object sender, EventArgs e)
        {

        }
    }
}
