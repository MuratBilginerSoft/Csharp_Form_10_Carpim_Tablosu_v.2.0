using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Kod_H_Çarpım_Tablosu_v2._0_Corona
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
            Application.Run(new Form1());
        }
    }
}
