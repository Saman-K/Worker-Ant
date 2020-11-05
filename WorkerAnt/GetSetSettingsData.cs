using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Globalization;

namespace WorkerAnt
{
    public static class GetSetSettingsData
    {
        /// <summary>
        /// Set settings to developers default 
        /// </summary>
        public static void SetSettingsToDefault()
        {
            Properties.Settings.Default.recoveryWorkTime = 1800;
            Properties.Settings.Default.recoveryBreakTime = 120;
            Properties.Settings.Default.smartWorkTime = 2400;
            Properties.Settings.Default.smartBreakTime = 240;
            Properties.Settings.Default.progressWorkTime = 3300;
            Properties.Settings.Default.progressBreakTime = 300;
            Properties.Settings.Default.lapCounter = 1;

            Properties.Settings.Default.audioAlert = true;
            Properties.Settings.Default.simpleUI = false;
            Properties.Settings.Default.breakStretches = true;
        }
        /// <summary>
        /// It will save the settings.
        /// </summary>
        /// <param name="workRecovery">Lap Package:Recovery Segment:Work</param>
        /// <param name="breakRecovery">Lap Package:Recovery Segment:Break</param>
        /// <param name="workSmart">Lap Package:Smart Segment:Work</param>
        /// <param name="breakSmart">Lap Package:Smart Segment:Break</param>
        /// <param name="workProgress">Lap Package:Progress Segment:Work</param>
        /// <param name="breakProgress">Lap Package:Progress Segment:Break</param>
        /// <param name="lapCounter">Segment:Lap Counter</param>
        /// <param name="audioAlert">Audio Alert</param>
        /// <param name="simpleUI">Simple UI</param>
        /// <param name="autoStart">Auto Start</param>
        /// <returns>String: User readable message.</returns>
        public static string SaveSettings(decimal workRecovery, decimal breakRecovery, decimal workSmart, decimal breakSmart, decimal workProgress,
            decimal breakProgress, decimal lapCounter, bool audioAlert, bool simpleUI, bool autoStart, bool breakInfo)
        {
            var message = "";
            try
            {
                Properties.Settings.Default.recoveryWorkTime = workRecovery * 60;
                Properties.Settings.Default.recoveryBreakTime = breakRecovery * 60;
                Properties.Settings.Default.smartWorkTime = workSmart * 60;
                Properties.Settings.Default.smartBreakTime = breakSmart * 60;
                Properties.Settings.Default.progressWorkTime = workProgress * 60;
                Properties.Settings.Default.progressBreakTime = breakProgress * 60;
                Properties.Settings.Default.lapCounter = lapCounter;

                Properties.Settings.Default.audioAlert = audioAlert;
                Properties.Settings.Default.breakStretches = breakInfo;

                if (Properties.Settings.Default.simpleUI != simpleUI)
                {
                    Properties.Settings.Default.simpleUI = simpleUI;
                    message = "Re-lunch the page to see the change. ";
                    
                    //notify balloon can be used
                }
                 //save autostart in registry 

                RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true);

                if (autoStart == true && registry.GetValue(Application.ProductName) == null)
                {
                    registry.SetValue(Application.ProductName, Application.ExecutablePath.ToString());
                }
                else if (autoStart == false && registry.GetValue(Application.ProductName) != null)
                {
                    registry.DeleteValue(Application.ProductName);
                }

                Properties.Settings.Default.Save();
                message += "Saved.";                
            }
            catch
            {
                message = "Settings could not be saved!";
            }
            return message;
        }

