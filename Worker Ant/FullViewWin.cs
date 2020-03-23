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
    public partial class FullViewWin : Form
    {
        public FullViewWin()
        {
            InitializeComponent();
        }

        private void btnSetReset_Click(object sender, EventArgs e)
        {
            btnSetReset.Text = "Reset";
            //add a void in countdoun class to grabe the data from the preset and send it to the timer

            labelRoundNumCountdown.Text = Properties.Settings.Default.roundCountdown.ToString();

        }
    }
}
