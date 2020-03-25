using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Worker_Ant
{
    class CountDown
    {
        //int breakTime;
        //int workTime;
        //int round;
        

        public void SetPresetTimeVer()
        {
            //check to see which radiobtn is selcted
        }

        // save settings and menual in the fullviewwin
        public void SavePresetTimeToSettings(string buttonPressed) 
        {
            if (buttonPressed == "save")
            {
                var settingsWin = new Worker_Ant.SettingsWin();
                Properties.Settings.Default.recoveryWorkTime = Convert.ToInt32(settingsWin.numUDWorkRecovery.Value);
                Properties.Settings.Default.recoveryBreakTime = Convert.ToInt32(settingsWin.numUDBreakRecovery.Value);
                Properties.Settings.Default.smartWorkTime = Convert.ToInt32(settingsWin.numUDWorkSmart.Value);
                Properties.Settings.Default.smartBreakTime = Convert.ToInt32(settingsWin.numUDBreakSmart.Value);
                Properties.Settings.Default.progressWorkTime = Convert.ToInt32(settingsWin.numUDWorkProgress.Value);
                Properties.Settings.Default.progressBreakTime = Convert.ToInt32(settingsWin.numUDBreakProgress.Value);
                Properties.Settings.Default.roundCountdown = Convert.ToInt32(settingsWin.numUDRound.Value);

                //Properties.Settings.Default.audioAlert = settingsWin.checkBoxAudioAlert.Checked;
                //Properties.Settings.Default.simpleView = settingsWin.checkBoxSimpleView.Checked;
                //Properties.Settings.Default.saftyInfo = settingsWin.checkBoxSafetyInfo.Checked;

                InsertSettingsData("");
            }
            else if (buttonPressed == "set")
            {
                var fullViewWin = new FullViewWin();
                Properties.Settings.Default.manualWorkTime = Convert.ToInt32(fullViewWin.numUDWorkManual);
                Properties.Settings.Default.manualBreakTime = Convert.ToInt32(fullViewWin.numUDBreakManual);
                MessageBox.Show("set has been pressed and menuall has been saved");
            }
        }
        // set setting to default
        public void SetPresetTimeToDefault()
        {
            Properties.Settings.Default.recoveryWorkTime = 0;
            Properties.Settings.Default.recoveryBreakTime = 0;
            Properties.Settings.Default.smartWorkTime = 0;
            Properties.Settings.Default.smartBreakTime = 0;
            Properties.Settings.Default.progressWorkTime = 0;
            Properties.Settings.Default.progressBreakTime = 0;
            Properties.Settings.Default.roundCountdown = 1;

            //settingsWin.checkBoxSafetyInfo.Checked = true;
            //settingsWin.checkBoxAudioAlert.Checked = true;
            //settingsWin.checkBoxSimpleView.Checked = true;

            InsertSettingsData("");
        }
        // refresh data from the data base 
        public void InsertSettingsData(string calledFrom)
        {
            if (calledFrom == "FullViewWin")
            {

            }
            else
            {
                var settingsWin = new Worker_Ant.SettingsWin();
                settingsWin.numUDWorkRecovery.Value = Properties.Settings.Default.recoveryWorkTime;
                settingsWin.numUDBreakRecovery.Value = Properties.Settings.Default.recoveryBreakTime;
                settingsWin.numUDWorkSmart.Value = Properties.Settings.Default.smartWorkTime;
                settingsWin.numUDBreakSmart.Value = Properties.Settings.Default.smartBreakTime;
                settingsWin.numUDWorkProgress.Value = Properties.Settings.Default.progressWorkTime;
                settingsWin.numUDBreakProgress.Value = Properties.Settings.Default.progressBreakTime;
                settingsWin.numUDRound.Value = Properties.Settings.Default.roundCountdown;

                //settingsWin.checkBoxAudioAlert.Checked = Properties.Settings.Default.audioAlert;
                //settingsWin.checkBoxSimpleView.Checked = Properties.Settings.Default.simpleView;
                //settingsWin.checkBoxSafetyInfo.Checked = Properties.Settings.Default.saftyInfo;
            }
        }
    }
}
