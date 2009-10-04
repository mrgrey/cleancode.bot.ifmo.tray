using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;

namespace cleancode.bot.schedule.tray
{
    public class Communicator
    {
        private Settings _settings;
        public Settings Settings
        {
            get { return _settings; }
        }

        public Communicator(Settings settings)
        {
            this._settings = settings;
        }

        private HttpWebResponse _getSchedule(DateTime date)
        {
            string url = String.Format(
                "{0}?schedule_id={1}&gr={2}&date={3}",
                _settings.DatasourceUrl,
                _settings.SceduleId,
                _settings.GroupId,
                date.ToString("dd.MM.yyyy"));

            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            return (HttpWebResponse)request.GetResponse();
        }

        private HttpWebResponse _getSchedule()
        {
            return _getSchedule(DateTime.Now);
        }
    }
}