        /// <summary>
        /// Get lap Packages working settings.
        /// </summary>
        /// <returns>(W,B) Recovery, (W,B) Smart, (W,B) Progress, Lap Counter</returns>
        public static ((decimal workRecovery, decimal breakRecovery), ( decimal workSmart, decimal breakSmart), (decimal workProgress, decimal breakProgress), decimal lapCounter)
            GetSattingsLapPackages()
        {

            decimal workRecovery = Properties.Settings.Default.recoveryWorkTime / 60;
            decimal breakRecovery = Properties.Settings.Default.recoveryBreakTime / 60;
            decimal workSmart = Properties.Settings.Default.smartWorkTime / 60;
            decimal breakSmart = Properties.Settings.Default.smartBreakTime / 60;
            decimal workProgress = Properties.Settings.Default.progressWorkTime / 60;
            decimal breakProgress = Properties.Settings.Default.progressBreakTime / 60;
            decimal lapCounter = Properties.Settings.Default.lapCounter;

            return ((workRecovery, breakRecovery),( workSmart, breakSmart), (workProgress, breakProgress),lapCounter);

        }

        /// <summary>
        /// Get user preferred working settings.
        /// </summary>
        /// <returns>Audio alert, Simple UI, Auto Start</returns>
        public static (bool audioAlert, bool simpleUI, bool autoStart, bool breakInfo)
            GetSettingsUserPreferences()
        {
            bool audioAlert;
            bool simpleUI;
            bool autoStart;
            bool breakInfo;

            audioAlert = Properties.Settings.Default.audioAlert;
            simpleUI = Properties.Settings.Default.simpleUI;
            breakInfo = Properties.Settings.Default.breakStretches;

            RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (registry.GetValue(Application.ProductName) != null && Application.ExecutablePath == registry.GetValue(Application.ProductName).ToString())
            {
                autoStart = true;
            }
            else
            {
                autoStart = false;
            }

            return (audioAlert, simpleUI, autoStart, breakInfo);
        }



        #region ------------------------------------------------------------------------- Extended Methods 

        /// <summary>
        /// it convert int "300" to user readable time "5:00".
        /// </summary>
        /// <param name="timer">Timer in seconds.</param>
        /// <returns>Formated return "00:00".</returns>
        public static string IntToTimerFormat(this int timer)
        {
            var formated = (timer / 60 + ":" + (timer % 60).ToString("D2"));

            return formated;
        }

        /// <summary>
        /// Save the last lap package 
        /// </summary>
        /// <param name="lastUsed">Name of the lap package </param>
        public static void SaveLastUsedLapPackage(this LapPackageNames lastUsed)
        {
            Properties.Settings.Default.lastUsedLapPackage = (int)lastUsed;

            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Get Saved Data
        /// </summary>
        /// <param name="package"></param>
        /// <returns>Work timer, Break timer, Number of laps</returns>
        public static (int Work,int Break,int Laps) GetLapPackageValue(this LapPackageNames package)
        {
            int WorkTime = 0;
            int BreakTime = 0;
            switch (package)
            {
                case (LapPackageNames.Manual):
                    WorkTime = Convert.ToInt16(Properties.Settings.Default.manualWorkTime);
                    BreakTime = Convert.ToInt16(Properties.Settings.Default.manualBreakTime);
                    break;
                case (LapPackageNames.Recovery):
                    WorkTime = Convert.ToInt16(Properties.Settings.Default.recoveryWorkTime);
                    BreakTime = Convert.ToInt16(Properties.Settings.Default.recoveryBreakTime);
                    break;
                case (LapPackageNames.Smart):
                    WorkTime = Convert.ToInt16(Properties.Settings.Default.smartWorkTime);
                    BreakTime = Convert.ToInt16(Properties.Settings.Default.smartBreakTime);
                    break;
                case (LapPackageNames.Progress):
                    WorkTime = Convert.ToInt16(Properties.Settings.Default.progressWorkTime);
                    BreakTime = Convert.ToInt16(Properties.Settings.Default.progressBreakTime);
                    break;
                default:

                    break;
            }

            return (WorkTime, BreakTime, Convert.ToInt32(Properties.Settings.Default.lapCounter));
        }


        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);

        /// <summary>
        /// will change the color according to input
        /// </summary>
        /// <param name="pBar">progress bar name</param>
        /// <param name="state">1 = green, 2 = yellow, 3 = red</param>
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
        #endregion
    }
}
