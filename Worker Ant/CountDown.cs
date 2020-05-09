using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Timers;
using System.Windows.Forms;
using System.Media;

namespace Worker_Ant
{
    class Countdown
    {
        // fields
        private static (int, int, int) _savedCountdownValuesWBR;

        internal static int _workValueLive = 0;
        internal static int _breakValueLive = 0;
        internal static int _roundsValueLive = 0;

        internal static string _timerRoundName;

        internal static string _timerStatus;

        // Item1 == Work timer , Item2 == Break timer , Item3 == Round counter
        public static (int, int, int) SavedCountdownValuesWBR
        {
            set
            {
                _savedCountdownValuesWBR = value;
            }
            get
            {
                return _savedCountdownValuesWBR;
            }
        }

        public static int WorkValueLive
        {
            set
            {
                if (value >= 0)
                {
                    _workValueLive = value;
                }
                else
                {
                    var errorHandler = new ErrorHandlerWin();
                    errorHandler.ErrorHandeler("", "CD", "06", true);
                    errorHandler.ShowDialog();
                }
            }
            get
            {
                return _workValueLive;
            }
        }
        public static int BreakValueLive
        {
            set
            {
                _breakValueLive = value;
            }
            get
            {
                return _breakValueLive;
            }
        }
        public static int RoundValueLive
        {
            set
            {
                if (value >= 0)
                {
                    _roundsValueLive = value;
                }
                else
                {
                    var errorHandler = new ErrorHandlerWin();
                    errorHandler.ErrorHandeler("", "CD", "07", true);
                    errorHandler.ShowDialog();
                }

            }
            get
            {
                return _roundsValueLive;
            }
        }

        public static string TimerRoundName
        {
            set
            {
                if (value == "Work" || value == "Break" || value == "End Break")
                {
                    _timerRoundName = value;
                }
                else
                {
                    var errorHandler = new ErrorHandlerWin();
                    errorHandler.ErrorHandeler("", "CD", "08", true);
                    errorHandler.ShowDialog();
                }
            }
            get
            {
                return _timerRoundName;
            }
        }
        public static string TimerStatus
        {
            set
            {
                if (value == "Tick" || value == "Pause")
                {
                    _timerStatus = value;
                }
                else
                {
                    var errorHandler = new ErrorHandlerWin();
                    errorHandler.ErrorHandeler("", "CD", "09", true);
                    errorHandler.ShowDialog();
                }
            }
            get
            {
                return _timerStatus;
            }

        }

        internal static System.Windows.Forms.Timer _countdownTimer = new System.Windows.Forms.Timer();

        public static void Start()
        {
            _countdownTimer.Tick += CountdownTimer_Tick;

        }

        // ------------------------------------------------------------------------- button
        // set setting to default
        public void SetSettingsToDefault()
        {
            Properties.Settings.Default.recoveryWorkTime = 1800;
            Properties.Settings.Default.recoveryBreakTime = 120;
            Properties.Settings.Default.smartWorkTime = 2400;
            Properties.Settings.Default.smartBreakTime = 240;
            Properties.Settings.Default.progressWorkTime = 3300;
            Properties.Settings.Default.progressBreakTime = 300;
            Properties.Settings.Default.roundCountdown = 1;

            //settingsWin.checkBoxSafetyInfo.Checked = true;
            Properties.Settings.Default.audioAlert = true;
            Properties.Settings.Default.simpleView = false;

            //InsertSettingsData("Settings");
        }
        // insert data to view/set/reset to start
        public (int, int, int) GetTimerDataForUI(string chosenRadioBtn)
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
                    errorHandler.ErrorHandeler("", "CD", "01", true);
                    errorHandler.ShowDialog();
                    break;
            }

