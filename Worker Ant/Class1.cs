using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Timers.Timer;
using System.Windows.Forms;
namespace Worker_Ant
{
    class Class1
    {
        internal static int numbertest;

        internal static Timer testtimer = new Timer(1000);
        
        public static void starttimer(string btn)
        {
            if (btn == "Start")
            {
                testtimer.Elapsed += Testtimer_Elapsed;
                testtimer.Start();
            }
        }

        private static void Testtimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            numbertest++;

            if (numbertest == 1)
            {
                MessageBox.Show("1");
            }
            else if(numbertest == 2)
            {
                MessageBox.Show("2");

                var info = new InfoWin();
                info.Show();



                //var winb = new WinBehavior();
                //winb.ChackWins("Info");
            
            }
            else if (numbertest > 4)
            {
                testtimer.Stop();
            }
            
        }
    }
}
