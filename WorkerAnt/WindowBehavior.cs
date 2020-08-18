using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

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
                    OpenWindow("AboutUI");
                    break;
                case WindowNames.Settings:
                    OpenWindow("SettingsUI");
                    break;
                case WindowNames.Break:
                    if (Properties.Settings.Default.breakStretches == true)
                        OpenWindow("BreakStretchesUI");
                    else if (Properties.Settings.Default.breakStretches == false)
                        OpenWindow("BreakUI");
                    break;
                case WindowNames.ToBreak:
                    OpenWindow("DueBreakUI");
                    break;
                case WindowNames.Main:
                    if (Properties.Settings.Default.simpleUI == true)
                        OpenWindow("SimpleUI");
                    else if (Properties.Settings.Default.simpleUI == false)
                        OpenWindow("CompleteUI");
                    break;
                default:
                    throw new ArgumentOutOfRangeException("winName", winName, "Please report to the developer (WB 74)");

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
                        throw new ArgumentOutOfRangeException("WindowsOpenStatus", WindowsOpenStatus, "Please report to the developer (WB 96)");
                    }
                }
            }
            if (WindowsOpenStatus == false)
            {
                switch (winName)
                {
                    case "AboutUI":
                        var aboutUI = new AboutUI();
                        aboutUI.Show();
                        break;
                    case "SettingsUI":
                        var settingsUI = new SettingsUI();
                        settingsUI.Show();
                        break;
                    case "BreakUI":
                        var breakUI = new BreakUI();
                        breakUI.Show();
                        break;
                    case "BreakStretchesUI":
                        var breakStretchesUI = new BreakStretchesUI();
                        breakStretchesUI.Show();
                        break;
                    case "DueBreakUI":
                        var dueBreakUI = new DueBreakUI();
                        dueBreakUI.Show();
                        break;
                    case "SimpleUI":
                        var simpleUI = new SimpleUI();
                        simpleUI.Show();
                        break;
                    case "CompleteUI":
                        var completeUI = new CompleteUI();
                        completeUI.Show();

                        break;
                    default:
                        throw new ArgumentOutOfRangeException("winName", winName, "Please report to the developer (WB 130)");
                }
            }
        }
        #endregion
    }
}
