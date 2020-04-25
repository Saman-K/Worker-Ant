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
        internal bool WinIsOpen;
        //-------------------------------------------------------------------------check windows to let only one to be visibel
        public void ChackWins(string winName)
        {
            var winCouter = new WinBehavior();
            if (Properties.Settings.Default.Theme == "Basic")
            {
                if (winName == "Info")
                {
                    winCouter.WinOpener("InfoWin");
                }
                else if (winName == "Settings")
                {
                    winCouter.WinOpener("SettingsWin");
                }
                else if (winName == "Break")
                {
                    winCouter.WinOpener("BreakBasicWin");
                }
                else if (winName == "ToBreak")
                {
                    winCouter.WinOpener("ToBreakBasicWin");
                }
                else if (winName == "SimpleView")
                {
                    winCouter.WinOpener("SimpleViewWin");
                }
                else if(winName == "FullView")
                {
                    winCouter.WinOpener("FullViewWin");
                }
                else if(winName == "Box")
                {
                    var breakBasicWin = new BreakBasicWin();
                    breakBasicWin.Show();
                    MessageBox.Show("");
                }
                else
                {
                    // error 
                }
            }
            else if (Properties.Settings.Default.Theme == "")
            {

            }
            else
            {
                //error
            }

        }

        public void WinOpener(string winName)
        {
            foreach (Form win in Application.OpenForms)
            {
                if (win.Name == winName)
                {
                    WinIsOpen = true;
                    try
                    {
                        win.BringToFront();
                    }
                    catch 
                    {
                        //error
                    }
                }
            }
            if (WinIsOpen == false)
            {
                switch (winName)
                {
                    case "InfoWin":
                        var infoWin = new InfoWin();
                        infoWin.Show();
                        break;
                    case "SettingsWin":
                        var settingsWin = new SettingsWin();
                        settingsWin.Show();
                        break;
                    case "BreakBasicWin":
                        var breakBasicWin = new BreakBasicWin();
                        breakBasicWin.Show();
                        break;
                    case "ToBreakBasicWin":
                        var toBreakBasicWin = new ToBreakBasicWin();
                        toBreakBasicWin.Show();
                        break;
                    case "SimpleViewWin":
                        var simpleViewWin = new SimpleViewWin();
                        simpleViewWin.Show();
                        break;
                    case "FullViewWin":
                        var fullViewWin = new FullViewWin();
                        fullViewWin.Show();
                        break;

                    default:
                        //error
                        break;
                }
            }
        }
    }
}
