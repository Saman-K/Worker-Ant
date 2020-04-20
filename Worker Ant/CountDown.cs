using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Timer = System.Timers.Timer;


namespace Worker_Ant
{
    class Countdown /*: FullViewWin*/
    {
        // fields
        private static int _workTimerCountdown;
        private static int _breakTimerCountdown;
        private static int _roundsCountdown;

        private static int _workTimerLive = 0;
        private static int _breakTimerLive = 0;
        private static int _roundsLive = 0;

        private static string _wBTimer;

        // properties
        public static int WorkTimerCountdown
        {
            set {
                if (value >= 0)
                {
                    _workTimerCountdown = Convert.ToInt16(value);
                }
            }
            get { return _workTimerCountdown; }
        }
        public static int BreakTimerCountdown
        {
            set {
                if (value >= 0)
                {
                    _breakTimerCountdown = Convert.ToInt16(value);
                }
            }
            get { return _breakTimerCountdown; }
        }
        public static int RoundsCountdown
        {
            set { if (value >= 0)
                {
                    _roundsCountdown = Convert.ToInt16(value);
                } }
            get { return _roundsCountdown; }
        }

        public static int WorkTimerLive
        {
            set
            {
                _workTimerLive = value;
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
                _roundsLive = value; 
            }
            get 
            {
                return _roundsLive; 
            }
        }

        private static Timer _countdownTimer = new Timer(1000);
        //------------------------------------------------------------------------- btn 
        // set setting to default
        public void SetPresetTimeToDefault()
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
            _countdownTimer.Elapsed += CountdownTimer_Tick;
            return (WorkTime, BreakTime, Convert.ToInt32(Properties.Settings.Default.roundCountdown));
        }
        // Bottun press input
        public static string StartStopTimer(string btnText)
        {
            if (btnText == "Start")
            {
                SetToStartTimer("Start");
                return "Stop";
            }
            else if (btnText == "Stop")
            {
                SetToStartTimer("Stop");
                return "Start";
            }
            else
            {
                return "Error!";
            }
        }
        //------------------------------------------------------------------------- thinking 
        // timer tike  
        private static void CountdownTimer_Tick(object sender, System.Timers.ElapsedEventArgs e)
        {
           if (_wBTimer == "Work")
            {
                if (WorkTimerLive > 60)
                {

                    WorkTimerLive--;
                }
                else if (WorkTimerLive <= 60 && WorkTimerLive > 0)
                {
                    WorkTimerCountdown--;
                }
                else if (WorkTimerLive <= 0)
                {
                    _countdownTimer.Stop();

                    SetToStartTimer("Break");
                }
            }

            else if (_wBTimer == "Break")
            {
                if (BreakTimerLive > 0)
                {
                    BreakTimerLive--;
                }
                else if (BreakTimerLive <= 0)
                {

                    if (RoundTimerLive <= 0)
                    {
                        SetToStartTimer("End");
                    }
                    else if (RoundTimerLive > 0)
                    {
                        SetToStartTimer("Lap");
                    }

                    _countdownTimer.Stop();
                }

            }
            

            // do the maths for and numbers for the property 
            // get date to store on propertis
            //MessageBox.Show("work " + WorkTimerCountdown + "break " + BreakTimerCountdown + "round " + RoundsCountdown);
        }
        // 
        private static void SetToStartTimer(string function )
        {
            switch (function)
            {
                case ("Start"):
                    if (WorkTimerLive == 0 && BreakTimerLive == 0 && RoundTimerLive == 0)
                    {
                        WorkTimerLive = WorkTimerCountdown;
                        BreakTimerLive = BreakTimerCountdown;
                        RoundTimerLive = RoundsCountdown;

                        RoundTimerLive--;
                        _wBTimer = "Work";
                        _countdownTimer.Start();
                    }
                    else if (WorkTimerLive == 0 && BreakTimerLive == 0)
                    {
                        WorkTimerLive = WorkTimerCountdown;
                        BreakTimerLive = BreakTimerCountdown;

                        RoundTimerLive--;
                        _wBTimer = "Work";
                        _countdownTimer.Start();
                    }
                    else
                    {

                    }
                    break;
                case ("Stop"):

                    _countdownTimer.Stop();
                    break;
                case ("Lap"):
                    _wBTimer = "Work";
                    _countdownTimer.Start();

                    RoundTimerLive--;
                    break;
                case ("Break"):
                    _wBTimer = "Break";
                    _countdownTimer.Start();
                    //breakwin
                    break;

                case ("End"):

                    WorkTimerLive = WorkTimerCountdown;
                    BreakTimerLive = BreakTimerCountdown;
                    RoundTimerLive = RoundsCountdown;

                    break;
            }
        }
    }
}
