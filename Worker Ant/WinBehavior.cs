﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Worker_Ant
{
    public class WinBehavior
    {
        //public string winName;
        internal bool WinIsOpen;
        //------------------------------------------------------------------------- check windows to let only one to be visibel
        public static void Start()
        {
            WinBehavior winBehavior = new WinBehavior();
            if (Properties.Settings.Default.simpleView == true)
            {
                Application.Run(new SimpleViewWin());
            }
            else if (Properties.Settings.Default.simpleView == false)
            {
                Application.Run(new FullViewWin());
            }
        }

        public void ChackWins(string winName)
        {
            var errorHandler = new ErrorHandlerWin();
            
            if (Properties.Settings.Default.Theme == "Basic")
            {
                switch (winName)
                {
                    case "Info":
                        WinOpener("InfoWin");
                        break;
                    case "Settings":
                    WinOpener("SettingsWin");
                        break;
                    case "Break":
                    WinOpener("BreakBasicWin");
                        break;
                    case "ToBreak":
                    WinOpener("ToBreakBasicWin");
                        break;
                    case "SimpleView":
                        WinOpener("SimpleViewWin");
                        break;
                    case "FullView":
                        WinOpener("FullViewWin");
                        break;
                    default:

                    errorHandler.ErrorHandeler("", "WB", "01", true);
                        break;
                }
            }
            else if (Properties.Settings.Default.Theme == "")
            {
                switch (winName)
                {
                    case "Info":
                        WinOpener("InfoWin");
                        break;
                    case "Settings":
                        WinOpener("SettingsWin");
                        break;
                    case "Break":
                        WinOpener("BreakBasicWin");
                        break;
                    case "ToBreak":
                        WinOpener("ToBreakBasicWin");
                        break;
                    case "SimpleView":
                        WinOpener("SimpleViewWin");
                        break;
                    case "FullView":
                        WinOpener("FullViewWin");
                        break;
                    default:
                        errorHandler.ErrorHandeler("", "WB", "05", true);
                        break;
                }
            }
            else
            {
                errorHandler.ErrorHandeler("", "WB", "02", true);
            }

        }

        protected void WinOpener(string winName)
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
Application.Exit();
                        Application.Run(new SimpleViewWin());
                        
                        break;
                    case "FullViewWin":
                        Application.Run(new FullViewWin());
                        Application.Exit();
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
