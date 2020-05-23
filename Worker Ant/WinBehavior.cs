using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace Worker_Ant
{
    public class WinBehavior
    {
        internal bool WinIsOpen;

        #region Initialization
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Countdown.Start();

            if (Properties.Settings.Default.simpleView == true)
            {
                Application.Run(new SimpleViewWin());
            }
            else if (Properties.Settings.Default.simpleView == false)
            {
                Application.Run(new FullViewWin());
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// get the name of the win acarning to the thame and ask to open 
        /// </summary>
        /// <param name="winName">win name</param>
        public void ChackWins(string winName)
        {
            var errorHandler = new ErrorHandlerWin();
            
            if (Properties.Settings.Default.winTheme == "Basic")
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
                    case "Main":
                        if (Properties.Settings.Default.simpleView == true)
                        { 
                            WinOpener("SimpleViewWin");
                        }
                        else if (Properties.Settings.Default.simpleView == false)
                        {
                            WinOpener("FullViewWin");
                        }
                        break;
                    default:

                    errorHandler.ErrorHandeler("", "WB", "01", true);
                        break;
                }
            }
            else if (Properties.Settings.Default.winTheme == "")
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
        /// <summary>
        /// open win
        /// </summary>
        /// <param name="winName">win of name to open</param>
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
                        var simpleViewWin = new SimpleViewWin();
                        simpleViewWin.Show();
                        break;
                    case "FullViewWin":
                        //var fullViewWin = new FullViewWin();
                        //fullViewWin.Show();
                        
                        break;
                    default:
                        errorHandler.ErrorHandeler("", "WB", "04", true);
                        errorHandler.Show();
                        break;
                }
            }
        }
        #endregion
    }
}
