using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace cleancode.bot.schedule.tray
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
            Application.Run(new TrayPopupForm());
        }
    }
}