using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Timers;


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
            Properties.Settings.Default.recoveryWorkTime = 30;
            Properties.Settings.Default.recoveryBreakTime = 2;
            Properties.Settings.Default.smartWorkTime = 40;
            Properties.Settings.Default.smartBreakTime = 4;
            Properties.Settings.Default.progressWorkTime = 55;
            Properties.Settings.Default.progressBreakTime = 5;
            Properties.Settings.Default.roundCountdown = 1;

            //settingsWin.checkBoxSafetyInfo.Checked = true;
            //settingsWin.checkBoxAudioAlert.Checked = true;
            Properties.Settings.Default.simpleView = false;

            //InsertSettingsData("Settings");
        }
        // insert data to view/set/reset to start
        public static (int, int, int) InsertDataToView(string chosenRadioBtn)
        {
            int WorkTime = 0;
            int BreakTime = 0;
            switch (chosenRadioBtn)
            {
                case ("Recovery"):
                    WorkTime = Convert.ToInt32(Properties.Settings.Default.recoveryWorkTime);
                    BreakTime = Convert.ToInt32(Properties.Settings.Default.recoveryBreakTime);
                    break;
                case ("Smart"):
                    WorkTime = Convert.ToInt32(Properties.Settings.Default.smartWorkTime);
                    BreakTime = Convert.ToInt32(Properties.Settings.Default.smartBreakTime);
                    break;
                case ("Progress"):
                    WorkTime = Convert.ToInt32(Properties.Settings.Default.progressWorkTime);
                    BreakTime = Convert.ToInt32(Properties.Settings.Default.progressBreakTime);
                    break;
                case ("Manual"):
                    WorkTime = Convert.ToInt32(Properties.Settings.Default.manualWorkTime);
                    BreakTime = Convert.ToInt32(Properties.Settings.Default.manualBreakTime);
                    break;
                default:
                    //MessageBox.Show("Redio button is not selected");
                    break;
            }

            return (WorkTime, BreakTime, Convert.ToInt32(Properties.Settings.Default.roundCountdown));
        }
        // Bottun press input
        public static string BtnInputControl(string btnText)
        {
            if (btnText == "Start")
            {
                SetToStartTimer("Start");
                return "Stop";
            }
            else if (btnText == "Stop" && WorkTimerLive != 0)
            {
                SetToStartTimer("Stop");
                return "Start";
            }
            else if (btnText == "Stop" && WorkTimerLive == 0 && BreakTimerLive != 0)
            {
                // stop during break 
                // error you can not stop during break
                return "Stop";
            }
            else if (btnText == "Stop" && WorkTimerLive == 0 && BreakTimerLive == 0 && RoundTimerLive !=0)
            {
                // stop during round elaps 
                // not needed 
                SetToStartTimer("Stop");
                return "Start";
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
            // error handeling there somthing round with btn input control
            else
            {
                return "Error!";
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
                    if (RoundTimerLive >= 0)
                    {
                        SetToStartTimer("Lap");
                    }
                    else if (RoundTimerLive < 0)
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
            switch (function)
            {
                case ("Start"):
                    _countdownTimer.Elapsed += CountdownTimer_Tick;
                    _countdownTimer.Interval = 1000;
                    if (WorkTimerLive == CountdownValues.Item1 && BreakTimerLive == CountdownValues.Item2 && RoundTimerLive == CountdownValues.Item3)
                    {
                        WBTimer = "Work";
                        RoundTimerLive--;
                        _countdownTimer.Start();
                    }
                    else if (WorkTimerLive > 0 && BreakTimerLive > 0 && RoundTimerLive >= 0)
                    {
                        WBTimer = "Work";
                        _countdownTimer.Start();
                    }
                    else if (BreakTimerLive != CountdownValues.Item2 || WorkTimerLive <= 0)
                    {
                        WBTimer = "Break";
                        _countdownTimer.Start();
                    }
                    else if (BreakTimerLive <= 0 || RoundTimerLive != 0)
                    {
                        SetToStartTimer("Lap");
                    }
                    else
                    {
                        // there is somthing roung with start btn 
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


                    //open break win error
                    //_countdownTimer.Start();
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
            }
        }
    }
}
