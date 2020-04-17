using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Worker_Ant
{
    class Countdown /*: FullViewWin*/
    {
        // fields
        private static int _workTimerCountdown;
        private static int _breakTimerCountdown;
        private static int _roundsCountdown;
        // properties
        public static decimal WorkTimerCountdown 
        { 
            set {
                if (value >= 0)
                {
                    _workTimerCountdown = Convert.ToInt32(value);
                }
            }
            get { return _workTimerCountdown ;}
        }
        public static decimal BreakTimerCountdown 
        {
            set {
                if (value >= 0)
                {
                    _breakTimerCountdown = Convert.ToInt32(value);
                }
            }
            get { return _breakTimerCountdown; }
        }
        public static decimal RoundsCountdown 
        {
            set { if (value >= 0) 
                { 
                _roundsCountdown = Convert.ToInt32(value);
                } }
            get { return _roundsCountdown; }
        }


        //------------------------------------------------------------------------- set setting to default
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
            Properties.Settings.Default.simpleView = true;

            //InsertSettingsData("Settings");
        }
        //------------------------------------------------------------------------- insert data to view/set/reset to start
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
        //------------------------------------------------------------------------- btn 
        // start timer 
        public static void StartStopTimer(/*string btnText*/)
        {
            while (RoundsCountdown > 0)
            {
                RoundsCountdown--;
                while (WorkTimerCountdown > 0)
                {
                    WorkTimerCountdown--;
                    System.Threading.Thread.Sleep(1000);


                    // make a timer to limit the speed of the loops 

                    // try to make the live time label refrash every second 

                    // do the maths for and numbers for the property 

                    //var timer1 = new Timer;
                }
                while (BreakTimerCountdown > 0)
                {
                    BreakTimerCountdown--;

                }
            }
            // get date to store on propertis
            MessageBox.Show("work " + WorkTimerCountdown + "break " + BreakTimerCountdown + "round " + RoundsCountdown);
        }
    }
}
