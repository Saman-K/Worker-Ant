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
        public decimal BreakTimerCountdown;
        public decimal WorkTimerCountdown;
        public decimal RoundsCountdown;

        public void SetPresetTimeVer()
        {
            //check to see which radiobtn is selcted
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
            //settingsWin.checkBoxSimpleView.Checked = true;

            //InsertSettingsData("Settings");
        }
        //------------------------------------------------------------------------- insert data to preview/set/reset to start
       public static (int, int ,int) InsertDataToPreview(string chosenRadioBtn)
        {
            int workTime = 0;
            int breakTime = 0;
            switch (chosenRadioBtn)
            {
                case ("Recovery"):
                    workTime = Convert.ToInt32(Properties.Settings.Default.recoveryWorkTime);
                    breakTime = Convert.ToInt32(Properties.Settings.Default.recoveryBreakTime);
                    break;
                case ("Smart"):
                    workTime = Convert.ToInt32(Properties.Settings.Default.smartWorkTime);
                    breakTime = Convert.ToInt32(Properties.Settings.Default.smartBreakTime);
                    break;
                case ("Progress"):
                    workTime = Convert.ToInt32(Properties.Settings.Default.progressWorkTime);
                    breakTime = Convert.ToInt32(Properties.Settings.Default.progressBreakTime);
                    break;
                case ("Manual"):
                    workTime = Convert.ToInt32(Properties.Settings.Default.manualWorkTime);
                    breakTime = Convert.ToInt32(Properties.Settings.Default.manualBreakTime);
                    break;
                default:
                    //MessageBox.Show("Redio button is not selected");
                    break;
            }

            return (workTime, breakTime, Convert.ToInt32(Properties.Settings.Default.roundCountdown));
            
        }
        //------------------------------------------------------------------------- btn 
        // start timer 
        public void StartStopTimer(string btnText)
        {

        }
    }
}
