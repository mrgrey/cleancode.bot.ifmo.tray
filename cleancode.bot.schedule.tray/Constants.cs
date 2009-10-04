using System;
using System.Collections.Generic;
using System.Text;

namespace cleancode.bot.schedule.tray
{
    public static class Constants
    {
        public static string SaveSettingsFileName = "settings.dat";
        public delegate void SettingsTransferEventArgs(Settings settings);
    }
}
