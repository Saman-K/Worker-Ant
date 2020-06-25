using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerAnt
{
    interface IUserInterface
    {
        #region Properties
        (int Work, int Break, int Laps) LastUserInput { get; set; }
        #endregion

        #region Method 
        void SetLapPackage();

        #endregion method
    }
}
