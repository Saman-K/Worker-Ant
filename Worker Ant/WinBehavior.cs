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
        //------------------------------------------------------------------------- check windows to let only one to be visibel
        public void ChackWins(string winName)
        {
            var errorHandler = new ErrorHandlerWin();
            
            if (Properties.Settings.Default.Theme == "Basic")
            {
                if (winName == "Info")
                {
                    WinOpener("InfoWin");
                }
                else if (winName == "Settings")
                {
                    WinOpener("SettingsWin");
                }
                else if (winName == "Break")
                {
                    WinOpener("BreakBasicWin");
                }
                else if (winName == "ToBreak")
                {
                    WinOpener("ToBreakBasicWin");
                }
                else if (winName == "SimpleView")
                {
                    WinOpener("SimpleViewWin");
                }
                else if(winName == "FullView")
                {
                    WinOpener("FullViewWin");
                }
                else
                {
                    errorHandler.ErrorHandeler("", "WB", "01", true);
                    errorHandler.Show();
                }
            }
            else if (Properties.Settings.Default.Theme == "")
            {

            }
            else
            {
                errorHandler.ErrorHandeler("", "WB", "02", true);
                errorHandler.Show();
            }

        }

        internal void WinOpener(string winName)
        {
            var errorHandler = new ErrorHandlerWin();

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
                        errorHandler.ErrorHandeler("", "WB", "03", true);
                        errorHandler.Show();
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
                        errorHandler.ErrorHandeler("", "WB", "04", true);
                        errorHandler.Show();
                        break;
                }
            }
        }
    }
}
