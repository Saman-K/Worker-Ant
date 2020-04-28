using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Timers;
using System.Windows.Forms;

namespace Worker_Ant
{
    /*static*/ class Countdown /*: FullViewWin*/
    {
        // fields
        private static (int, int, int) _countdownValues;

        private static int _workTimerLive = 0;
        private static int _breakTimerLive = 0;
        private static int _roundsLive = 0;

        internal static string _wBTimer;

        // Item1 == Work timer , Item2 == Break timer , Item3 == Round counter
        public static (int, int, int) CountdownValues
        {
            set
            {
                _countdownValues = value;
            }
            get
            {
                return _countdownValues;
            }
        }

        public static int WorkTimerLive
        {
            set
            {
                if (value >= 0)
                {
                    _workTimerLive = value;
                }
                else
                {
                    //error
                }
            }
            get 
            { 
                return _workTimerLive; 
            }
        }
        public static int BreakTimerLive 
        {
            set
            {
                _breakTimerLive = value;
            }
            get
            {
                return _breakTimerLive;
            }
        }
        public static int RoundTimerLive 
        {
            set 
            {
                if (value >= 0)
                {
                    _roundsLive = value; 
                }
                else
                {
                    //error 
                }
                
            }
            get 
            {
                return _roundsLive; 
            }
        }

        public static string WBTimer
        {
            set
            {
                if (value == "Work" || value == "Break")
                {
                    _wBTimer = value;
                }
                else
                {
                    //error
                }
            }
            get
            {
                return _wBTimer;
            }
        }

        private static System.Timers.Timer _countdownTimer = new System.Timers.Timer(1000);

        // ------------------------------------------------------------------------- button
        // set setting to default
        public static void SetPresetTimeToDefault()
        {
            Properties.Settings.Default.recoveryWorkTime = 1800;
            Properties.Settings.Default.recoveryBreakTime = 120;
            Properties.Settings.Default.smartWorkTime = 2400;
            Properties.Settings.Default.smartBreakTime = 240;
            Properties.Settings.Default.progressWorkTime = 3300;
            Properties.Settings.Default.progressBreakTime = 300;
            Properties.Settings.Default.roundCountdown = 1;

            //settingsWin.checkBoxSafetyInfo.Checked = true;
            //settingsWin.checkBoxAudioAlert.Checked = true;
            Properties.Settings.Default.simpleView = false;

            //InsertSettingsData("Settings");
        }
        // insert data to view/set/reset to start
        public static (int, int, int) InsertDataToView(string chosenRadioBtn)
        {
            var errorHandler = new ErrorHandlerWin();
            int WorkTime = 0;
            int BreakTime = 0;
            switch (chosenRadioBtn)
            {
                case ("Recovery"):
                    WorkTime = Convert.ToInt16(Properties.Settings.Default.recoveryWorkTime);
                    BreakTime = Convert.ToInt16(Properties.Settings.Default.recoveryBreakTime);
                    break;
                case ("Smart"):
                    WorkTime = Convert.ToInt16(Properties.Settings.Default.smartWorkTime);
                    BreakTime = Convert.ToInt16(Properties.Settings.Default.smartBreakTime);
                    break;
                case ("Progress"):
                    WorkTime = Convert.ToInt16(Properties.Settings.Default.progressWorkTime);
                    BreakTime = Convert.ToInt16(Properties.Settings.Default.progressBreakTime);
                    break;
                case ("Manual"):
                    WorkTime = Convert.ToInt16(Properties.Settings.Default.manualWorkTime);
                    BreakTime = Convert.ToInt16(Properties.Settings.Default.manualBreakTime);
                    break;
                default:
                    errorHandler.ErrorHandeler("", "CD", "01",true );
                    errorHandler.Show();
                    break;
            }
            
            return (WorkTime, BreakTime, Convert.ToInt32(Properties.Settings.Default.roundCountdown));
        }
        // Bottun press input
        public static string BtnInputControl(string btnText)
        {
            var errorHandler = new ErrorHandlerWin();
            if (btnText == "Start")
            {
                SetToStartTimer("Start");
                return "Stop";
            }
            else if (btnText == "Stop")
            {
                if (WBTimer == "Work")
                {
                    _countdownTimer.Stop();
                    _countdownTimer.Enabled = false;
                    _countdownTimer.Elapsed -= CountdownTimer_Tick;
                    SetToStartTimer("Stop");
                    return "Start";
                }
                else
                {
                    errorHandler.ErrorHandeler("You can NOT stop during a break.", "CD", "05", false);
                    errorHandler.Show();
                    SetToStartTimer("Start");
                    return "Stop";
                }

            }
            else if (btnText == "Reset" || btnText == "Set")
            {
                SetToStartTimer("Set");
                return "Reset";
            }
            // break button okey 
            else if (btnText == "Okey")
            {
                SetToStartTimer("Lap");
                return "";
            }
            // to break btns 
            else if (btnText == "No")
            {
                return "";
            }
            else if (btnText == "Yes")
            {
                return "";
            }
            else
            {
                errorHandler.ErrorHandeler("", "CD", "02", true);
                errorHandler.Show();
                return "CD/2";
            }
        }
        // ------------------------------------------------------------------------- timer
        // timer tike  
        private static void CountdownTimer_Tick(object sender, System.Timers.ElapsedEventArgs e)
        {
            _countdownTimer.Interval = 1000;
            if (WBTimer == "Work")
            {
                if (WorkTimerLive > 0)
                {
                    WorkTimerLive--;
                }
                else if (WorkTimerLive <= 0)
                {
                    SetToStartTimer("Break");
                }
            }
            else if (WBTimer == "Break")
            {
                BreakTimerLive--;
                if (BreakTimerLive == 0)
                {
                    if (RoundTimerLive > 0)
                    {
                        SetToStartTimer("Lap");
                    }
                    else if (RoundTimerLive <= 0)
                    {
                        SetToStartTimer("End");
                    }
                }
            }
        }
        // ------------------------------------------------------------------------- function
        // 
        public static void SetToStartTimer(string function)
        {
            var errorHandler = new ErrorHandlerWin();
            switch (function)
            {
                case ("Start"):
                    _countdownTimer.Elapsed += CountdownTimer_Tick;
                    _countdownTimer.Interval = 1000;
                    if (WorkTimerLive == CountdownValues.Item1 || BreakTimerLive == CountdownValues.Item2 && RoundTimerLive == CountdownValues.Item3)
                    {
                        // start frome the top
                        WBTimer = "Work";
                        RoundTimerLive--;
                        _countdownTimer.Start();
                    }
                    else if (WorkTimerLive > 0 && BreakTimerLive > 0 && RoundTimerLive >= 0)
                    {
                        // start from work 
                        WBTimer = "Work";
                        _countdownTimer.Start();
                    }
                    else if (BreakTimerLive != CountdownValues.Item2 && WorkTimerLive <= 0)
                    {
                        // start from break
                        MessageBox.Show("break");
                        WBTimer = "Break";
                        _countdownTimer.Start();
                    }
                    else
                    {
                        errorHandler.ErrorHandeler("", "CD", "03", true);
                        errorHandler.Show();
                    }
                    break;
                case ("Stop"):
                    _countdownTimer.Stop();
                    _countdownTimer.Enabled = false;
                    _countdownTimer.Elapsed -= CountdownTimer_Tick;
                    break;
                case ("Set"):
                    WorkTimerLive = CountdownValues.Item1;
                    BreakTimerLive = CountdownValues.Item2;
                    RoundTimerLive = CountdownValues.Item3;
                    break;
                case ("Break"):
                    _countdownTimer.Stop();
                    WBTimer = "Break";
                    //open break win
                    _countdownTimer.Start();
                    break;
                case ("End Break"):

                    // enabel close button on breakwin
                    break;
                case ("Lap"):
                    _countdownTimer.Stop();
                    WorkTimerLive = CountdownValues.Item1;
                    BreakTimerLive = CountdownValues.Item2;

                    WBTimer = "Work";

                    RoundTimerLive--;
                    _countdownTimer.Start();
                    break;
                case ("End"):
                    WorkTimerLive = CountdownValues.Item1;
                    BreakTimerLive = CountdownValues.Item2;
                    RoundTimerLive = CountdownValues.Item3;

                    _countdownTimer.Stop();
                    _countdownTimer.Enabled = false;
                    _countdownTimer.Elapsed -= CountdownTimer_Tick;
                    break;
                default:
                    errorHandler.ErrorHandeler("", "CD", "04", true);
                    errorHandler.Show();
                    break;
            }
        }
    }
}
