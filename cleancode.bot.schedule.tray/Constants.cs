using System;
using System.Collections.Generic;
using System.Text;

namespace cleancode.bot.schedule.tray
{
    public static class Constants
    {
        public static string SaveSettingsFileName = "settings.dat";
        public static string DefaultDatasourceUrl = "http://faculty.ifmo.ru/gadgets/spbsuitmo-schedule-lessons/data/lessons-proxy-json.php";
        public static int DefaultScheduleId = 1;
        public delegate void SettingsTransferEventArgs(Settings settings);

        public static string DefaultPrintFormBaseUrl = "http://www.ifmo.ru/file/schedule.php";
    }
}
