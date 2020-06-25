using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using RedCell.Diagnostics.Update;


namespace WorkerAnt
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
                Application.Run(new SimpleUI());
            }
            else if (Properties.Settings.Default.simpleUI == false)
            {
                Application.Run(new CompleteUI());
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
                    MessageBox.Show("WB 81", "WorkerAnt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //error
                    break;
            }

        }
        /// <summary>
        /// Opens the window which is given to it.
        /// </summary>
        /// <param name="winName">Name of the window to open</param>
        private void OpenWindow(string winName)
        {
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
                        MessageBox.Show("WB 104", "WorkerAnt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //error
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
                        var breakWin = new BreakWin();
                        breakWin.Show();
                        break;
                    case "ToBreakWin":
                        var toBreakWin = new ToBreakWin();
                        toBreakWin.Show();
                        break;
                    case "SimpleUIWin":
                        var simpleViewWin = new SimpleUI();
                        simpleViewWin.Show();
                        break;
                    case "CompleteUIWin":
                        var fullViewWin = new CompleteUI();
                        fullViewWin.Show();

                        break;
                    default:
                        //error
                        break;
                }
            }
        }
        #endregion
    }
}
