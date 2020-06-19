using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using RedCell.Diagnostics.Update;


namespace Worker_Ant
{
    public class WindowBehavior
    {
        #region Fields
        /// <summary>
        /// Stores the open Status of the Window
        /// </summary>
        private bool WindowsOpenStatus;
        #endregion

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

            var updater = new RedCell.Diagnostics.Update.Updater();
            updater.StartMonitoring();

            if (Properties.Settings.Default.simpleUI == true)
            {
                Application.Run(new SimpleUIWin());
            }
            else if (Properties.Settings.Default.simpleUI == false)
            {
                Application.Run(new CompleteUIWin());
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Get the name of the window and send it to OpenWindow()
        /// </summary>
        /// <param name="winName">win name</param>
        public void WindowsOpenCheck(WindowNames winName)
        {
            var errorHandler = new ErrorHandlerWin();

            switch (winName)
            {
                case WindowNames.Info:
                    OpenWindow("InfoWin");
                    break;
                case WindowNames.Settings:
                    OpenWindow("SettingsWin");
                    break;
                case WindowNames.Break:
                    OpenWindow("BreakWin");
                    break;
                case WindowNames.ToBreak:
                    OpenWindow("ToBreakWin");
                    break;
                case WindowNames.Main:
                    if (Properties.Settings.Default.simpleUI == true)
                    {
                        OpenWindow("SimpleUIWin");
                    }
                    else if (Properties.Settings.Default.simpleUI == false)
                    {
                        OpenWindow("CompleteUIWin");
                    }
                    break;
                default:

                    errorHandler.ErrorHandeler("", "WB", "01", true);
                    break;
            }

        }
        /// <summary>
        /// Opens the window which is given to it.
        /// </summary>
        /// <param name="winName">Name of the window to open</param>
        private void OpenWindow(string winName)
        {
            var errorHandler = new ErrorHandlerWin();

            foreach (Form win in Application.OpenForms)
            {
                if (win.Name == winName)
                {
                    WindowsOpenStatus = true;
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
            if (WindowsOpenStatus == false)
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
                    case "BreakWin":
                        var breakBasicWin = new BreakWin();
                        breakBasicWin.Show();
                        break;
                    case "ToBreakWin":
                        var toBreakBasicWin = new ToBreakWin();
                        toBreakBasicWin.Show();
                        break;
                    case "SimpleUIWin":
                        var simpleViewWin = new SimpleUIWin();
                        simpleViewWin.Show();
                        break;
                    case "CompleteUIWin":
                        var fullViewWin = new CompleteUIWin();
                        fullViewWin.Show();

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
