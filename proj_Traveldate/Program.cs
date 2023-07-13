using proj_Traveldate.searchUIRev;
using proj_Traveldate.金負責區_LoginPage_Member;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj_Traveldate
{
    internal static class Program
    {
//        [System.Runtime.InteropServices.DllImport("user32.dll")]
   //     private static extern bool SetProcessDPIAware();

        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
//            if (System.Environment.OSVersion.Version.Major >= 6) { SetProcessDPIAware(); }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
             Application.Run(new FrmHome());
            //Application.Run(new FrmsearchUIRev());
        }
    }
}
