using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Worker_Ant
{
    public class WinBehavior
    {
        //public string winName;
        bool winIsOpen;
        //-------------------------------------------------------------------------check windows to let only one to be visibel
        public void ChackWins(string winName)
        {
            foreach (Form win in Application.OpenForms)
            {
                if (win.Name == winName)
                {
                    winIsOpen = true;
                    win.BringToFront();
                }
            }
            if (winIsOpen == false)
            {
                if (winName == "InfoWin")
                {
                    var infoWin = new InfoWin();
                    infoWin.Show();
                }
                else if (winName == "SettingsWin")
                {
                    var settingsWin = new SettingsWin();
                    settingsWin.Show();
                }
                else
                {
                    MessageBox.Show("form/win " + winName + " dose not exist");
                }

            }
        }
    }
}
