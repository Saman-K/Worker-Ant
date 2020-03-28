using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Worker_Ant
{
    class Countdown : FullViewWin
    {
        public decimal breakTimeCoutdown;
        public decimal workTimeCoutdown;
        public decimal roundsCountdown;
        Timer tWorkTimer = new Timer();
        Timer tBreakTimer = new Timer();

        public void SetPresetTimeVer()
        {
            //check to see which radiobtn is selcted
        }
        //------------------------------------------------------------------------- save to settings 
        // save preset times to settings
        public void SaveTimesPresetsToSettings(decimal recoveryWorkTime, decimal recoveryBreakTime, decimal smartWorkTime, decimal smartBreakTime, decimal progressWorkTime, decimal progressBreakTime)
        {
            Properties.Settings.Default.recoveryWorkTime = recoveryWorkTime;
            Properties.Settings.Default.recoveryBreakTime = recoveryBreakTime;
            Properties.Settings.Default.smartWorkTime = smartWorkTime;
            Properties.Settings.Default.smartBreakTime = smartBreakTime;
            Properties.Settings.Default.progressWorkTime = progressWorkTime;
            Properties.Settings.Default.progressBreakTime = progressBreakTime;
        }
        // save user setting to app settings
        public void SaveSettingsPresetsToSettings(decimal roundCountdown,bool audioAlert, bool simpleView, bool saftyInfo)
        {
            Properties.Settings.Default.roundCountdown = roundCountdown;

            //Properties.Settings.Default.audioAlert = audioAlert;
            //Properties.Settings.Default.simpleView = simpleView;
            //Properties.Settings.Default.saftyInfo = saftyInfo;
            //InsertSettingsData("Settings");

        }
        //
        //
        //
        //
        //redo
        //  |
        //  V
        //
        //

        //------------------------------------------------------------------------- refresh data from the data base 
        ////private void InsertSettingsData(string calledFrom)
        ////{
        ////    var settingsWin = new Worker_Ant.SettingsWin();
        ////    var fullViewWin = new Worker_Ant.FullViewWin();
        ////    refresh after save
        ////    if (calledFrom == "FullViewWin")
        ////    {
        ////        fullViewWin.numUDWorkManual.Value = Properties.Settings.Default.manualWorkTime;
        ////        fullViewWin.numUDBreakManual.Value = Properties.Settings.Default.manualBreakTime;
        ////    }
        ////    else if (calledFrom == "Settings")
        ////    {
        ////        settingsWin.numUDWorkRecovery.Value = Properties.Settings.Default.recoveryWorkTime;
        ////        settingsWin.numUDBreakRecovery.Value = Properties.Settings.Default.recoveryBreakTime;
        ////        settingsWin.numUDWorkSmart.Value = Properties.Settings.Default.smartWorkTime;
        ////        settingsWin.numUDBreakSmart.Value = Properties.Settings.Default.smartBreakTime;
        ////        settingsWin.numUDWorkProgress.Value = Properties.Settings.Default.progressWorkTime;
        ////        settingsWin.numUDBreakProgress.Value = Properties.Settings.Default.progressBreakTime;
        ////        settingsWin.numUDRound.Value = Properties.Settings.Default.roundCountdown;

        ////        settingsWin.checkBoxAudioAlert.Checked = Properties.Settings.Default.audioAlert;
        ////        settingsWin.checkBoxSimpleView.Checked = Properties.Settings.Default.simpleView;
        ////        settingsWin.checkBoxSafetyInfo.Checked = Properties.Settings.Default.saftyInfo;
        ////    }
        ////}
        //
        //
        //   ^
        //   |
        //
        //redo
        //
        //
        //
        //
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
                    workTimeCoutdown = Convert.ToInt32(Properties.Settings.Default.recoveryWorkTime);
                    breakTimeCoutdown = Convert.ToInt32(Properties.Settings.Default.recoveryBreakTime);
                    break;
                case ("Smart"):
                    workTimeCoutdown = Convert.ToInt32(Properties.Settings.Default.smartWorkTime);
                    breakTimeCoutdown = Convert.ToInt32(Properties.Settings.Default.smartBreakTime);
                    break;
                case ("Progress"):
                    workTimeCoutdown = Convert.ToInt32(Properties.Settings.Default.progressWorkTime);
                    breakTimeCoutdown = Convert.ToInt32(Properties.Settings.Default.progressBreakTime);
                    break;
                case ("Manual"):
                    workTimeCoutdown = Convert.ToInt32(Properties.Settings.Default.manualWorkTime);
                    breakTimeCoutdown = Convert.ToInt32(Properties.Settings.Default.manualBreakTime);
                    break;
                default:
                    MessageBox.Show("Redio button is not selected");
                    break;
            }

            roundsCountdown = Convert.ToInt32(Properties.Settings.Default.roundCountdown);
        }
        // btn
        // start timer 
        public void StartTimer()
        {
            
        }
        // stop timer 
        public void StopTimer()
        {

        }
    }
}
