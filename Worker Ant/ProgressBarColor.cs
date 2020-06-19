using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace Worker_Ant
{
    public class ProgressBarColor
    {

        //[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        //static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);

        ///// <summary>
        ///// will change the color according to input
        ///// </summary>
        ///// <param name="pBar">progress bar name</param>
        ///// <param name="state">1 = green, 2 = yellow, 3 = red</param>
        //public static void SetState(this ProgressBar pBar, int state)
        //{
        //    SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        //}
    }
}
