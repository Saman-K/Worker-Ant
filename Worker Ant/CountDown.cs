using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Worker_Ant
{
    class Countdown : FullViewWin
    {
        public decimal BreakTimerCountdown;
        public decimal WorkTimerCountdown;
        public decimal RoundsCountdown;


        public void SetPresetTimeVer()
        {
            //check to see which radiobtn is selcted
        }
        ////------------------------------------------------------------------------- save to settings 
        //// save preset times to settings
        //public void SaveTimesPresetsToSettings(decimal recoveryWorkTime, decimal recoveryBreakTime, decimal smartWorkTime, decimal smartBreakTime, decimal progressWorkTime, decimal progressBreakTime)
        //{
        //    Properties.Settings.Default.recoveryWorkTime = recoveryWorkTime;
        //    Properties.Settings.Default.recoveryBreakTime = recoveryBreakTime;
        //    Properties.Settings.Default.smartWorkTime = smartWorkTime;
        //    Properties.Settings.Default.smartBreakTime = smartBreakTime;
        //    Properties.Settings.Default.progressWorkTime = progressWorkTime;
        //    Properties.Settings.Default.progressBreakTime = progressBreakTime;
        //}
        //// save user setting to app settings
        //public void SaveSettingsPresetsToSettings(decimal roundCountdown,bool audioAlert, bool simpleView, bool saftyInfo)
        //{
        //    Properties.Settings.Default.roundCountdown = roundCountdown;

        //    //Properties.Settings.Default.audioAlert = audioAlert;
        //    //Properties.Settings.Default.simpleView = simpleView;
        //    //Properties.Settings.Default.saftyInfo = saftyInfo;
        //    //InsertSettingsData("Settings");

        //}
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
            //settingsWin.checkBoxSimpleView.Checked = true;

            //InsertSettingsData("Settings");
        }
        //------------------------------------------------------------------------- insert data to preview/set/reset to start
        public void InsertDataToPreview(string chosenRadioBtn)
        {
            switch (chosenRadioBtn)
            {
                case ("Recovery"):
                    WorkTimerCountdown = Convert.ToInt32(Properties.Settings.Default.recoveryWorkTime);
                    BreakTimerCountdown = Convert.ToInt32(Properties.Settings.Default.recoveryBreakTime);
                    break;
                case ("Smart"):
                    WorkTimerCountdown = Convert.ToInt32(Properties.Settings.Default.smartWorkTime);
                    BreakTimerCountdown = Convert.ToInt32(Properties.Settings.Default.smartBreakTime);
                    break;
                case ("Progress"):
                    WorkTimerCountdown = Convert.ToInt32(Properties.Settings.Default.progressWorkTime);
                    BreakTimerCountdown = Convert.ToInt32(Properties.Settings.Default.progressBreakTime);
                    break;
                case ("Manual"):
                    WorkTimerCountdown = Convert.ToInt32(Properties.Settings.Default.manualWorkTime);
                    BreakTimerCountdown = Convert.ToInt32(Properties.Settings.Default.manualBreakTime);
                    break;
                default:
                    MessageBox.Show("Redio button is not selected");
                    break;
            }

            RoundsCountdown = Convert.ToInt32(Properties.Settings.Default.roundCountdown);
        }
        //------------------------------------------------------------------------- btn
        // start timer 
        public void StartStopTimer(string btnText)
        {

            if (btnText == "Start")
            {
                btnText = "Stop";
                if (RoundsCountdown != 0)
                {
                    --RoundsCountdown;
                }
                else
                {
                    MessageBox.Show("there is an issue with RoundsCounter = " + RoundsCountdown);
                }

            }
            else if (btnText == "Stop")
            {
                btnText = "Start";

            }
            //while (RoundsCountdown > 0)
            //{
            //    RoundsCountdown--;
            //    while (WorkTimerCountdown > 0)
            //    {

            //    }
            //    while (BreakTimerCountdown > 0)
            //    {

            //    }
            //}
        }
        // stop timer 
    }
}
