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
    public static class Countdown
    {

        #region Fields
        /// <summary>
        /// live work timer data
        /// </summary>
        private static int _workTimerLive = 0;
        /// <summary>
        /// live lap Counter data
        /// </summary>
        private static int _lapCounterLive = 0;

        private static System.Windows.Forms.Timer _countdownTimer = new System.Windows.Forms.Timer();

        #endregion

        #region Properties
        /// <summary>
        /// last user inputed data
        /// Item1 == Work timer , Item2 == Break timer , Item3 == Lap counter
        /// </summary>
        public static (int, int, int) LastUserInput { get; set; }

        #region Private live timer data 
        private static int WorkTimerLive
        {
            get
            {
                return _workTimerLive;
            }

            set
            {
                if (value >= 0)
                {
                    _workTimerLive = value;
                }
                else
                {
                    _workTimerLive = 0;
                }
            }

        }
        private static int BreakTimerLive { get; set; } = 0;
        #endregion

        #region Publicly available formated live timers
        /// <summary>
        /// Live updating work timer with format of "00:00".
        /// </summary>
        public static string WorkTimerFormatedLive => (_workTimerLive / 60 + ":" + (_workTimerLive % 60).ToString("D2"));
        /// <summary>
        /// Live updating break timer with format of "00:00".
        /// </summary>
        public static string BreakTimerFormattedLive
        {
            get
            {
                if (BreakTimerLive < 0 || TimeTickSegment == SegmentNames.EndBreak)
                {
                    return ("- " + BreakTimerLive / 60 + ":" + (BreakTimerLive % 60).ToString("D2"));
                }
                else
                {
                    return (BreakTimerLive / 60 + ":" + (BreakTimerLive % 60).ToString("D2"));
                }
            }
        }
        /// <summary>
        /// Number of lap left (private setter)
        /// </summary>
        public static int LapCounterLive
        {
            get
            {
                return _lapCounterLive;
            }
            private set
            {
                if (value > 0)
                {
                    _lapCounterLive = value;
                }
                else
                {
                    _lapCounterLive = 0;
                }
            }
        }

        #endregion
        /// <summary>
        /// Count up to 100 for Work segment.
        /// Count down to 0 for Break segment.
        /// Shows only 100 for End Break segment.
        /// 0 for anything else.
        /// (100 = 100%, 63 = 63%)
        /// </summary>
        public static int GetProgressInPercentage(SegmentNames segment)
        {
            if (segment == SegmentNames.Work)
            {
                return 100 - (WorkTimerLive * 100) / LastUserInput.Item1;
            }
            else if (segment == SegmentNames.Break)
            {
                return (BreakTimerLive * 100) / LastUserInput.Item2;
            }
            else if (segment == SegmentNames.EndBreak)
            {
                return 100;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Get statistic of the lap 
        /// </summary>
        public static SegmentNames TimeTickSegment { get; private set; }
        /// <summary>
        /// Get if the timer is ticking.
        /// </summary>
        public static bool TimerTick { get; private set; }

        #endregion

        #region Initialization

        // error
        public static void Start()
        {
            _countdownTimer.Tick += CountdownTimer_Tick;
        }
        #endregion

        #region Method
        
        /// <summary>
        /// Timer 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void CountdownTimer_Tick(object sender, EventArgs e)
        {
            _countdownTimer.Interval = 1000;
            if (TimeTickSegment == SegmentNames.Work)
            {
                if (WorkTimerLive > 0)
                {
                    WorkTimerLive--;
                    if (WorkTimerLive == 300)
                    {
                        TimerController("ToBreakPopup");
                    }
                }
                else if (WorkTimerLive <= 0)
                {
                    TimerController("Break");
                }

            }
            else if (TimeTickSegment == SegmentNames.Break)
            {
                BreakTimerLive--;
                if (BreakTimerLive == 0)
                {
                    TimerController("End Break");
                }
            }
            else if (TimeTickSegment == SegmentNames.EndBreak)
            {
                BreakTimerLive++;
                if (Properties.Settings.Default.audioAlert == true)
                {
                    Console.Beep(800, 100);
                }
            }
        }
        /// <summary>
        /// This will control the CountdownTimer() 
        /// </summary>
        /// <param name="function">Function that the controller has to complete </param>
        private static void TimerController(string function)
        {
            var errorHandler = new ErrorHandlerWin();
            var winBehavior = new WindowBehavior();
            switch (function)
            {
                case "ToBreakPopup":
                    winBehavior.WindowsOpenCheck(WindowNames.ToBreak);
                    if (Properties.Settings.Default.audioAlert == true)
                    {
                        Console.Beep(1000, 500);
                    }
                    break;
                //-------------------------------------
                case "Break":
                    _countdownTimer.Stop();
                    TimerTick = false;
                    if (Properties.Settings.Default.audioAlert == true)
                    {
                        Console.Beep(1000, 500);
                    }

                    winBehavior.WindowsOpenCheck(WindowNames.Break);
                    TimeTickSegment = SegmentNames.Break;
                    _countdownTimer.Start();
                    TimerTick = true;
                    break;
                case "End Break":
                    TimeTickSegment = SegmentNames.EndBreak;
                    winBehavior.WindowsOpenCheck(WindowNames.Main);
                    if (Properties.Settings.Default.audioAlert == true)
                    {
                        Console.Beep(1000, 500);
                    }
                    break;
                default:
                    errorHandler.ErrorHandeler("", "CD", "04", true);
                    errorHandler.ShowDialog();
                    break;
            }
        }
        /// <summary>
        /// Start and stop the timer.
        /// The input has to be "Start" or "Stop".
        /// </summary>
        /// <param name="btnText">Takes the text of the button and execute the faction</param>
        /// <returns>The name of the button after execution</returns>
        public static string StartStop(this string btnText)
        {
            var errorHandler = new ErrorHandlerWin();
            // Start timer 
            if (btnText == "Start")
            {
                // start from the top
                if (WorkTimerLive == LastUserInput.Item1 || BreakTimerLive == LastUserInput.Item2 && LapCounterLive == LastUserInput.Item3)
                {
                    
                    LapCounterLive--;
                    TimeTickSegment = SegmentNames.Work;
                    _countdownTimer.Start();
                    TimerTick = true;
                }
                // start from work segment
                else if ((WorkTimerLive > 0 || WorkTimerLive  != LastUserInput.Item1) && LapCounterLive >= 0)
                {
                    TimeTickSegment = SegmentNames.Work;
                    _countdownTimer.Start();
                    TimerTick = true;
                }
                // start from break
                else if (BreakTimerLive != LastUserInput.Item2 && WorkTimerLive <= 0 && LapCounterLive >= 0)
                {
                    MessageBox.Show("break");
                    TimeTickSegment = SegmentNames.Break;
                    _countdownTimer.Start();
                    TimerTick = true;
                }
                else
                {
                    Set();
                    StartStop("Start");
                }
                return "Stop";
            }
            // Stop timer 
            else if (btnText == "Stop")
            {
                // Stop during break
                if (TimeTickSegment == SegmentNames.Break)
                {
                    // error
                    return "Stop";
                }
                // Stop after break ended 
                else if (TimeTickSegment == SegmentNames.EndBreak)
                {
                    if (LapCounterLive > 0)
                    {
                        StartLap();
                    }
                    else if (LapCounterLive <= 0)
                    {
                        EndLapPackage();
                    }
                    return "Start";
                }
                else
                {
                    _countdownTimer.Stop();
                    TimerTick = false;
                    TimeTickSegment = SegmentNames.Paused;
                    return "Start";
                }
            }
            else
            {
                errorHandler.ErrorHandeler("", "CD", "02", true);
                errorHandler.ShowDialog();
                return "CD/2";
            }
        }
        /// <summary>
        /// Set last used values to the live countdowns.
        /// </summary>
        public static void Set()
        {
            WorkTimerLive = LastUserInput.Item1;
            BreakTimerLive = LastUserInput.Item2;
            LapCounterLive = LastUserInput.Item3;
        }
        /// <summary>
        /// Skipping to break form work segment.
        /// </summary>
        public static void SkipToBreak()
        {
            WorkTimerLive = 0;
            TimerController("Break");
        }
        /// <summary>
        /// Start to the next lap.
        /// </summary>
        public static void StartLap()
        {
            _countdownTimer.Stop();
            TimerTick = false;
            WorkTimerLive = LastUserInput.Item1;
            BreakTimerLive = LastUserInput.Item2;

            LapCounterLive--;
            TimeTickSegment = SegmentNames.Work;
            _countdownTimer.Start();
            TimerTick = true;
        }
        /// <summary>
        /// Finish up the last lap 
        /// </summary>
        public static void EndLapPackage()
        {
            Set();

            _countdownTimer.Stop();
            TimerTick = false;
            TimeTickSegment = SegmentNames.Paused;
        }
        /// <summary>
        /// pause after end of lap
        /// </summary>
        public static void PauseBetweenLap()
        {
            _countdownTimer.Stop();
            TimerTick = false;
            TimeTickSegment = SegmentNames.Paused;
            WorkTimerLive = LastUserInput.Item1;
            BreakTimerLive = LastUserInput.Item2;
        }
        #endregion
    }
}
