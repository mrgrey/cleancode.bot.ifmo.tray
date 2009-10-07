using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using cleancode.bot.schedule.tray.DataSourceAnswer;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace cleancode.bot.schedule.tray
{
    public class Communicator
    {
        public Settings Settings;

        public Communicator(Settings settings)
        {
            this.Settings = settings;
        }

        private HttpWebResponse _getSchedule(DateTime date)
        {
            string url = String.Format(
                "{0}?schedule_id={1}&gr={2}&date={3}",
                Settings.DatasourceUrl,
                Settings.SceduleId,
                Settings.GroupId,
                date.ToString("dd.MM.yyyy"));

            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            return (HttpWebResponse)request.GetResponse();
        }

        private HttpWebResponse _getSchedule()
        {
            return _getSchedule(DateTime.Now);
        }

        public AnswerData GetSchedule()
        {
            HttpWebResponse response = _getSchedule();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            string data = sr.ReadToEnd();
            sr.Close();
            response.Close();

            //Deserialize data to anser object
            JObject jsonObj = JObject.Parse(data);

            AnswerData answer = new AnswerData(
                (Status)Enum.Parse(typeof(Status), jsonObj.Value<string>("status"), true),
                jsonObj["data"].Value<int>("week_number"),
                jsonObj["data"].Value<string>("day")
            );
            foreach (JToken tLesson in jsonObj["data"].Value<JArray>("lessons").Children())
            {
                Lesson lesson = new Lesson(
                    tLesson.Value<string>("time"),
                    tLesson.Value<string>("place"),
                    tLesson.Value<string>("subject"),
                    tLesson.Value<string>("person_name")
                );
                answer.Lessons.Add(lesson);
            }
            return answer;
        }
    }
}