            return (WorkTime, BreakTime, Convert.ToInt32(Properties.Settings.Default.roundCountdown));
        }
        // Bottun press input
        public string CountdownInputControl(string btnText)
        {
            var errorHandler = new ErrorHandlerWin();
            if (btnText == "Start")
            {
                TimerControler("Start");
                return "Stop";
            }
            else if (btnText == "Stop")
            {
                if (TimerRoundName == "Break")
                {
                    errorHandler.ErrorHandeler("You can NOT stop during a break.", "CD", "05", false);
                    errorHandler.ShowDialog();
                    return "Stop";
                }
                else if (TimerRoundName == "End Break")
                {
                    if (Countdown.RoundValueLive > 0)
                    {
                        TimerControler("Lap");
                    }
                    else if (Countdown.RoundValueLive <= 0)
                    {
                        TimerControler("End");
                    }
                    return "Start";
                }
                else /*if (TimerRoundName == "Work")*/
                {
                    _countdownTimer.Stop();
                    TimerControler("Stop");
                    return "Start";
                }

            }
            else if (btnText == "Reset" || btnText == "Set")
            {
                TimerControler("Set");
                return "Reset";
            }
            // break button
            else if (btnText == "BreakWinYes")
            {
                TimerControler("Lap");
                return "";
            }
            // to break
            else if (btnText == "BreakWinOkay")
            {
                TimerControler("End");
                return "";
            }
            else if (btnText == "BreakWinNo")
            {
                TimerControler("LapPause");
                return "";
            }
            else if (btnText == "ToBreakYes")
            {
                TimerControler("ToBreak");
                return "";
            }
            else
            {
                errorHandler.ErrorHandeler("", "CD", "02", true);
                errorHandler.ShowDialog();
                return "CD/2";
            }
        }
        // ------------------------------------------------------------------------- timer
        // timer tike  
        private static void CountdownTimer_Tick(object sender, EventArgs e)
        {
            _countdownTimer.Interval = 100;
            if (TimerRoundName == "Work")
            {
                if (WorkValueLive > 0)
                {
                    WorkValueLive--;
                    if (WorkValueLive == 30)
                    {
                        TimerControler("ToBreakPopup");
                    }
                }
                else if (WorkValueLive <= 0)
                {
                    TimerControler("Break");
                }

            }
            else if (TimerRoundName == "Break")
            {
                BreakValueLive--;
                if (BreakValueLive == 0)
                {
                    TimerControler("End Break");
                }
            }
            else if (TimerRoundName == "End Break")
            {
                BreakValueLive++;
                if (Properties.Settings.Default.audioAlert == true)
                {
                    Console.Beep(800, 100);
                }
            }
        }
        // ------------------------------------------------------------------------- function
        public static void TimerControler(string function)
        {
            var errorHandler = new ErrorHandlerWin();
            var winBehavior = new WinBehavior();
            switch (function)
            {
                case "Start":
                    if (WorkValueLive == SavedCountdownValuesWBR.Item1 || BreakValueLive == SavedCountdownValuesWBR.Item2 && RoundValueLive == SavedCountdownValuesWBR.Item3)
                    {
                        // start from the top

                        RoundValueLive--;
                        TimerRoundName = "Work";
                        _countdownTimer.Start();
                        TimerStatus = "Tick";
                    }
                    else if (WorkValueLive > 0 && BreakValueLive > 0 && RoundValueLive >= 0)
                    {
                        // start from work 
                        TimerRoundName = "Work";
                        _countdownTimer.Start();
                        TimerStatus = "Tick";
                    }
                    else if (BreakValueLive != SavedCountdownValuesWBR.Item2 && WorkValueLive <= 0)
                    {
                        // start from break
                        MessageBox.Show("break");
                        TimerRoundName = "Break";
                        _countdownTimer.Start();
                        TimerStatus = "Tick";
                    }
                    else
                    {
                        errorHandler.ErrorHandeler("", "CD", "03", true);
                        errorHandler.ShowDialog();
                    }
                    break;
                case "Stop":
                    _countdownTimer.Stop();
                    TimerStatus = "Pause";
                    break;
                case "Set":
                    WorkValueLive = SavedCountdownValuesWBR.Item1;
                    BreakValueLive = SavedCountdownValuesWBR.Item2;
                    RoundValueLive = SavedCountdownValuesWBR.Item3;
                    break;
                //------------------------------------ 
                case "ToBreakPopup":
                    winBehavior.ChackWins("ToBreak");
                    if (Properties.Settings.Default.audioAlert == true)
                    {
                        Console.Beep(1000, 500);
                    }

                    break;
                case "ToBreak":
                    WorkValueLive = 0;
                    TimerControler("Break");
                    break;
                //case "ToBreak 5":
                //    winBehavior.Notify("5 Seconds", "Your break will start in 5 Seconds");
                //    break;
                //-------------------------------------
                case "LapPause":
                    TimerRoundName = "Work";
                    _countdownTimer.Stop();
                    TimerStatus = "Pause";

                    WorkValueLive = SavedCountdownValuesWBR.Item1;
                    BreakValueLive = SavedCountdownValuesWBR.Item2;
                    break;
                //-------------------------------------
                case "Break":
                    _countdownTimer.Stop();
                    if (Properties.Settings.Default.audioAlert == true)
                    {
                        Console.Beep(1000, 500);
                    }

                    winBehavior.ChackWins("Break");
                    TimerRoundName = "Break";
                    _countdownTimer.Start();
                    TimerStatus = "Tick";
                    break;
                case "End Break":
                    TimerRoundName = "End Break";
                    winBehavior.ChackWins("Main");
                    if (Properties.Settings.Default.audioAlert == true)
                    {
                        Console.Beep(1000, 500);
                    }
                    break;
                case "Lap":
                    _countdownTimer.Stop();
                    TimerStatus = "Pause";
                    WorkValueLive = SavedCountdownValuesWBR.Item1;
                    BreakValueLive = SavedCountdownValuesWBR.Item2;

                    RoundValueLive--;
                    TimerRoundName = "Work";
                    _countdownTimer.Start();
                    TimerStatus = "Tick";
                    break;
                case "End":
                    WorkValueLive = SavedCountdownValuesWBR.Item1;
                    BreakValueLive = SavedCountdownValuesWBR.Item2;
                    RoundValueLive = SavedCountdownValuesWBR.Item3;

                    TimerRoundName = "Work";
                    _countdownTimer.Stop();
                    TimerStatus = "Pause";
                    break;
                default:
                    errorHandler.ErrorHandeler("", "CD", "04", true);
                    errorHandler.ShowDialog();
                    break;
            }
        }
    }
}
