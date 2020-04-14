using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Worker_Ant
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Properties.Settings.Default.simpleView == true)
            {
                Application.Run(new SimpleViewWin());
            }
            else if (Properties.Settings.Default.simpleView == false)
            {
                Application.Run(new FullViewWin());
            }

        }
    }
}
